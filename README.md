# StarkExpress.SDK.Client [![Github Actions][gha-badge]][gha] [![Docs][dotnet-badge]][dotnet] [![License: MIT][license-badge]][license]
[gha]: https://github.com/threesigmaxyz/starkexpress-dotnet-client/actions
[gha-badge]: https://github.com/threesigmaxyz/starkexpress-dotnet-client/actions/workflows/main.yml/badge.svg
[dotnet]: https://github.com/dotnet/core
[dotnet-badge]: https://img.shields.io/static/v1?label=Built%20with&message=.NET&color=blueviolet
[license]: https://opensource.org/licenses/MIT
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg

An API for the StarkExpress platform.

- API version: 1.0
- SDK version: 1.0.0

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="installation"></a>
## Installation
You can install the publicly available nuget packages via the following command.
We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages.
```bash
dotnet add package StarkExpress.SDK.Client
```

Then add the packages to your project, use the namespaces:
```csharp
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;
```

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StarkExpress.SDK.Client.Api;
using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.starkexpress.io";
            // Configure API key authorization: apikey
            config.ApiKey.Add("x-api-key", "YOUR_API_KEY");

            var apiInstance = new AssetApi(config);
            var deployAssetModel = new DeployAssetModel(); // DeployAssetModel | The asset deployment request.

            try
            {
                // Deploy Asset
                TenantAssetDto result = apiInstance.DeployAsset(deployAssetModel);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AssetApi.DeployAsset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints
| Base URL | Description |
|------------|-------------|
| https://testnet-api.starkexpress.io | Testnet server (uses test data). |
| https://api.starkexpress.io | Mainnet server (uses live data). |

All URIs are relative to base url:

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AssetApi* | [**DeployAsset**](docs/AssetApi.md#deployasset) | **POST** /api/v1/assets/deploy | Deploy Asset
*AssetApi* | [**EnableAsset**](docs/AssetApi.md#enableasset) | **POST** /api/v1/assets | Enable Asset
*AssetApi* | [**GetAllAssets**](docs/AssetApi.md#getallassets) | **GET** /api/v1/assets | Get All Assets
*AssetApi* | [**GetAsset**](docs/AssetApi.md#getasset) | **GET** /api/v1/assets/{assetId} | Get Asset
*DepositApi* | [**DepositDetails**](docs/DepositApi.md#depositdetails) | **POST** /api/v1/vaults/deposit-details | Returns the deposit details for a given asset.
*FeeApi* | [**ConfigureFeeModel**](docs/FeeApi.md#configurefeemodel) | **POST** /api/v1/fees | Configure Fee Model
*FeeApi* | [**GetFeeModel**](docs/FeeApi.md#getfeemodel) | **GET** /api/v1/fees/{feeId} | Get Fee Model
*MintApi* | [**MintAssets**](docs/MintApi.md#mintassets) | **POST** /api/v1/mint | Mint Assets
*OrderApi* | [**CancelOrder**](docs/OrderApi.md#cancelorder) | **DELETE** /api/v1/orders/{orderId} | Cancel Order (Not Implemented)
*OrderApi* | [**OrderDetails**](docs/OrderApi.md#orderdetails) | **POST** /api/v1/orders/details | Get Order Details (Not Implemented)
*OrderApi* | [**SubmitOrder**](docs/OrderApi.md#submitorder) | **POST** /api/v1/orders | Submit Order (Not Implemented)
*OrderbookApi* | [**CreateOrderbook**](docs/OrderbookApi.md#createorderbook) | **POST** /api/v1/orderbooks | Create Orderbook (Not Implemented)
*OrderbookApi* | [**GetOrderbook**](docs/OrderbookApi.md#getorderbook) | **GET** /api/v1/orderbooks/{orderbookId} | Get Orderbook (Not Implemented)
*OrderbookApi* | [**GetOrderbookLevel1Data**](docs/OrderbookApi.md#getorderbooklevel1data) | **GET** /api/v1/orderbooks/{orderbookId}/l1 | Get Orderbook L1 Data (Not Implemented)
*OrderbookApi* | [**GetOrderbookLevel2Data**](docs/OrderbookApi.md#getorderbooklevel2data) | **GET** /api/v1/orderbooks/{orderbookId}/l2 | Get Orderbook L2 Data (Not Implemented)
*SettlementApi* | [**SubmitSettlement**](docs/SettlementApi.md#submitsettlement) | **POST** /api/v1/settlements | Submit Settlement
*TransactionApi* | [**GetAllTransactions**](docs/TransactionApi.md#getalltransactions) | **GET** /api/v1/transactions | Get All Transactions
*TransactionApi* | [**GetTransaction**](docs/TransactionApi.md#gettransaction) | **GET** /api/v1/transactions/{transactionId} | Get Transaction
*TransferApi* | [**Transfer**](docs/TransferApi.md#transfer) | **POST** /api/v1/transfers | Transfer Asset
*TransferApi* | [**TransferDetails**](docs/TransferApi.md#transferdetails) | **POST** /api/v1/transfers/details | Get Transfer Details
*UserApi* | [**EIP712Details**](docs/UserApi.md#eip712details) | **GET** /api/v1/users/register-details | Get EIP712 data to be signed
*UserApi* | [**GetAllUsers**](docs/UserApi.md#getallusers) | **GET** /api/v1/users | Get All Users
*UserApi* | [**GetUser**](docs/UserApi.md#getuser) | **GET** /api/v1/users/{userId} | Get User
*UserApi* | [**RegisterUser**](docs/UserApi.md#registeruser) | **POST** /api/v1/users | Register new User
*VaultApi* | [**AllocateVault**](docs/VaultApi.md#allocatevault) | **POST** /api/v1/vaults | Allocate vault
*VaultApi* | [**GetAllVaults**](docs/VaultApi.md#getallvaults) | **GET** /api/v1/vaults | Get All Vaults
*VaultApi* | [**GetVault**](docs/VaultApi.md#getvault) | **GET** /api/v1/vaults/{vaultId} | Get a single Vault
*WithdrawApi* | [**Withdraw**](docs/WithdrawApi.md#withdraw) | **POST** /api/v1/vaults/withdraw | Withdraw Asset


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AllocateVaultModel](docs/AllocateVaultModel.md)
 - [Model.AssetType](docs/AssetType.md)
 - [Model.BatchMintRequestModel](docs/BatchMintRequestModel.md)
 - [Model.BigInteger](docs/BigInteger.md)
 - [Model.ConfigureFeeModel](docs/ConfigureFeeModel.md)
 - [Model.CreateOrderbookModel](docs/CreateOrderbookModel.md)
 - [Model.DataAvailabilityModes](docs/DataAvailabilityModes.md)
 - [Model.DeployAssetModel](docs/DeployAssetModel.md)
 - [Model.DepositDetailsDto](docs/DepositDetailsDto.md)
 - [Model.DepositDetailsModel](docs/DepositDetailsModel.md)
 - [Model.DomainDto](docs/DomainDto.md)
 - [Model.EnableAssetModel](docs/EnableAssetModel.md)
 - [Model.FeeAction](docs/FeeAction.md)
 - [Model.FeeConfigDto](docs/FeeConfigDto.md)
 - [Model.FeeDto](docs/FeeDto.md)
 - [Model.FilterOptions](docs/FilterOptions.md)
 - [Model.MemberDescriptionDto](docs/MemberDescriptionDto.md)
 - [Model.MemberValueDto](docs/MemberValueDto.md)
 - [Model.MessageDto](docs/MessageDto.md)
 - [Model.MintDataModel](docs/MintDataModel.md)
 - [Model.MintRequestDataModel](docs/MintRequestDataModel.md)
 - [Model.OrderDetailsDto](docs/OrderDetailsDto.md)
 - [Model.OrderDetailsModel](docs/OrderDetailsModel.md)
 - [Model.OrderDto](docs/OrderDto.md)
 - [Model.OrderFillDto](docs/OrderFillDto.md)
 - [Model.OrderSide](docs/OrderSide.md)
 - [Model.OrderbookAssetDto](docs/OrderbookAssetDto.md)
 - [Model.OrderbookDto](docs/OrderbookDto.md)
 - [Model.OrderbookLevel1DataDto](docs/OrderbookLevel1DataDto.md)
 - [Model.OrderbookLevel2DataDto](docs/OrderbookLevel2DataDto.md)
 - [Model.OrderbookLevel2EntryDto](docs/OrderbookLevel2EntryDto.md)
 - [Model.PaginationDto](docs/PaginationDto.md)
 - [Model.ProblemDetails](docs/ProblemDetails.md)
 - [Model.RegisterDetailsDto](docs/RegisterDetailsDto.md)
 - [Model.RegisterUserModel](docs/RegisterUserModel.md)
 - [Model.SettlementInfoModel](docs/SettlementInfoModel.md)
 - [Model.SettlementOrderModel](docs/SettlementOrderModel.md)
 - [Model.SignatureModel](docs/SignatureModel.md)
 - [Model.StarkExOperation](docs/StarkExOperation.md)
 - [Model.SubmitOrderModel](docs/SubmitOrderModel.md)
 - [Model.SubmitSettlementModel](docs/SubmitSettlementModel.md)
 - [Model.TenantAssetDto](docs/TenantAssetDto.md)
 - [Model.TenantAssetDtoPaginatedResponseDto](docs/TenantAssetDtoPaginatedResponseDto.md)
 - [Model.TransactionDto](docs/TransactionDto.md)
 - [Model.TransactionDtoPaginatedResponseDto](docs/TransactionDtoPaginatedResponseDto.md)
 - [Model.TransactionModel](docs/TransactionModel.md)
 - [Model.TransactionStatus](docs/TransactionStatus.md)
 - [Model.TransferDetailsDto](docs/TransferDetailsDto.md)
 - [Model.TransferDetailsModel](docs/TransferDetailsModel.md)
 - [Model.TransferModel](docs/TransferModel.md)
 - [Model.UserDto](docs/UserDto.md)
 - [Model.UserDtoPaginatedResponseDto](docs/UserDtoPaginatedResponseDto.md)
 - [Model.UserWithVaultsDto](docs/UserWithVaultsDto.md)
 - [Model.VaultDto](docs/VaultDto.md)
 - [Model.VaultDtoPaginatedResponseDto](docs/VaultDtoPaginatedResponseDto.md)
 - [Model.WithdrawDetailsDto](docs/WithdrawDetailsDto.md)
 - [Model.WithdrawModel](docs/WithdrawModel.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="apikey"></a>
### apikey

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header

<a name="oauth2"></a>
### oauth2



---
<a name="documentation-for-about-us"></a>
## About Us
[Three Sigma](https://threesigma.xyz/) is a venture builder firm focused on blockchain engineering, research, and investment. Our mission is to advance the adoption of blockchain technology and contribute towards the healthy development of the Web3 space.
If you are interested in joining our team, please contact us [here](mailto:info@threesigma.xyz).

---

<p align="center">
    <a href="https://starkexpress.io" target="_blank">
        <img src="https://threesigma.xyz/_next/image?url=%2F_next%2Fstatic%2Fmedia%2Fthree-sigma-labs-research-capital-white.0f8e8f50.png&w=2048&q=75" width="75%" />
    </a>
</p>