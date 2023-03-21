# StarkExpress.SDK.Client.Model.SubmitOrderModel
Request model to submit an orderbook order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderbookId** | **Guid** | The ID of the orderbook. | 
**UserId** | **Guid** | The unique identifier of the user submitting the order. | 
**Side** | **OrderSide** |  | 
**Price** | **double** | The order price. | 
**Amount** | **string** | The order amount. | 
**SellDataAvailabilityMode** | **DataAvailabilityModes** |  | 
**BuyDataAvailabilityMode** | **DataAvailabilityModes** |  | 
**ExpirationTimestamp** | **long** | The timestamp at which this order becomes invalid, in seconds since the Unix epoch. | 
**Nonce** | **int** | The unique nonce for the order. | 
**Signature** | [**SignatureModel**](SignatureModel.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

