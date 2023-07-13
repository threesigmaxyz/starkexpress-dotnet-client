# StarkExpress.SDK.Client.Api.MintApi

All URIs are relative to *https://testnet-api.starkexpress.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MintAssets**](MintApi.md#mintassets) | **POST** /api/v1/mint | Mint Assets |

<a name="mintassets"></a>
# **MintAssets**
> Dictionary&lt;string, List&lt;VaultDto&gt;&gt; MintAssets (BatchMintRequestModel batchMintRequestModel)

Mint Assets

This endpoint allows for the minting of fungible and non-fungible assets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class MintAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");

            var apiInstance = new MintApi(config);
            var batchMintRequestModel = new BatchMintRequestModel(); // BatchMintRequestModel | The assets to mint for each user.

            try
            {
                // Mint Assets
                Dictionary<string, List<VaultDto>> result = apiInstance.MintAssets(batchMintRequestModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MintApi.MintAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MintAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mint Assets
    ApiResponse<Dictionary<string, List<VaultDto>>> response = apiInstance.MintAssetsWithHttpInfo(batchMintRequestModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MintApi.MintAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchMintRequestModel** | [**BatchMintRequestModel**](BatchMintRequestModel.md) | The assets to mint for each user. |  |

### Return type

**Dictionary<string, List<VaultDto>>**

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the vaults updated by the mint operation. |  -  |
| **400** | The mint request was invalid. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

