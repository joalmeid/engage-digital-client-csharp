using Newtonsoft.Json;
using System;


namespace Dimelo.Sdk.Models
{
    class MessageResponse : ResponseBase
    {
        /// <summary>
        /// Array Required unless body is present.An array of objects containing the url or a base64 
        /// content and the associated filename for each attachment
        /// </summary>
        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }

        /// <summary>
        /// String It has to be a valid content ID if present.
        /// </summary>
        [JsonProperty("in_reply_to_id")]
        public string InReplyToId { get; set; }

        /// <summary>
        /// Required. If the option `messages.unthreaded` is set this field will be ignored
        /// </summary>
        /// TODO: check for conditional requirement
        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }  
    }
}
