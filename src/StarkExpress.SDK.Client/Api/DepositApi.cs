/*
 * StarkExpress API Docs
 *
 * An API for the StarkExpress platform.
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Client.Auth;
using StarkExpress.SDK.Client.Model;

namespace StarkExpress.SDK.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDepositApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the deposit details for a given asset.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DepositDetailsDto</returns>
        DepositDetailsDto DepositDetails(DepositDetailsModel depositDetailsModel, int operationIndex = 0);

        /// <summary>
        /// Returns the deposit details for a given asset.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DepositDetailsDto</returns>
        ApiResponse<DepositDetailsDto> DepositDetailsWithHttpInfo(DepositDetailsModel depositDetailsModel, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDepositApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Returns the deposit details for a given asset.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DepositDetailsDto</returns>
        System.Threading.Tasks.Task<DepositDetailsDto> DepositDetailsAsync(DepositDetailsModel depositDetailsModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns the deposit details for a given asset.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DepositDetailsDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DepositDetailsDto>> DepositDetailsWithHttpInfoAsync(DepositDetailsModel depositDetailsModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDepositApi : IDepositApiSync, IDepositApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DepositApi : IDepositApi
    {
        private StarkExpress.SDK.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DepositApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DepositApi(string basePath)
        {
            this.Configuration = StarkExpress.SDK.Client.Client.Configuration.MergeConfigurations(
                StarkExpress.SDK.Client.Client.GlobalConfiguration.Instance,
                new StarkExpress.SDK.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new StarkExpress.SDK.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new StarkExpress.SDK.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = StarkExpress.SDK.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DepositApi(StarkExpress.SDK.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = StarkExpress.SDK.Client.Client.Configuration.MergeConfigurations(
                StarkExpress.SDK.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new StarkExpress.SDK.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new StarkExpress.SDK.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = StarkExpress.SDK.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DepositApi(StarkExpress.SDK.Client.Client.ISynchronousClient client, StarkExpress.SDK.Client.Client.IAsynchronousClient asyncClient, StarkExpress.SDK.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = StarkExpress.SDK.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public StarkExpress.SDK.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public StarkExpress.SDK.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public StarkExpress.SDK.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public StarkExpress.SDK.Client.Client.ExceptionFactory ExceptionFactory
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
        /// Returns the deposit details for a given asset. This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DepositDetailsDto</returns>
        public DepositDetailsDto DepositDetails(DepositDetailsModel depositDetailsModel, int operationIndex = 0)
        {
            StarkExpress.SDK.Client.Client.ApiResponse<DepositDetailsDto> localVarResponse = DepositDetailsWithHttpInfo(depositDetailsModel);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the deposit details for a given asset. This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DepositDetailsDto</returns>
        public StarkExpress.SDK.Client.Client.ApiResponse<DepositDetailsDto> DepositDetailsWithHttpInfo(DepositDetailsModel depositDetailsModel, int operationIndex = 0)
        {
            // verify the required parameter 'depositDetailsModel' is set
            if (depositDetailsModel == null)
            {
                throw new StarkExpress.SDK.Client.Client.ApiException(400, "Missing required parameter 'depositDetailsModel' when calling DepositApi->DepositDetails");
            }

            StarkExpress.SDK.Client.Client.RequestOptions localVarRequestOptions = new StarkExpress.SDK.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = StarkExpress.SDK.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = StarkExpress.SDK.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = depositDetailsModel;

            localVarRequestOptions.Operation = "DepositApi.DepositDetails";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<DepositDetailsDto>("/api/v1/vaults/deposit-details", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DepositDetails", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the deposit details for a given asset. This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DepositDetailsDto</returns>
        public async System.Threading.Tasks.Task<DepositDetailsDto> DepositDetailsAsync(DepositDetailsModel depositDetailsModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            StarkExpress.SDK.Client.Client.ApiResponse<DepositDetailsDto> localVarResponse = await DepositDetailsWithHttpInfoAsync(depositDetailsModel, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the deposit details for a given asset. This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DepositDetailsDto)</returns>
        public async System.Threading.Tasks.Task<StarkExpress.SDK.Client.Client.ApiResponse<DepositDetailsDto>> DepositDetailsWithHttpInfoAsync(DepositDetailsModel depositDetailsModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'depositDetailsModel' is set
            if (depositDetailsModel == null)
            {
                throw new StarkExpress.SDK.Client.Client.ApiException(400, "Missing required parameter 'depositDetailsModel' when calling DepositApi->DepositDetails");
            }


            StarkExpress.SDK.Client.Client.RequestOptions localVarRequestOptions = new StarkExpress.SDK.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = StarkExpress.SDK.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = StarkExpress.SDK.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = depositDetailsModel;

            localVarRequestOptions.Operation = "DepositApi.DepositDetails";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<DepositDetailsDto>("/api/v1/vaults/deposit-details", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DepositDetails", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
