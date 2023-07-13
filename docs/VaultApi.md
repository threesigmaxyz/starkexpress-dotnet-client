# StarkExpress.SDK.Client.Api.VaultApi

All URIs are relative to *https://testnet-api.starkexpress.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AllocateVault**](VaultApi.md#allocatevault) | **POST** /api/v1/vaults | Allocate vault |
| [**GetAllVaults**](VaultApi.md#getallvaults) | **GET** /api/v1/vaults | Get All Vaults |
| [**GetVault**](VaultApi.md#getvault) | **GET** /api/v1/vaults/{vaultId} | Get a single Vault |

<a name="allocatevault"></a>
# **AllocateVault**
> VaultDto AllocateVault (AllocateVaultModel allocateVaultModel = null)

Allocate vault

This endpoint allocates a new vault for a given asset, if there isn't one already allocated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");

            var apiInstance = new VaultApi(config);
            var allocateVaultModel = new AllocateVaultModel(); // AllocateVaultModel |  (optional) 

            try
            {
                // Allocate vault
                VaultDto result = apiInstance.AllocateVault(allocateVaultModel);
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
    // Allocate vault
    ApiResponse<VaultDto> response = apiInstance.AllocateVaultWithHttpInfo(allocateVaultModel);
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
| **allocateVaultModel** | [**AllocateVaultModel**](AllocateVaultModel.md) |  | [optional]  |

### Return type

[**VaultDto**](VaultDto.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the newly allocated vault. |  -  |
| **400** | The vault allocation request was invalid. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallvaults"></a>
# **GetAllVaults**
> VaultDtoPaginatedResponseDto GetAllVaults (Guid? assetId = null, int? pageNumber = null, int? pageSize = null, string sortBy = null)

Get All Vaults

This endpoint fetches all vaults in the system, with support for filters and pagination.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");

            var apiInstance = new VaultApi(config);
            var assetId = "assetId_example";  // Guid? |  (optional) 
            var pageNumber = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var sortBy = "sortBy_example";  // string |  (optional) 

            try
            {
                // Get All Vaults
                VaultDtoPaginatedResponseDto result = apiInstance.GetAllVaults(assetId, pageNumber, pageSize, sortBy);
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
    ApiResponse<VaultDtoPaginatedResponseDto> response = apiInstance.GetAllVaultsWithHttpInfo(assetId, pageNumber, pageSize, sortBy);
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
| **assetId** | **Guid?** |  | [optional]  |
| **pageNumber** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **sortBy** | **string** |  | [optional]  |

### Return type

[**VaultDtoPaginatedResponseDto**](VaultDtoPaginatedResponseDto.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

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

<a name="getvault"></a>
# **GetVault**
> VaultDto GetVault (Guid vaultId)

Get a single Vault

This endpoint fetches a vault identified by its unique id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class GetVaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");

            var apiInstance = new VaultApi(config);
            var vaultId = "vaultId_example";  // Guid | The vault id.

            try
            {
                // Get a single Vault
                VaultDto result = apiInstance.GetVault(vaultId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultApi.GetVault: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVaultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a single Vault
    ApiResponse<VaultDto> response = apiInstance.GetVaultWithHttpInfo(vaultId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VaultApi.GetVaultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vaultId** | **Guid** | The vault id. |  |

### Return type

[**VaultDto**](VaultDto.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single vault identified by its id. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

