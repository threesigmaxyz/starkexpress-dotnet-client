# StarkExpress.SDK.Client.Api.OrderApi

All URIs are relative to *https://testnet-api.onarc.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelOrder**](OrderApi.md#cancelorder) | **DELETE** /api/v1/orders/{orderId} | Cancel Order (Not Implemented) |
| [**OrderDetails**](OrderApi.md#orderdetails) | **POST** /api/v1/orders/details | Get Order Details (Not Implemented) |
| [**SubmitOrder**](OrderApi.md#submitorder) | **POST** /api/v1/orders | Submit Order (Not Implemented) |

<a name="cancelorder"></a>
# **CancelOrder**
> OrderDto CancelOrder (Guid orderId)

Cancel Order (Not Implemented)

This endpoint cancels an active order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class CancelOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.onarc.io";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OrderApi(httpClient, config, httpClientHandler);
            var orderId = "orderId_example";  // Guid | 

            try
            {
                // Cancel Order (Not Implemented)
                OrderDto result = apiInstance.CancelOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CancelOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Order (Not Implemented)
    ApiResponse<OrderDto> response = apiInstance.CancelOrderWithHttpInfo(orderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CancelOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderId** | **Guid** |  |  |

### Return type

[**OrderDto**](OrderDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the cancelled order. |  -  |
| **404** | Not Found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderdetails"></a>
# **OrderDetails**
> OrderDetailsDto OrderDetails (OrderDetailsModel orderDetailsModel)

Get Order Details (Not Implemented)

This endpoint allows for fetching details of an order to be signed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class OrderDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.onarc.io";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OrderApi(httpClient, config, httpClientHandler);
            var orderDetailsModel = new OrderDetailsModel(); // OrderDetailsModel | The signable order details request.

            try
            {
                // Get Order Details (Not Implemented)
                OrderDetailsDto result = apiInstance.OrderDetails(orderDetailsModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Order Details (Not Implemented)
    ApiResponse<OrderDetailsDto> response = apiInstance.OrderDetailsWithHttpInfo(orderDetailsModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderDetailsModel** | [**OrderDetailsModel**](OrderDetailsModel.md) | The signable order details request. |  |

### Return type

[**OrderDetailsDto**](OrderDetailsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the signable order details. |  -  |
| **400** | The signable order request was invalid. |  -  |
| **404** | Not Found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitorder"></a>
# **SubmitOrder**
> OrderDto SubmitOrder (SubmitOrderModel submitOrderModel)

Submit Order (Not Implemented)

This endpoint submits an order to the matching engine.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class SubmitOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.onarc.io";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OrderApi(httpClient, config, httpClientHandler);
            var submitOrderModel = new SubmitOrderModel(); // SubmitOrderModel | The order submission request.

            try
            {
                // Submit Order (Not Implemented)
                OrderDto result = apiInstance.SubmitOrder(submitOrderModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.SubmitOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubmitOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit Order (Not Implemented)
    ApiResponse<OrderDto> response = apiInstance.SubmitOrderWithHttpInfo(submitOrderModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.SubmitOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submitOrderModel** | [**SubmitOrderModel**](SubmitOrderModel.md) | The order submission request. |  |

### Return type

[**OrderDto**](OrderDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created order. |  -  |
| **400** | The order submission request was invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

