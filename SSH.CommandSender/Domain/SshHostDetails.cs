using System;
using Newtonsoft.Json;
using Renci.SshNet;

namespace SSH.CommandSender.Domain
{
    public class SshHostDetails : ICloneable
    {
        public abstract class Auth
        {
            public string Username { get; set; }

            public Auth(string username)
            {
                Username = username;
            }

            public abstract SshClient CreateSshClient(string host, ushort port);

            public abstract bool Validate();
        }

        public class PrivateKeyFileAuth : Auth
        {
            public string PathToKeyFile { get; set; }
            public string PassPhrase { get; set; }

            public PrivateKeyFileAuth(string username, string pathToKeyFile, string passPhrase) : base(username)
            {
                PathToKeyFile = pathToKeyFile;
                PassPhrase = passPhrase;
            }

            public override SshClient CreateSshClient(string host, ushort port)
            {
                return new SshClient(host, port, Username, new PrivateKeyFile(this.PathToKeyFile, this.PassPhrase));

            }

            public override bool Validate()
            {
                return string.IsNullOrWhiteSpace(this.Username) == false &&
                       string.IsNullOrWhiteSpace(this.PathToKeyFile) == false;
            }
        }

        public class PasswordAuth : Auth
        {
            public string Password { get; set; }

            public PasswordAuth(string username, string password) : base(username)
            {
                Password = password;
            }

            public override SshClient CreateSshClient(string host, ushort port)
            {
                return new SshClient(host, port, Username, Password);
            }

            public override bool Validate()
            {
                return string.IsNullOrWhiteSpace(this.Username) == false;
            }
        }
        public string Name { get;  set; }
        public string Host { get; set; }
        public ushort Port { get; set; }

        [JsonConverter(typeof(AuthJsonConverter))]
        public Auth AuthenticationDetails { get; set; }

        public SshHostDetails(string name = "", string host = "", ushort port = 22, Auth authenticationDetails = null)
        {
            Name = name;
            Host = host;
            Port = port;

            if (authenticationDetails == null)
            {
                AuthenticationDetails = new PasswordAuth(string.Empty, string.Empty);
            }
            else
            {
                AuthenticationDetails = authenticationDetails;
            }
        }

        public SshClient CreateSshClient()
        {
            return AuthenticationDetails.CreateSshClient(Host,Port);

        }

        public object Clone()
        {
            return new SshHostDetails(this.Name, this.Host, this.Port, AuthenticationDetails);
        }
    }
}