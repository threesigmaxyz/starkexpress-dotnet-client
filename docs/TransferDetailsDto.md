# StarkExpress.SDK.Client.Model.TransferDetailsDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SenderStarkKey** | **string** | The STARK key of the sender. | [optional] 
**SenderVaultChainId** | **string** | The vault chain ID of the sender. | [optional] 
**SenderVaultId** | **Guid** | The vault ID of the sender. | [optional] 
**ReceiverStarkKey** | **string** | The STARK key of the receiver. | [optional] 
**ReceiverVaultChainId** | **string** | The vault chain ID of the receiver. | [optional] 
**ReceiverVaultId** | **Guid** | The vault ID of the receiver. | [optional] 
**AssetId** | **string** | The StarkEx ID of the asset being transferred. | [optional] 
**QuantizedAmount** | **string** | The amount of the asset to be transferred, in quantized form. | [optional] 
**FeeVaultChainId** | **string** | The vault chain ID of the fee sender. | [optional] 
**FeeVaultId** | **Guid** | The vault ID of the fee sender. | [optional] 
**FeeQuantizedAmount** | **string** | The amount of the fee asset to be collected, in quantized form. | [optional] 
**FeeAssetId** | **string** | The StarkEx ID of the fee asset to be collected. | [optional] 
**ExpirationTimestamp** | **long** | The timestamp at which this transfer becomes invalid, in seconds since the Unix epoch. | [optional] 
**Nonce** | **int** | The unique nonce for the transfer. | [optional] 
**SignablePayload** | **string** | The signable payload for the transfer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

