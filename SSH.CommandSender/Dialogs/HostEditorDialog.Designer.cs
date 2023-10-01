namespace SSH.CommandSender.Dialogs
{
    partial class HostEditorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostEditorDialog));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtPathToKeyFile = new System.Windows.Forms.TextBox();
            this.lnkTogglePassPhrase = new System.Windows.Forms.LinkLabel();
            this.txtPassPhrase = new System.Windows.Forms.TextBox();
            this.lblAuthMethod = new System.Windows.Forms.Label();
            this.numericPort = new System.Windows.Forms.NumericUpDown();
            this.lnkTogglePasswordField = new System.Windows.Forms.LinkLabel();
            this.comboAuthMethod = new System.Windows.Forms.ComboBox();
            this.lblPathToKey = new System.Windows.Forms.Label();
            this.lblPassPhrase = new System.Windows.Forms.Label();
            this.btnBrowseKeyPath = new System.Windows.Forms.Button();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(127, 63);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(444, 30);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 63);
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 0, 36, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 63);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 5;
            this.tableLayoutPanelMain.SetColumnSpan(this.tableLayoutPanelButtons, 3);
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.Controls.Add(this.btnCancel, 3, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnSave, 4, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(3, 570);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(629, 64);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(378, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 58);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(503, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 58);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblHost
            // 
            this.lblHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(57, 126);
            this.lblHost.Margin = new System.Windows.Forms.Padding(0, 0, 38, 0);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 17);
            this.lblHost.TabIndex = 3;
            this.lblHost.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHost.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(127, 126);
            this.txtHost.Margin = new System.Windows.Forms.Padding(0);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(444, 30);
            this.txtHost.TabIndex = 4;
            // 
            // lblPort
            // 
            this.lblPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(58, 189);
            this.lblPort.Margin = new System.Windows.Forms.Padding(0, 0, 38, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(31, 17);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Port:";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(56, 252);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(59, 17);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(127, 252);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(444, 30);
            this.txtUsername.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(59, 378);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 17);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(127, 378);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(444, 30);
            this.txtPassword.TabIndex = 10;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.Controls.Add(this.txtPathToKeyFile, 1, 7);
            this.tableLayoutPanelMain.Controls.Add(this.lnkTogglePassPhrase, 2, 8);
            this.tableLayoutPanelMain.Controls.Add(this.txtPassPhrase, 1, 8);
            this.tableLayoutPanelMain.Controls.Add(this.lblAuthMethod, 0, 5);
            this.tableLayoutPanelMain.Controls.Add(this.txtPassword, 1, 6);
            this.tableLayoutPanelMain.Controls.Add(this.lblPassword, 0, 6);
            this.tableLayoutPanelMain.Controls.Add(this.txtUsername, 1, 4);
            this.tableLayoutPanelMain.Controls.Add(this.lblUsername, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.lblPort, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.txtHost, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.lblHost, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelButtons, 0, 9);
            this.tableLayoutPanelMain.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.numericPort, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.lnkTogglePasswordField, 2, 6);
            this.tableLayoutPanelMain.Controls.Add(this.comboAuthMethod, 1, 5);
            this.tableLayoutPanelMain.Controls.Add(this.lblPathToKey, 0, 7);
            this.tableLayoutPanelMain.Controls.Add(this.lblPassPhrase, 0, 8);
            this.tableLayoutPanelMain.Controls.Add(this.btnBrowseKeyPath, 2, 7);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 10;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(635, 637);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // txtPathToKeyFile
            // 
            this.txtPathToKeyFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPathToKeyFile.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToKeyFile.Location = new System.Drawing.Point(127, 441);
            this.txtPathToKeyFile.Margin = new System.Windows.Forms.Padding(0);
            this.txtPathToKeyFile.Name = "txtPathToKeyFile";
            this.txtPathToKeyFile.Size = new System.Drawing.Size(444, 30);
            this.txtPathToKeyFile.TabIndex = 19;
            // 
            // lnkTogglePassPhrase
            // 
            this.lnkTogglePassPhrase.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkTogglePassPhrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkTogglePassPhrase.AutoSize = true;
            this.lnkTogglePassPhrase.Font = new System.Drawing.Font("Ubuntu Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lnkTogglePassPhrase.Image = global::SSH.CommandSender.Properties.Resources.icon_opened_eye;
            this.lnkTogglePassPhrase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkTogglePassPhrase.LinkArea = new System.Windows.Forms.LinkArea(0, 25);
            this.lnkTogglePassPhrase.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkTogglePassPhrase.LinkColor = System.Drawing.Color.Black;
            this.lnkTogglePassPhrase.Location = new System.Drawing.Point(571, 504);
            this.lnkTogglePassPhrase.Margin = new System.Windows.Forms.Padding(0);
            this.lnkTogglePassPhrase.Name = "lnkTogglePassPhrase";
            this.lnkTogglePassPhrase.Size = new System.Drawing.Size(54, 63);
            this.lnkTogglePassPhrase.TabIndex = 18;
            this.lnkTogglePassPhrase.TabStop = true;
            this.lnkTogglePassPhrase.Text = "         ";
            this.lnkTogglePassPhrase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkTogglePassPhrase.UseCompatibleTextRendering = true;
            this.lnkTogglePassPhrase.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkTogglePassPhrase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTogglePassPhrase_LinkClicked);
            // 
            // txtPassPhrase
            // 
            this.txtPassPhrase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassPhrase.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassPhrase.Location = new System.Drawing.Point(127, 504);
            this.txtPassPhrase.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassPhrase.Name = "txtPassPhrase";
            this.txtPassPhrase.PasswordChar = '●';
            this.txtPassPhrase.Size = new System.Drawing.Size(444, 30);
            this.txtPassPhrase.TabIndex = 17;
            // 
            // lblAuthMethod
            // 
            this.lblAuthMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthMethod.AutoSize = true;
            this.lblAuthMethod.Location = new System.Drawing.Point(48, 315);
            this.lblAuthMethod.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblAuthMethod.Name = "lblAuthMethod";
            this.lblAuthMethod.Size = new System.Drawing.Size(74, 17);
            this.lblAuthMethod.TabIndex = 13;
            this.lblAuthMethod.Text = "Auth Method:";
            // 
            // numericPort
            // 
            this.numericPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.numericPort.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPort.Location = new System.Drawing.Point(130, 192);
            this.numericPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPort.Name = "numericPort";
            this.numericPort.Size = new System.Drawing.Size(136, 30);
            this.numericPort.TabIndex = 11;
            this.numericPort.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // lnkTogglePasswordField
            // 
            this.lnkTogglePasswordField.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkTogglePasswordField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkTogglePasswordField.AutoSize = true;
            this.lnkTogglePasswordField.Font = new System.Drawing.Font("Ubuntu Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lnkTogglePasswordField.Image = global::SSH.CommandSender.Properties.Resources.icon_opened_eye;
            this.lnkTogglePasswordField.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkTogglePasswordField.LinkArea = new System.Windows.Forms.LinkArea(0, 25);
            this.lnkTogglePasswordField.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkTogglePasswordField.LinkColor = System.Drawing.Color.Black;
            this.lnkTogglePasswordField.Location = new System.Drawing.Point(571, 378);
            this.lnkTogglePasswordField.Margin = new System.Windows.Forms.Padding(0);
            this.lnkTogglePasswordField.Name = "lnkTogglePasswordField";
            this.lnkTogglePasswordField.Size = new System.Drawing.Size(54, 63);
            this.lnkTogglePasswordField.TabIndex = 12;
            this.lnkTogglePasswordField.TabStop = true;
            this.lnkTogglePasswordField.Text = "         ";
            this.lnkTogglePasswordField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkTogglePasswordField.UseCompatibleTextRendering = true;
            this.lnkTogglePasswordField.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkTogglePasswordField.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTogglePasswordField_LinkClicked);
            // 
            // comboAuthMethod
            // 
            this.comboAuthMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboAuthMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAuthMethod.FormattingEnabled = true;
            this.comboAuthMethod.Items.AddRange(new object[] {
            "Password",
            "Private Key File"});
            this.comboAuthMethod.Location = new System.Drawing.Point(130, 318);
            this.comboAuthMethod.Name = "comboAuthMethod";
            this.comboAuthMethod.Size = new System.Drawing.Size(438, 25);
            this.comboAuthMethod.TabIndex = 14;
            // 
            // lblPathToKey
            // 
            this.lblPathToKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPathToKey.AutoSize = true;
            this.lblPathToKey.Location = new System.Drawing.Point(61, 441);
            this.lblPathToKey.Margin = new System.Windows.Forms.Padding(3, 0, 12, 0);
            this.lblPathToKey.Name = "lblPathToKey";
            this.lblPathToKey.Size = new System.Drawing.Size(54, 17);
            this.lblPathToKey.TabIndex = 15;
            this.lblPathToKey.Text = "Key Path:";
            // 
            // lblPassPhrase
            // 
            this.lblPassPhrase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassPhrase.AutoSize = true;
            this.lblPassPhrase.Location = new System.Drawing.Point(58, 504);
            this.lblPassPhrase.Name = "lblPassPhrase";
            this.lblPassPhrase.Size = new System.Drawing.Size(66, 17);
            this.lblPassPhrase.TabIndex = 16;
            this.lblPassPhrase.Text = "Pass Phrase:";
            // 
            // btnBrowseKeyPath
            // 
            this.btnBrowseKeyPath.Location = new System.Drawing.Point(574, 444);
            this.btnBrowseKeyPath.Name = "btnBrowseKeyPath";
            this.btnBrowseKeyPath.Size = new System.Drawing.Size(58, 27);
            this.btnBrowseKeyPath.TabIndex = 20;
            this.btnBrowseKeyPath.Text = "Browse";
            this.btnBrowseKeyPath.UseVisualStyleBackColor = true;
            this.btnBrowseKeyPath.Click += new System.EventHandler(this.btnBrowseKeyPath_Click);
            // 
            // HostEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 637);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Font = new System.Drawing.Font("Ubuntu Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "HostEditorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.HostEditorDialog_Load);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.NumericUpDown numericPort;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lnkTogglePasswordField;
        private System.Windows.Forms.Label lblAuthMethod;
        private System.Windows.Forms.ComboBox comboAuthMethod;
        private System.Windows.Forms.Label lblPathToKey;
        private System.Windows.Forms.Label lblPassPhrase;
        private System.Windows.Forms.TextBox txtPassPhrase;
        private System.Windows.Forms.LinkLabel lnkTogglePassPhrase;
        private System.Windows.Forms.TextBox txtPathToKeyFile;
        private System.Windows.Forms.Button btnBrowseKeyPath;
    }
}