# StarkExpress.SDK.Client.Api.DepositApi

All URIs are relative to *https://testnet-api.starkexpress.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DepositDetails**](DepositApi.md#depositdetails) | **POST** /api/v1/vaults/deposit-details | Returns the deposit details for a given asset. |

<a name="depositdetails"></a>
# **DepositDetails**
> DepositDetailsDto DepositDetails (DepositDetailsModel depositDetailsModel)

Returns the deposit details for a given asset.

This endpoint returns the deposit details for a given user, asset, and data availability mode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class DepositDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepositApi(config);
            var depositDetailsModel = new DepositDetailsModel(); // DepositDetailsModel | The deposit details request.

            try
            {
                // Returns the deposit details for a given asset.
                DepositDetailsDto result = apiInstance.DepositDetails(depositDetailsModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepositApi.DepositDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepositDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the deposit details for a given asset.
    ApiResponse<DepositDetailsDto> response = apiInstance.DepositDetailsWithHttpInfo(depositDetailsModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepositApi.DepositDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **depositDetailsModel** | [**DepositDetailsModel**](DepositDetailsModel.md) | The deposit details request. |  |

### Return type

[**DepositDetailsDto**](DepositDetailsDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the deposit details. |  -  |
| **400** | The deposit details request was invalid. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

