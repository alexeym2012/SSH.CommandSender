namespace SSH.CommandSender.Domain
{
    public class SshServerDetails
    {
        public string Name { get;  set; }
        public string Ip { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public SshServerDetails(string name, string ip, string username, string password)
        {
            Name = name;
            Ip = ip;
            Username = username;
            Password = password;
        }
    }
}