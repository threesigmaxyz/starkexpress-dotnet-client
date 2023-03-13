# StarkExpress.SDK.Client.Api.AssetApi

All URIs are relative to *https://testnet-api.starkexpress.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EnableAsset**](AssetApi.md#enableasset) | **POST** /api/assets | Enable Asset |
| [**GetAllAssets**](AssetApi.md#getallassets) | **GET** /api/assets | Get All Assets |
| [**GetAsset**](AssetApi.md#getasset) | **GET** /api/assets/{assetId} | Get Asset |

<a name="enableasset"></a>
# **EnableAsset**
> TenantAssetDto EnableAsset (EnableAssetModel enableAssetModel)

Enable Asset

This endpoint allows to enable an asset in the tenant system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class EnableAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetApi(config);
            var enableAssetModel = new EnableAssetModel(); // EnableAssetModel | The asset enabling request.

            try
            {
                // Enable Asset
                TenantAssetDto result = apiInstance.EnableAsset(enableAssetModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.EnableAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnableAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable Asset
    ApiResponse<TenantAssetDto> response = apiInstance.EnableAssetWithHttpInfo(enableAssetModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.EnableAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **enableAssetModel** | [**EnableAssetModel**](EnableAssetModel.md) | The asset enabling request. |  |

### Return type

[**TenantAssetDto**](TenantAssetDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the enabled asset. |  -  |
| **400** | The asset enabling request was invalid. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallassets"></a>
# **GetAllAssets**
> TenantAssetDtoPaginatedResponseDto GetAllAssets (int pageNumber, int pageSize, Guid? assetId = null, AssetType? assetType = null, FilterOptions? assetTypeComparison = null, string assetSymbol = null, FilterOptions? assetSymbolComparison = null, string sortBy = null)

Get All Assets

This endpoint fetches all assets enabled in the tenant system, with support for filters and pagination.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class GetAllAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetApi(config);
            var pageNumber = 56;  // int | 
            var pageSize = 56;  // int | 
            var assetId = "assetId_example";  // Guid? |  (optional) 
            var assetType = (AssetType) "0";  // AssetType? |  (optional) 
            var assetTypeComparison = (FilterOptions) "1";  // FilterOptions? |  (optional) 
            var assetSymbol = "assetSymbol_example";  // string |  (optional) 
            var assetSymbolComparison = (FilterOptions) "1";  // FilterOptions? |  (optional) 
            var sortBy = "sortBy_example";  // string |  (optional) 

            try
            {
                // Get All Assets
                TenantAssetDtoPaginatedResponseDto result = apiInstance.GetAllAssets(pageNumber, pageSize, assetId, assetType, assetTypeComparison, assetSymbol, assetSymbolComparison, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.GetAllAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get All Assets
    ApiResponse<TenantAssetDtoPaginatedResponseDto> response = apiInstance.GetAllAssetsWithHttpInfo(pageNumber, pageSize, assetId, assetType, assetTypeComparison, assetSymbol, assetSymbolComparison, sortBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.GetAllAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageNumber** | **int** |  |  |
| **pageSize** | **int** |  |  |
| **assetId** | **Guid?** |  | [optional]  |
| **assetType** | **AssetType?** |  | [optional]  |
| **assetTypeComparison** | **FilterOptions?** |  | [optional]  |
| **assetSymbol** | **string** |  | [optional]  |
| **assetSymbolComparison** | **FilterOptions?** |  | [optional]  |
| **sortBy** | **string** |  | [optional]  |

### Return type

[**TenantAssetDtoPaginatedResponseDto**](TenantAssetDtoPaginatedResponseDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all assets enabled in the tenant system (paginated). |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getasset"></a>
# **GetAsset**
> TenantAssetDto GetAsset (Guid assetId)

Get Asset

This endpoint fetches a specific enabled asset by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class GetAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetApi(config);
            var assetId = "assetId_example";  // Guid | The asset ID.

            try
            {
                // Get Asset
                TenantAssetDto result = apiInstance.GetAsset(assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.GetAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asset
    ApiResponse<TenantAssetDto> response = apiInstance.GetAssetWithHttpInfo(assetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.GetAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **Guid** | The asset ID. |  |

### Return type

[**TenantAssetDto**](TenantAssetDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an asset enabled in the tenant system. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

