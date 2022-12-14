namespace SSH.CommandSender.Domain
{
    public class SshCommandDetails
    {
        public string Description { get; set; }
        public string Command { get; set; }

        public SshCommandDetails(string description, string command)
        {
            Description = description;
            Command = command;
        }
    }
}