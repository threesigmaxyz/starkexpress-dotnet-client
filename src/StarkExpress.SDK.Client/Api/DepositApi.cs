/*
 * Arc API Docs
 *
 * An API for the Arc platform.
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using StarkExpress.SDK.Client.Client;
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
        /// <returns>DepositDetailsDto</returns>
        DepositDetailsDto DepositDetails(DepositDetailsModel depositDetailsModel);

        /// <summary>
        /// Returns the deposit details for a given asset.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <returns>ApiResponse of DepositDetailsDto</returns>
        ApiResponse<DepositDetailsDto> DepositDetailsWithHttpInfo(DepositDetailsModel depositDetailsModel);
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
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DepositDetailsDto</returns>
        System.Threading.Tasks.Task<DepositDetailsDto> DepositDetailsAsync(DepositDetailsModel depositDetailsModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns the deposit details for a given asset.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DepositDetailsDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DepositDetailsDto>> DepositDetailsWithHttpInfoAsync(DepositDetailsModel depositDetailsModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
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
    public partial class DepositApi : IDisposable, IDepositApi
    {
        private StarkExpress.SDK.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public DepositApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public DepositApi(string basePath)
        {
            this.Configuration = StarkExpress.SDK.Client.Client.Configuration.MergeConfigurations(
                StarkExpress.SDK.Client.Client.GlobalConfiguration.Instance,
                new StarkExpress.SDK.Client.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new StarkExpress.SDK.Client.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = StarkExpress.SDK.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public DepositApi(StarkExpress.SDK.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = StarkExpress.SDK.Client.Client.Configuration.MergeConfigurations(
                StarkExpress.SDK.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new StarkExpress.SDK.Client.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = StarkExpress.SDK.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public DepositApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public DepositApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = StarkExpress.SDK.Client.Client.Configuration.MergeConfigurations(
                StarkExpress.SDK.Client.Client.GlobalConfiguration.Instance,
                new StarkExpress.SDK.Client.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new StarkExpress.SDK.Client.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = StarkExpress.SDK.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public DepositApi(HttpClient client, StarkExpress.SDK.Client.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = StarkExpress.SDK.Client.Client.Configuration.MergeConfigurations(
                StarkExpress.SDK.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new StarkExpress.SDK.Client.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = StarkExpress.SDK.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
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
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public StarkExpress.SDK.Client.Client.ApiClient ApiClient { get; set; } = null;

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
        /// <returns>DepositDetailsDto</returns>
        public DepositDetailsDto DepositDetails(DepositDetailsModel depositDetailsModel)
        {
            StarkExpress.SDK.Client.Client.ApiResponse<DepositDetailsDto> localVarResponse = DepositDetailsWithHttpInfo(depositDetailsModel);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the deposit details for a given asset. This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <returns>ApiResponse of DepositDetailsDto</returns>
        public StarkExpress.SDK.Client.Client.ApiResponse<DepositDetailsDto> DepositDetailsWithHttpInfo(DepositDetailsModel depositDetailsModel)
        {
            // verify the required parameter 'depositDetailsModel' is set
            if (depositDetailsModel == null)
                throw new StarkExpress.SDK.Client.Client.ApiException(400, "Missing required parameter 'depositDetailsModel' when calling DepositApi->DepositDetails");

            StarkExpress.SDK.Client.Client.RequestOptions localVarRequestOptions = new StarkExpress.SDK.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = StarkExpress.SDK.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = StarkExpress.SDK.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = depositDetailsModel;

            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<DepositDetailsDto>("/api/v1/vaults/deposit-details", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DepositDetails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the deposit details for a given asset. This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DepositDetailsDto</returns>
        public async System.Threading.Tasks.Task<DepositDetailsDto> DepositDetailsAsync(DepositDetailsModel depositDetailsModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            StarkExpress.SDK.Client.Client.ApiResponse<DepositDetailsDto> localVarResponse = await DepositDetailsWithHttpInfoAsync(depositDetailsModel, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the deposit details for a given asset. This endpoint returns the deposit details for a given user, asset, and data availability mode.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="depositDetailsModel">The deposit details request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DepositDetailsDto)</returns>
        public async System.Threading.Tasks.Task<StarkExpress.SDK.Client.Client.ApiResponse<DepositDetailsDto>> DepositDetailsWithHttpInfoAsync(DepositDetailsModel depositDetailsModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'depositDetailsModel' is set
            if (depositDetailsModel == null)
                throw new StarkExpress.SDK.Client.Client.ApiException(400, "Missing required parameter 'depositDetailsModel' when calling DepositApi->DepositDetails");


            StarkExpress.SDK.Client.Client.RequestOptions localVarRequestOptions = new StarkExpress.SDK.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = StarkExpress.SDK.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = StarkExpress.SDK.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = depositDetailsModel;

            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<DepositDetailsDto>("/api/v1/vaults/deposit-details", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DepositDetails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
