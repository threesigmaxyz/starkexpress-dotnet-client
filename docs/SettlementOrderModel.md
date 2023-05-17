# StarkExpress.SDK.Client.Model.SettlementOrderModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BuyVaultId** | **Guid** | The unique identifier of the transfer sender vault. | 
**BuyQuantizedAmount** | **string** | The amount of the asset to be transferred, in quantized form. | 
**SellVaultId** | **Guid** | The unique identifier of the transfer sender vault. | 
**SellQuantizedAmount** | **string** | The amount of the asset to be transferred, in quantized form. | 
**FeeVaultId** | **Guid?** | The unique identifier of the transfer sender vault. | [optional] 
**FeeQuantizedAmount** | **string** | The amount of the fee asset to be collected, in quantized form. | [optional] 
**Nonce** | **int** | The unique nonce for the transfer. | 
**Signature** | [**SignatureModel**](SignatureModel.md) |  | 
**ExpirationTimestamp** | **long** | The timestamp at which this transfer becomes invalid, in seconds since the Unix epoch. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

