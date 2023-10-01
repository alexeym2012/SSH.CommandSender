using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SSH.CommandSender.Domain;
using SSH.CommandSender.Properties;

namespace SSH.CommandSender.Dialogs
{
    public partial class HostEditorDialog : Form
    {
        public SshHostDetails HostDetails { get; }

        public HostEditorDialog(string windowTitle, SshHostDetails hostDetails)
        {
            HostDetails = hostDetails;
            this.Text = windowTitle;
            InitializeComponent();
        }

        private void HostEditorDialog_Load(object sender, EventArgs e)
        {
            BindControls();
        }

        private void BindControls()
        {
            this.txtName.Text = this.HostDetails.Name;
            this.txtHost.Text = this.HostDetails.Host;
            this.numericPort.Value = this.HostDetails.Port;
            BindAuth();
            this.txtName.DataBindings.Add("Text", this.HostDetails, "Name", false,
                DataSourceUpdateMode.OnValidation);

            this.txtHost.DataBindings.Add("Text", this.HostDetails, "Host", false,
                DataSourceUpdateMode.OnValidation);

            this.numericPort.DataBindings.Add("Value", this.HostDetails, "Port", false,
                DataSourceUpdateMode.OnValidation);
            this.txtUsername.DataBindings.Add("Text", this.HostDetails.AuthenticationDetails, "Username", false,
                DataSourceUpdateMode.OnValidation);
    

      
        }

        private void BindAuth()
        {
            this.txtUsername.Text = this.HostDetails.AuthenticationDetails.Username;
            switch (this.HostDetails.AuthenticationDetails)
            {
                case SshHostDetails.PasswordAuth passwordAuth:
                    
                    comboAuthMethod.SelectedIndex = 0;
                    this.txtPassword.Text = passwordAuth.Password;

                    if (txtPassword.DataBindings.Count == 0)
                    {
                        this.txtPassword.DataBindings.Add("Text", this.HostDetails.AuthenticationDetails as SshHostDetails.PasswordAuth, "Password", false,
                            DataSourceUpdateMode.OnValidation);
                    }
                    
                    HideRowInPanel(tableLayoutPanelMain, new List<int>() {7, 8});

                    break;
                case SshHostDetails.PrivateKeyFileAuth privateKeyFileAuth:
                    comboAuthMethod.SelectedIndex = 1;
                    txtPassPhrase.Text = privateKeyFileAuth.PassPhrase;
                    txtPathToKeyFile.Text = privateKeyFileAuth.PathToKeyFile;

                    if (txtPassPhrase.DataBindings.Count == 0)
                    {
                        this.txtPassPhrase.DataBindings.Add("Text", this.HostDetails.AuthenticationDetails as SshHostDetails.PrivateKeyFileAuth, "PassPhrase", false,
                            DataSourceUpdateMode.OnValidation);
                    }

                    if (txtPathToKeyFile.DataBindings.Count == 0)
                    {
                        this.txtPathToKeyFile.DataBindings.Add("Text", this.HostDetails.AuthenticationDetails as SshHostDetails.PrivateKeyFileAuth, "PathToKeyFile", false,
                            DataSourceUpdateMode.OnValidation);
                    }
                    HideRowInPanel(tableLayoutPanelMain, new List<int>() { 6 });

                    break;
            }

            //HideRowInPanel(tableLayoutPanelMain, 6);
        }

        private void HideRowInPanel(TableLayoutPanel tableLayoutPanel, List<int> rowIndexes)
        {
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                if (rowIndexes.Any(x => x == i))
                {
                    tableLayoutPanel.RowStyles[i].SizeType = SizeType.Absolute;
                    tableLayoutPanel.RowStyles[i].Height = 0;
                    foreach (Control control in tableLayoutPanel.Controls)
                    {
                        if (rowIndexes.Any(x => x == tableLayoutPanel.GetRow(control)))
                        {
                            control.Hide();
                        }
                        else
                        {
                            control.Show();
                        }
                    }
                }
                else
                {
                    tableLayoutPanel.RowStyles[i].SizeType = SizeType.Percent;
                    tableLayoutPanel.RowStyles[i].Height = 50;
                }
            }
        }

        private void lnkTogglePasswordField_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostEditorDialog));

            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar = '\0';
                this.lnkTogglePasswordField.Image = ((System.Drawing.Image)(resources.GetObject("icon-closed-eye")));

            }
            else
            {
                txtPassword.PasswordChar = '●';
                this.lnkTogglePasswordField.Image = ((System.Drawing.Image)(resources.GetObject("icon-opened-eye")));

            }
        }

        private void lnkTogglePassPhrase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostEditorDialog));

            if (txtPassPhrase.PasswordChar == '●')
            {
                txtPassPhrase.PasswordChar = '\0';
                this.lnkTogglePasswordField.Image = ((System.Drawing.Image)(resources.GetObject("icon-closed-eye")));

            }
            else
            {
                txtPassPhrase.PasswordChar = '●';
                this.lnkTogglePasswordField.Image = ((System.Drawing.Image)(resources.GetObject("icon-opened-eye")));
            }
        }

        private void btnBrowseKeyPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileName != null && openFileDialog.FileName.Length > 0)
                    {
                        txtPathToKeyFile.Text = openFileDialog.FileName;
                        (this.HostDetails.AuthenticationDetails as SshHostDetails.PrivateKeyFileAuth).PathToKeyFile = openFileDialog.FileName;
                    }

                }
            }
        }

        private void comboAuthMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAuthMethod.SelectedIndex == 0)
            {
                //pass auth
                this.HostDetails.AuthenticationDetails = new SshHostDetails.PasswordAuth(this.HostDetails.AuthenticationDetails.Username, string.Empty);
            }
            else
            {
                //key file auth
                this.HostDetails.AuthenticationDetails =
                    new SshHostDetails.PrivateKeyFileAuth(this.HostDetails.AuthenticationDetails.Username, string.Empty, string.Empty);
            }

            BindAuth();
        }
    }
}
