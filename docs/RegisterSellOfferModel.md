# StarkExpress.SDK.Client.Model.RegisterSellOfferModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SellerId** | **Guid** | The unique identifier of the user who is placing the sell offer. | 
**ProductVaultId** | **Guid** | The unique identifier of the product vault. | 
**ProductAmount** | **string** | The quantized amount of the product being sold. | 
**CurrencyVaultId** | **Guid** | The unique identifier of the currency vault. | 
**CurrencyAmount** | **string** | The quantized amount of the currency for which the product is being sold. | 
**ExpirationTimestamp** | **long** | The timestamp at which this settlement becomes invalid, in seconds since the Unix epoch. | 
**Nonce** | **int** | The unique nonce for the transfer. | 
**ProductName** | **string** | The product name if the product hasn&#39;t been listed before in the marketplace. | [optional] 
**ProductDescription** | **string** | The product description if the product hasn&#39;t been listed before in the marketplace. | [optional] 
**Signature** | [**SignatureModel**](SignatureModel.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

