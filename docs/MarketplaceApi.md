# StarkExpress.SDK.Client.Api.MarketplaceApi

All URIs are relative to *https://testnet-api.onarc.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BuyOrderDetails**](MarketplaceApi.md#buyorderdetails) | **POST** /api/v1/marketplace/buy-details | Get buy order details |
| [**DeleteSellOffer**](MarketplaceApi.md#deleteselloffer) | **DELETE** /api/v1/marketplace/sell/{offerId} | Delete sell offer |
| [**ListBuyOrders**](MarketplaceApi.md#listbuyorders) | **GET** /api/v1/marketplace/buy-orders | List buy orders |
| [**ListSellOffers**](MarketplaceApi.md#listselloffers) | **GET** /api/v1/marketplace/sell-offers | List sell offers |
| [**RegisterBuyOrder**](MarketplaceApi.md#registerbuyorder) | **POST** /api/v1/marketplace/buy | Register buy order |
| [**RegisterSellOffer**](MarketplaceApi.md#registerselloffer) | **POST** /api/v1/marketplace/sell | Register sell offer |
| [**SellOfferDetails**](MarketplaceApi.md#sellofferdetails) | **POST** /api/v1/marketplace/sell-details | Get sell offer details |

<a name="buyorderdetails"></a>
# **BuyOrderDetails**
> OrderDetailsDto BuyOrderDetails (BuyOrderDetailsModel buyOrderDetailsModel)

Get buy order details

This endpoint returns the details for a buy order in the public marketplace.

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
    public class BuyOrderDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.onarc.io";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketplaceApi(httpClient, config, httpClientHandler);
            var buyOrderDetailsModel = new BuyOrderDetailsModel(); // BuyOrderDetailsModel | The buy order details request.

            try
            {
                // Get buy order details
                OrderDetailsDto result = apiInstance.BuyOrderDetails(buyOrderDetailsModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketplaceApi.BuyOrderDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuyOrderDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get buy order details
    ApiResponse<OrderDetailsDto> response = apiInstance.BuyOrderDetailsWithHttpInfo(buyOrderDetailsModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketplaceApi.BuyOrderDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **buyOrderDetailsModel** | [**BuyOrderDetailsModel**](BuyOrderDetailsModel.md) | The buy order details request. |  |

### Return type

[**OrderDetailsDto**](OrderDetailsDto.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the order details for a buy order in the public marketplace. |  -  |
| **400** | The buy order details request was invalid. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteselloffer"></a>
# **DeleteSellOffer**
> OfferDto DeleteSellOffer (Guid offerId)

Delete sell offer

This endpoint deletes a sell offer in the public marketplace.

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
    public class DeleteSellOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.onarc.io";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketplaceApi(httpClient, config, httpClientHandler);
            var offerId = "offerId_example";  // Guid | The offer id.

            try
            {
                // Delete sell offer
                OfferDto result = apiInstance.DeleteSellOffer(offerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketplaceApi.DeleteSellOffer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSellOfferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete sell offer
    ApiResponse<OfferDto> response = apiInstance.DeleteSellOfferWithHttpInfo(offerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketplaceApi.DeleteSellOfferWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offerId** | **Guid** | The offer id. |  |

### Return type

[**OfferDto**](OfferDto.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The sell offer was successfully deleted. |  -  |
| **400** | The sell offer deletion request was invalid. |  -  |
| **404** | The sell offer doesn&#39;t exist. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbuyorders"></a>
# **ListBuyOrders**
> MarketplaceOrderDtoPaginatedResponseDto ListBuyOrders (string offerId, int? pageNumber = null, int? pageSize = null, string sortBy = null)

List buy orders

This endpoint returns a paginated list of buy orders in the public marketplace.

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
    public class ListBuyOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.onarc.io";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketplaceApi(httpClient, config, httpClientHandler);
            var offerId = "offerId_example";  // string | 
            var pageNumber = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var sortBy = "sortBy_example";  // string |  (optional) 

            try
            {
                // List buy orders
                MarketplaceOrderDtoPaginatedResponseDto result = apiInstance.ListBuyOrders(offerId, pageNumber, pageSize, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketplaceApi.ListBuyOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListBuyOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List buy orders
    ApiResponse<MarketplaceOrderDtoPaginatedResponseDto> response = apiInstance.ListBuyOrdersWithHttpInfo(offerId, pageNumber, pageSize, sortBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketplaceApi.ListBuyOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offerId** | **string** |  |  |
| **pageNumber** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **sortBy** | **string** |  | [optional]  |

### Return type

[**MarketplaceOrderDtoPaginatedResponseDto**](MarketplaceOrderDtoPaginatedResponseDto.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a paginated list of buy orders. |  -  |
| **400** | The buy order filters were invalid. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listselloffers"></a>
# **ListSellOffers**
> OfferDtoPaginatedResponseDto ListSellOffers (string productId, OfferStatus offerStatus = null, string userId = null, int? pageNumber = null, int? pageSize = null, string sortBy = null)

List sell offers

This endpoint returns a paginated list of sell offer in the public marketplace.

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
    public class ListSellOffersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.onarc.io";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketplaceApi(httpClient, config, httpClientHandler);
            var productId = "productId_example";  // string | 
            var offerStatus = new OfferStatus(); // OfferStatus |  (optional) 
            var userId = "userId_example";  // string |  (optional) 
            var pageNumber = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var sortBy = "sortBy_example";  // string |  (optional) 

            try
            {
                // List sell offers
                OfferDtoPaginatedResponseDto result = apiInstance.ListSellOffers(productId, offerStatus, userId, pageNumber, pageSize, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketplaceApi.ListSellOffers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSellOffersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List sell offers
    ApiResponse<OfferDtoPaginatedResponseDto> response = apiInstance.ListSellOffersWithHttpInfo(productId, offerStatus, userId, pageNumber, pageSize, sortBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketplaceApi.ListSellOffersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** |  |  |
| **offerStatus** | [**OfferStatus**](OfferStatus.md) |  | [optional]  |
| **userId** | **string** |  | [optional]  |
| **pageNumber** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **sortBy** | **string** |  | [optional]  |

### Return type

[**OfferDtoPaginatedResponseDto**](OfferDtoPaginatedResponseDto.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a paginated list of sell offers. |  -  |
| **400** | The sell offer filters were invalid. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registerbuyorder"></a>
# **RegisterBuyOrder**
> OfferDto RegisterBuyOrder (RegisterBuyOrderModel registerBuyOrderModel)

Register buy order

This endpoint buys a product listed in the public marketplace.

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
    public class RegisterBuyOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.onarc.io";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketplaceApi(httpClient, config, httpClientHandler);
            var registerBuyOrderModel = new RegisterBuyOrderModel(); // RegisterBuyOrderModel | The buy order registration request.

            try
            {
                // Register buy order
                OfferDto result = apiInstance.RegisterBuyOrder(registerBuyOrderModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketplaceApi.RegisterBuyOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterBuyOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Register buy order
    ApiResponse<OfferDto> response = apiInstance.RegisterBuyOrderWithHttpInfo(registerBuyOrderModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketplaceApi.RegisterBuyOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registerBuyOrderModel** | [**RegisterBuyOrderModel**](RegisterBuyOrderModel.md) | The buy order registration request. |  |

### Return type

[**OfferDto**](OfferDto.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the newly registered buy order. |  -  |
| **400** | The buy order registration request was invalid. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registerselloffer"></a>
# **RegisterSellOffer**
> OfferDto RegisterSellOffer (RegisterSellOfferModel registerSellOfferModel)

Register sell offer

This endpoint registers a sell offer in the public marketplace.

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
    public class RegisterSellOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.onarc.io";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketplaceApi(httpClient, config, httpClientHandler);
            var registerSellOfferModel = new RegisterSellOfferModel(); // RegisterSellOfferModel | The sell offer registration request.

            try
            {
                // Register sell offer
                OfferDto result = apiInstance.RegisterSellOffer(registerSellOfferModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketplaceApi.RegisterSellOffer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterSellOfferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Register sell offer
    ApiResponse<OfferDto> response = apiInstance.RegisterSellOfferWithHttpInfo(registerSellOfferModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketplaceApi.RegisterSellOfferWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registerSellOfferModel** | [**RegisterSellOfferModel**](RegisterSellOfferModel.md) | The sell offer registration request. |  |

### Return type

[**OfferDto**](OfferDto.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the newly registered sell offer. |  -  |
| **400** | The sell offer registration request was invalid. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sellofferdetails"></a>
# **SellOfferDetails**
> OrderDetailsDto SellOfferDetails (SellOfferDetailsModel sellOfferDetailsModel)

Get sell offer details

This endpoint returns the details for a sell offer in the public marketplace.

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
    public class SellOfferDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.onarc.io";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketplaceApi(httpClient, config, httpClientHandler);
            var sellOfferDetailsModel = new SellOfferDetailsModel(); // SellOfferDetailsModel | The sell offer details request.

            try
            {
                // Get sell offer details
                OrderDetailsDto result = apiInstance.SellOfferDetails(sellOfferDetailsModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketplaceApi.SellOfferDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SellOfferDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get sell offer details
    ApiResponse<OrderDetailsDto> response = apiInstance.SellOfferDetailsWithHttpInfo(sellOfferDetailsModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketplaceApi.SellOfferDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sellOfferDetailsModel** | [**SellOfferDetailsModel**](SellOfferDetailsModel.md) | The sell offer details request. |  |

### Return type

[**OrderDetailsDto**](OrderDetailsDto.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details for a sell offer in the public marketplace. |  -  |
| **400** | The sell offer details request was invalid. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

