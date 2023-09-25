# StarkExpress.SDK.Client.Api.AssetApi

All URIs are relative to *https://testnet-api.onarc.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeployAsset**](AssetApi.md#deployasset) | **POST** /api/v1/assets/deploy | Deploy Asset |
| [**DisableAsset**](AssetApi.md#disableasset) | **POST** /api/v1/assets/disable | Disable Asset |
| [**EnableAsset**](AssetApi.md#enableasset) | **POST** /api/v1/assets | Enable Asset |
| [**EstimateAssetDeployCost**](AssetApi.md#estimateassetdeploycost) | **GET** /api/v1/assets/estimate-deploy | Estimate cost of the deployment for a new Asset |
| [**GetAllAssets**](AssetApi.md#getallassets) | **GET** /api/v1/assets | Get All Assets |
| [**GetAsset**](AssetApi.md#getasset) | **GET** /api/v1/assets/{assetId} | Get Asset |

<a name="deployasset"></a>
# **DeployAsset**
> TenantAssetDto DeployAsset (DeployAssetModel deployAssetModel)

Deploy Asset

This endpoint allows for deploying an asset and enable it in the tenant system.

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
    public class DeployAssetExample
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
            var apiInstance = new AssetApi(httpClient, config, httpClientHandler);
            var deployAssetModel = new DeployAssetModel(); // DeployAssetModel | The asset deployment request.

            try
            {
                // Deploy Asset
                TenantAssetDto result = apiInstance.DeployAsset(deployAssetModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.DeployAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeployAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deploy Asset
    ApiResponse<TenantAssetDto> response = apiInstance.DeployAssetWithHttpInfo(deployAssetModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.DeployAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deployAssetModel** | [**DeployAssetModel**](DeployAssetModel.md) | The asset deployment request. |  |

### Return type

[**TenantAssetDto**](TenantAssetDto.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the deployed asset. |  -  |
| **400** | The asset deployment request was invalid. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disableasset"></a>
# **DisableAsset**
> TenantAssetDto DisableAsset (DisableAssetModel disableAssetModel)

Disable Asset

This endpoint allows to disable an asset in the tenant system.

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
    public class DisableAssetExample
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
            var apiInstance = new AssetApi(httpClient, config, httpClientHandler);
            var disableAssetModel = new DisableAssetModel(); // DisableAssetModel | The asset disabling request.

            try
            {
                // Disable Asset
                TenantAssetDto result = apiInstance.DisableAsset(disableAssetModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.DisableAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisableAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disable Asset
    ApiResponse<TenantAssetDto> response = apiInstance.DisableAssetWithHttpInfo(disableAssetModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.DisableAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **disableAssetModel** | [**DisableAssetModel**](DisableAssetModel.md) | The asset disabling request. |  |

### Return type

[**TenantAssetDto**](TenantAssetDto.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the disabled asset. |  -  |
| **400** | The asset disabling request was invalid. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enableasset"></a>
# **EnableAsset**
> TenantAssetDto EnableAsset (EnableAssetModel enableAssetModel)

Enable Asset

This endpoint allows to enable an asset in the tenant system.

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
    public class EnableAssetExample
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
            var apiInstance = new AssetApi(httpClient, config, httpClientHandler);
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

[apikey](../README.md#apikey)

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

<a name="estimateassetdeploycost"></a>
# **EstimateAssetDeployCost**
> TenantAssetDto EstimateAssetDeployCost (AssetType assetType)

Estimate cost of the deployment for a new Asset

This endpoint allows for deploying an asset and enable it in the tenant system.

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
    public class EstimateAssetDeployCostExample
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
            var apiInstance = new AssetApi(httpClient, config, httpClientHandler);
            var assetType = new AssetType(); // AssetType | 

            try
            {
                // Estimate cost of the deployment for a new Asset
                TenantAssetDto result = apiInstance.EstimateAssetDeployCost(assetType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.EstimateAssetDeployCost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EstimateAssetDeployCostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Estimate cost of the deployment for a new Asset
    ApiResponse<TenantAssetDto> response = apiInstance.EstimateAssetDeployCostWithHttpInfo(assetType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.EstimateAssetDeployCostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetType** | [**AssetType**](AssetType.md) |  |  |

### Return type

[**TenantAssetDto**](TenantAssetDto.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the estimated cost of the asset deployment. |  -  |
| **400** | The asset deployment estimation request was invalid. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallassets"></a>
# **GetAllAssets**
> TenantAssetDtoPaginatedResponseDto GetAllAssets (Guid? assetId = null, AssetType assetType = null, FilterOptions assetTypeComparison = null, string assetSymbol = null, FilterOptions assetSymbolComparison = null, int? pageNumber = null, int? pageSize = null, string sortBy = null)

Get All Assets

This endpoint fetches all assets enabled in the tenant system, with support for filters and pagination.

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
    public class GetAllAssetsExample
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
            var apiInstance = new AssetApi(httpClient, config, httpClientHandler);
            var assetId = "assetId_example";  // Guid? |  (optional) 
            var assetType = new AssetType(); // AssetType |  (optional) 
            var assetTypeComparison = new FilterOptions(); // FilterOptions |  (optional) 
            var assetSymbol = "assetSymbol_example";  // string |  (optional) 
            var assetSymbolComparison = new FilterOptions(); // FilterOptions |  (optional) 
            var pageNumber = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var sortBy = "sortBy_example";  // string |  (optional) 

            try
            {
                // Get All Assets
                TenantAssetDtoPaginatedResponseDto result = apiInstance.GetAllAssets(assetId, assetType, assetTypeComparison, assetSymbol, assetSymbolComparison, pageNumber, pageSize, sortBy);
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
    ApiResponse<TenantAssetDtoPaginatedResponseDto> response = apiInstance.GetAllAssetsWithHttpInfo(assetId, assetType, assetTypeComparison, assetSymbol, assetSymbolComparison, pageNumber, pageSize, sortBy);
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
| **assetId** | **Guid?** |  | [optional]  |
| **assetType** | [**AssetType**](AssetType.md) |  | [optional]  |
| **assetTypeComparison** | [**FilterOptions**](FilterOptions.md) |  | [optional]  |
| **assetSymbol** | **string** |  | [optional]  |
| **assetSymbolComparison** | [**FilterOptions**](FilterOptions.md) |  | [optional]  |
| **pageNumber** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **sortBy** | **string** |  | [optional]  |

### Return type

[**TenantAssetDtoPaginatedResponseDto**](TenantAssetDtoPaginatedResponseDto.md)

### Authorization

[apikey](../README.md#apikey)

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
using System.Net.Http;
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
            config.BasePath = "https://testnet-api.onarc.io";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AssetApi(httpClient, config, httpClientHandler);
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

[apikey](../README.md#apikey)

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

