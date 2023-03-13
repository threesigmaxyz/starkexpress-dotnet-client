# StarkExpress.SDK.Client.Api.TransactionApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllTransactions**](TransactionApi.md#getalltransactions) | **GET** /api/transactions | Get All Transactions |
| [**GetTransaction**](TransactionApi.md#gettransaction) | **GET** /api/transactions/{transactionId} | Get Transaction |

<a name="getalltransactions"></a>
# **GetAllTransactions**
> TransactionDtoPaginatedResponseDto GetAllTransactions (int pageNumber, int pageSize, TransactionStatus? transactionStatus = null, FilterOptions? transactionStatusComparison = null, int? starkexTxId = null, FilterOptions? starkexTxIdComparison = null, string sortBy = null)

Get All Transactions

This endpoint fetches all transactions submitted by the system, with support for filters and pagination.

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
    public class GetAllTransactionsExample
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
            var apiInstance = new TransactionApi(httpClient, config, httpClientHandler);
            var pageNumber = 56;  // int | 
            var pageSize = 56;  // int | 
            var transactionStatus = (TransactionStatus) "0";  // TransactionStatus? |  (optional) 
            var transactionStatusComparison = (FilterOptions) "1";  // FilterOptions? |  (optional) 
            var starkexTxId = 56;  // int? |  (optional) 
            var starkexTxIdComparison = (FilterOptions) "1";  // FilterOptions? |  (optional) 
            var sortBy = "sortBy_example";  // string |  (optional) 

            try
            {
                // Get All Transactions
                TransactionDtoPaginatedResponseDto result = apiInstance.GetAllTransactions(pageNumber, pageSize, transactionStatus, transactionStatusComparison, starkexTxId, starkexTxIdComparison, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionApi.GetAllTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get All Transactions
    ApiResponse<TransactionDtoPaginatedResponseDto> response = apiInstance.GetAllTransactionsWithHttpInfo(pageNumber, pageSize, transactionStatus, transactionStatusComparison, starkexTxId, starkexTxIdComparison, sortBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionApi.GetAllTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageNumber** | **int** |  |  |
| **pageSize** | **int** |  |  |
| **transactionStatus** | **TransactionStatus?** |  | [optional]  |
| **transactionStatusComparison** | **FilterOptions?** |  | [optional]  |
| **starkexTxId** | **int?** |  | [optional]  |
| **starkexTxIdComparison** | **FilterOptions?** |  | [optional]  |
| **sortBy** | **string** |  | [optional]  |

### Return type

[**TransactionDtoPaginatedResponseDto**](TransactionDtoPaginatedResponseDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all transactions submitted by the system (paginated). |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransaction"></a>
# **GetTransaction**
> TransactionDto GetTransaction (Guid transactionId)

Get Transaction

This endpoint fetches a specific transaction by ID.

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
    public class GetTransactionExample
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
            var apiInstance = new TransactionApi(httpClient, config, httpClientHandler);
            var transactionId = "transactionId_example";  // Guid | The transaction ID.

            try
            {
                // Get Transaction
                TransactionDto result = apiInstance.GetTransaction(transactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionApi.GetTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transaction
    ApiResponse<TransactionDto> response = apiInstance.GetTransactionWithHttpInfo(transactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionApi.GetTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **Guid** | The transaction ID. |  |

### Return type

[**TransactionDto**](TransactionDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a transaction. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

