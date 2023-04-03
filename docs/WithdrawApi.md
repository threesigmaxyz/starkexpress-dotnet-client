# StarkExpress.SDK.Client.Api.WithdrawApi

All URIs are relative to *https://testnet-api.starkexpress.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Withdraw**](WithdrawApi.md#withdraw) | **POST** /api/vaults/withdraw | Withdraw Asset |

<a name="withdraw"></a>
# **Withdraw**
> WithdrawDetailsDto Withdraw (WithdrawModel withdrawModel)

Withdraw Asset

This endpoint allows for withdrawing assets from StarkExpress.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class WithdrawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WithdrawApi(config);
            var withdrawModel = new WithdrawModel(); // WithdrawModel | The withdraw request.

            try
            {
                // Withdraw Asset
                WithdrawDetailsDto result = apiInstance.Withdraw(withdrawModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WithdrawApi.Withdraw: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WithdrawWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Withdraw Asset
    ApiResponse<WithdrawDetailsDto> response = apiInstance.WithdrawWithHttpInfo(withdrawModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WithdrawApi.WithdrawWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **withdrawModel** | [**WithdrawModel**](WithdrawModel.md) | The withdraw request. |  |

### Return type

[**WithdrawDetailsDto**](WithdrawDetailsDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details of the withdraw operation. |  -  |
| **400** | The withdraw request was invalid. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

