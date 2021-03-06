/* 
 * Engage Digital API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace RingCentral.EngageDigital.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAgentStatusApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Changing an agent&#39;s status
        /// </summary>
        /// <remarks>
        /// This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>AgentStatus</returns>
        AgentStatus ChangeAgentStatus (string agentId, string status = default(string), string customStatusId = default(string));

        /// <summary>
        /// Changing an agent&#39;s status
        /// </summary>
        /// <remarks>
        /// This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>ApiResponse of AgentStatus</returns>
        ApiResponse<AgentStatus> ChangeAgentStatusWithHttpInfo (string agentId, string status = default(string), string customStatusId = default(string));
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
        /// <returns>Collection&lt;AgentStatus&gt;</returns>
        Collection<AgentStatus> GetAllAgentStatus ();

        /// <summary>
        /// Get all connected agents status
        /// </summary>
        /// <remarks>
        /// This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Collection&lt;AgentStatus&gt;</returns>
        ApiResponse<Collection<AgentStatus>> GetAllAgentStatusWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAgentStatusApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Changing an agent&#39;s status
        /// </summary>
        /// <remarks>
        /// This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>Task of AgentStatus</returns>
        System.Threading.Tasks.Task<AgentStatus> ChangeAgentStatusAsync (string agentId, string status = default(string), string customStatusId = default(string));

        /// <summary>
        /// Changing an agent&#39;s status
        /// </summary>
        /// <remarks>
        /// This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>Task of ApiResponse (AgentStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<AgentStatus>> ChangeAgentStatusAsyncWithHttpInfo (string agentId, string status = default(string), string customStatusId = default(string));
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
        /// <returns>Task of Collection&lt;AgentStatus&gt;</returns>
        System.Threading.Tasks.Task<Collection<AgentStatus>> GetAllAgentStatusAsync ();

        /// <summary>
        /// Get all connected agents status
        /// </summary>
        /// <remarks>
        /// This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Collection&lt;AgentStatus&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Collection<AgentStatus>>> GetAllAgentStatusAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAgentStatusApi : IAgentStatusApiSync, IAgentStatusApiAsync
    {

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
        public AgentStatusApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AgentStatusApi(String basePath)
        {
            this.Configuration = RingCentral.EngageDigital.Client.Configuration.MergeConfigurations(
                RingCentral.EngageDigital.Client.GlobalConfiguration.Instance,
                new RingCentral.EngageDigital.Client.Configuration { BasePath = basePath }
            );
            this.Client = new RingCentral.EngageDigital.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new RingCentral.EngageDigital.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = RingCentral.EngageDigital.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatusApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AgentStatusApi(RingCentral.EngageDigital.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = RingCentral.EngageDigital.Client.Configuration.MergeConfigurations(
                RingCentral.EngageDigital.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new RingCentral.EngageDigital.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new RingCentral.EngageDigital.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = RingCentral.EngageDigital.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatusApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AgentStatusApi(RingCentral.EngageDigital.Client.ISynchronousClient client,RingCentral.EngageDigital.Client.IAsynchronousClient asyncClient, RingCentral.EngageDigital.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = RingCentral.EngageDigital.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public RingCentral.EngageDigital.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public RingCentral.EngageDigital.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public RingCentral.EngageDigital.Client.IReadableConfiguration Configuration {get; set;}

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
        /// Changing an agent&#39;s status This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>AgentStatus</returns>
        public AgentStatus ChangeAgentStatus (string agentId, string status = default(string), string customStatusId = default(string))
        {
             RingCentral.EngageDigital.Client.ApiResponse<AgentStatus> localVarResponse = ChangeAgentStatusWithHttpInfo(agentId, status, customStatusId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Changing an agent&#39;s status This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>ApiResponse of AgentStatus</returns>
        public RingCentral.EngageDigital.Client.ApiResponse< AgentStatus > ChangeAgentStatusWithHttpInfo (string agentId, string status = default(string), string customStatusId = default(string))
        {
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new RingCentral.EngageDigital.Client.ApiException(400, "Missing required parameter 'agentId' when calling AgentStatusApi->ChangeAgentStatus");

            RingCentral.EngageDigital.Client.RequestOptions localVarRequestOptions = new RingCentral.EngageDigital.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = RingCentral.EngageDigital.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = RingCentral.EngageDigital.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (agentId != null)
                localVarRequestOptions.PathParameters.Add("agentId", RingCentral.EngageDigital.Client.ClientUtils.ParameterToString(agentId)); // path parameter
            if (status != null)
            {
                foreach (var _kvp in RingCentral.EngageDigital.Client.ClientUtils.ParameterToMultiMap("", "status", status))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (customStatusId != null)
            {
                foreach (var _kvp in RingCentral.EngageDigital.Client.ClientUtils.ParameterToMultiMap("", "custom_status_id", customStatusId))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }


            // make the HTTP request
            var localVarResponse = this.Client.Put< AgentStatus >("/status/{agentId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ChangeAgentStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Changing an agent&#39;s status This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>Task of AgentStatus</returns>
        public async System.Threading.Tasks.Task<AgentStatus> ChangeAgentStatusAsync (string agentId, string status = default(string), string customStatusId = default(string))
        {
             RingCentral.EngageDigital.Client.ApiResponse<AgentStatus> localVarResponse = await ChangeAgentStatusAsyncWithHttpInfo(agentId, status, customStatusId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Changing an agent&#39;s status This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>Task of ApiResponse (AgentStatus)</returns>
        public async System.Threading.Tasks.Task<RingCentral.EngageDigital.Client.ApiResponse<AgentStatus>> ChangeAgentStatusAsyncWithHttpInfo (string agentId, string status = default(string), string customStatusId = default(string))
        {
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new RingCentral.EngageDigital.Client.ApiException(400, "Missing required parameter 'agentId' when calling AgentStatusApi->ChangeAgentStatus");


            RingCentral.EngageDigital.Client.RequestOptions localVarRequestOptions = new RingCentral.EngageDigital.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (agentId != null)
                localVarRequestOptions.PathParameters.Add("agentId", RingCentral.EngageDigital.Client.ClientUtils.ParameterToString(agentId)); // path parameter
            if (status != null)
            {
                foreach (var _kvp in RingCentral.EngageDigital.Client.ClientUtils.ParameterToMultiMap("", "status", status))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }
            if (customStatusId != null)
            {
                foreach (var _kvp in RingCentral.EngageDigital.Client.ClientUtils.ParameterToMultiMap("", "custom_status_id", customStatusId))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<AgentStatus>("/status/{agentId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ChangeAgentStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a connected agent status This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>AgentStatus</returns>
        public AgentStatus GetAgentStatus (string agentId)
        {
             RingCentral.EngageDigital.Client.ApiResponse<AgentStatus> localVarResponse = GetAgentStatusWithHttpInfo(agentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a connected agent status This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>ApiResponse of AgentStatus</returns>
        public RingCentral.EngageDigital.Client.ApiResponse< AgentStatus > GetAgentStatusWithHttpInfo (string agentId)
        {
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new RingCentral.EngageDigital.Client.ApiException(400, "Missing required parameter 'agentId' when calling AgentStatusApi->GetAgentStatus");

            RingCentral.EngageDigital.Client.RequestOptions localVarRequestOptions = new RingCentral.EngageDigital.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = RingCentral.EngageDigital.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = RingCentral.EngageDigital.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (agentId != null)
                localVarRequestOptions.PathParameters.Add("agentId", RingCentral.EngageDigital.Client.ClientUtils.ParameterToString(agentId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get< AgentStatus >("/status/{agentId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAgentStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a connected agent status This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>Task of AgentStatus</returns>
        public async System.Threading.Tasks.Task<AgentStatus> GetAgentStatusAsync (string agentId)
        {
             RingCentral.EngageDigital.Client.ApiResponse<AgentStatus> localVarResponse = await GetAgentStatusAsyncWithHttpInfo(agentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a connected agent status This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>Task of ApiResponse (AgentStatus)</returns>
        public async System.Threading.Tasks.Task<RingCentral.EngageDigital.Client.ApiResponse<AgentStatus>> GetAgentStatusAsyncWithHttpInfo (string agentId)
        {
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new RingCentral.EngageDigital.Client.ApiException(400, "Missing required parameter 'agentId' when calling AgentStatusApi->GetAgentStatus");


            RingCentral.EngageDigital.Client.RequestOptions localVarRequestOptions = new RingCentral.EngageDigital.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (agentId != null)
                localVarRequestOptions.PathParameters.Add("agentId", RingCentral.EngageDigital.Client.ClientUtils.ParameterToString(agentId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AgentStatus>("/status/{agentId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAgentStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all connected agents status This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Collection&lt;AgentStatus&gt;</returns>
        public Collection<AgentStatus> GetAllAgentStatus ()
        {
             RingCentral.EngageDigital.Client.ApiResponse<Collection<AgentStatus>> localVarResponse = GetAllAgentStatusWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all connected agents status This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Collection&lt;AgentStatus&gt;</returns>
        public RingCentral.EngageDigital.Client.ApiResponse< Collection<AgentStatus> > GetAllAgentStatusWithHttpInfo ()
        {
            RingCentral.EngageDigital.Client.RequestOptions localVarRequestOptions = new RingCentral.EngageDigital.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = RingCentral.EngageDigital.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = RingCentral.EngageDigital.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get< Collection<AgentStatus> >("/status", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllAgentStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all connected agents status This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Collection&lt;AgentStatus&gt;</returns>
        public async System.Threading.Tasks.Task<Collection<AgentStatus>> GetAllAgentStatusAsync ()
        {
             RingCentral.EngageDigital.Client.ApiResponse<Collection<AgentStatus>> localVarResponse = await GetAllAgentStatusAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all connected agents status This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="RingCentral.EngageDigital.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Collection&lt;AgentStatus&gt;)</returns>
        public async System.Threading.Tasks.Task<RingCentral.EngageDigital.Client.ApiResponse<Collection<AgentStatus>>> GetAllAgentStatusAsyncWithHttpInfo ()
        {

            RingCentral.EngageDigital.Client.RequestOptions localVarRequestOptions = new RingCentral.EngageDigital.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Collection<AgentStatus>>("/status", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllAgentStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
