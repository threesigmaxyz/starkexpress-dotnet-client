# StarkExpress.SDK.Client.Api.FeeApi

All URIs are relative to *https://testnet-api.starkexpress.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConfigureFeeModel**](FeeApi.md#configurefeemodel) | **POST** /api/fees | Configure Fee Model |
| [**GetFeeModel**](FeeApi.md#getfeemodel) | **GET** /api/fees/{feeId} | Get Fee Model |

<a name="configurefeemodel"></a>
# **ConfigureFeeModel**
> FeeConfigDto ConfigureFeeModel (ConfigureFeeModel configureFeeModel)

Configure Fee Model

This endpoint allows to configure the fee model for a specific operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class ConfigureFeeModelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            var apiInstance = new FeeApi(config);
            var configureFeeModel = new ConfigureFeeModel(); // ConfigureFeeModel | The fee model configuration request.

            try
            {
                // Configure Fee Model
                FeeConfigDto result = apiInstance.ConfigureFeeModel(configureFeeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeeApi.ConfigureFeeModel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfigureFeeModelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Configure Fee Model
    ApiResponse<FeeConfigDto> response = apiInstance.ConfigureFeeModelWithHttpInfo(configureFeeModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeeApi.ConfigureFeeModelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configureFeeModel** | [**ConfigureFeeModel**](ConfigureFeeModel.md) | The fee model configuration request. |  |

### Return type

[**FeeConfigDto**](FeeConfigDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the configured operation fee. |  -  |
| **400** | The fee model configuration request was invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeemodel"></a>
# **GetFeeModel**
> FeeConfigDto GetFeeModel (Guid feeId)

Get Fee Model

This endpoint fetches a configured operation fee by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class GetFeeModelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            var apiInstance = new FeeApi(config);
            var feeId = "feeId_example";  // Guid | The fee model configuration ID.

            try
            {
                // Get Fee Model
                FeeConfigDto result = apiInstance.GetFeeModel(feeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeeApi.GetFeeModel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFeeModelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Fee Model
    ApiResponse<FeeConfigDto> response = apiInstance.GetFeeModelWithHttpInfo(feeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeeApi.GetFeeModelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **feeId** | **Guid** | The fee model configuration ID. |  |

### Return type

[**FeeConfigDto**](FeeConfigDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a configured operation fee. |  -  |
| **404** | Not Found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

