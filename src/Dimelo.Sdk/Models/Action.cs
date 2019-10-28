using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Dimelo.Sdk.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Action
    {
        [EnumMember(Value = "create")]
        Create,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "list")]
        List,
        [EnumMember(Value = "show")]
        Show,
        [EnumMember(Value = "publish")]
        Publish,
        [EnumMember(Value = "unpublish")]
        Unpublish,
        [EnumMember(Value = "reply")]
        Reply,
    }
}
