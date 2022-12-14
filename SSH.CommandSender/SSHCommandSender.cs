using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json.Linq;
using SSH.CommandSender.Domain;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;

namespace SSH.CommandSender
{
    public partial class SSHCommandSender : Form
    {
        private List<SshServerDetails> _allServers = new List<SshServerDetails>();
        private List<SshCommandDetails> _allCommands = new List<SshCommandDetails>();


        private bool _taskRunning = false;



        public SSHCommandSender()
        {
            InitializeComponent();

        }


        private void btnRunCommands_Click(object sender, EventArgs e)
        {
            if (ValidateServersAndCommandsSelected())
            {
                if (_taskRunning)
                {
                    //cancel tasks
                    _taskRunning = false;

                }
                else
                {
                    var dialogResult = MessageBox.Show(this, "Are you sure you want to run selected tasks?", "Attention!", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        RunTasks();
                    }
                }

                SetUIAccordingToProgrammState();
            }
            else
            {
                MessageBox.Show(this, "Please select servers and commands!", "Cancelled!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }



        private void btnImportServers_Click(object sender, EventArgs e)
        {
            var serversFromJsonFile = this.ReturnObjectFromFileDialog<SshServerDetails>();
            if (serversFromJsonFile != null && serversFromJsonFile.Count > 0)
            {
                this._allServers.AddRange(serversFromJsonFile);

                BindServersCheckbox();
            }
        }

        private void btnExportServers_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewServer_Click(object sender, EventArgs e)
        {

        }

        private void btnImportCommand_Click(object sender, EventArgs e)
        {
            var commandsFromJsonFile = this.ReturnObjectFromFileDialog<SshCommandDetails>();
            if (commandsFromJsonFile != null && commandsFromJsonFile.Count > 0)
            {
                this._allCommands.AddRange(commandsFromJsonFile);

                BindCommandsCheckbox();
            }
        }

        private void btnExportCommand_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewCommand_Click(object sender, EventArgs e)
        {

        }




        private void menuRemoveSelectedServers_Click(object sender, EventArgs e)
        {
            foreach (var checkedItem in this.chkListServers.CheckedItems.Cast<SshServerDetails>().ToList())
            {
                this._allServers.Remove(checkedItem);
            }

            BindServersCheckbox(false);
        }

        private void menuRemoveSelectedCommands_Click(object sender, EventArgs e)
        {
            foreach (var checkedItem in this.chkListCommands.CheckedItems.Cast<SshCommandDetails>().ToList())
            {
                this._allCommands.Remove(checkedItem);
            }

            BindCommandsCheckbox(false);
        }

        private void menuSaveOutputsToFile_Click(object sender, EventArgs e)
        {
            var outputLog = GenerateOutputsLog();

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files|*.txt|All files|*.*";
            saveFileDialog.Title = "Save Outputs To File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, outputLog);
            }
        }

        private void RunTasks()
        {
            _taskRunning = true;

            var runTasks = new List<Task>();
            this.tabSshOutputs.TabPages.Clear();



            var selectedCommands = new List<SshCommandDetails>();
            var selectedServers = new List<SshServerDetails>();

            foreach (var checkedCommand in this.chkListCommands.CheckedItems)
            {
                var selectedCommand = (checkedCommand as SshCommandDetails);
                selectedCommands.AddRange(this._allCommands.FindAll(c => c.Command == selectedCommand.Command));
            }

            foreach (var checkedServer in this.chkListServers.CheckedItems)
            {
                var selectedServer = (checkedServer as SshServerDetails);
                selectedServers.AddRange(this._allServers.FindAll(c => c.Ip == selectedServer.Ip));
            }


            this.progressBarRunningTasks.Maximum = (2 + selectedCommands.Count) * selectedServers.Count;
            this.progressBarRunningTasks.Value = 1;


            foreach (var server in selectedServers)
            {
                var page = CreateEmptyTabWithListView(server.Name);
                this.tabSshOutputs.TabPages.Add(page);

                runTasks.Add(Task.Run(() =>
                {

                    page.Invoke(new Action(() =>
                    {
                        page.Text = server.Name + "-RUNNING!";
                    }));
                    using (var client = new SshClient(server.Ip, server.Username, server.Password))
                    {
                        WriteLogThreadSafety(page, "Trying to connect");

                        try
                        {
                            if (_taskRunning)
                            {
                                client.Connect();
                            }

                            this.Invoke(new Action(() => { this.progressBarRunningTasks.PerformStep(); }));
                            WriteLogThreadSafety(page, "Connected");

                            foreach (var command in selectedCommands)
                            {
                                WriteLogThreadSafety(page, "Running command: " + command.Description);

                                if (_taskRunning)
                                {
                                    var runCommand = client.RunCommand(command.Command);
                                    WriteLogThreadSafety(page,
                                        $"Command: {command.Command}, Result: {runCommand.Result}");
                                }

                                this.Invoke(new Action(() => { this.progressBarRunningTasks.PerformStep(); }));

                            }

                            client.Disconnect();

                            WriteLogThreadSafety(page, "Disconnected");

                      

                            if (_taskRunning == false)
                            {
                                WriteLogThreadSafety(page, "Cancel task requested by the user!");

                            }

                            this.Invoke(new Action(() => { this.progressBarRunningTasks.PerformStep(); }));

                            page.Invoke(new Action(() => { page.Text = server.Name + "-DONE!"; }));
                        }
                        catch (Exception exception)
                        {
                            WriteLogThreadSafety(page, "Exception while running commands: \n" + exception.Message);

                            page.Invoke(new Action(() => { page.Text = server.Name + "-ERROR!"; }));

                        }

                    }
                }));
            }
            //waiting task
            Task.Run(() =>
            {
                Task.WaitAll(runTasks.ToArray());

                this.Invoke(new Action(() =>
                {

                    if (_taskRunning)
                    {
                        MessageBox.Show(this, "Finished running tasks!", "Success!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, "Cancelled running tasks!", "Cancelled!", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }));



                _taskRunning = false;
                this.Invoke(new Action(SetUIAccordingToProgrammState));


            });
        }

        private void BindCommandsCheckbox(bool forceSelectAll = true)
        {
            this.chkListCommands.DataSource = null;
            this.chkListCommands.DisplayMember = "Description";
            this.chkListCommands.ValueMember = "Command";
            this.chkListCommands.DataSource = this._allCommands;
            this.chkListCommands.DisplayMember = "Description";
            this.chkListCommands.ValueMember = "Command";

            if (forceSelectAll)
            {
                for (var i = 0; i < this.chkListCommands.Items.Count; i++)
                {
                    this.chkListCommands.SetItemChecked(i, true);
                }
            }
        }

        private void BindServersCheckbox(bool forceSelectAll = true)
        {
            this.chkListServers.DataSource = null;
            this.chkListServers.DisplayMember = "Name";
            this.chkListServers.ValueMember = "Ip";
            this.chkListServers.DataSource = this._allServers;

            this.chkListServers.DisplayMember = "Name";
            this.chkListServers.ValueMember = "Ip";
            if (forceSelectAll)
            {
                for (var i = 0; i < this.chkListServers.Items.Count; i++)
                {
                    this.chkListServers.SetItemChecked(i, true);
                }
            }

        }

        private string GenerateOutputsLog()
        {
            var sb = new StringBuilder();

            foreach (TabPage tabPage in this.tabSshOutputs.TabPages)
            {
                sb.Append($"\n===================================================START {tabPage.Text}===================================================================\n");
                var listBox = (tabPage.Controls[0] as ListBox);
                sb.Append(string.Join("\n",listBox.Items.Cast<string>()));

                sb.Append($"\n===================================================END {tabPage.Text}=====================================================================\n");
            }

            return sb.ToString();
        }

        private List<T> ReturnObjectFromFileDialog<T>()
        {
            var result = new List<T>();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileNames != null && openFileDialog.FileNames.Length > 0)
                    {
                        foreach (var fileName in openFileDialog.FileNames)
                        {
                            var json = File.ReadAllText(fileName);
                            result.AddRange(JsonConvert.DeserializeObject<List<T>>(json));
                        }
                    }
                  
                }
            }


            return result;
        }

        private TabPage CreateEmptyTabWithListView(string tabName)
        {
            var result = new TabPage(tabName);
            result.BorderStyle = BorderStyle.Fixed3D;
            var listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;
            result.Controls.Add(listBox);

            return result;
        }

        private void SetUIAccordingToProgrammState()
        {
            btnAddNewServer.Enabled = !this._taskRunning;

            if (this._taskRunning)
            {
                btnRunCommands.Text = "Cancel Tasks!";
                btnRunCommands.BackColor = Color.DarkSalmon;
            }
            else
            {
                btnRunCommands.Text = "RUN";
                btnRunCommands.BackColor = Color.PaleGreen;
            }
            
        }

        private string FormatTime(DateTime time)
        {
            return time.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private bool ValidateServersAndCommandsSelected()
        {
            return chkListServers.CheckedItems.Count > 0 && chkListCommands.CheckedItems.Count > 0;
        }

        private void WriteLogThreadSafety(TabPage tabPage, string text)
        {
            foreach (var textEntry in text.Split('\n'))
            {

                tabPage.Invoke(new Action(() =>
                {
                    (tabPage.Controls[0] as System.Windows.Forms.ListBox).Items.Add($"[{FormatTime(DateTime.UtcNow)}] {textEntry}");
                }));
            }

        }

        
    }
}
