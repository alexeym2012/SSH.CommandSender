using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSH.CommandSender.Domain;

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
    }
}
