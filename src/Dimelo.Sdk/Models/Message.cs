using Newtonsoft.Json;
using System.ComponentModel;

namespace Dimelo.Sdk.Models
{
    public class Message : Base
    {
        /// <summary>
        /// Possible actions for this content.
        /// </summary>
        [JsonProperty("actions")]
        public Action[] Actions { get; set; }

        /// <summary>
        /// Array Required unless body is present.An array of objects containing the url or a base64 
        /// content and the associated filename for each attachment
        /// </summary>
        /// TODO: check for conditional requirement
        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }

        /// <summary>
        /// Required. An User object.
        /// </summary>
        [JsonRequired]
        [JsonProperty("author")]
        public User Author { get; set; }

        /// <summary>
        /// Required. unless attachments are present.Maximum size is 20k characters.
        /// </summary>
        [JsonRequired]
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// Example: `["TV", "Internet"]`
        /// </summary>
        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        /// <summary>
        /// A full URI where anyone can see the specific comment
        /// </summary>
        [JsonProperty("display_url")]
        public string DisplayUrl { get; set; }

        /// <summary>
        /// html or text. Default on html if not specified.
        /// </summary>
        //[DefaultValue(Formatting.Html)]
        //[JsonProperty("format")]
        //public Formatting Format { get; set; }

        /// <summary>
        /// String It has to be a valid content ID if present.
        /// </summary>
        [JsonProperty("in_reply_to_id")]
        public string InReplyToId { get; set; }

        /// <summary>
        /// Example: `1.2.3.4`
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// Required. If the option `messages.unthreaded` is set this field will be ignored
        /// </summary>
        /// TODO: check for conditional requirement
        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }
    }
}
