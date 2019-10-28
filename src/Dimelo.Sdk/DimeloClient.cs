using Dimelo.Sdk.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dimelo.Sdk
{
    /// <summary>
    /// Main client for connecting to Dimelo
    /// </summary>
    public class DimeloClient
    {
        private const string SIGNATURE_ATTRIBUTE = "X-SMCCSDK-SIGNATURE";
        private const string MEDIATYPE_JSON = "application/json";

        private readonly string _endpointUrl = string.Empty;
        private readonly string _accessToken = string.Empty;

        private HttpClient _client = null;

        /// <summary>
        /// Constructor must be provided with valid parameters for the connection to work
        /// </summary>
        /// <param name="endpointUrl"></param>
        /// <param name="accessToken"></param>
        public DimeloClient(string endpointUrl, string accessToken)
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
        public async Task<string> SendAsync(DimeloRequest request)
        {
                // only create HttpClient once for performance
            if (_client == null) _client = new HttpClient();

            // creating the request
            StringContent content;
            try
            {       
                // construct the json content first
                string json = request.GetJson();
                content = new StringContent(json, Encoding.UTF8, MEDIATYPE_JSON);
                
                // compute the signature
                string signature = SigningHelper.Sign(_accessToken, json);

                // set the necessary header(s)
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add(SIGNATURE_ATTRIBUTE, signature);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error setting the request to send", ex);
            }

            // send the request
            HttpResponseMessage response = null;
            try
            {
                response = await _client.PostAsync(_endpointUrl, content);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error sending the request to {_endpointUrl}", ex);
            }

            // handle the response
            try
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                // unsuccesful statuscodes are thrown as exception
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Sending the request return HTTP status code {(int)response.StatusCode} {response.StatusCode} {responseContent}");
                }
                return responseContent;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error processing the response", ex);
            }
        }
    }
}
