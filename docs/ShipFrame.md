# SpaceTradersUnitySDK.Model.ShipFrame
The frame of the ship. The frame determines the number of modules and mounting points of the ship, as well as base fuel capacity. As the condition of the frame takes more wear, the ship will become more sluggish and less maneuverable.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Symbol** | **string** | Symbol of the frame. | 
**Name** | **string** | Name of the frame. | 
**Description** | **string** | Description of the frame. | 
**Condition** | **int** | Condition is a range of 0 to 100 where 0 is completely worn out and 100 is brand new. | [optional] 
**ModuleSlots** | **int** | The amount of slots that can be dedicated to modules installed in the ship. Each installed module take up a number of slots, and once there are no more slots, no new modules can be installed. | 
**MountingPoints** | **int** | The amount of slots that can be dedicated to mounts installed in the ship. Each installed mount takes up a number of points, and once there are no more points remaining, no new mounts can be installed. | 
**FuelCapacity** | **int** | The maximum amount of fuel that can be stored in this ship. When refueling, the ship will be refueled to this amount. | 
**Requirements** | [**ShipRequirements**](ShipRequirements.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

