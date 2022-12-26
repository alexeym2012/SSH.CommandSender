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
            this.txtUsername.Text = this.HostDetails.Username;
            this.txtPassword.Text = this.HostDetails.Password;

            this.txtName.DataBindings.Add("Text", this.HostDetails, "Name", false,
                DataSourceUpdateMode.OnValidation);

            this.txtHost.DataBindings.Add("Text", this.HostDetails, "Host", false,
                DataSourceUpdateMode.OnValidation);

            this.numericPort.DataBindings.Add("Value", this.HostDetails, "Port", false,
                DataSourceUpdateMode.OnValidation);
            this.txtUsername.DataBindings.Add("Text", this.HostDetails, "Username", false,
                DataSourceUpdateMode.OnValidation);
            this.txtPassword.DataBindings.Add("Text", this.HostDetails, "Password", false,
                DataSourceUpdateMode.OnValidation);
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanelButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void lblHost_Click(object sender, EventArgs e)
        {

        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPort_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericPort_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
