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
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
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
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>AgentStatus</returns>
        AgentStatus ChangeAgentStatus (string agentId, string status = null, string customStatusId = null);

        /// <summary>
        /// Changing an agent&#39;s status
        /// </summary>
        /// <remarks>
        /// This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>AgentStatus</returns>
        AgentStatus GetAgentStatus (string agentId);

        /// <summary>
        /// Get a connected agent status
        /// </summary>
        /// <remarks>
        /// This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>ApiResponse of AgentStatus</returns>
        ApiResponse<AgentStatus> GetAgentStatusWithHttpInfo (string agentId);
        /// <summary>
        /// Get all connected agents status
        /// </summary>
        /// <remarks>
        /// This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;AgentStatus&gt;</returns>
        List<AgentStatus> GetAllAgentStatus ();

        /// <summary>
        /// Get all connected agents status
        /// </summary>
        /// <remarks>
        /// This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;AgentStatus&gt;</returns>
        ApiResponse<List<AgentStatus>> GetAllAgentStatusWithHttpInfo ();
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
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>Task of AgentStatus</returns>
        System.Threading.Tasks.Task<AgentStatus> ChangeAgentStatusAsync (string agentId, string status = null, string customStatusId = null);

        /// <summary>
        /// Changing an agent&#39;s status
        /// </summary>
        /// <remarks>
        /// This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>Task of AgentStatus</returns>
        System.Threading.Tasks.Task<AgentStatus> GetAgentStatusAsync (string agentId);

        /// <summary>
        /// Get a connected agent status
        /// </summary>
        /// <remarks>
        /// This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>Task of ApiResponse (AgentStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<AgentStatus>> GetAgentStatusAsyncWithHttpInfo (string agentId);
        /// <summary>
        /// Get all connected agents status
        /// </summary>
        /// <remarks>
        /// This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;AgentStatus&gt;</returns>
        System.Threading.Tasks.Task<List<AgentStatus>> GetAllAgentStatusAsync ();

        /// <summary>
        /// Get all connected agents status
        /// </summary>
        /// <remarks>
        /// This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;AgentStatus&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AgentStatus>>> GetAllAgentStatusAsyncWithHttpInfo ();
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
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

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
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatusApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AgentStatusApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatusApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AgentStatusApi(Org.OpenAPITools.Client.ISynchronousClient client,Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

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
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
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
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>AgentStatus</returns>
        public AgentStatus ChangeAgentStatus (string agentId, string status = null, string customStatusId = null)
        {
             Org.OpenAPITools.Client.ApiResponse<AgentStatus> localVarResponse = ChangeAgentStatusWithHttpInfo(agentId, status, customStatusId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Changing an agent&#39;s status This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>ApiResponse of AgentStatus</returns>
        public Org.OpenAPITools.Client.ApiResponse< AgentStatus > ChangeAgentStatusWithHttpInfo (string agentId, string status = null, string customStatusId = null)
        {
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'agentId' when calling AgentStatusApi->ChangeAgentStatus");

            Org.OpenAPITools.Client.RequestOptions requestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (agentId != null)
                requestOptions.PathParameters.Add("agentId", Org.OpenAPITools.Client.ClientUtils.ParameterToString(agentId)); // path parameter
            if (status != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "status", status))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (customStatusId != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "custom_status_id", customStatusId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }


            // make the HTTP request

            var response = this.Client.Put< AgentStatus >("/status/{agentId}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ChangeAgentStatus", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Changing an agent&#39;s status This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>Task of AgentStatus</returns>
        public async System.Threading.Tasks.Task<AgentStatus> ChangeAgentStatusAsync (string agentId, string status = null, string customStatusId = null)
        {
             Org.OpenAPITools.Client.ApiResponse<AgentStatus> localVarResponse = await ChangeAgentStatusAsyncWithHttpInfo(agentId, status, customStatusId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Changing an agent&#39;s status This method updates an agent&#39;s availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <param name="status">A hash of channel_id &#x3D;&gt; availability (must contain all channels). (optional)</param>
        /// <param name="customStatusId">id of presence status (optional) (optional)</param>
        /// <returns>Task of ApiResponse (AgentStatus)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<AgentStatus>> ChangeAgentStatusAsyncWithHttpInfo (string agentId, string status = null, string customStatusId = null)
        {
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'agentId' when calling AgentStatusApi->ChangeAgentStatus");


            Org.OpenAPITools.Client.RequestOptions requestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (agentId != null)
                requestOptions.PathParameters.Add("agentId", Org.OpenAPITools.Client.ClientUtils.ParameterToString(agentId)); // path parameter
            if (status != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "status", status))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (customStatusId != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "custom_status_id", customStatusId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }


            // make the HTTP request

            var response = await this.AsynchronousClient.PutAsync<AgentStatus>("/status/{agentId}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ChangeAgentStatus", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Get a connected agent status This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>AgentStatus</returns>
        public AgentStatus GetAgentStatus (string agentId)
        {
             Org.OpenAPITools.Client.ApiResponse<AgentStatus> localVarResponse = GetAgentStatusWithHttpInfo(agentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a connected agent status This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>ApiResponse of AgentStatus</returns>
        public Org.OpenAPITools.Client.ApiResponse< AgentStatus > GetAgentStatusWithHttpInfo (string agentId)
        {
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'agentId' when calling AgentStatusApi->GetAgentStatus");

            Org.OpenAPITools.Client.RequestOptions requestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (agentId != null)
                requestOptions.PathParameters.Add("agentId", Org.OpenAPITools.Client.ClientUtils.ParameterToString(agentId)); // path parameter


            // make the HTTP request

            var response = this.Client.Get< AgentStatus >("/status/{agentId}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetAgentStatus", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Get a connected agent status This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>Task of AgentStatus</returns>
        public async System.Threading.Tasks.Task<AgentStatus> GetAgentStatusAsync (string agentId)
        {
             Org.OpenAPITools.Client.ApiResponse<AgentStatus> localVarResponse = await GetAgentStatusAsyncWithHttpInfo(agentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a connected agent status This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentId"></param>
        /// <returns>Task of ApiResponse (AgentStatus)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<AgentStatus>> GetAgentStatusAsyncWithHttpInfo (string agentId)
        {
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'agentId' when calling AgentStatusApi->GetAgentStatus");


            Org.OpenAPITools.Client.RequestOptions requestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (agentId != null)
                requestOptions.PathParameters.Add("agentId", Org.OpenAPITools.Client.ClientUtils.ParameterToString(agentId)); // path parameter


            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<AgentStatus>("/status/{agentId}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetAgentStatus", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Get all connected agents status This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;AgentStatus&gt;</returns>
        public List<AgentStatus> GetAllAgentStatus ()
        {
             Org.OpenAPITools.Client.ApiResponse<List<AgentStatus>> localVarResponse = GetAllAgentStatusWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all connected agents status This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;AgentStatus&gt;</returns>
        public Org.OpenAPITools.Client.ApiResponse< List<AgentStatus> > GetAllAgentStatusWithHttpInfo ()
        {
            Org.OpenAPITools.Client.RequestOptions requestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var response = this.Client.Get< List<AgentStatus> >("/status", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetAllAgentStatus", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Get all connected agents status This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;AgentStatus&gt;</returns>
        public async System.Threading.Tasks.Task<List<AgentStatus>> GetAllAgentStatusAsync ()
        {
             Org.OpenAPITools.Client.ApiResponse<List<AgentStatus>> localVarResponse = await GetAllAgentStatusAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all connected agents status This method get all currently connected agents &amp; their status.  Authorization​: only users that have the right to monitor the task view.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;AgentStatus&gt;)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<List<AgentStatus>>> GetAllAgentStatusAsyncWithHttpInfo ()
        {

            Org.OpenAPITools.Client.RequestOptions requestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            


            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<List<AgentStatus>>("/status", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetAllAgentStatus", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}
