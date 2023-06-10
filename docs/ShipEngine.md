# SpaceTradersUnitySDK.Model.ShipEngine
The engine determines how quickly a ship travels between waypoints.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Symbol** | **string** | The symbol of the engine. | 
**Name** | **string** | The name of the engine. | 
**Description** | **string** | The description of the engine. | 
**Condition** | **int** | Condition is a range of 0 to 100 where 0 is completely worn out and 100 is brand new. | [optional] 
**Speed** | **int** | The speed stat of this engine. The higher the speed, the faster a ship can travel from one point to another. Reduces the time of arrival when navigating the ship. | 
**Requirements** | [**ShipRequirements**](ShipRequirements.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

