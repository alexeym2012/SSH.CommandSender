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
    public partial class CommandEditorDialog : Form
    {
        public SshCommandDetails CommandDetails { get; }

        public CommandEditorDialog(string windowTitle, SshCommandDetails commandDetails)
        {
            CommandDetails = commandDetails;
            InitializeComponent();

            this.Text = windowTitle;
            this.txtCommand.Text = commandDetails.Command;
            this.txtDescription.Text = commandDetails.Description;
        }

        private void CommandEditorDialog_Load(object sender, EventArgs e)
        {
            BindControls();
        }

        private void BindControls()
        {
            this.txtCommand.DataBindings.Add("Text", this.CommandDetails, "Command", false,
                DataSourceUpdateMode.OnValidation);
            this.txtDescription.DataBindings.Add("Text", this.CommandDetails, "Description", false,
                DataSourceUpdateMode.OnValidation);
        }
    }
}
