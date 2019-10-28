using Newtonsoft.Json;
using System.ComponentModel;

namespace Dimelo.Sdk.Models
{
    public class Thread : Base
    {
        /// <summary>
        /// Possible actions for this content.
        /// </summary>
        [JsonProperty("actions")]
        public Action[] Actions { get; set; }

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
        // TODO: mtirion changed this to JsonIgnore, as the format property causes an error in the Dimelo API
        [JsonIgnore]
        public Formatting Format { get; set; }

        /// <summary>
        /// Example: `1.2.3.4`
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
