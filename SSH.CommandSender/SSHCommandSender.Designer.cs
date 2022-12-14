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
            this.ctxMenuProccessOutputs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSaveOutputsToFile = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ctxMenuProccessOutputs.SuspendLayout();
            this.ctxMenuServers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ctxMenuCommands.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSshOutputs
            // 
            this.tabSshOutputs.ContextMenuStrip = this.ctxMenuProccessOutputs;
            this.tabSshOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSshOutputs.Location = new System.Drawing.Point(7, 13);
            this.tabSshOutputs.Margin = new System.Windows.Forms.Padding(0);
            this.tabSshOutputs.Name = "tabSshOutputs";
            this.tabSshOutputs.SelectedIndex = 0;
            this.tabSshOutputs.Size = new System.Drawing.Size(690, 680);
            this.tabSshOutputs.TabIndex = 0;
            // 
            // ctxMenuProccessOutputs
            // 
            this.ctxMenuProccessOutputs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuProccessOutputs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaveOutputsToFile});
            this.ctxMenuProccessOutputs.Name = "ctxMenuServers";
            this.ctxMenuProccessOutputs.Size = new System.Drawing.Size(181, 26);
            // 
            // menuSaveOutputsToFile
            // 
            this.menuSaveOutputsToFile.Name = "menuSaveOutputsToFile";
            this.menuSaveOutputsToFile.Size = new System.Drawing.Size(180, 22);
            this.menuSaveOutputsToFile.Text = "Save Outputs To File";
            this.menuSaveOutputsToFile.Click += new System.EventHandler(this.menuSaveOutputsToFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(905, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(6, 7);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRunCommands
            // 
            this.btnRunCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunCommands.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRunCommands.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunCommands.Location = new System.Drawing.Point(1049, 2);
            this.btnRunCommands.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRunCommands.Name = "btnRunCommands";
            this.btnRunCommands.Size = new System.Drawing.Size(121, 42);
            this.btnRunCommands.TabIndex = 2;
            this.btnRunCommands.Text = "Run";
            this.btnRunCommands.UseVisualStyleBackColor = false;
            this.btnRunCommands.Click += new System.EventHandler(this.btnRunCommands_Click);
            // 
            // btnLoadServersListFromFile
            // 
            this.btnLoadServersListFromFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadServersListFromFile.Location = new System.Drawing.Point(8, 2);
            this.btnLoadServersListFromFile.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.btnLoadServersListFromFile.Name = "btnLoadServersListFromFile";
            this.btnLoadServersListFromFile.Size = new System.Drawing.Size(218, 43);
            this.btnLoadServersListFromFile.TabIndex = 3;
            this.btnLoadServersListFromFile.Text = "Load Servers From File";
            this.btnLoadServersListFromFile.UseVisualStyleBackColor = true;
            this.btnLoadServersListFromFile.Click += new System.EventHandler(this.btnLoadServersListFromFile_Click);
            // 
            // progressBarRunningTasks
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressBarRunningTasks, 3);
            this.progressBarRunningTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarRunningTasks.Location = new System.Drawing.Point(2, 742);
            this.progressBarRunningTasks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarRunningTasks.Minimum = 1;
            this.progressBarRunningTasks.Name = "progressBarRunningTasks";
            this.progressBarRunningTasks.Size = new System.Drawing.Size(1168, 44);
            this.progressBarRunningTasks.Step = 1;
            this.progressBarRunningTasks.TabIndex = 4;
            this.progressBarRunningTasks.Value = 1;
            // 
            // chkListServers
            // 
            this.chkListServers.CheckOnClick = true;
            this.chkListServers.ContextMenuStrip = this.ctxMenuServers;
            this.chkListServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListServers.FormattingEnabled = true;
            this.chkListServers.Location = new System.Drawing.Point(7, 13);
            this.chkListServers.Margin = new System.Windows.Forms.Padding(0);
            this.chkListServers.Name = "chkListServers";
            this.chkListServers.Size = new System.Drawing.Size(210, 680);
            this.chkListServers.TabIndex = 5;
            // 
            // ctxMenuServers
            // 
            this.ctxMenuServers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuServers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRemoveSelectedServers});
            this.ctxMenuServers.Name = "ctxMenuServers";
            this.ctxMenuServers.Size = new System.Drawing.Size(165, 26);
            // 
            // menuRemoveSelectedServers
            // 
            this.menuRemoveSelectedServers.Name = "menuRemoveSelectedServers";
            this.menuRemoveSelectedServers.Size = new System.Drawing.Size(164, 22);
            this.menuRemoveSelectedServers.Text = "Remove Selected";
            this.menuRemoveSelectedServers.Click += new System.EventHandler(this.menuRemoveSelectedServers_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.chkListServers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.groupBox1.Size = new System.Drawing.Size(224, 693);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servers";
            // 
            // chkListCommands
            // 
            this.chkListCommands.CheckOnClick = true;
            this.chkListCommands.ContextMenuStrip = this.ctxMenuCommands;
            this.chkListCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListCommands.FormattingEnabled = true;
            this.chkListCommands.Location = new System.Drawing.Point(7, 13);
            this.chkListCommands.Margin = new System.Windows.Forms.Padding(0);
            this.chkListCommands.Name = "chkListCommands";
            this.chkListCommands.Size = new System.Drawing.Size(210, 680);
            this.chkListCommands.TabIndex = 5;
            // 
            // ctxMenuCommands
            // 
            this.ctxMenuCommands.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRemoveSelectedCommands});
            this.ctxMenuCommands.Name = "ctxMenuServers";
            this.ctxMenuCommands.Size = new System.Drawing.Size(165, 26);
            // 
            // menuRemoveSelectedCommands
            // 
            this.menuRemoveSelectedCommands.Name = "menuRemoveSelectedCommands";
            this.menuRemoveSelectedCommands.Size = new System.Drawing.Size(164, 22);
            this.menuRemoveSelectedCommands.Text = "Remove Selected";
            this.menuRemoveSelectedCommands.Click += new System.EventHandler(this.menuRemoveSelectedCommands_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.chkListCommands);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(239, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.groupBox2.Size = new System.Drawing.Size(224, 693);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.tabSshOutputs);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(468, 47);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.groupBox3.Size = new System.Drawing.Size(704, 693);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proccess Outputs";
            // 
            // btnLoadCommandsFromFile
            // 
            this.btnLoadCommandsFromFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadCommandsFromFile.Location = new System.Drawing.Point(242, 2);
            this.btnLoadCommandsFromFile.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.btnLoadCommandsFromFile.Name = "btnLoadCommandsFromFile";
            this.btnLoadCommandsFromFile.Size = new System.Drawing.Size(218, 43);
            this.btnLoadCommandsFromFile.TabIndex = 9;
            this.btnLoadCommandsFromFile.Text = "Load Commands From File";
            this.btnLoadCommandsFromFile.UseVisualStyleBackColor = true;
            this.btnLoadCommandsFromFile.Click += new System.EventHandler(this.btnLoadCommandsFromFile_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.progressBarRunningTasks, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadServersListFromFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadCommandsFromFile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRunCommands, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1172, 788);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // SSHCommandSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 788);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SSHCommandSender";
            this.Text = "SSH.CommandSender";
            this.ctxMenuProccessOutputs.ResumeLayout(false);
            this.ctxMenuServers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ctxMenuCommands.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

