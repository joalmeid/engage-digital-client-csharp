using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Dimelo.Sdk.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreateAction
    {
        [EnumMember(Value = "messages.create")]
        Message,
        [EnumMember(Value = "threads.create")]
        Thread,
        [EnumMember(Value = "users.create")]
        User,
    }
}
