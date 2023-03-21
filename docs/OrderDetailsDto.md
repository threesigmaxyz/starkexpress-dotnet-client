# StarkExpress.SDK.Client.Model.OrderDetailsDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StarkKey** | **string** | The STARK key of the user. | [optional] 
**SellQuantizedAmount** | **string** | The amount to be sold, in quantized form. | [optional] 
**BuyQuantizedAmount** | **string** | The amount to be bough, in quantized form. | [optional] 
**SellVaultChainId** | **string** | The vault chain ID for the asset being sold. | [optional] 
**BuyVaultChainId** | **string** | The vault chain ID for the asset being bought. | [optional] 
**Fee** | [**FeeDto**](FeeDto.md) |  | [optional] 
**ExpirationTimestamp** | **long** | The timestamp at which this order becomes invalid, in seconds since the Unix epoch. | [optional] 
**Nonce** | **int** | The unique nonce for the order. | [optional] 
**SignablePayload** | **string** | The signable payload for the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

