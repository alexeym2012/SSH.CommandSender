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
using Renci.SshNet.Async;
using SSH.CommandSender.Dialogs;
using SSH.CommandSender.Domain;

namespace SSH.CommandSender
{
    public partial class SSHCommandSender : Form
    {
        private List<SshHostDetails> _allHosts = new List<SshHostDetails>();
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
            var serversFromJsonFile = this.ReturnObjectFromFileDialog<SshHostDetails>();
            if (serversFromJsonFile != null && serversFromJsonFile.Count > 0)
            {
                this._allHosts.AddRange(serversFromJsonFile);

                BindHostsCheckbox(false);
            }
        }

        private void btnExportServers_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json files|*.json|All files|*.*";
            saveFileDialog.Title = "Save Servers To File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(this._allHosts, Formatting.Indented));
            }
        }

        private void btnAddNewServer_Click(object sender, EventArgs e)
        {
            var hostEditorDialog = new HostEditorDialog("Add New Host", new SshHostDetails());
            var dialogResult = hostEditorDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var newHost = hostEditorDialog.HostDetails;
                if (string.IsNullOrWhiteSpace(newHost.Name) == false &&
                    string.IsNullOrWhiteSpace(newHost.Host) == false &&
                    string.IsNullOrWhiteSpace(newHost.Username) == false &&
                    string.IsNullOrWhiteSpace(newHost.Password) == false && newHost.Port > 0)
                {
                    this._allHosts.Add(newHost);

                    BindHostsCheckbox(false);
                }
                else
                {
                    MessageBox.Show(this, "Failed to add a host. Please fill all fields!", "Failed!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnImportCommand_Click(object sender, EventArgs e)
        {
            var commandsFromJsonFile = this.ReturnObjectFromFileDialog<SshCommandDetails>();
            if (commandsFromJsonFile != null && commandsFromJsonFile.Count > 0)
            {
                this._allCommands.AddRange(commandsFromJsonFile);

                BindCommandsCheckbox(false);
            }
        }

        private void btnExportCommand_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json files|*.json|All files|*.*";
            saveFileDialog.Title = "Save Commands To File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(this._allCommands, Formatting.Indented));
            }

        }

        private void btnAddNewCommand_Click(object sender, EventArgs e)
        {
            var commandEditorDialog = new CommandEditorDialog("Add New Command", new SshCommandDetails());
            var dialogResult = commandEditorDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var newCommand = commandEditorDialog.CommandDetails;
                if (string.IsNullOrWhiteSpace(newCommand.Command) == false &&
                    string.IsNullOrWhiteSpace(newCommand.Description) == false)
                {
                    this._allCommands.Add(newCommand);

                    BindCommandsCheckbox(false);
                }
                else
                {
                    MessageBox.Show(this, "Failed to add a command. Please fill all fields!", "Failed!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }




        private void menuRemoveSelectedServers_Click(object sender, EventArgs e)
        {
            foreach (var checkedItem in this.chkListHosts.CheckedItems.Cast<SshHostDetails>().ToList())
            {
                this._allHosts.Remove(checkedItem);
            }

            BindHostsCheckbox(false);
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
            var selectedServers = new List<SshHostDetails>();

            foreach (var checkedCommand in this.chkListCommands.CheckedItems)
            {
                var selectedCommand = (checkedCommand as SshCommandDetails);
                selectedCommands.Add(this._allCommands.FindLast(c => c.Command == selectedCommand.Command));
            }

            foreach (var checkedHost in this.chkListHosts.CheckedItems)
            {
                var selectedHost = (checkedHost as SshHostDetails);
                selectedServers.Add(this._allHosts.FindLast(c => c.Host == selectedHost.Host && c.Port == selectedHost.Port));
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
                    try
                    {
                        using (var client = new SshClient(server.Host, server.Port, server.Username, server.Password))
                        {
                            WriteLogThreadSafety(page, $"Trying to connect to {server.Host}:{server.Port}");


                            if (_taskRunning)
                            {
                                client.Connect();
                            }

                            this.Invoke(new Action(() => { this.progressBarRunningTasks.PerformStep(); }));
                            WriteLogThreadSafety(page, "Connected");
                          
                            foreach (var command in selectedCommands)
                            {
                                foreach (var commandRow in command.Command.Split('\n'))
                                {
                                    if (string.IsNullOrWhiteSpace(commandRow) == false)
                                    {
                                        if (_taskRunning)
                                        {
                                            WriteLogThreadSafety(page, "Running command: " + commandRow);
                                            client.CreateCommand(commandRow).ExecuteAsync((progress) =>
                                            {
                                                WriteLogThreadSafety(page,
                                                    $"{progress.Line}");
                                            }, CancellationToken.None).Wait();
                                            
                                            //var runCommand = client.RunCommand(commandRow);
                                           
                                        }
                                    }
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
                    }
                    catch (Exception exception)
                    {
                        WriteLogThreadSafety(page, "Exception while running commands: \n" + exception.Message);

                        page.Invoke(new Action(() => { page.Text = server.Name + "-ERROR!"; }));

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

            var checkedItemIndecencies = new HashSet<int>();

            for (var i = 0; i < this.chkListCommands.Items.Count; i++)
            {
                if (this.chkListCommands.GetItemChecked(i))
                {
                    checkedItemIndecencies.Add(i);
                }
            }

            this.chkListCommands.DataSource = null;
            this.chkListCommands.DisplayMember = "Description";
            this.chkListCommands.ValueMember = "Command";
            this.chkListCommands.DataSource = this._allCommands;
            this.chkListCommands.DisplayMember = "Description";
            this.chkListCommands.ValueMember = "Command";


            for (var i = 0; i < this.chkListCommands.Items.Count; i++)
            {
                if (forceSelectAll || checkedItemIndecencies.Contains(i))
                {
                    this.chkListCommands.SetItemChecked(i, true);
                }
            }

        }

        private void BindHostsCheckbox(bool forceSelectAll = true)
        {
            var checkedItemIndecencies = new HashSet<int>();

            for (var i = 0; i < this.chkListHosts.Items.Count; i++)
            {
                if (this.chkListHosts.GetItemChecked(i))
                {
                    checkedItemIndecencies.Add(i);
                }
            }

            this.chkListHosts.DataSource = null;
            this.chkListHosts.DisplayMember = "Name";
            this.chkListHosts.ValueMember = "Host";
            this.chkListHosts.DataSource = this._allHosts;

            this.chkListHosts.DisplayMember = "Name";
            this.chkListHosts.ValueMember = "Host";

            for (var i = 0; i < this.chkListHosts.Items.Count; i++)
            {
                if (forceSelectAll || checkedItemIndecencies.Contains(i))
                {
                    this.chkListHosts.SetItemChecked(i, true);
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
                sb.Append(string.Join("\n", listBox.Items.Cast<string>()));

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
            return chkListHosts.CheckedItems.Count > 0 && chkListCommands.CheckedItems.Count > 0;
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
