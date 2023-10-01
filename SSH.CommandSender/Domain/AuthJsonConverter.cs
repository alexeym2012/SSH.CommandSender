using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SSH.CommandSender.Domain
{
    public class AuthJsonConverter : JsonConverter<SshHostDetails.Auth>
    {
        public override void WriteJson(JsonWriter writer, SshHostDetails.Auth value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override SshHostDetails.Auth ReadJson(JsonReader reader, Type objectType, SshHostDetails.Auth existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            if (jObject["PathToKeyFile"] == null)
            {
                return new SshHostDetails.PasswordAuth(jObject["Username"].Value<string>(),
                    jObject["Password"].Value<string>());
            }
            else
            {
                return new SshHostDetails.PrivateKeyFileAuth(jObject["Username"].Value<string>(),
                    jObject["PathToKeyFile"].Value<string>(), jObject["PassPhrase"].Value<string>());
                
            }

        }
    }
}