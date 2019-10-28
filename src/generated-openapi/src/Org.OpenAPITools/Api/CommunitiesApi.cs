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
    public interface ICommunitiesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Getting all communities
        /// </summary>
        /// <remarks>
        /// This method renders communities ordered by creation date (ascending).
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The record index to start. Default value is 0. (optional)</param>
        /// <param name="limit">The max number of records to return. Default value is 30, max value is 150. (optional)</param>
        /// <returns>GetAllCommunitiesResponse</returns>
        GetAllCommunitiesResponse GetAllCommunities (int? offset = null, int? limit = null);

        /// <summary>
        /// Getting all communities
        /// </summary>
        /// <remarks>
        /// This method renders communities ordered by creation date (ascending).
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The record index to start. Default value is 0. (optional)</param>
        /// <param name="limit">The max number of records to return. Default value is 30, max value is 150. (optional)</param>
        /// <returns>ApiResponse of GetAllCommunitiesResponse</returns>
        ApiResponse<GetAllCommunitiesResponse> GetAllCommunitiesWithHttpInfo (int? offset = null, int? limit = null);
        /// <summary>
        /// Getting a community from its id
        /// </summary>
        /// <remarks>
        /// This method renders a community from given id.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communityId"></param>
        /// <returns>Community</returns>
        Community GetCommunity (string communityId);

        /// <summary>
        /// Getting a community from its id
        /// </summary>
        /// <remarks>
        /// This method renders a community from given id.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communityId"></param>
        /// <returns>ApiResponse of Community</returns>
        ApiResponse<Community> GetCommunityWithHttpInfo (string communityId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommunitiesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Getting all communities
        /// </summary>
        /// <remarks>
        /// This method renders communities ordered by creation date (ascending).
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The record index to start. Default value is 0. (optional)</param>
        /// <param name="limit">The max number of records to return. Default value is 30, max value is 150. (optional)</param>
        /// <returns>Task of GetAllCommunitiesResponse</returns>
        System.Threading.Tasks.Task<GetAllCommunitiesResponse> GetAllCommunitiesAsync (int? offset = null, int? limit = null);

        /// <summary>
        /// Getting all communities
        /// </summary>
        /// <remarks>
        /// This method renders communities ordered by creation date (ascending).
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The record index to start. Default value is 0. (optional)</param>
        /// <param name="limit">The max number of records to return. Default value is 30, max value is 150. (optional)</param>
        /// <returns>Task of ApiResponse (GetAllCommunitiesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetAllCommunitiesResponse>> GetAllCommunitiesAsyncWithHttpInfo (int? offset = null, int? limit = null);
        /// <summary>
        /// Getting a community from its id
        /// </summary>
        /// <remarks>
        /// This method renders a community from given id.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communityId"></param>
        /// <returns>Task of Community</returns>
        System.Threading.Tasks.Task<Community> GetCommunityAsync (string communityId);

        /// <summary>
        /// Getting a community from its id
        /// </summary>
        /// <remarks>
        /// This method renders a community from given id.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communityId"></param>
        /// <returns>Task of ApiResponse (Community)</returns>
        System.Threading.Tasks.Task<ApiResponse<Community>> GetCommunityAsyncWithHttpInfo (string communityId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommunitiesApi : ICommunitiesApiSync, ICommunitiesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CommunitiesApi : ICommunitiesApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunitiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CommunitiesApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunitiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CommunitiesApi(String basePath)
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
        /// Initializes a new instance of the <see cref="CommunitiesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CommunitiesApi(Org.OpenAPITools.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="CommunitiesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CommunitiesApi(Org.OpenAPITools.Client.ISynchronousClient client,Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
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
        /// Getting all communities This method renders communities ordered by creation date (ascending).
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The record index to start. Default value is 0. (optional)</param>
        /// <param name="limit">The max number of records to return. Default value is 30, max value is 150. (optional)</param>
        /// <returns>GetAllCommunitiesResponse</returns>
        public GetAllCommunitiesResponse GetAllCommunities (int? offset = null, int? limit = null)
        {
             Org.OpenAPITools.Client.ApiResponse<GetAllCommunitiesResponse> localVarResponse = GetAllCommunitiesWithHttpInfo(offset, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Getting all communities This method renders communities ordered by creation date (ascending).
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The record index to start. Default value is 0. (optional)</param>
        /// <param name="limit">The max number of records to return. Default value is 30, max value is 150. (optional)</param>
        /// <returns>ApiResponse of GetAllCommunitiesResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse< GetAllCommunitiesResponse > GetAllCommunitiesWithHttpInfo (int? offset = null, int? limit = null)
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

            if (offset != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "offset", offset))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (limit != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "limit", limit))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }


            // make the HTTP request

            var response = this.Client.Get< GetAllCommunitiesResponse >("/communities", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetAllCommunities", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Getting all communities This method renders communities ordered by creation date (ascending).
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The record index to start. Default value is 0. (optional)</param>
        /// <param name="limit">The max number of records to return. Default value is 30, max value is 150. (optional)</param>
        /// <returns>Task of GetAllCommunitiesResponse</returns>
        public async System.Threading.Tasks.Task<GetAllCommunitiesResponse> GetAllCommunitiesAsync (int? offset = null, int? limit = null)
        {
             Org.OpenAPITools.Client.ApiResponse<GetAllCommunitiesResponse> localVarResponse = await GetAllCommunitiesAsyncWithHttpInfo(offset, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Getting all communities This method renders communities ordered by creation date (ascending).
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The record index to start. Default value is 0. (optional)</param>
        /// <param name="limit">The max number of records to return. Default value is 30, max value is 150. (optional)</param>
        /// <returns>Task of ApiResponse (GetAllCommunitiesResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<GetAllCommunitiesResponse>> GetAllCommunitiesAsyncWithHttpInfo (int? offset = null, int? limit = null)
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
            
            if (offset != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "offset", offset))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (limit != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "limit", limit))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }


            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<GetAllCommunitiesResponse>("/communities", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetAllCommunities", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Getting a community from its id This method renders a community from given id.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communityId"></param>
        /// <returns>Community</returns>
        public Community GetCommunity (string communityId)
        {
             Org.OpenAPITools.Client.ApiResponse<Community> localVarResponse = GetCommunityWithHttpInfo(communityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Getting a community from its id This method renders a community from given id.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communityId"></param>
        /// <returns>ApiResponse of Community</returns>
        public Org.OpenAPITools.Client.ApiResponse< Community > GetCommunityWithHttpInfo (string communityId)
        {
            // verify the required parameter 'communityId' is set
            if (communityId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'communityId' when calling CommunitiesApi->GetCommunity");

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

            if (communityId != null)
                requestOptions.PathParameters.Add("communityId", Org.OpenAPITools.Client.ClientUtils.ParameterToString(communityId)); // path parameter


            // make the HTTP request

            var response = this.Client.Get< Community >("/communities/{communityId}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetCommunity", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Getting a community from its id This method renders a community from given id.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communityId"></param>
        /// <returns>Task of Community</returns>
        public async System.Threading.Tasks.Task<Community> GetCommunityAsync (string communityId)
        {
             Org.OpenAPITools.Client.ApiResponse<Community> localVarResponse = await GetCommunityAsyncWithHttpInfo(communityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Getting a community from its id This method renders a community from given id.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communityId"></param>
        /// <returns>Task of ApiResponse (Community)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Community>> GetCommunityAsyncWithHttpInfo (string communityId)
        {
            // verify the required parameter 'communityId' is set
            if (communityId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'communityId' when calling CommunitiesApi->GetCommunity");


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
            
            if (communityId != null)
                requestOptions.PathParameters.Add("communityId", Org.OpenAPITools.Client.ClientUtils.ParameterToString(communityId)); // path parameter


            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<Community>("/communities/{communityId}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetCommunity", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}