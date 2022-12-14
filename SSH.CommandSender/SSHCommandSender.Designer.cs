namespace SSH.CommandSender
{
    partial class SSHCommandSender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSHCommandSender));
            this.tabSshOutputs = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRunCommands = new System.Windows.Forms.Button();
            this.btnLoadServersListFromFile = new System.Windows.Forms.Button();
            this.progressBarRunningTasks = new System.Windows.Forms.ProgressBar();
            this.chkListServers = new System.Windows.Forms.CheckedListBox();
            this.ctxMenuServers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRemoveSelectedServers = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkListCommands = new System.Windows.Forms.CheckedListBox();
            this.ctxMenuCommands = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRemoveSelectedCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoadCommandsFromFile = new System.Windows.Forms.Button();
            this.ctxMenuProccessOutputs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSaveOutputsToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuServers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ctxMenuCommands.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ctxMenuProccessOutputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSshOutputs
            // 
            this.tabSshOutputs.ContextMenuStrip = this.ctxMenuProccessOutputs;
            this.tabSshOutputs.Location = new System.Drawing.Point(9, 18);
            this.tabSshOutputs.Name = "tabSshOutputs";
            this.tabSshOutputs.SelectedIndex = 0;
            this.tabSshOutputs.Size = new System.Drawing.Size(1064, 610);
            this.tabSshOutputs.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1207, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRunCommands
            // 
            this.btnRunCommands.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunCommands.Location = new System.Drawing.Point(1386, 12);
            this.btnRunCommands.Name = "btnRunCommands";
            this.btnRunCommands.Size = new System.Drawing.Size(161, 59);
            this.btnRunCommands.TabIndex = 2;
            this.btnRunCommands.Text = "Run";
            this.btnRunCommands.UseVisualStyleBackColor = true;
            this.btnRunCommands.Click += new System.EventHandler(this.btnRunCommands_Click);
            // 
            // btnLoadServersListFromFile
            // 
            this.btnLoadServersListFromFile.Location = new System.Drawing.Point(9, 12);
            this.btnLoadServersListFromFile.Name = "btnLoadServersListFromFile";
            this.btnLoadServersListFromFile.Size = new System.Drawing.Size(215, 59);
            this.btnLoadServersListFromFile.TabIndex = 3;
            this.btnLoadServersListFromFile.Text = "Load Servers From File";
            this.btnLoadServersListFromFile.UseVisualStyleBackColor = true;
            this.btnLoadServersListFromFile.Click += new System.EventHandler(this.btnLoadServersListFromFile_Click);
            // 
            // progressBarRunningTasks
            // 
            this.progressBarRunningTasks.Location = new System.Drawing.Point(3, 724);
            this.progressBarRunningTasks.Minimum = 1;
            this.progressBarRunningTasks.Name = "progressBarRunningTasks";
            this.progressBarRunningTasks.Size = new System.Drawing.Size(1544, 62);
            this.progressBarRunningTasks.Step = 1;
            this.progressBarRunningTasks.TabIndex = 4;
            this.progressBarRunningTasks.Value = 1;
            // 
            // chkListServers
            // 
            this.chkListServers.CheckOnClick = true;
            this.chkListServers.ContextMenuStrip = this.ctxMenuServers;
            this.chkListServers.FormattingEnabled = true;
            this.chkListServers.Location = new System.Drawing.Point(6, 21);
            this.chkListServers.Name = "chkListServers";
            this.chkListServers.Size = new System.Drawing.Size(215, 616);
            this.chkListServers.TabIndex = 5;
            // 
            // ctxMenuServers
            // 
            this.ctxMenuServers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuServers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRemoveSelectedServers});
            this.ctxMenuServers.Name = "ctxMenuServers";
            this.ctxMenuServers.Size = new System.Drawing.Size(194, 28);
            // 
            // menuRemoveSelectedServers
            // 
            this.menuRemoveSelectedServers.Name = "menuRemoveSelectedServers";
            this.menuRemoveSelectedServers.Size = new System.Drawing.Size(193, 24);
            this.menuRemoveSelectedServers.Text = "Remove Selected";
            this.menuRemoveSelectedServers.Click += new System.EventHandler(this.menuRemoveSelectedServers_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkListServers);
            this.groupBox1.Location = new System.Drawing.Point(3, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 640);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servers";
            // 
            // chkListCommands
            // 
            this.chkListCommands.CheckOnClick = true;
            this.chkListCommands.ContextMenuStrip = this.ctxMenuCommands;
            this.chkListCommands.FormattingEnabled = true;
            this.chkListCommands.Location = new System.Drawing.Point(6, 21);
            this.chkListCommands.Name = "chkListCommands";
            this.chkListCommands.Size = new System.Drawing.Size(215, 616);
            this.chkListCommands.TabIndex = 5;
            // 
            // ctxMenuCommands
            // 
            this.ctxMenuCommands.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRemoveSelectedCommands});
            this.ctxMenuCommands.Name = "ctxMenuServers";
            this.ctxMenuCommands.Size = new System.Drawing.Size(194, 28);
            // 
            // menuRemoveSelectedCommands
            // 
            this.menuRemoveSelectedCommands.Name = "menuRemoveSelectedCommands";
            this.menuRemoveSelectedCommands.Size = new System.Drawing.Size(193, 24);
            this.menuRemoveSelectedCommands.Text = "Remove Selected";
            this.menuRemoveSelectedCommands.Click += new System.EventHandler(this.menuRemoveSelectedCommands_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkListCommands);
            this.groupBox2.Location = new System.Drawing.Point(236, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 640);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabSshOutputs);
            this.groupBox3.Location = new System.Drawing.Point(469, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1082, 640);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proccess Outputs";
            // 
            // btnLoadCommandsFromFile
            // 
            this.btnLoadCommandsFromFile.Location = new System.Drawing.Point(242, 12);
            this.btnLoadCommandsFromFile.Name = "btnLoadCommandsFromFile";
            this.btnLoadCommandsFromFile.Size = new System.Drawing.Size(215, 59);
            this.btnLoadCommandsFromFile.TabIndex = 9;
            this.btnLoadCommandsFromFile.Text = "Load Commands From File";
            this.btnLoadCommandsFromFile.UseVisualStyleBackColor = true;
            this.btnLoadCommandsFromFile.Click += new System.EventHandler(this.btnLoadCommandsFromFile_Click);
            // 
            // ctxMenuProccessOutputs
            // 
            this.ctxMenuProccessOutputs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuProccessOutputs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaveOutputsToFile});
            this.ctxMenuProccessOutputs.Name = "ctxMenuServers";
            this.ctxMenuProccessOutputs.Size = new System.Drawing.Size(213, 28);
            // 
            // menuSaveOutputsToFile
            // 
            this.menuSaveOutputsToFile.Name = "menuSaveOutputsToFile";
            this.menuSaveOutputsToFile.Size = new System.Drawing.Size(212, 24);
            this.menuSaveOutputsToFile.Text = "Save Outputs To File";
            this.menuSaveOutputsToFile.Click += new System.EventHandler(this.menuSaveOutputsToFile_Click);
            // 
            // SSHCommandSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 788);
            this.Controls.Add(this.btnLoadCommandsFromFile);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBarRunningTasks);
            this.Controls.Add(this.btnLoadServersListFromFile);
            this.Controls.Add(this.btnRunCommands);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SSHCommandSender";
            this.Text = "SSH.CommandSender";
            this.ctxMenuServers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ctxMenuCommands.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ctxMenuProccessOutputs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSshOutputs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRunCommands;
        private System.Windows.Forms.Button btnLoadServersListFromFile;
        private System.Windows.Forms.ProgressBar progressBarRunningTasks;
        private System.Windows.Forms.CheckedListBox chkListServers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chkListCommands;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLoadCommandsFromFile;
        private System.Windows.Forms.ContextMenuStrip ctxMenuServers;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveSelectedServers;
        private System.Windows.Forms.ContextMenuStrip ctxMenuCommands;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveSelectedCommands;
        private System.Windows.Forms.ContextMenuStrip ctxMenuProccessOutputs;
        private System.Windows.Forms.ToolStripMenuItem menuSaveOutputsToFile;
    }
}

