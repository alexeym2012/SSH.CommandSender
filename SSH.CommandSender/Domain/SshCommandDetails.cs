using System;
using System.Drawing;

namespace SSH.CommandSender.Domain
{
    public class SshCommandDetails: ICloneable
    {
        public string Description { get; set; }
        public string Command { get; set; }

        public SshCommandDetails(string description = "", string command = "")
        {
            Description = description;
            Command = command;
        }

        public object Clone()
        {
            return new SshCommandDetails(this.Description, this.Command);
        }
    }
}