using Ringcentral.Engage.Sdk.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ringcentral.Engage.Sdk
{
    public class EngageClient
    {
        private const string AUTHORIZATION_ATTRIBUTE = "Authorization";

        private readonly string _endpointUrl = string.Empty;
        private readonly string _accessToken = string.Empty;

        private HttpClient _client = null;

        /// <summary>
        /// Constructor must be provided with valid parameters for the connection to work
        /// </summary>
        /// <param name="endpointUrl"></param>
        /// <param name="accessToken"></param>
        public EngageClient(string endpointUrl, string accessToken)
        {
            // check valid parameters
            if (string.IsNullOrWhiteSpace(endpointUrl)) throw new ArgumentNullException("A valid serverURL should be provided");
            if (string.IsNullOrWhiteSpace(accessToken)) throw new ArgumentNullException("A valid accessToken should be provided");
            if (!Uri.IsWellFormedUriString(endpointUrl, UriKind.Absolute)) throw new ArgumentException("A valid serverURL should be provided");

            _endpointUrl = endpointUrl;
            _accessToken = accessToken;
        }

        /// <summary>
        /// Async send the request to the server
        /// </summary>
        /// <returns>Async</returns>
        public async Task<bool> AddCategoryAsync(string foreignThreadId, string categoryId)
        {
            // only create HttpClient once for performance
            if (_client == null) _client = new HttpClient();

            try
            {
                // set the necessary header(s)
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add(AUTHORIZATION_ATTRIBUTE, $"Bearer {_accessToken}");
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error setting the request to send", ex);
            }

            // send the request
            HttpResponseMessage response = null;
            string responseContent = string.Empty;
            try
            {
                var getThreadIdUrl = $"{_endpointUrl}/content_threads?q=foreign_id:\"{foreignThreadId}\"";
                response = await _client.GetAsync(getThreadIdUrl);

                responseContent = await response.Content.ReadAsStringAsync();
                var thread = JsonConvert.DeserializeObject<ThreadResponse>(responseContent);
                
                if (thread.Count == 1)
                {
                    var threadId = thread.Records[0].Id;

                    var listCategoryIds = (thread.Records[0].ThreadCategoryIds).ToList<string>();
                    listCategoryIds.Add(categoryId);

                    var categoryIds = string.Join(",", listCategoryIds.ToArray<string>());
                    var putCategoryUrl = $"{_endpointUrl}/content_threads/{threadId}/update_categories?thread_category_ids[]={categoryIds}";

                    response = await _client.PutAsync(putCategoryUrl, new StringContent(string.Empty));

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error sending the request to {_endpointUrl}", ex);
            }

            return false;
        }
    }
}
