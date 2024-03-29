# StarkExpress.SDK.Client.Api.SettlementApi

All URIs are relative to *https://testnet-api.onarc.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubmitSettlement**](SettlementApi.md#submitsettlement) | **POST** /api/v1/settlements | Submit Settlement |

<a name="submitsettlement"></a>
# **SubmitSettlement**
> List&lt;VaultDto&gt; SubmitSettlement (SubmitSettlementModel submitSettlementModel)

Submit Settlement

This endpoint submits an order settlement.

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
    public class SubmitSettlementExample
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
            var apiInstance = new SettlementApi(httpClient, config, httpClientHandler);
            var submitSettlementModel = new SubmitSettlementModel(); // SubmitSettlementModel | The settlement request.

            try
            {
                // Submit Settlement
                List<VaultDto> result = apiInstance.SubmitSettlement(submitSettlementModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettlementApi.SubmitSettlement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubmitSettlementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit Settlement
    ApiResponse<List<VaultDto>> response = apiInstance.SubmitSettlementWithHttpInfo(submitSettlementModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettlementApi.SubmitSettlementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submitSettlementModel** | [**SubmitSettlementModel**](SubmitSettlementModel.md) | The settlement request. |  |

### Return type

[**List&lt;VaultDto&gt;**](VaultDto.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the vaults updated by the settlement operation. |  -  |
| **400** | The settlement request was invalid. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

