using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dimelo.Sdk.Models
{
    public class ResponseBase
    {
        /// <summary>
        /// Author identifier
        /// </summary>
        [JsonProperty("author_id")]
        public String AuthorId { get; set; }

        /// <summary>
        /// Required. unless attachments are present.Maximum size is 20k characters.
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// Example: `["TV", "Internet"]`
        /// </summary>
        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        /// <summary>
        /// Supported formats: `2012-02-10`, `2012-10-01T17:18:40Z` (ISO 8601)
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// html or text. Default on html if not specified.
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// Supported formats: `2012-02-10`, `2012-10-01T17:18:40Z` (ISO 8601)
        /// </summary> 
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
