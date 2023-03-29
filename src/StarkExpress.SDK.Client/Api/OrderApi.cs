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
    public interface IOrderApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Cancel Order (Not Implemented)
        /// </summary>
        /// <remarks>
        /// This endpoint cancels an active order.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OrderDto</returns>
        OrderDto CancelOrder(Guid orderId, int operationIndex = 0);

        /// <summary>
        /// Cancel Order (Not Implemented)
        /// </summary>
        /// <remarks>
        /// This endpoint cancels an active order.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OrderDto</returns>
        ApiResponse<OrderDto> CancelOrderWithHttpInfo(Guid orderId, int operationIndex = 0);
        /// <summary>
        /// Get Order Details (Not Implemented)
        /// </summary>
        /// <remarks>
        /// This endpoint allows for fetching details of an order to be signed.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderDetailsModel">The signable order details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OrderDetailsDto</returns>
        OrderDetailsDto OrderDetails(OrderDetailsModel orderDetailsModel, int operationIndex = 0);

        /// <summary>
        /// Get Order Details (Not Implemented)
        /// </summary>
        /// <remarks>
        /// This endpoint allows for fetching details of an order to be signed.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderDetailsModel">The signable order details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OrderDetailsDto</returns>
        ApiResponse<OrderDetailsDto> OrderDetailsWithHttpInfo(OrderDetailsModel orderDetailsModel, int operationIndex = 0);
        /// <summary>
        /// Submit Order (Not Implemented)
        /// </summary>
        /// <remarks>
        /// This endpoint submits an order to the matching engine.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="submitOrderModel">The order submission request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OrderDto</returns>
        OrderDto SubmitOrder(SubmitOrderModel submitOrderModel, int operationIndex = 0);

        /// <summary>
        /// Submit Order (Not Implemented)
        /// </summary>
        /// <remarks>
        /// This endpoint submits an order to the matching engine.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="submitOrderModel">The order submission request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OrderDto</returns>
        ApiResponse<OrderDto> SubmitOrderWithHttpInfo(SubmitOrderModel submitOrderModel, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrderApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Cancel Order (Not Implemented)
        /// </summary>
        /// <remarks>
        /// This endpoint cancels an active order.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OrderDto</returns>
        System.Threading.Tasks.Task<OrderDto> CancelOrderAsync(Guid orderId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Cancel Order (Not Implemented)
        /// </summary>
        /// <remarks>
        /// This endpoint cancels an active order.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OrderDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderDto>> CancelOrderWithHttpInfoAsync(Guid orderId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get Order Details (Not Implemented)
        /// </summary>
        /// <remarks>
        /// This endpoint allows for fetching details of an order to be signed.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderDetailsModel">The signable order details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OrderDetailsDto</returns>
        System.Threading.Tasks.Task<OrderDetailsDto> OrderDetailsAsync(OrderDetailsModel orderDetailsModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Order Details (Not Implemented)
        /// </summary>
        /// <remarks>
        /// This endpoint allows for fetching details of an order to be signed.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderDetailsModel">The signable order details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OrderDetailsDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderDetailsDto>> OrderDetailsWithHttpInfoAsync(OrderDetailsModel orderDetailsModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Submit Order (Not Implemented)
        /// </summary>
        /// <remarks>
        /// This endpoint submits an order to the matching engine.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="submitOrderModel">The order submission request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OrderDto</returns>
        System.Threading.Tasks.Task<OrderDto> SubmitOrderAsync(SubmitOrderModel submitOrderModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Submit Order (Not Implemented)
        /// </summary>
        /// <remarks>
        /// This endpoint submits an order to the matching engine.
        /// </remarks>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="submitOrderModel">The order submission request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OrderDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderDto>> SubmitOrderWithHttpInfoAsync(SubmitOrderModel submitOrderModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrderApi : IOrderApiSync, IOrderApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrderApi : IOrderApi
    {
        private StarkExpress.SDK.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderApi(string basePath)
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
        /// Initializes a new instance of the <see cref="OrderApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrderApi(StarkExpress.SDK.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="OrderApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public OrderApi(StarkExpress.SDK.Client.Client.ISynchronousClient client, StarkExpress.SDK.Client.Client.IAsynchronousClient asyncClient, StarkExpress.SDK.Client.Client.IReadableConfiguration configuration)
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
        /// Cancel Order (Not Implemented) This endpoint cancels an active order.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OrderDto</returns>
        public OrderDto CancelOrder(Guid orderId, int operationIndex = 0)
        {
            StarkExpress.SDK.Client.Client.ApiResponse<OrderDto> localVarResponse = CancelOrderWithHttpInfo(orderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel Order (Not Implemented) This endpoint cancels an active order.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OrderDto</returns>
        public StarkExpress.SDK.Client.Client.ApiResponse<OrderDto> CancelOrderWithHttpInfo(Guid orderId, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("orderId", StarkExpress.SDK.Client.Client.ClientUtils.ParameterToString(orderId)); // path parameter

            localVarRequestOptions.Operation = "OrderApi.CancelOrder";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Delete<OrderDto>("/api/orders/{orderId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelOrder", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancel Order (Not Implemented) This endpoint cancels an active order.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OrderDto</returns>
        public async System.Threading.Tasks.Task<OrderDto> CancelOrderAsync(Guid orderId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            StarkExpress.SDK.Client.Client.ApiResponse<OrderDto> localVarResponse = await CancelOrderWithHttpInfoAsync(orderId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel Order (Not Implemented) This endpoint cancels an active order.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OrderDto)</returns>
        public async System.Threading.Tasks.Task<StarkExpress.SDK.Client.Client.ApiResponse<OrderDto>> CancelOrderWithHttpInfoAsync(Guid orderId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("orderId", StarkExpress.SDK.Client.Client.ClientUtils.ParameterToString(orderId)); // path parameter

            localVarRequestOptions.Operation = "OrderApi.CancelOrder";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<OrderDto>("/api/orders/{orderId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelOrder", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Order Details (Not Implemented) This endpoint allows for fetching details of an order to be signed.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderDetailsModel">The signable order details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OrderDetailsDto</returns>
        public OrderDetailsDto OrderDetails(OrderDetailsModel orderDetailsModel, int operationIndex = 0)
        {
            StarkExpress.SDK.Client.Client.ApiResponse<OrderDetailsDto> localVarResponse = OrderDetailsWithHttpInfo(orderDetailsModel);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Order Details (Not Implemented) This endpoint allows for fetching details of an order to be signed.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderDetailsModel">The signable order details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OrderDetailsDto</returns>
        public StarkExpress.SDK.Client.Client.ApiResponse<OrderDetailsDto> OrderDetailsWithHttpInfo(OrderDetailsModel orderDetailsModel, int operationIndex = 0)
        {
            // verify the required parameter 'orderDetailsModel' is set
            if (orderDetailsModel == null)
            {
                throw new StarkExpress.SDK.Client.Client.ApiException(400, "Missing required parameter 'orderDetailsModel' when calling OrderApi->OrderDetails");
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

            localVarRequestOptions.Data = orderDetailsModel;

            localVarRequestOptions.Operation = "OrderApi.OrderDetails";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<OrderDetailsDto>("/api/orders/details", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("OrderDetails", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Order Details (Not Implemented) This endpoint allows for fetching details of an order to be signed.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderDetailsModel">The signable order details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OrderDetailsDto</returns>
        public async System.Threading.Tasks.Task<OrderDetailsDto> OrderDetailsAsync(OrderDetailsModel orderDetailsModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            StarkExpress.SDK.Client.Client.ApiResponse<OrderDetailsDto> localVarResponse = await OrderDetailsWithHttpInfoAsync(orderDetailsModel, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Order Details (Not Implemented) This endpoint allows for fetching details of an order to be signed.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderDetailsModel">The signable order details request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OrderDetailsDto)</returns>
        public async System.Threading.Tasks.Task<StarkExpress.SDK.Client.Client.ApiResponse<OrderDetailsDto>> OrderDetailsWithHttpInfoAsync(OrderDetailsModel orderDetailsModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'orderDetailsModel' is set
            if (orderDetailsModel == null)
            {
                throw new StarkExpress.SDK.Client.Client.ApiException(400, "Missing required parameter 'orderDetailsModel' when calling OrderApi->OrderDetails");
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

            localVarRequestOptions.Data = orderDetailsModel;

            localVarRequestOptions.Operation = "OrderApi.OrderDetails";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<OrderDetailsDto>("/api/orders/details", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("OrderDetails", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Submit Order (Not Implemented) This endpoint submits an order to the matching engine.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="submitOrderModel">The order submission request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OrderDto</returns>
        public OrderDto SubmitOrder(SubmitOrderModel submitOrderModel, int operationIndex = 0)
        {
            StarkExpress.SDK.Client.Client.ApiResponse<OrderDto> localVarResponse = SubmitOrderWithHttpInfo(submitOrderModel);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Submit Order (Not Implemented) This endpoint submits an order to the matching engine.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="submitOrderModel">The order submission request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OrderDto</returns>
        public StarkExpress.SDK.Client.Client.ApiResponse<OrderDto> SubmitOrderWithHttpInfo(SubmitOrderModel submitOrderModel, int operationIndex = 0)
        {
            // verify the required parameter 'submitOrderModel' is set
            if (submitOrderModel == null)
            {
                throw new StarkExpress.SDK.Client.Client.ApiException(400, "Missing required parameter 'submitOrderModel' when calling OrderApi->SubmitOrder");
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

            localVarRequestOptions.Data = submitOrderModel;

            localVarRequestOptions.Operation = "OrderApi.SubmitOrder";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<OrderDto>("/api/orders", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SubmitOrder", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Submit Order (Not Implemented) This endpoint submits an order to the matching engine.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="submitOrderModel">The order submission request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OrderDto</returns>
        public async System.Threading.Tasks.Task<OrderDto> SubmitOrderAsync(SubmitOrderModel submitOrderModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            StarkExpress.SDK.Client.Client.ApiResponse<OrderDto> localVarResponse = await SubmitOrderWithHttpInfoAsync(submitOrderModel, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Submit Order (Not Implemented) This endpoint submits an order to the matching engine.
        /// </summary>
        /// <exception cref="StarkExpress.SDK.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="submitOrderModel">The order submission request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OrderDto)</returns>
        public async System.Threading.Tasks.Task<StarkExpress.SDK.Client.Client.ApiResponse<OrderDto>> SubmitOrderWithHttpInfoAsync(SubmitOrderModel submitOrderModel, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'submitOrderModel' is set
            if (submitOrderModel == null)
            {
                throw new StarkExpress.SDK.Client.Client.ApiException(400, "Missing required parameter 'submitOrderModel' when calling OrderApi->SubmitOrder");
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

            localVarRequestOptions.Data = submitOrderModel;

            localVarRequestOptions.Operation = "OrderApi.SubmitOrder";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<OrderDto>("/api/orders", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SubmitOrder", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
