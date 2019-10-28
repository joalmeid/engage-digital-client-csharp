
using Dimelo.Sdk.Models;
using Newtonsoft.Json;
using System;

namespace Dimelo.Sdk
{
    /// <summary>
    /// Request for sending to Dimelo server using the DimeloClient
    /// </summary>
    public class DimeloRequest
    {
        [JsonProperty("action")]
        public CreateAction Action { get; set; }
        [JsonProperty("params")]
        public Base Params { get; set; }

        public DimeloRequest()
        {
        }

        /// <summary>
        /// Retrieve json for the complete request
        /// </summary>
        /// <returns>Json</returns>
        public string GetJson()
        {
            try
            {
                return JsonConvert.SerializeObject(
                    this,
                    Newtonsoft.Json.Formatting.None,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    }
                );
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error serializing request to json", ex);
            }
        }
    }
}
