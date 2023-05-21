# SpaceTradersUnitySDK.Model.Contract

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**FactionSymbol** | **string** | The symbol of the faction that this contract is for. | 
**Type** | **string** |  | 
**Terms** | [**ContractTerms**](ContractTerms.md) |  | 
**Accepted** | **bool** | Whether the contract has been accepted by the agent | [default to false]
**Fulfilled** | **bool** | Whether the contract has been fulfilled | [default to false]
**Expiration** | **DateTime** | Deprecated in favor of deadlineToAccept | 
**DeadlineToAccept** | **DateTime** | The time at which the contract is no longer available to be accepted | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

