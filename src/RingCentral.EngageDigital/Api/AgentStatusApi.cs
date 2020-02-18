/* 
 * Engage Digital API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace RingCentral.EngageDigital.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        internal interface IAgentStatusApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Changing an agent&#x27;s status
        /// </summary>
        /// <remarks>
        /// This method updates an agent&#x27;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>AgentStatus</returns>
        AgentStatus ChangeAgentStatus (string agentId, string status = null, string customStatusId = null);

        /// <summary>
        /// Changing an agent&#x27;s status
        /// </summary>
        /// <remarks>
        /// This method updates an agent&#x27;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>ApiResponse of AgentStatus</returns>
        ApiResponse<AgentStatus> ChangeAgentStatusWithHttpInfo (string agentId, string status = null, string customStatusId = null);
        /// <summary>
        /// Get a connected agent status
        /// </summary>
        /// <remarks>
        /// This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>AgentStatus</returns>
        AgentStatus GetAgentStatus (string agentId);

        /// <summary>
        /// Get a connected agent status
        /// </summary>
        /// <remarks>
        /// This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>ApiResponse of AgentStatus</returns>
        ApiResponse<AgentStatus> GetAgentStatusWithHttpInfo (string agentId);
        /// <summary>
        /// Get all connected agents status
        /// </summary>
        /// <remarks>
        /// This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;AgentStatus&gt;</returns>
        List<AgentStatus> GetAllAgentStatus ();

        /// <summary>
        /// Get all connected agents status
        /// </summary>
        /// <remarks>
        /// This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;AgentStatus&gt;</returns>
        ApiResponse<List<AgentStatus>> GetAllAgentStatusWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Changing an agent&#x27;s status
        /// </summary>
        /// <remarks>
        /// This method updates an agent&#x27;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>Task of AgentStatus</returns>
        System.Threading.Tasks.Task<AgentStatus> ChangeAgentStatusAsync (string agentId, string status = null, string customStatusId = null);

        /// <summary>
        /// Changing an agent&#x27;s status
        /// </summary>
        /// <remarks>
        /// This method updates an agent&#x27;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>Task of ApiResponse (AgentStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<AgentStatus>> ChangeAgentStatusAsyncWithHttpInfo (string agentId, string status = null, string customStatusId = null);
        /// <summary>
        /// Get a connected agent status
        /// </summary>
        /// <remarks>
        /// This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>Task of AgentStatus</returns>
        System.Threading.Tasks.Task<AgentStatus> GetAgentStatusAsync (string agentId);

        /// <summary>
        /// Get a connected agent status
        /// </summary>
        /// <remarks>
        /// This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>Task of ApiResponse (AgentStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<AgentStatus>> GetAgentStatusAsyncWithHttpInfo (string agentId);
        /// <summary>
        /// Get all connected agents status
        /// </summary>
        /// <remarks>
        /// This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;AgentStatus&gt;</returns>
        System.Threading.Tasks.Task<List<AgentStatus>> GetAllAgentStatusAsync ();

        /// <summary>
        /// Get all connected agents status
        /// </summary>
        /// <remarks>
        /// This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;AgentStatus&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AgentStatus>>> GetAllAgentStatusAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class AgentStatusApi : IAgentStatusApi
    {
        private RingCentral.EngageDigital.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AgentStatusApi(String basePath)
        {
            this.Configuration = new RingCentral.EngageDigital.Client.Configuration { BasePath = basePath };

            ExceptionFactory = RingCentral.EngageDigital.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatusApi"/> class
        /// </summary>
        /// <returns></returns>
        public AgentStatusApi()
        {
            this.Configuration = RingCentral.EngageDigital.Client.Configuration.Default;

            ExceptionFactory = RingCentral.EngageDigital.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatusApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AgentStatusApi(RingCentral.EngageDigital.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = RingCentral.EngageDigital.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = RingCentral.EngageDigital.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public RingCentral.EngageDigital.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public RingCentral.EngageDigital.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Changing an agent&#x27;s status This method updates an agent&#x27;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>AgentStatus</returns>
        public AgentStatus ChangeAgentStatus (string agentId, string status = null, string customStatusId = null)
        {
             ApiResponse<AgentStatus> localVarResponse = ChangeAgentStatusWithHttpInfo(agentId, status, customStatusId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Changing an agent&#x27;s status This method updates an agent&#x27;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>ApiResponse of AgentStatus</returns>
        public ApiResponse< AgentStatus > ChangeAgentStatusWithHttpInfo (string agentId, string status = null, string customStatusId = null)
        {
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentStatusApi->ChangeAgentStatus");

            var localVarPath = "./status/{agentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId)); // path parameter
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (customStatusId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "custom_status_id", customStatusId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ChangeAgentStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AgentStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AgentStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentStatus)));
        }

        /// <summary>
        /// Changing an agent&#x27;s status This method updates an agent&#x27;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>Task of AgentStatus</returns>
        public async System.Threading.Tasks.Task<AgentStatus> ChangeAgentStatusAsync (string agentId, string status = null, string customStatusId = null)
        {
             ApiResponse<AgentStatus> localVarResponse = await ChangeAgentStatusAsyncWithHttpInfo(agentId, status, customStatusId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Changing an agent&#x27;s status This method updates an agent&#x27;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>Task of ApiResponse (AgentStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AgentStatus>> ChangeAgentStatusAsyncWithHttpInfo (string agentId, string status = null, string customStatusId = null)
        {
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentStatusApi->ChangeAgentStatus");

            var localVarPath = "./status/{agentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId)); // path parameter
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (customStatusId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "custom_status_id", customStatusId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ChangeAgentStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AgentStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AgentStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentStatus)));
        }

        /// <summary>
        /// Get a connected agent status This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>AgentStatus</returns>
        public AgentStatus GetAgentStatus (string agentId)
        {
             ApiResponse<AgentStatus> localVarResponse = GetAgentStatusWithHttpInfo(agentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a connected agent status This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>ApiResponse of AgentStatus</returns>
        public ApiResponse< AgentStatus > GetAgentStatusWithHttpInfo (string agentId)
        {
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentStatusApi->GetAgentStatus");

            var localVarPath = "./status/{agentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAgentStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AgentStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AgentStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentStatus)));
        }

        /// <summary>
        /// Get a connected agent status This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>Task of AgentStatus</returns>
        public async System.Threading.Tasks.Task<AgentStatus> GetAgentStatusAsync (string agentId)
        {
             ApiResponse<AgentStatus> localVarResponse = await GetAgentStatusAsyncWithHttpInfo(agentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a connected agent status This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>Task of ApiResponse (AgentStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AgentStatus>> GetAgentStatusAsyncWithHttpInfo (string agentId)
        {
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling AgentStatusApi->GetAgentStatus");

            var localVarPath = "./status/{agentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAgentStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AgentStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AgentStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentStatus)));
        }

        /// <summary>
        /// Get all connected agents status This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;AgentStatus&gt;</returns>
        public List<AgentStatus> GetAllAgentStatus ()
        {
             ApiResponse<List<AgentStatus>> localVarResponse = GetAllAgentStatusWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all connected agents status This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;AgentStatus&gt;</returns>
        public ApiResponse< List<AgentStatus> > GetAllAgentStatusWithHttpInfo ()
        {

            var localVarPath = "./status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllAgentStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<AgentStatus>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (List<AgentStatus>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AgentStatus>)));
        }

        /// <summary>
        /// Get all connected agents status This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;AgentStatus&gt;</returns>
        public async System.Threading.Tasks.Task<List<AgentStatus>> GetAllAgentStatusAsync ()
        {
             ApiResponse<List<AgentStatus>> localVarResponse = await GetAllAgentStatusAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all connected agents status This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;AgentStatus&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<AgentStatus>>> GetAllAgentStatusAsyncWithHttpInfo ()
        {

            var localVarPath = "./status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllAgentStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<AgentStatus>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (List<AgentStatus>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AgentStatus>)));
        }

    }
}
