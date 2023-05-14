# SpaceTradersUnitySDK.Model.Survey
A resource survey of a waypoint, detailing a specific extraction location and the types of resources that can be found there.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Signature** | **string** | A unique signature for the location of this survey. This signature is verified when attempting an extraction using this survey. | 
**Symbol** | **string** | The symbol of the waypoint that this survey is for. | 
**Deposits** | [**List&lt;SurveyDeposit&gt;**](SurveyDeposit.md) | A list of deposits that can be found at this location. | 
**Expiration** | **DateTime** | The date and time when the survey expires. After this date and time, the survey will no longer be available for extraction. | 
**Size** | **string** | The size of the deposit. This value indicates how much can be extracted from the survey before it is exhausted. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

