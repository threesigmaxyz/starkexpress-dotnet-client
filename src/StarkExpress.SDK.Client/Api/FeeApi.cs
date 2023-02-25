/*
 * StarkExpress API Docs
 *
 * An API for the StarkExpress platform.
 *
 * The version of the OpenAPI document: v1
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
    public interface IFeeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Configure Fee Model
        /// </summary>
        /// <remarks>
        /// This endpoint allows to configure the fee model for a specific operation.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configureFeeModel">The fee model configuration request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>FeeConfigDto</returns>
        FeeConfigDto ConfigureFeeModel(ConfigureFeeModel configureFeeModel, int operationIndex = 0);

        /// <summary>
        /// Configure Fee Model
        /// </summary>
        /// <remarks>
        /// This endpoint allows to configure the fee model for a specific operation.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configureFeeModel">The fee model configuration request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of FeeConfigDto</returns>
        ApiResponse<FeeConfigDto> ConfigureFeeModelWithHttpInfo(ConfigureFeeModel configureFeeModel, int operationIndex = 0);
        /// <summary>
        /// Get Fee Model
        /// </summary>
        /// <remarks>
        /// This endpoint fetches a configured operation fee by ID.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId">The fee model configuration ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>FeeConfigDto</returns>
        FeeConfigDto GetFeeModel(Guid feeId, int operationIndex = 0);

        /// <summary>
        /// Get Fee Model
        /// </summary>
        /// <remarks>
        /// This endpoint fetches a configured operation fee by ID.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId">The fee model configuration ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of FeeConfigDto</returns>
        ApiResponse<FeeConfigDto> GetFeeModelWithHttpInfo(Guid feeId, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFeeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Configure Fee Model
        /// </summary>
        /// <remarks>
        /// This endpoint allows to configure the fee model for a specific operation.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configureFeeModel">The fee model configuration request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FeeConfigDto</returns>
        System.Threading.Tasks.Task<FeeConfigDto> ConfigureFeeModelAsync(ConfigureFeeModel configureFeeModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Configure Fee Model
        /// </summary>
        /// <remarks>
        /// This endpoint allows to configure the fee model for a specific operation.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configureFeeModel">The fee model configuration request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FeeConfigDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<FeeConfigDto>> ConfigureFeeModelWithHttpInfoAsync(ConfigureFeeModel configureFeeModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get Fee Model
        /// </summary>
        /// <remarks>
        /// This endpoint fetches a configured operation fee by ID.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId">The fee model configuration ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FeeConfigDto</returns>
        System.Threading.Tasks.Task<FeeConfigDto> GetFeeModelAsync(Guid feeId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Fee Model
        /// </summary>
        /// <remarks>
        /// This endpoint fetches a configured operation fee by ID.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId">The fee model configuration ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FeeConfigDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<FeeConfigDto>> GetFeeModelWithHttpInfoAsync(Guid feeId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFeeApi : IFeeApiSync, IFeeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FeeApi : IFeeApi
    {
        private StarkExpress.SDK.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FeeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FeeApi(string basePath)
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
        /// Initializes a new instance of the <see cref="FeeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FeeApi(StarkExpress.SDK.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="FeeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public FeeApi(StarkExpress.SDK.Client.Client.ISynchronousClient client, StarkExpress.SDK.Client.Client.IAsynchronousClient asyncClient, StarkExpress.SDK.Client.Client.IReadableConfiguration configuration)
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
        /// Configure Fee Model This endpoint allows to configure the fee model for a specific operation.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configureFeeModel">The fee model configuration request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>FeeConfigDto</returns>
        public FeeConfigDto ConfigureFeeModel(ConfigureFeeModel configureFeeModel, int operationIndex = 0)
        {
            StarkExpress.SDK.Client.Client.ApiResponse<FeeConfigDto> localVarResponse = ConfigureFeeModelWithHttpInfo(configureFeeModel);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure Fee Model This endpoint allows to configure the fee model for a specific operation.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configureFeeModel">The fee model configuration request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of FeeConfigDto</returns>
        public StarkExpress.SDK.Client.Client.ApiResponse<FeeConfigDto> ConfigureFeeModelWithHttpInfo(ConfigureFeeModel configureFeeModel, int operationIndex = 0)
        {
            // verify the required parameter 'configureFeeModel' is set
            if (configureFeeModel == null)
            {
                throw new StarkExpress.SDK.Client.Client.ApiException(400, "Missing required parameter 'configureFeeModel' when calling FeeApi->ConfigureFeeModel");
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

            localVarRequestOptions.Data = configureFeeModel;

            localVarRequestOptions.Operation = "FeeApi.ConfigureFeeModel";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<FeeConfigDto>("/api/fees", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConfigureFeeModel", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure Fee Model This endpoint allows to configure the fee model for a specific operation.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configureFeeModel">The fee model configuration request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FeeConfigDto</returns>
        public async System.Threading.Tasks.Task<FeeConfigDto> ConfigureFeeModelAsync(ConfigureFeeModel configureFeeModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            StarkExpress.SDK.Client.Client.ApiResponse<FeeConfigDto> localVarResponse = await ConfigureFeeModelWithHttpInfoAsync(configureFeeModel, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure Fee Model This endpoint allows to configure the fee model for a specific operation.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configureFeeModel">The fee model configuration request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FeeConfigDto)</returns>
        public async System.Threading.Tasks.Task<StarkExpress.SDK.Client.Client.ApiResponse<FeeConfigDto>> ConfigureFeeModelWithHttpInfoAsync(ConfigureFeeModel configureFeeModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'configureFeeModel' is set
            if (configureFeeModel == null)
            {
                throw new StarkExpress.SDK.Client.Client.ApiException(400, "Missing required parameter 'configureFeeModel' when calling FeeApi->ConfigureFeeModel");
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

            localVarRequestOptions.Data = configureFeeModel;

            localVarRequestOptions.Operation = "FeeApi.ConfigureFeeModel";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<FeeConfigDto>("/api/fees", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConfigureFeeModel", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Fee Model This endpoint fetches a configured operation fee by ID.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId">The fee model configuration ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>FeeConfigDto</returns>
        public FeeConfigDto GetFeeModel(Guid feeId, int operationIndex = 0)
        {
            StarkExpress.SDK.Client.Client.ApiResponse<FeeConfigDto> localVarResponse = GetFeeModelWithHttpInfo(feeId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Fee Model This endpoint fetches a configured operation fee by ID.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId">The fee model configuration ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of FeeConfigDto</returns>
        public StarkExpress.SDK.Client.Client.ApiResponse<FeeConfigDto> GetFeeModelWithHttpInfo(Guid feeId, int operationIndex = 0)
        {
            StarkExpress.SDK.Client.Client.RequestOptions localVarRequestOptions = new StarkExpress.SDK.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("feeId", StarkExpress.SDK.Client.Client.ClientUtils.ParameterToString(feeId)); // path parameter

            localVarRequestOptions.Operation = "FeeApi.GetFeeModel";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<FeeConfigDto>("/api/fees/{feeId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFeeModel", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Fee Model This endpoint fetches a configured operation fee by ID.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId">The fee model configuration ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FeeConfigDto</returns>
        public async System.Threading.Tasks.Task<FeeConfigDto> GetFeeModelAsync(Guid feeId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            StarkExpress.SDK.Client.Client.ApiResponse<FeeConfigDto> localVarResponse = await GetFeeModelWithHttpInfoAsync(feeId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Fee Model This endpoint fetches a configured operation fee by ID.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId">The fee model configuration ID.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FeeConfigDto)</returns>
        public async System.Threading.Tasks.Task<StarkExpress.SDK.Client.Client.ApiResponse<FeeConfigDto>> GetFeeModelWithHttpInfoAsync(Guid feeId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            StarkExpress.SDK.Client.Client.RequestOptions localVarRequestOptions = new StarkExpress.SDK.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("feeId", StarkExpress.SDK.Client.Client.ClientUtils.ParameterToString(feeId)); // path parameter

            localVarRequestOptions.Operation = "FeeApi.GetFeeModel";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<FeeConfigDto>("/api/fees/{feeId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFeeModel", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
