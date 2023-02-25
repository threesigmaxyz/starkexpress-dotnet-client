# StarkExpress.SDK.Client.Api.TransferApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Transfer**](TransferApi.md#transfer) | **POST** /api/transfers | Transfer Asset |
| [**TransferDetails**](TransferApi.md#transferdetails) | **POST** /api/transfers/details | Get Transfer Details |

<a name="transfer"></a>
# **Transfer**
> List&lt;VaultDto&gt; Transfer (TransferModel transferModel)

Transfer Asset

This endpoint allows for transferring assets between users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class TransferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransferApi(config);
            var transferModel = new TransferModel(); // TransferModel | The transfer request.

            try
            {
                // Transfer Asset
                List<VaultDto> result = apiInstance.Transfer(transferModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransferApi.Transfer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transfer Asset
    ApiResponse<List<VaultDto>> response = apiInstance.TransferWithHttpInfo(transferModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransferApi.TransferWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferModel** | [**TransferModel**](TransferModel.md) | The transfer request. |  |

### Return type

[**List&lt;VaultDto&gt;**](VaultDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the vaults updated by the transfer operation. |  -  |
| **400** | The transfer request was invalid. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transferdetails"></a>
# **TransferDetails**
> TransferDetailsDto TransferDetails (TransferDetailsModel transferDetailsModel)

Get Transfer Details

This endpoint allows for fetching details of a transfer to be signed (allocates a vault for the receiver)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class TransferDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransferApi(config);
            var transferDetailsModel = new TransferDetailsModel(); // TransferDetailsModel | The signable transfer details request.

            try
            {
                // Get Transfer Details
                TransferDetailsDto result = apiInstance.TransferDetails(transferDetailsModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransferApi.TransferDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransferDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transfer Details
    ApiResponse<TransferDetailsDto> response = apiInstance.TransferDetailsWithHttpInfo(transferDetailsModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransferApi.TransferDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferDetailsModel** | [**TransferDetailsModel**](TransferDetailsModel.md) | The signable transfer details request. |  |

### Return type

[**TransferDetailsDto**](TransferDetailsDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the signable transfer details. |  -  |
| **400** | The signable transfer request was invalid. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

