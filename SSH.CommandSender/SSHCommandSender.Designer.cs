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
            this.btnRunCommands = new System.Windows.Forms.Button();
            this.btnAddNewServer = new System.Windows.Forms.Button();
            this.progressBarRunningTasks = new System.Windows.Forms.ProgressBar();
            this.ctxMenuServers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRemoveSelectedServers = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCommands = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRemoveSelectedCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxProccessOutputs = new System.Windows.Forms.GroupBox();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxServers = new System.Windows.Forms.GroupBox();
            this.tableLayoutServers = new System.Windows.Forms.TableLayoutPanel();
            this.chkListServers = new System.Windows.Forms.CheckedListBox();
            this.groupBoxCommands = new System.Windows.Forms.GroupBox();
            this.tableLayoutCommands = new System.Windows.Forms.TableLayoutPanel();
            this.chkListCommands = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanelServersButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnImportServers = new System.Windows.Forms.Button();
            this.btnExportServers = new System.Windows.Forms.Button();
            this.tableLayoutPanelCommandsButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnImportCommand = new System.Windows.Forms.Button();
            this.btnExportCommand = new System.Windows.Forms.Button();
            this.btnAddNewCommand = new System.Windows.Forms.Button();
            this.ctxMenuProccessOutputs.SuspendLayout();
            this.ctxMenuServers.SuspendLayout();
            this.ctxMenuCommands.SuspendLayout();
            this.groupBoxProccessOutputs.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
            this.groupBoxServers.SuspendLayout();
            this.tableLayoutServers.SuspendLayout();
            this.groupBoxCommands.SuspendLayout();
            this.tableLayoutCommands.SuspendLayout();
            this.tableLayoutPanelServersButtons.SuspendLayout();
            this.tableLayoutPanelCommandsButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSshOutputs
            // 
            this.tabSshOutputs.ContextMenuStrip = this.ctxMenuProccessOutputs;
            this.tabSshOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSshOutputs.Location = new System.Drawing.Point(7, 16);
            this.tabSshOutputs.Margin = new System.Windows.Forms.Padding(0);
            this.tabSshOutputs.Name = "tabSshOutputs";
            this.tabSshOutputs.SelectedIndex = 0;
            this.tabSshOutputs.Size = new System.Drawing.Size(690, 677);
            this.tabSshOutputs.TabIndex = 0;
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
            // btnRunCommands
            // 
            this.btnRunCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunCommands.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRunCommands.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunCommands.Location = new System.Drawing.Point(1049, 2);
            this.btnRunCommands.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunCommands.Name = "btnRunCommands";
            this.btnRunCommands.Size = new System.Drawing.Size(121, 42);
            this.btnRunCommands.TabIndex = 2;
            this.btnRunCommands.Text = "Run";
            this.btnRunCommands.UseVisualStyleBackColor = false;
            this.btnRunCommands.Click += new System.EventHandler(this.btnRunCommands_Click);
            // 
            // btnAddNewServer
            // 
            this.btnAddNewServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewServer.Location = new System.Drawing.Point(170, 0);
            this.btnAddNewServer.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewServer.Name = "btnAddNewServer";
            this.btnAddNewServer.Size = new System.Drawing.Size(85, 81);
            this.btnAddNewServer.TabIndex = 3;
            this.btnAddNewServer.Text = "Add";
            this.btnAddNewServer.UseVisualStyleBackColor = true;
            this.btnAddNewServer.Click += new System.EventHandler(this.btnAddNewServer_Click);
            // 
            // progressBarRunningTasks
            // 
            this.tableLayoutMain.SetColumnSpan(this.progressBarRunningTasks, 3);
            this.progressBarRunningTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarRunningTasks.Location = new System.Drawing.Point(2, 742);
            this.progressBarRunningTasks.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarRunningTasks.Minimum = 1;
            this.progressBarRunningTasks.Name = "progressBarRunningTasks";
            this.progressBarRunningTasks.Size = new System.Drawing.Size(1168, 44);
            this.progressBarRunningTasks.Step = 1;
            this.progressBarRunningTasks.TabIndex = 4;
            this.progressBarRunningTasks.Value = 1;
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
            // groupBoxProccessOutputs
            // 
            this.groupBoxProccessOutputs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxProccessOutputs.Controls.Add(this.tabSshOutputs);
            this.groupBoxProccessOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProccessOutputs.Location = new System.Drawing.Point(468, 47);
            this.groupBoxProccessOutputs.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxProccessOutputs.Name = "groupBoxProccessOutputs";
            this.groupBoxProccessOutputs.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.groupBoxProccessOutputs.Size = new System.Drawing.Size(704, 693);
            this.groupBoxProccessOutputs.TabIndex = 8;
            this.groupBoxProccessOutputs.TabStop = false;
            this.groupBoxProccessOutputs.Text = "Proccess Outputs";
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 3;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutMain.Controls.Add(this.progressBarRunningTasks, 0, 2);
            this.tableLayoutMain.Controls.Add(this.groupBoxServers, 0, 0);
            this.tableLayoutMain.Controls.Add(this.groupBoxProccessOutputs, 2, 1);
            this.tableLayoutMain.Controls.Add(this.btnRunCommands, 2, 0);
            this.tableLayoutMain.Controls.Add(this.groupBoxCommands, 1, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 3;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1172, 788);
            this.tableLayoutMain.TabIndex = 10;
            // 
            // groupBoxServers
            // 
            this.groupBoxServers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxServers.Controls.Add(this.tableLayoutServers);
            this.groupBoxServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxServers.Location = new System.Drawing.Point(5, 0);
            this.groupBoxServers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.groupBoxServers.Name = "groupBoxServers";
            this.groupBoxServers.Padding = new System.Windows.Forms.Padding(7, 0, 7, 5);
            this.tableLayoutMain.SetRowSpan(this.groupBoxServers, 2);
            this.groupBoxServers.Size = new System.Drawing.Size(224, 740);
            this.groupBoxServers.TabIndex = 6;
            this.groupBoxServers.TabStop = false;
            this.groupBoxServers.Text = "Servers";
            // 
            // tableLayoutServers
            // 
            this.tableLayoutServers.ColumnCount = 1;
            this.tableLayoutServers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutServers.Controls.Add(this.chkListServers, 0, 1);
            this.tableLayoutServers.Controls.Add(this.tableLayoutPanelServersButtons, 0, 0);
            this.tableLayoutServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutServers.Location = new System.Drawing.Point(7, 16);
            this.tableLayoutServers.Name = "tableLayoutServers";
            this.tableLayoutServers.RowCount = 2;
            this.tableLayoutServers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutServers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutServers.Size = new System.Drawing.Size(210, 719);
            this.tableLayoutServers.TabIndex = 6;
            // 
            // chkListServers
            // 
            this.chkListServers.CheckOnClick = true;
            this.chkListServers.ContextMenuStrip = this.ctxMenuServers;
            this.chkListServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListServers.FormattingEnabled = true;
            this.chkListServers.Location = new System.Drawing.Point(0, 71);
            this.chkListServers.Margin = new System.Windows.Forms.Padding(0);
            this.chkListServers.Name = "chkListServers";
            this.chkListServers.Size = new System.Drawing.Size(210, 648);
            this.chkListServers.TabIndex = 5;
            // 
            // groupBoxCommands
            // 
            this.groupBoxCommands.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCommands.Controls.Add(this.tableLayoutCommands);
            this.groupBoxCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCommands.Location = new System.Drawing.Point(239, 0);
            this.groupBoxCommands.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.groupBoxCommands.Name = "groupBoxCommands";
            this.groupBoxCommands.Padding = new System.Windows.Forms.Padding(7, 0, 7, 5);
            this.tableLayoutMain.SetRowSpan(this.groupBoxCommands, 2);
            this.groupBoxCommands.Size = new System.Drawing.Size(224, 740);
            this.groupBoxCommands.TabIndex = 7;
            this.groupBoxCommands.TabStop = false;
            this.groupBoxCommands.Text = "Commands";
            // 
            // tableLayoutCommands
            // 
            this.tableLayoutCommands.ColumnCount = 1;
            this.tableLayoutCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutCommands.Controls.Add(this.chkListCommands, 0, 1);
            this.tableLayoutCommands.Controls.Add(this.tableLayoutPanelCommandsButtons, 0, 0);
            this.tableLayoutCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutCommands.Location = new System.Drawing.Point(7, 16);
            this.tableLayoutCommands.Name = "tableLayoutCommands";
            this.tableLayoutCommands.RowCount = 2;
            this.tableLayoutCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutCommands.Size = new System.Drawing.Size(210, 719);
            this.tableLayoutCommands.TabIndex = 10;
            // 
            // chkListCommands
            // 
            this.chkListCommands.CheckOnClick = true;
            this.chkListCommands.ContextMenuStrip = this.ctxMenuCommands;
            this.chkListCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListCommands.FormattingEnabled = true;
            this.chkListCommands.Location = new System.Drawing.Point(0, 71);
            this.chkListCommands.Margin = new System.Windows.Forms.Padding(0);
            this.chkListCommands.Name = "chkListCommands";
            this.chkListCommands.Size = new System.Drawing.Size(210, 648);
            this.chkListCommands.TabIndex = 5;
            // 
            // tableLayoutPanelServersButtons
            // 
            this.tableLayoutPanelServersButtons.ColumnCount = 3;
            this.tableLayoutPanelServersButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelServersButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelServersButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelServersButtons.Controls.Add(this.btnExportServers, 1, 0);
            this.tableLayoutPanelServersButtons.Controls.Add(this.btnImportServers, 0, 0);
            this.tableLayoutPanelServersButtons.Controls.Add(this.btnAddNewServer, 2, 0);
            this.tableLayoutPanelServersButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelServersButtons.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelServersButtons.Name = "tableLayoutPanelServersButtons";
            this.tableLayoutPanelServersButtons.RowCount = 1;
            this.tableLayoutPanelServersButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelServersButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelServersButtons.Size = new System.Drawing.Size(204, 65);
            this.tableLayoutPanelServersButtons.TabIndex = 6;
            // 
            // btnImportServers
            // 
            this.btnImportServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImportServers.Location = new System.Drawing.Point(0, 0);
            this.btnImportServers.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportServers.Name = "btnImportServers";
            this.btnImportServers.Size = new System.Drawing.Size(85, 81);
            this.btnImportServers.TabIndex = 4;
            this.btnImportServers.Text = "Import";
            this.btnImportServers.UseVisualStyleBackColor = true;
            this.btnImportServers.Click += new System.EventHandler(this.btnImportServers_Click);
            // 
            // btnExportServers
            // 
            this.btnExportServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportServers.Location = new System.Drawing.Point(85, 0);
            this.btnExportServers.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportServers.Name = "btnExportServers";
            this.btnExportServers.Size = new System.Drawing.Size(85, 81);
            this.btnExportServers.TabIndex = 5;
            this.btnExportServers.Text = "Export";
            this.btnExportServers.UseVisualStyleBackColor = true;
            this.btnExportServers.Click += new System.EventHandler(this.btnExportServers_Click);
            // 
            // tableLayoutPanelCommandsButtons
            // 
            this.tableLayoutPanelCommandsButtons.ColumnCount = 3;
            this.tableLayoutPanelCommandsButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelCommandsButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelCommandsButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelCommandsButtons.Controls.Add(this.btnAddNewCommand, 2, 0);
            this.tableLayoutPanelCommandsButtons.Controls.Add(this.btnExportCommand, 1, 0);
            this.tableLayoutPanelCommandsButtons.Controls.Add(this.btnImportCommand, 0, 0);
            this.tableLayoutPanelCommandsButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCommandsButtons.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanelCommandsButtons.Name = "tableLayoutPanelCommandsButtons";
            this.tableLayoutPanelCommandsButtons.RowCount = 1;
            this.tableLayoutPanelCommandsButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCommandsButtons.Size = new System.Drawing.Size(255, 81);
            this.tableLayoutPanelCommandsButtons.TabIndex = 6;
            // 
            // btnImportCommand
            // 
            this.btnImportCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImportCommand.Location = new System.Drawing.Point(0, 0);
            this.btnImportCommand.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportCommand.Name = "btnImportCommand";
            this.btnImportCommand.Size = new System.Drawing.Size(106, 101);
            this.btnImportCommand.TabIndex = 0;
            this.btnImportCommand.Text = "Import";
            this.btnImportCommand.UseVisualStyleBackColor = true;
            this.btnImportCommand.Click += new System.EventHandler(this.btnImportCommand_Click);
            // 
            // btnExportCommand
            // 
            this.btnExportCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportCommand.Location = new System.Drawing.Point(106, 0);
            this.btnExportCommand.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportCommand.Name = "btnExportCommand";
            this.btnExportCommand.Size = new System.Drawing.Size(106, 101);
            this.btnExportCommand.TabIndex = 1;
            this.btnExportCommand.Text = "Export";
            this.btnExportCommand.UseVisualStyleBackColor = true;
            this.btnExportCommand.Click += new System.EventHandler(this.btnExportCommand_Click);
            // 
            // btnAddNewCommand
            // 
            this.btnAddNewCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewCommand.Location = new System.Drawing.Point(213, 0);
            this.btnAddNewCommand.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewCommand.Name = "btnAddNewCommand";
            this.btnAddNewCommand.Size = new System.Drawing.Size(106, 101);
            this.btnAddNewCommand.TabIndex = 2;
            this.btnAddNewCommand.Text = "Add";
            this.btnAddNewCommand.UseVisualStyleBackColor = true;
            this.btnAddNewCommand.Click += new System.EventHandler(this.btnAddNewCommand_Click);
            // 
            // SSHCommandSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 788);
            this.Controls.Add(this.tableLayoutMain);
            this.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SSHCommandSender";
            this.Text = "SSH.CommandSender";
            this.ctxMenuProccessOutputs.ResumeLayout(false);
            this.ctxMenuServers.ResumeLayout(false);
            this.ctxMenuCommands.ResumeLayout(false);
            this.groupBoxProccessOutputs.ResumeLayout(false);
            this.tableLayoutMain.ResumeLayout(false);
            this.groupBoxServers.ResumeLayout(false);
            this.tableLayoutServers.ResumeLayout(false);
            this.groupBoxCommands.ResumeLayout(false);
            this.tableLayoutCommands.ResumeLayout(false);
            this.tableLayoutPanelServersButtons.ResumeLayout(false);
            this.tableLayoutPanelCommandsButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSshOutputs;
        private System.Windows.Forms.Button btnRunCommands;
        private System.Windows.Forms.Button btnAddNewServer;
        private System.Windows.Forms.ProgressBar progressBarRunningTasks;
        private System.Windows.Forms.GroupBox groupBoxProccessOutputs;
        private System.Windows.Forms.ContextMenuStrip ctxMenuServers;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveSelectedServers;
        private System.Windows.Forms.ContextMenuStrip ctxMenuCommands;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveSelectedCommands;
        private System.Windows.Forms.ContextMenuStrip ctxMenuProccessOutputs;
        private System.Windows.Forms.ToolStripMenuItem menuSaveOutputsToFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.GroupBox groupBoxServers;
        private System.Windows.Forms.CheckedListBox chkListServers;
        private System.Windows.Forms.GroupBox groupBoxCommands;
        private System.Windows.Forms.CheckedListBox chkListCommands;
        private System.Windows.Forms.TableLayoutPanel tableLayoutServers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCommands;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelServersButtons;
        private System.Windows.Forms.Button btnExportServers;
        private System.Windows.Forms.Button btnImportServers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCommandsButtons;
        private System.Windows.Forms.Button btnAddNewCommand;
        private System.Windows.Forms.Button btnExportCommand;
        private System.Windows.Forms.Button btnImportCommand;
    }
}

