using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json.Linq;
using SSH.CommandSender.Domain;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;
using SSH.CommandSender.Dialogs;
using SSH.CommandSender.Domain;
using System.Reflection;

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

            this.Text = this.Text + $" {GetAssemblyVersion()}";
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
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(this._allHosts, Formatting.Indented));
                }
            }

           
        }

        private void btnAddNewHost_Click(object sender, EventArgs e)
        {
            ShowHostEditorDialog("Add New Host", new SshHostDetails(), true);
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
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json files|*.json|All files|*.*";
            saveFileDialog.Title = "Save Commands To File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(this._allCommands, Formatting.Indented));
                }
            }
        }

        private void btnAddNewCommand_Click(object sender, EventArgs e)
        {
            ShowCommandEditorDialog("Add New Command", new SshCommandDetails(), true);
        }




        private void menuRemoveAllHosts_Click(object sender, EventArgs e)
        {
            foreach (var checkedItem in this.chkListHosts.Items.Cast<SshHostDetails>().ToList())
            {
                this._allHosts.Remove(checkedItem);
            }

            BindHostsCheckbox(false);
        }

        private void menuRemoveAllCommands_Click(object sender, EventArgs e)
        {
            foreach (var checkedItem in this.chkListCommands.Items.Cast<SshCommandDetails>().ToList())
            {
                this._allCommands.Remove(checkedItem);
            }

            BindCommandsCheckbox();
        }

        private void menuSaveOutputsToFile_Click(object sender, EventArgs e)
        {
            var outputLog = GenerateOutputsLog();

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files|*.txt|All files|*.*";
            saveFileDialog.Title = "Save Outputs To File";
            saveFileDialog.FileName = $"{DateTime.UtcNow.ToString("dd-MM-yyyy_HH:mm:ss")}_log.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    File.WriteAllText(saveFileDialog.FileName, outputLog);
                }
            }

           
        }
        private void menuEditCommand_Click(object sender, EventArgs e)
        {
            var selectedCommand = chkListCommands.SelectedItem as SshCommandDetails;
            if (selectedCommand != null)
            {
                ShowCommandEditorDialog($"Edit {selectedCommand.Command}", selectedCommand, false);
            }
        }

        private void menuItemRemoveSelectedCommand_Click(object sender, EventArgs e)
        {
            var selectedCommand = chkListCommands.SelectedItem as SshCommandDetails;
            if (selectedCommand != null)
            {
                _allCommands.Remove(selectedCommand);
                BindCommandsCheckbox();
            }
        }

        private void menuItemEditHost_Click(object sender, EventArgs e)
        {
            var selectedHost = chkListHosts.SelectedItem as SshHostDetails;
            if (selectedHost != null)
            {
                ShowHostEditorDialog($"Edit {selectedHost.Name}", selectedHost, false);
            }
        }

        private void menuItemRemoveHost_Click(object sender, EventArgs e)
        {
            var selectedHost = chkListHosts.SelectedItem as SshHostDetails;
            if (selectedHost != null)
            {
                _allHosts.Remove(selectedHost);
                BindHostsCheckbox(false);
            }
        }

        private void checkListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var relevantControl = sender as CheckedListBox;
                var index = relevantControl.IndexFromPoint(e.X, e.Y);
                if (index != ListBox.NoMatches)
                {
                    relevantControl.SelectedIndex = index;
                }
            }
        }
        private void menuSelectAllCommands_Click(object sender, EventArgs e)
        {
            BindCommandsCheckbox(true);
        }

        private void menuUnselectAllCommands_Click(object sender, EventArgs e)
        {
            BindCommandsCheckbox(false);

        }

        private void menuUnselectAllHosts_Click(object sender, EventArgs e)
        {
            BindHostsCheckbox(false);
        }

        private void menuSelectAllHosts_Click(object sender, EventArgs e)
        {
            BindHostsCheckbox(true);
        }

        private void menuRemoveUncheckedHosts_Click(object sender, EventArgs e)
        {
            var checkedHosts = new HashSet<SshHostDetails>(chkListHosts.CheckedItems.OfType<SshHostDetails>().ToList());
            _allHosts.RemoveAll(h => checkedHosts.Contains(h) == false);
            BindHostsCheckbox(true);
        }

        private void menuRemoveUncheckedCommands_Click(object sender, EventArgs e)
        {
            var checkedCommands = new HashSet<SshCommandDetails>(chkListCommands.CheckedItems.OfType<SshCommandDetails>().ToList());
            _allCommands.RemoveAll(c => checkedCommands.Contains(c) == false);
            BindCommandsCheckbox(true);
        }

        private void menuRemoveCheckedCommands_Click(object sender, EventArgs e)
        {
            var checkedCommands = new HashSet<SshCommandDetails>(chkListCommands.CheckedItems.OfType<SshCommandDetails>().ToList());
            _allCommands.RemoveAll(c => checkedCommands.Contains(c));
            BindCommandsCheckbox(false);
        }

        private void menuRemoveCheckedHosts_Click(object sender, EventArgs e)
        {
            var checkedHosts = new HashSet<SshHostDetails>(chkListHosts.CheckedItems.OfType<SshHostDetails>().ToList());
            _allHosts.RemoveAll(h => checkedHosts.Contains(h) == true);
            BindHostsCheckbox(false);
        }
        private void menuMoveCommandDown_Click(object sender, EventArgs e)
        {
            var selectedCommand = chkListCommands.SelectedItem as SshCommandDetails;
            var currentCommandIndex = _allCommands.IndexOf(selectedCommand);
            if (currentCommandIndex < (_allCommands.Count - 1))
            {
                var newIndex = ++currentCommandIndex;
                _allCommands.Remove(selectedCommand);
                _allCommands.Insert( newIndex, selectedCommand);
                chkListCommands.SelectedIndex = newIndex;

                BindCommandsCheckbox();
            }
        }

        private void menuMoveCommandUp_Click(object sender, EventArgs e)
        {
            var selectedCommand = chkListCommands.SelectedItem as SshCommandDetails;
            var currentCommandIndex = _allCommands.IndexOf(selectedCommand);
            if (currentCommandIndex > 0)
            {
                var newIndex = --currentCommandIndex;
                _allCommands.Remove(selectedCommand);
                _allCommands.Insert(newIndex, selectedCommand);
                chkListCommands.SelectedIndex = newIndex;

                BindCommandsCheckbox();
            }
        }
        private void menuMoveHostDown_Click(object sender, EventArgs e)
        {
            var selectedHost = chkListHosts.SelectedItem as SshHostDetails;
            var currentHostIndex = _allHosts.IndexOf(selectedHost);
            if (currentHostIndex < (_allHosts.Count - 1))
            {
                var newIndex = ++currentHostIndex;
                _allHosts.Remove(selectedHost);
                _allHosts.Insert(newIndex, selectedHost);
                chkListHosts.SelectedIndex = newIndex;

                BindHostsCheckbox();
            }
        }

        private void menuMoveHostUp_Click(object sender, EventArgs e)
        {
            var selectedHost = chkListHosts.SelectedItem as SshHostDetails;
            var currentHostIndex = _allHosts.IndexOf(selectedHost);
            if (currentHostIndex > 0)
            {
                var newIndex = --currentHostIndex;
                _allHosts.Remove(selectedHost);
                _allHosts.Insert(newIndex, selectedHost);
                chkListHosts.SelectedIndex = newIndex;

                BindHostsCheckbox();
            }
        }

        private void ShowHostEditorDialog(string windowTitle, SshHostDetails host, bool appedToList)
        {
            var hostEditorDialog = new HostEditorDialog(windowTitle, host);
            var dialogResult = hostEditorDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var relevantHost = hostEditorDialog.HostDetails;
                if (string.IsNullOrWhiteSpace(relevantHost.Name) == false &&
                    string.IsNullOrWhiteSpace(relevantHost.Host) == false &&
                    string.IsNullOrWhiteSpace(relevantHost.Username) == false  && relevantHost.Port > 0)
                {
                    if (appedToList)
                    {
                        this._allHosts.Add(relevantHost);
                    }
                    

                    BindHostsCheckbox();
                }
                else
                {
                    MessageBox.Show(this, "Failed to edit the host. Please fill all fields!", "Failed!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void menuCreateCommandFromSelection_Click(object sender, EventArgs e)
        {
            var relevantRichTextBox = ctxMenuProccessOutputs.SourceControl as RichTextBox;
            var selectedText = relevantRichTextBox.SelectedText;

            ShowCommandEditorDialog("Add New Command", new SshCommandDetails(string.Empty, selectedText), true);
        }
        private void chkListHosts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BindHostsCheckbox(true);
        }

        private void chkListCommands_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BindCommandsCheckbox(true);
        }

        private void tabSshOutputs_DrawItem(object sender, DrawItemEventArgs e)
        {
            //e.DrawBackground();
            if (e.Index < tabSshOutputs.TabPages.Count)
            {
                var tabPage = tabSshOutputs.TabPages[e.Index];

                TextRenderer.DrawText(e.Graphics, tabPage.Text, e.Font, e.Bounds, tabPage.ForeColor);
            }
       
        }

        private void ShowCommandEditorDialog(string windowTitle, SshCommandDetails command, bool appedToList)
        {
            var commandEditorDialog = new CommandEditorDialog(windowTitle, command);
            var dialogResult = commandEditorDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var relevantCommand = commandEditorDialog.CommandDetails;
                if (string.IsNullOrWhiteSpace(relevantCommand.Command) == false &&
                    string.IsNullOrWhiteSpace(relevantCommand.Description) == false)
                {
                    if (appedToList)
                    {
                        this._allCommands.Add(relevantCommand);
                    }


                    BindCommandsCheckbox();
                }
                else
                {
                    MessageBox.Show(this, "Failed to edit the command. Please fill all fields!", "Failed!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void SetTabHeader(TabPage page, Color color)
        {
            page.ForeColor = color;
            //tabSshOutputs.Invalidate();
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
                                                    $"{progress.Line}", progress.IsErrorLine);
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

                        this.Invoke(new Action(() => { SetErrorTab(page, server); }));

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
                        _taskRunning = false;
                        SetUIAccordingToProgrammState();
                        MessageBox.Show(this, "Finished running tasks!", "Success!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        _taskRunning = false;
                        SetUIAccordingToProgrammState();
                        MessageBox.Show(this, "Cancelled running tasks!", "Cancelled!", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }));

            });
        }

        private void SetErrorTab(TabPage page, SshHostDetails server)
        {
            page.Text = server.Name + "-ERROR!";
            MoveTabToHead(page);

            SetTabHeader(page, Color.Red);
        }

        private void MoveTabToHead(TabPage page)
        {
            tabSshOutputs.TabPages.Remove(page);
            tabSshOutputs.TabPages.Insert(0, page);
            tabSshOutputs.SelectedTab = page;
        }

        private void BindCommandsCheckbox(bool? forceSelection = null)
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
                if (checkedItemIndecencies.Contains(i))
                {
                    this.chkListCommands.SetItemChecked(i, true);
                }

                if (forceSelection.HasValue)
                {
                    this.chkListCommands.SetItemChecked(i, forceSelection.Value);

                }
            }

        }

        private void BindHostsCheckbox(bool? forceSelection = null)
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
                if (checkedItemIndecencies.Contains(i))
                {
                    this.chkListHosts.SetItemChecked(i, true);
                }

                if (forceSelection.HasValue)
                {
                    this.chkListHosts.SetItemChecked(i, forceSelection.Value);
                }
            }
        }

        private string GenerateOutputsLog()
        {
            var sb = new StringBuilder();

            foreach (TabPage tabPage in this.tabSshOutputs.TabPages)
            {
                sb.Append($"\n===================================================START {tabPage.Text}===================================================================\n");
                var textBox = (tabPage.Controls[0] as RichTextBox);
                sb.Append(string.Join("\n", textBox.Text));

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
                            try
                            {
                                var json = File.ReadAllText(fileName);
                                result.AddRange(JsonConvert.DeserializeObject<List<T>>(json));
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(this, e.Message, $"Failed to import {fileName}", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                           
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
            var textBox = new System.Windows.Forms.RichTextBox();
            textBox.Dock = DockStyle.Fill;
            textBox.Multiline = true;
            textBox.ReadOnly = true;
            textBox.BackColor = Color.Black;
            textBox.ForeColor = Color.White;
            textBox.BorderStyle = BorderStyle.None;
            textBox.ContextMenuStrip = ctxMenuProccessOutputs;
            textBox.SelectionChanged += ((o,e) => menuCreateCommandFromSelection.Visible = menuProccessOutputsSeparator.Visible = string.IsNullOrWhiteSpace(textBox.SelectedText) == false);

            result.Controls.Add(textBox);

            return result;
        }


        private void SetUIAccordingToProgrammState()
        {
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

        private void WriteLogThreadSafety(TabPage tabPage, string text, bool errorLine = false)
        {
            foreach (var textEntry in text.Split('\n'))
            {
                tabPage.Invoke(new Action(() =>
                {
                    var outputTextBox = (tabPage.Controls[0] as System.Windows.Forms.RichTextBox);
                    if (errorLine)
                    {
                        outputTextBox.SelectionColor = Color.Red;
                        tabPage.ForeColor = Color.DarkGoldenrod;
                    }
                    outputTextBox.AppendText($"[{FormatTime(DateTime.UtcNow)} UTC] {textEntry}");
                    outputTextBox.AppendText(Environment.NewLine);

                    outputTextBox.SelectionColor = Color.White;
                }));
            }

        }

        private string GetAssemblyVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }

      
    }

}
