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
    public interface IWithdrawApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Withdraw Asset
        /// </summary>
        /// <remarks>
        /// This endpoint allows for withdrawing assets from StarkExpress.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withdrawModel">The withdraw request.</param>
        /// <returns>WithdrawDetailsDto</returns>
        WithdrawDetailsDto Withdraw(WithdrawModel withdrawModel);

        /// <summary>
        /// Withdraw Asset
        /// </summary>
        /// <remarks>
        /// This endpoint allows for withdrawing assets from StarkExpress.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withdrawModel">The withdraw request.</param>
        /// <returns>ApiResponse of WithdrawDetailsDto</returns>
        ApiResponse<WithdrawDetailsDto> WithdrawWithHttpInfo(WithdrawModel withdrawModel);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWithdrawApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Withdraw Asset
        /// </summary>
        /// <remarks>
        /// This endpoint allows for withdrawing assets from StarkExpress.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withdrawModel">The withdraw request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WithdrawDetailsDto</returns>
        System.Threading.Tasks.Task<WithdrawDetailsDto> WithdrawAsync(WithdrawModel withdrawModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Withdraw Asset
        /// </summary>
        /// <remarks>
        /// This endpoint allows for withdrawing assets from StarkExpress.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withdrawModel">The withdraw request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WithdrawDetailsDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<WithdrawDetailsDto>> WithdrawWithHttpInfoAsync(WithdrawModel withdrawModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWithdrawApi : IWithdrawApiSync, IWithdrawApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WithdrawApi : IDisposable, IWithdrawApi
    {
        private StarkExpress.SDK.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public WithdrawApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public WithdrawApi(string basePath)
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
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public WithdrawApi(StarkExpress.SDK.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public WithdrawApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class.
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
        public WithdrawApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class using Configuration object.
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
        public WithdrawApi(HttpClient client, StarkExpress.SDK.Client.Client.Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public WithdrawApi(StarkExpress.SDK.Client.Client.ISynchronousClient client, StarkExpress.SDK.Client.Client.IAsynchronousClient asyncClient, StarkExpress.SDK.Client.Client.IReadableConfiguration configuration)
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
        /// Withdraw Asset This endpoint allows for withdrawing assets from StarkExpress.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withdrawModel">The withdraw request.</param>
        /// <returns>WithdrawDetailsDto</returns>
        public WithdrawDetailsDto Withdraw(WithdrawModel withdrawModel)
        {
            StarkExpress.SDK.Client.Client.ApiResponse<WithdrawDetailsDto> localVarResponse = WithdrawWithHttpInfo(withdrawModel);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Withdraw Asset This endpoint allows for withdrawing assets from StarkExpress.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withdrawModel">The withdraw request.</param>
        /// <returns>ApiResponse of WithdrawDetailsDto</returns>
        public StarkExpress.SDK.Client.Client.ApiResponse<WithdrawDetailsDto> WithdrawWithHttpInfo(WithdrawModel withdrawModel)
        {
            // verify the required parameter 'withdrawModel' is set
            if (withdrawModel == null)
                throw new StarkExpress.SDK.Client.Client.ApiException(400, "Missing required parameter 'withdrawModel' when calling WithdrawApi->Withdraw");

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

            localVarRequestOptions.Data = withdrawModel;

            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<WithdrawDetailsDto>("/api/v1/vaults/withdraw", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Withdraw", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Withdraw Asset This endpoint allows for withdrawing assets from StarkExpress.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withdrawModel">The withdraw request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WithdrawDetailsDto</returns>
        public async System.Threading.Tasks.Task<WithdrawDetailsDto> WithdrawAsync(WithdrawModel withdrawModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            StarkExpress.SDK.Client.Client.ApiResponse<WithdrawDetailsDto> localVarResponse = await WithdrawWithHttpInfoAsync(withdrawModel, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Withdraw Asset This endpoint allows for withdrawing assets from StarkExpress.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withdrawModel">The withdraw request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WithdrawDetailsDto)</returns>
        public async System.Threading.Tasks.Task<StarkExpress.SDK.Client.Client.ApiResponse<WithdrawDetailsDto>> WithdrawWithHttpInfoAsync(WithdrawModel withdrawModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'withdrawModel' is set
            if (withdrawModel == null)
                throw new StarkExpress.SDK.Client.Client.ApiException(400, "Missing required parameter 'withdrawModel' when calling WithdrawApi->Withdraw");


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

            localVarRequestOptions.Data = withdrawModel;

            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<WithdrawDetailsDto>("/api/v1/vaults/withdraw", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Withdraw", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
