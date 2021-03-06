﻿using Microsoft.Win32;
using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Tarkov_Optimizer
{
    public partial class Form1 : Form
    {
        //Directories
        string workdDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TarkovOptimizer";
        string logDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TarkovOptimizer\logs";

        //Logging
        StringBuilder log = new StringBuilder();

        //Defaults
        public static String ABSOLUT_VERSION = GetVersion();
        public static String Author = "Naits";

        //Variables
        ProcessPriorityClass priority;
        Boolean optimized = false;

        //Properties
        Boolean runOnStartup = false;
        Boolean startMinimixed = false;
        Boolean running = false;
        Boolean autoRun = false;
        Boolean updateAvailable = false;
        Boolean updateClose = false;
        Boolean changeAffinity = true;
        Boolean advanced = false;
        String updateDownloadLink = "";

        long affinity;
        int cores = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load properties
            LoadProperties();

            //Setting default values and configurations
            labelToolVersion.Text = ABSOLUT_VERSION + " - by " + Author;

            //Checking for updates
            UpdateChecker();
            //Starting update checker timer
            timerUpdater.Interval = 7200000;
            timerUpdater.Start();

            //If found auto settings
            cores = AutoConfig();
            if (cores > 0 && !autoRun)
            {
                textLog.AppendText(Environment.NewLine + "Auto optimized! - Not running.");
                comboCores.Text = cores.ToString();
                autoRun = true;
            }
            else
            {
                textLog.AppendText(Environment.NewLine + "Not running.");
                comboCores.Text = cores.ToString();
            }

            if (running)
                textLog.AppendText(Environment.NewLine + DateTime.Now.ToString("hh:mm:ss") + " - waiting for game to launch... ");

            //Creating log dir
            if (!File.Exists(workdDir))
            {
                Directory.CreateDirectory(workdDir);
            }

            if (!File.Exists(logDir))
            {
                Directory.CreateDirectory(logDir);
                log.AppendLine(DateTime.Now.ToString("hh:mm:ss") + " - Log file and dir created!");
            }

            //Log timer
            timerLog.Interval = 20000;
            timerLog.Start();

            notifyIcon1.ContextMenuStrip = this.notifMenu;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Check what state to start in
            if (startMinimixed)
            {
                WindowState = FormWindowState.Minimized;
                Hide();
            }
        }

        private int AutoConfig()
        {
            try
            {
                int coreCount = 0;
                foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
                {
                    coreCount += int.Parse(item["NumberOfCores"].ToString());
                }
                return coreCount;
            }
            catch
            {
                return 0;
            }
        }

        private void ButtonToolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateChecker()
        {
            textLog.AppendText(Environment.NewLine + DateTime.Now.ToString("hh:mm:ss") + " - Checking for updates...");
            try
            {
                WebClient client = new WebClient();
                string file = client.DownloadString(@"http://realnaits.com/projects/tarkovoptimizer/version.txt");

                String[] split = file.Split('-');

                var oldVer = new Version(ABSOLUT_VERSION);
                var newVer = new Version(file);

                if (split.Length == 2)
                {
                    updateDownloadLink = split[1];
                }

                if (newVer > oldVer)
                {
                    textLog.AppendText(Environment.NewLine + "Update available. New version: " + file);
                    updateAvailable = true;
                    linkUpdate.Visible = true;

                }
                else
                {
                    linkUpdate.Visible = false;
                }
            }
            catch(Exception ex)
            {
                log.AppendLine(DateTime.Now.ToString("hh:mm:ss") + ex);
                textLog.AppendText(Environment.NewLine + DateTime.Now.ToString("hh:mm:ss") + " - Couldn't reach update server... ");
            }
        }

        public static string GetVersion()
        {
            string ourVersion = string.Empty;
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                ourVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            else
            {
                System.Reflection.Assembly assemblyInfo = System.Reflection.Assembly.GetExecutingAssembly();
                if (assemblyInfo != null)
                    ourVersion = assemblyInfo.GetName().Version.ToString();
            }
            return ourVersion;
        }

        private void ComboCores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Updating priority
            if (!checkAdvanced.Checked)
            {
                int value = int.Parse(comboCores.Text);
                if (value == 1 || value == 2 || value == 3)
                {
                    comboPriority.SelectedIndex = 2;
                    priority = ProcessPriorityClass.Normal;
                    affinity = 0x0003;
                    label4.Text = affinity.ToString();
                }
                if (value == 4 || value == 5 || value == 6 || value == 7 || value == 8)
                {
                    comboPriority.SelectedIndex = 3;
                    priority = ProcessPriorityClass.AboveNormal;
                    affinity = 0x000F;
                    label4.Text = affinity.ToString();
                }
                if (value > 9)
                {
                    comboPriority.SelectedIndex = 4;
                    priority = ProcessPriorityClass.High;
                    affinity &= 0x007F;
                    label4.Text = affinity.ToString();
                }
            }
            else
            {
                int value = int.Parse(comboCores.Text);
                if (value == 1 || value == 2 || value == 3)
                {
                    comboPriority.SelectedIndex = 2;
                    priority = ProcessPriorityClass.Normal;
                    affinity = 0x0003;
                    label4.Text = affinity.ToString();
                }
                if (value == 4 || value == 5 || value == 6 || value == 7 || value == 8)
                {
                    comboPriority.SelectedIndex = 3;
                    priority = ProcessPriorityClass.AboveNormal;
                    affinity = 0x000F;
                    label4.Text = affinity.ToString();
                }
                if (value > 9)
                {
                    comboPriority.SelectedIndex = 4;
                    priority = ProcessPriorityClass.High;
                    affinity &= 0x007F;
                    label4.Text = affinity.ToString();
                }
            }
        }

        private void TimerCheck_Tick(object sender, EventArgs e)
        {
            //Process[] processes = Process.GetProcessesByName("notepad");
            Process[] processes = Process.GetProcessesByName("EscapeFromTarkov");
            foreach (Process proc in processes)
            {
                //Changing timer interval
                timerCheck.Interval = 30000;
                //Changing priority
                proc.PriorityClass = priority;
                //Changing affinity
                if (checkAffinity.Checked)
                {
                    long affinityMask = (long)proc.ProcessorAffinity;
                    affinityMask &= affinity;
                    proc.ProcessorAffinity = (IntPtr)affinityMask;
                }

                //Visual
                if (!optimized) 
                {
                    textLog.AppendText(Environment.NewLine + DateTime.Now.ToString("hh:mm:ss") + " - Escape from Tarkov detected, optimzing the process.");
                    optimized = true;
                    labelOptimized.Text = "true";
                    labelOptimized.ForeColor = Color.Green;
                    this.Icon = Properties.Resources.TarkovGreen;
                    notifyIcon1.Icon = Properties.Resources.TarkovGreen;
                    notifyIcon1.Text = "Tarkov optimized";
                }
            }

            if (processes.Length == 0 && optimized)
            {
                textLog.AppendText(Environment.NewLine + DateTime.Now.ToString("hh:mm:ss") + " - Game no longer running.");
                timerCheck.Interval = 5000;
                optimized = false;
                labelOptimized.Text = "false";
                labelOptimized.ForeColor = Color.DarkRed;
                this.Icon = Properties.Resources.TarkovRed;
                notifyIcon1.Icon = Properties.Resources.TarkovRed;
                notifyIcon1.Text = "Tarkov not optimized";
                textLog.AppendText(Environment.NewLine + DateTime.Now.ToString("hh:mm:ss") + " - waiting for game to launch... ");
            }
        }

        private void Start()
        {
            running = true;
            timerCheck.Start();
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            textLog.AppendText(Environment.NewLine + DateTime.Now.ToString("hh:mm:ss") + " - started!");
            textLog.AppendText(Environment.NewLine + DateTime.Now.ToString("hh:mm:ss") + " - waiting for game to launch... ");
        }

        private void Stop()
        {
            running = false;
            timerCheck.Stop();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            labelOptimized.Text = "false";
            labelOptimized.ForeColor = Color.DarkRed;
            textLog.AppendText(Environment.NewLine + DateTime.Now.ToString("hh:mm:ss") + " - stopped!");
            this.Icon = Properties.Resources.TarkovRed;
            notifyIcon1.Icon = Properties.Resources.TarkovRed;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (chkStartUp.Checked)
            {
                rk.SetValue(this.GetType().Name, Application.ExecutablePath);
                runOnStartup = true;
            }
            else
            {
                rk.DeleteValue(this.GetType().Name, false);
                runOnStartup = false;
            }

        }

        private void ChkStartUp_CheckedChanged(object sender, EventArgs e)
        {
            SetStartup();
        }

        private void CheckStartState_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStartState.Checked)
            {
                startMinimixed = true;
            }
            else
            {
                startMinimixed = false;
            }
        }

        private void SaveProperties()
        {
            Properties.Settings.Default.minimized = startMinimixed;
            Properties.Settings.Default.startup = runOnStartup;
            Properties.Settings.Default.running = running;
            Properties.Settings.Default.autoRun = autoRun;
            Properties.Settings.Default.cores = cores;
            Properties.Settings.Default.affinity = changeAffinity;
            Properties.Settings.Default.advanced = advanced;
            Properties.Settings.Default.Save();
        }

        private void LoadProperties()
        {
            //Minimized
            checkStartState.Checked = Properties.Settings.Default.minimized;
            startMinimixed = Properties.Settings.Default.minimized;

            //Run on startup
            chkStartUp.Checked = Properties.Settings.Default.startup;
            runOnStartup = Properties.Settings.Default.startup;

            //Autorun
            autoRun = Properties.Settings.Default.autoRun;

            //cores
            cores = Properties.Settings.Default.cores;

            //affinity
            checkAffinity.Checked = Properties.Settings.Default.affinity;
            changeAffinity = Properties.Settings.Default.affinity;

            //Advanced
            checkAdvanced.Checked = Properties.Settings.Default.advanced;
            advanced = Properties.Settings.Default.advanced;

            //Running
            bool isRun = Properties.Settings.Default.running;
            if (isRun)
            {
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                running = true;
                timerCheck.Start();
            }
            else
            {
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
                running = false;
                timerCheck.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!updateClose)
            {
                DialogResult dr = MessageBox.Show("Do you want to minimze to system tray instead?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    WindowState = FormWindowState.Minimized;
                    Hide();
                    e.Cancel = true;
                }
                else
                {
                    SaveProperties();
                    return;
                }
            }
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void TextLog_TextChanged(object sender, EventArgs e)
        {
            textLog.SelectionStart = textLog.TextLength;
            textLog.ScrollToCaret();
        }

        private void TextLog_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void InstallUpdateSyncWithInfo()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed && updateAvailable)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();

                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("The new version of the application cannot be downloaded at this time. \n\nPlease check your network connection, or try again later. Error: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("This application has detected a mandatory update from your current " +
                            "version to version " + info.MinimumRequiredVersion.ToString() +
                            ". The application will now install the update and restart.",
                            "Update Available", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            updateClose = true;
                            MessageBox.Show("The application has been upgraded, and will now restart.");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            log.AppendLine(DateTime.Now.ToString("hh:mm:ss") + dde);
                            MessageBox.Show("Cannot install the latest version of the application. \n\nPlease check your network connection, or try again later. Error: " + dde);
                            return;
                        }
                    }
                }
            }
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateChecker();
            InstallUpdateSyncWithInfo();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            InstallUpdateSyncWithInfo();
        }

        private void timerUpdater_Tick(object sender, EventArgs e)
        {
            UpdateChecker();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkForUpdatesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateChecker();
            InstallUpdateSyncWithInfo();
        }

        private void comboPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAdvanced.Checked)
            {
                advanced = true;
                checkAffinity.Enabled = true;
            }
            else
            {
                advanced = false;
                checkAffinity.Enabled = false;
            }
        }

        private void checkAffinity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAffinity.Checked)
            {
                changeAffinity = true;
            }
            else
            {
                changeAffinity = false;
            }
        }

        private void timerLog_Tick(object sender, EventArgs e)
        {
            File.AppendAllText(logDir + @"\log.txt", log.ToString());
            log.Clear();
        }
    }
}
