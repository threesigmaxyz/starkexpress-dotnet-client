# StarkExpress.SDK.Client.Api.UserApi

All URIs are relative to *https://testnet-api.starkexpress.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EIP712Details**](UserApi.md#eip712details) | **GET** /api/v1/users/register-details | Get EIP712 data to be signed |
| [**GetAllUsers**](UserApi.md#getallusers) | **GET** /api/v1/users | Get All Users |
| [**GetUser**](UserApi.md#getuser) | **GET** /api/v1/users/{userId} | Get User |
| [**RegisterUser**](UserApi.md#registeruser) | **POST** /api/v1/users | Register new User |

<a name="eip712details"></a>
# **EIP712Details**
> RegisterDetailsDto EIP712Details (string username, string starkKey, string address)

Get EIP712 data to be signed

This endpoint return the typed data to be signed with EIP712 that is used on user registration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class EIP712DetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | 
            var starkKey = "starkKey_example";  // string | 
            var address = "address_example";  // string | 

            try
            {
                // Get EIP712 data to be signed
                RegisterDetailsDto result = apiInstance.EIP712Details(username, starkKey, address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.EIP712Details: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EIP712DetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get EIP712 data to be signed
    ApiResponse<RegisterDetailsDto> response = apiInstance.EIP712DetailsWithHttpInfo(username, starkKey, address);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.EIP712DetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** |  |  |
| **starkKey** | **string** |  |  |
| **address** | **string** |  |  |

### Return type

[**RegisterDetailsDto**](RegisterDetailsDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the EIP712 typed data. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallusers"></a>
# **GetAllUsers**
> UserDtoPaginatedResponseDto GetAllUsers (int pageNumber, int pageSize, string username = null, FilterOptions? usernameComparison = null, string address = null, string creationDate = null, FilterOptions? creationDateComparison = null, string sortBy = null)

Get All Users

This endpoint fetches all users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class GetAllUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi(config);
            var pageNumber = 56;  // int | 
            var pageSize = 56;  // int | 
            var username = "username_example";  // string |  (optional) 
            var usernameComparison = (FilterOptions) "StartsWith";  // FilterOptions? |  (optional) 
            var address = "address_example";  // string |  (optional) 
            var creationDate = "creationDate_example";  // string |  (optional) 
            var creationDateComparison = (FilterOptions) "StartsWith";  // FilterOptions? |  (optional) 
            var sortBy = "sortBy_example";  // string |  (optional) 

            try
            {
                // Get All Users
                UserDtoPaginatedResponseDto result = apiInstance.GetAllUsers(pageNumber, pageSize, username, usernameComparison, address, creationDate, creationDateComparison, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.GetAllUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get All Users
    ApiResponse<UserDtoPaginatedResponseDto> response = apiInstance.GetAllUsersWithHttpInfo(pageNumber, pageSize, username, usernameComparison, address, creationDate, creationDateComparison, sortBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.GetAllUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageNumber** | **int** |  |  |
| **pageSize** | **int** |  |  |
| **username** | **string** |  | [optional]  |
| **usernameComparison** | **FilterOptions?** |  | [optional]  |
| **address** | **string** |  | [optional]  |
| **creationDate** | **string** |  | [optional]  |
| **creationDateComparison** | **FilterOptions?** |  | [optional]  |
| **sortBy** | **string** |  | [optional]  |

### Return type

[**UserDtoPaginatedResponseDto**](UserDtoPaginatedResponseDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all users. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> UserWithVaultsDto GetUser (Guid userId)

Get User

This endpoint fetches a specific user by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi(config);
            var userId = "userId_example";  // Guid | The user id.

            try
            {
                // Get User
                UserWithVaultsDto result = apiInstance.GetUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.GetUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User
    ApiResponse<UserWithVaultsDto> response = apiInstance.GetUserWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.GetUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | The user id. |  |

### Return type

[**UserWithVaultsDto**](UserWithVaultsDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an user. |  -  |
| **404** | Not Found. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registeruser"></a>
# **RegisterUser**
> UserDto RegisterUser (RegisterUserModel registerUserModel)

Register new User

This endpoint registers a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class RegisterUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://testnet-api.starkexpress.io";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi(config);
            var registerUserModel = new RegisterUserModel(); // RegisterUserModel | The user registration request.

            try
            {
                // Register new User
                UserDto result = apiInstance.RegisterUser(registerUserModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.RegisterUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Register new User
    ApiResponse<UserDto> response = apiInstance.RegisterUserWithHttpInfo(registerUserModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.RegisterUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registerUserModel** | [**RegisterUserModel**](RegisterUserModel.md) | The user registration request. |  |

### Return type

[**UserDto**](UserDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the newly registered user. |  -  |
| **400** | The user registration request was invalid. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

