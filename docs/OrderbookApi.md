# StarkExpress.SDK.Client.Api.OrderbookApi

All URIs are relative to *https://testnet-api.starkexpress.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrderbook**](OrderbookApi.md#createorderbook) | **POST** /api/v1/orderbooks | Create Orderbook (Not Implemented) |
| [**GetOrderbook**](OrderbookApi.md#getorderbook) | **GET** /api/v1/orderbooks/{orderbookId} | Get Orderbook (Not Implemented) |
| [**GetOrderbookLevel1Data**](OrderbookApi.md#getorderbooklevel1data) | **GET** /api/v1/orderbooks/{orderbookId}/l1 | Get Orderbook L1 Data (Not Implemented) |
| [**GetOrderbookLevel2Data**](OrderbookApi.md#getorderbooklevel2data) | **GET** /api/v1/orderbooks/{orderbookId}/l2 | Get Orderbook L2 Data (Not Implemented) |

<a name="createorderbook"></a>
# **CreateOrderbook**
> OrderbookDto CreateOrderbook (CreateOrderbookModel createOrderbookModel)

Create Orderbook (Not Implemented)

This endpoint creates an orderbook.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class CreateOrderbookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            var apiInstance = new OrderbookApi(config);
            var createOrderbookModel = new CreateOrderbookModel(); // CreateOrderbookModel | The orderbook creation request.

            try
            {
                // Create Orderbook (Not Implemented)
                OrderbookDto result = apiInstance.CreateOrderbook(createOrderbookModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderbookApi.CreateOrderbook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderbookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Orderbook (Not Implemented)
    ApiResponse<OrderbookDto> response = apiInstance.CreateOrderbookWithHttpInfo(createOrderbookModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderbookApi.CreateOrderbookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createOrderbookModel** | [**CreateOrderbookModel**](CreateOrderbookModel.md) | The orderbook creation request. |  |

### Return type

[**OrderbookDto**](OrderbookDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created orderbook. |  -  |
| **400** | The orderbook creation request was invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderbook"></a>
# **GetOrderbook**
> OrderbookDto GetOrderbook (Guid orderbookId)

Get Orderbook (Not Implemented)

This endpoint fetches orderbook metadata by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class GetOrderbookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            var apiInstance = new OrderbookApi(config);
            var orderbookId = "orderbookId_example";  // Guid | 

            try
            {
                // Get Orderbook (Not Implemented)
                OrderbookDto result = apiInstance.GetOrderbook(orderbookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderbookApi.GetOrderbook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderbookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Orderbook (Not Implemented)
    ApiResponse<OrderbookDto> response = apiInstance.GetOrderbookWithHttpInfo(orderbookId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderbookApi.GetOrderbookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderbookId** | **Guid** |  |  |

### Return type

[**OrderbookDto**](OrderbookDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns orderbook metadata. |  -  |
| **404** | Not Found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderbooklevel1data"></a>
# **GetOrderbookLevel1Data**
> OrderbookLevel1DataDto GetOrderbookLevel1Data (Guid orderbookId)

Get Orderbook L1 Data (Not Implemented)

This endpoint fetches orderbook level 1 data by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class GetOrderbookLevel1DataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            var apiInstance = new OrderbookApi(config);
            var orderbookId = "orderbookId_example";  // Guid | 

            try
            {
                // Get Orderbook L1 Data (Not Implemented)
                OrderbookLevel1DataDto result = apiInstance.GetOrderbookLevel1Data(orderbookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderbookApi.GetOrderbookLevel1Data: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderbookLevel1DataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Orderbook L1 Data (Not Implemented)
    ApiResponse<OrderbookLevel1DataDto> response = apiInstance.GetOrderbookLevel1DataWithHttpInfo(orderbookId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderbookApi.GetOrderbookLevel1DataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderbookId** | **Guid** |  |  |

### Return type

[**OrderbookLevel1DataDto**](OrderbookLevel1DataDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns orderbook level 1 data. |  -  |
| **404** | Not Found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderbooklevel2data"></a>
# **GetOrderbookLevel2Data**
> OrderbookLevel2DataDto GetOrderbookLevel2Data (Guid orderbookId, int? depth = null)

Get Orderbook L2 Data (Not Implemented)

This endpoint fetches orderbook level 2 data by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class GetOrderbookLevel2DataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            var apiInstance = new OrderbookApi(config);
            var orderbookId = "orderbookId_example";  // Guid | 
            var depth = 56;  // int? |  (optional) 

            try
            {
                // Get Orderbook L2 Data (Not Implemented)
                OrderbookLevel2DataDto result = apiInstance.GetOrderbookLevel2Data(orderbookId, depth);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderbookApi.GetOrderbookLevel2Data: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderbookLevel2DataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Orderbook L2 Data (Not Implemented)
    ApiResponse<OrderbookLevel2DataDto> response = apiInstance.GetOrderbookLevel2DataWithHttpInfo(orderbookId, depth);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderbookApi.GetOrderbookLevel2DataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderbookId** | **Guid** |  |  |
| **depth** | **int?** |  | [optional]  |

### Return type

[**OrderbookLevel2DataDto**](OrderbookLevel2DataDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns orderbook level 2 data. |  -  |
| **404** | Not Found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

