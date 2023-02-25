# StarkExpress.SDK.Client.Model.TransferModel
Request model to transfer assets between users.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SenderVaultId** | **Guid** | The unique identifier of the transfer sender vault. | 
**ReceiverVaultId** | **Guid** | The unique identifier of the transfer recipient vault. | 
**QuantizedAmount** | **string** | The amount of the asset to be transferred, in quantized form. | 
**ExpirationTimestamp** | **long** | The timestamp at which this transfer becomes invalid, in seconds since the Unix epoch. | 
**Nonce** | **int** | The unique nonce for the transfer. | 
**Signature** | [**SignatureModel**](SignatureModel.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

