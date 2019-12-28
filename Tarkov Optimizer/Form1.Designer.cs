namespace Tarkov_Optimizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelToolVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonToolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCores = new System.Windows.Forms.ComboBox();
            this.checkAdvanced = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.labelOptimized = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.chkStartUp = new System.Windows.Forms.CheckBox();
            this.checkStartState = new System.Windows.Forms.CheckBox();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.textLog = new System.Windows.Forms.RichTextBox();
            this.linkUpdate = new System.Windows.Forms.Label();
            this.timerUpdater = new System.Windows.Forms.Timer(this.components);
            this.notifMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAffinity = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.notifMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelToolVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(238, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelToolVersion
            // 
            this.labelToolVersion.Name = "labelToolVersion";
            this.labelToolVersion.Size = new System.Drawing.Size(97, 17);
            this.labelToolVersion.Text = "v: 1.0.0 - by Naits";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(238, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.issuesToolStripMenuItem,
            this.toolStripSeparator1,
            this.buttonToolExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // issuesToolStripMenuItem
            // 
            this.issuesToolStripMenuItem.Name = "issuesToolStripMenuItem";
            this.issuesToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.issuesToolStripMenuItem.Text = "Issues?";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
            // 
            // buttonToolExit
            // 
            this.buttonToolExit.Name = "buttonToolExit";
            this.buttonToolExit.Size = new System.Drawing.Size(110, 22);
            this.buttonToolExit.Text = "Exit";
            this.buttonToolExit.Click += new System.EventHandler(this.ButtonToolExit_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // comboPriority
            // 
            this.comboPriority.Enabled = false;
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Items.AddRange(new object[] {
            "Low",
            "Below normal",
            "Normal",
            "Above normal",
            "High",
            "Realtime"});
            this.comboPriority.Location = new System.Drawing.Point(12, 224);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(214, 21);
            this.comboPriority.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPU priority";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(11, 32);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(39, 20);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numbers of physical cores";
            // 
            // comboCores
            // 
            this.comboCores.FormattingEnabled = true;
            this.comboCores.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "12",
            "16"});
            this.comboCores.Location = new System.Drawing.Point(12, 161);
            this.comboCores.Name = "comboCores";
            this.comboCores.Size = new System.Drawing.Size(214, 21);
            this.comboCores.TabIndex = 6;
            this.comboCores.SelectedIndexChanged += new System.EventHandler(this.ComboCores_SelectedIndexChanged);
            // 
            // checkAdvanced
            // 
            this.checkAdvanced.AutoSize = true;
            this.checkAdvanced.Enabled = false;
            this.checkAdvanced.Location = new System.Drawing.Point(12, 188);
            this.checkAdvanced.Name = "checkAdvanced";
            this.checkAdvanced.Size = new System.Drawing.Size(112, 17);
            this.checkAdvanced.TabIndex = 7;
            this.checkAdvanced.Text = "Advanced options";
            this.checkAdvanced.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 388);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(214, 23);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(12, 359);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(214, 23);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // timerCheck
            // 
            this.timerCheck.Interval = 5000;
            this.timerCheck.Tick += new System.EventHandler(this.TimerCheck_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Optimized: ";
            // 
            // labelOptimized
            // 
            this.labelOptimized.AutoSize = true;
            this.labelOptimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptimized.ForeColor = System.Drawing.Color.DarkRed;
            this.labelOptimized.Location = new System.Drawing.Point(66, 110);
            this.labelOptimized.Name = "labelOptimized";
            this.labelOptimized.Size = new System.Drawing.Size(42, 16);
            this.labelOptimized.TabIndex = 12;
            this.labelOptimized.Text = "false";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Tarkov Optimizer";
            this.notifyIcon1.BalloonTipTitle = "Tarkov Optimizer";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Tarkov Optimizer";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // chkStartUp
            // 
            this.chkStartUp.AutoSize = true;
            this.chkStartUp.Location = new System.Drawing.Point(12, 307);
            this.chkStartUp.Name = "chkStartUp";
            this.chkStartUp.Size = new System.Drawing.Size(96, 17);
            this.chkStartUp.TabIndex = 13;
            this.chkStartUp.Text = "Run on startup";
            this.chkStartUp.UseVisualStyleBackColor = true;
            this.chkStartUp.CheckedChanged += new System.EventHandler(this.ChkStartUp_CheckedChanged);
            // 
            // checkStartState
            // 
            this.checkStartState.AutoSize = true;
            this.checkStartState.Location = new System.Drawing.Point(12, 284);
            this.checkStartState.Name = "checkStartState";
            this.checkStartState.Size = new System.Drawing.Size(96, 17);
            this.checkStartState.TabIndex = 14;
            this.checkStartState.Text = "Start minimized";
            this.checkStartState.UseVisualStyleBackColor = true;
            this.checkStartState.CheckedChanged += new System.EventHandler(this.CheckStartState_CheckedChanged);
            // 
            // buttonAuto
            // 
            this.buttonAuto.Enabled = false;
            this.buttonAuto.Location = new System.Drawing.Point(12, 330);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(214, 23);
            this.buttonAuto.TabIndex = 15;
            this.buttonAuto.Text = "Auto optimize";
            this.buttonAuto.UseVisualStyleBackColor = true;
            // 
            // textLog
            // 
            this.textLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLog.Location = new System.Drawing.Point(15, 55);
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.Size = new System.Drawing.Size(211, 52);
            this.textLog.TabIndex = 16;
            this.textLog.TabStop = false;
            this.textLog.Text = "";
            this.textLog.TextChanged += new System.EventHandler(this.TextLog_TextChanged);
            this.textLog.VisibleChanged += new System.EventHandler(this.TextLog_VisibleChanged);
            // 
            // linkUpdate
            // 
            this.linkUpdate.AutoSize = true;
            this.linkUpdate.ForeColor = System.Drawing.Color.Red;
            this.linkUpdate.Location = new System.Drawing.Point(139, 32);
            this.linkUpdate.Name = "linkUpdate";
            this.linkUpdate.Size = new System.Drawing.Size(87, 13);
            this.linkUpdate.TabIndex = 17;
            this.linkUpdate.Text = "Update available";
            this.linkUpdate.Click += new System.EventHandler(this.label4_Click);
            // 
            // timerUpdater
            // 
            this.timerUpdater.Tick += new System.EventHandler(this.timerUpdater_Tick);
            // 
            // notifMenu
            // 
            this.notifMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem1,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
            this.notifMenu.Name = "notifMenu";
            this.notifMenu.Size = new System.Drawing.Size(171, 76);
            this.notifMenu.Text = "Show";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem1
            // 
            this.checkForUpdatesToolStripMenuItem1.Name = "checkForUpdatesToolStripMenuItem1";
            this.checkForUpdatesToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.checkForUpdatesToolStripMenuItem1.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem1.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // checkAffinity
            // 
            this.checkAffinity.AutoSize = true;
            this.checkAffinity.Checked = true;
            this.checkAffinity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAffinity.Enabled = false;
            this.checkAffinity.Location = new System.Drawing.Point(12, 251);
            this.checkAffinity.Name = "checkAffinity";
            this.checkAffinity.Size = new System.Drawing.Size(137, 17);
            this.checkAffinity.TabIndex = 18;
            this.checkAffinity.Text = "Change affinity to cores";
            this.checkAffinity.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 442);
            this.Controls.Add(this.checkAffinity);
            this.Controls.Add(this.linkUpdate);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.buttonAuto);
            this.Controls.Add(this.checkStartState);
            this.Controls.Add(this.chkStartUp);
            this.Controls.Add(this.labelOptimized);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkAdvanced);
            this.Controls.Add(this.comboCores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPriority);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarkov Optimizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.notifMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboPriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCores;
        private System.Windows.Forms.CheckBox checkAdvanced;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ToolStripStatusLabel labelToolVersion;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem buttonToolExit;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOptimized;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox chkStartUp;
        private System.Windows.Forms.CheckBox checkStartState;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.RichTextBox textLog;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.Label linkUpdate;
        private System.Windows.Forms.Timer timerUpdater;
        private System.Windows.Forms.ContextMenuStrip notifMenu;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkAffinity;
    }
}

