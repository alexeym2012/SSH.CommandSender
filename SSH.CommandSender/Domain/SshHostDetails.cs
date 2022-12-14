using System;

namespace SSH.CommandSender.Domain
{
    public class SshHostDetails : ICloneable
    {
        public string Name { get;  set; }
        public string Host { get; set; }
        public ushort Port { get; }
        public string Username { get; set; }
        public string Password { get; set; }

        public SshHostDetails(string name = "", string host = "",string username = "", string password = "", ushort port = 22)
        {
            Name = name;
            Host = host;
            Port = port;
            Username = username;
            Password = password;
        }


        public object Clone()
        {
            return new SshHostDetails(this.Name, this.Host, this.Username, this.Password, this.Port);
        }
    }
}