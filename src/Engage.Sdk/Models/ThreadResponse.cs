using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Ringcentral.Engage.Sdk.Models
{
    public class ThreadResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("records")]
        public Record[] Records { get; set; }
    }

    public class Record
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("thread_category_ids")]
        public string[] ThreadCategoryIds { get; set; }
    }
}






