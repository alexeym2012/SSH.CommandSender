using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SSH.CommandSender.Domain
{
    public static class SshCommandExtensions
    {
        public static async Task ExecuteAsync(
            this SshCommand sshCommand,
            Action<SshScriptOutputLine> progress,
            CancellationToken cancellationToken)
        {
            var asyncResult = sshCommand.BeginExecute();
            var stdoutReader = new StreamReader(sshCommand.OutputStream);
            var stderrReader = new StreamReader(sshCommand.ExtendedOutputStream);

            var stderrTask = CheckOutputAndReportProgressAsync(sshCommand, asyncResult, stderrReader, progress, true, cancellationToken);
            var stdoutTask = CheckOutputAndReportProgressAsync(sshCommand, asyncResult, stdoutReader, progress, false, cancellationToken);

            await Task.WhenAll(stderrTask, stdoutTask);

            sshCommand.EndExecute(asyncResult);
        }

        private static async Task CheckOutputAndReportProgressAsync(
            SshCommand sshCommand,
            IAsyncResult asyncResult,
            StreamReader streamReader,
            Action<SshScriptOutputLine> progress,
            bool isError,
            CancellationToken cancellationToken)
        {
            while (!asyncResult.IsCompleted || !streamReader.EndOfStream)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    sshCommand.CancelAsync();
                }

                cancellationToken.ThrowIfCancellationRequested();

                var stderrLine = await streamReader.ReadLineAsync();

                if (!string.IsNullOrEmpty(stderrLine))
                {
                    progress(new SshScriptOutputLine(
                        line: stderrLine,
                        isErrorLine: isError));
                }

                // wait 10 ms
                await Task.Delay(10, cancellationToken);
            }
        }
    }

    public class SshScriptOutputLine
    {
        public SshScriptOutputLine(string line, bool isErrorLine)
        {
            Line = line;
            IsErrorLine = isErrorLine;
        }

        public string Line { get; private set; }

        public bool IsErrorLine { get; private set; }
    }
}
