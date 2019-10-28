using Newtonsoft.Json;
using System;

namespace Dimelo.Sdk.Models
{
    public class Base
    {
        /// <summary>
        /// Required.
        /// </summary>
        [JsonRequired]
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Supported formats: `2012-02-10`, `2012-10-01T17:18:40Z` (ISO 8601)
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Supported formats: `2012-02-10`, `2012-10-01T17:18:40Z` (ISO 8601)
        /// </summary>     
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// A hash having the(expected) form: 
        /// {'field_name' => 'value'}. The keys must be[a - zA - Z_\-]. 
        /// Example: `{"country": "Germany", "age": "34", "fruits": ["Apple", "Pear"]}`
        /// </summary>
        [JsonProperty("context_data")]
        public object ContextData { get; set; }
    }
}
