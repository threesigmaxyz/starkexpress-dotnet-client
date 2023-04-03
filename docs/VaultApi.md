# StarkExpress.SDK.Client.Api.VaultApi

All URIs are relative to *https://testnet-api.starkexpress.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllVaults**](VaultApi.md#getallvaults) | **GET** /api/vaults | Get All Vaults |
| [**GetVault**](VaultApi.md#getvault) | **GET** /api/vaults/{vaultId} | Get a single Vault |

<a name="getallvaults"></a>
# **GetAllVaults**
> VaultDtoPaginatedResponseDto GetAllVaults (int pageNumber, int pageSize, Guid? tenantId = null, Guid? assetId = null, string sortBy = null)

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
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VaultApi(config);
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
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

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

[oauth2](../README.md#oauth2)

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

