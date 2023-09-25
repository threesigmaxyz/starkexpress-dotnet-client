# StarkExpress.SDK.Client.Model.RegisterBuyOrderModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **Guid** | The unique identifier of the marketplace offer. | 
**BuyerId** | **Guid** | The unique identifier of the user who is placing the buy order. | 
**ProductVaultId** | **Guid** | The unique identifier of the product vault. | 
**CurrencyVaultId** | **Guid** | The unique identifier of the currency vault. | 
**ExpirationTimestamp** | **long** | The timestamp at which this transfer becomes invalid, in seconds since the Unix epoch. | 
**Nonce** | **int** | The unique nonce for the settlement. | 
**Signature** | [**SignatureModel**](SignatureModel.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

