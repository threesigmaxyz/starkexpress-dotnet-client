# StarkExpress.SDK.Client.Model.TransactionDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **Guid** | The ID of the transaction. | [optional] 
**StarkExTransactionId** | **long?** | The sequence ID of the transaction in StarkEx. | [optional] 
**StarkExInstanceId** | **Guid** | The ID of the StarkEx instance. | [optional] 
**TenantId** | **Guid** | The ID of the tenant. | [optional] 
**Operation** | **StarkExOperation** |  | [optional] 
**Status** | **TransactionStatus** |  | [optional] 
**CreationDate** | **DateTime** | The date the transaction was created. | [optional] 
**RawTransaction** | [**TransactionModel**](TransactionModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

