# StarkExpress.SDK.Client.Model.TransferDetailsModel
Request model to fetch details for a signable transfer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SenderUserId** | **Guid** | The unique identifier of the user sending the transfer. | 
**ReceiverUserId** | **Guid** | The unique identifier of the user receiving the transfer. | 
**AssetId** | **Guid** | The unique identifier of the asset being transferred. | 
**TokenId** | **string** | The hexadecimal string representation of the token ID, if applicable (ie. ERC-721/ERC-1155). | [optional] 
**MintingBlob** | **string** | The hexadecimal string representation of the minting blob, if applicable (ie. Mintable ERC-20/ERC-721/ERC-1155). | [optional] 
**SenderDataAvailabilityMode** | **DataAvailabilityModes** |  | 
**ReceiverDataAvailabilityMode** | **DataAvailabilityModes** |  | 
**Amount** | **string** | The amount of the asset to be transferred. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

