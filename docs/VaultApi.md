# StarkExpress.SDK.Client.Api.VaultApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AllocateVault**](VaultApi.md#allocatevault) | **POST** /api/vaults | Allocate Vault |
| [**GetAllVaults**](VaultApi.md#getallvaults) | **GET** /api/vaults | Get All Vaults |

<a name="allocatevault"></a>
# **AllocateVault**
> AllocateVaultDto AllocateVault (AllocateVaultModel allocateVaultModel)

Allocate Vault

This endpoint allocates a vault for a given user, asset, and data availability mode.

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
    public class AllocateVaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new VaultApi(httpClient, config, httpClientHandler);
            var allocateVaultModel = new AllocateVaultModel(); // AllocateVaultModel | The vault allocation request.

            try
            {
                // Allocate Vault
                AllocateVaultDto result = apiInstance.AllocateVault(allocateVaultModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.AllocateVault: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AllocateVaultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Allocate Vault
    ApiResponse<AllocateVaultDto> response = apiInstance.AllocateVaultWithHttpInfo(allocateVaultModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VaultApi.AllocateVaultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **allocateVaultModel** | [**AllocateVaultModel**](AllocateVaultModel.md) | The vault allocation request. |  |

### Return type

[**AllocateVaultDto**](AllocateVaultDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the allocated vault. |  -  |
| **400** | The vault allocation request was invalid. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallvaults"></a>
# **GetAllVaults**
> VaultDtoPaginatedResponseDto GetAllVaults (int pageNumber, int pageSize, Guid? tenantId = null, Guid? assetId = null, string sortBy = null)

Get All Vaults

This endpoint fetches all vaults in the system, with support for filters and pagination.

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
    public class GetAllVaultsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new VaultApi(httpClient, config, httpClientHandler);
            var pageNumber = 56;  // int | 
            var pageSize = 56;  // int | 
            var tenantId = "tenantId_example";  // Guid? |  (optional) 
            var assetId = "assetId_example";  // Guid? |  (optional) 
            var sortBy = "sortBy_example";  // string |  (optional) 

            try
            {
                // Get All Vaults
                VaultDtoPaginatedResponseDto result = apiInstance.GetAllVaults(pageNumber, pageSize, tenantId, assetId, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.GetAllVaults: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllVaultsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get All Vaults
    ApiResponse<VaultDtoPaginatedResponseDto> response = apiInstance.GetAllVaultsWithHttpInfo(pageNumber, pageSize, tenantId, assetId, sortBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VaultApi.GetAllVaultsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageNumber** | **int** |  |  |
| **pageSize** | **int** |  |  |
| **tenantId** | **Guid?** |  | [optional]  |
| **assetId** | **Guid?** |  | [optional]  |
| **sortBy** | **string** |  | [optional]  |

### Return type

[**VaultDtoPaginatedResponseDto**](VaultDtoPaginatedResponseDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all vaults in the system (paginated). |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

