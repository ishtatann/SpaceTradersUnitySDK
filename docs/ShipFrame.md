# SpaceTradersUnitySDK.Model.ShipFrame
The frame of the ship. The frame determines the number of modules and mounting points of the ship, as well as base fuel capacity. As the condition of the frame takes more wear, the ship will become more sluggish and less maneuverable.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Symbol** | **string** |  | 
**Name** | **string** |  | 
**Description** | **string** |  | 
**Condition** | **int** | Condition is a range of 0 to 100 where 0 is completely worn out and 100 is brand new. | [optional] 
**ModuleSlots** | **int** |  | 
**MountingPoints** | **int** |  | 
**FuelCapacity** | **int** |  | 
**Requirements** | [**ShipRequirements**](ShipRequirements.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

