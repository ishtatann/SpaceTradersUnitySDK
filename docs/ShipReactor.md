# SpaceTradersUnitySDK.Model.ShipReactor
The reactor of the ship. The reactor is responsible for powering the ship's systems and weapons.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Symbol** | **string** | Symbol of the reactor. | 
**Name** | **string** | Name of the reactor. | 
**Description** | **string** | Description of the reactor. | 
**Condition** | **int** | Condition is a range of 0 to 100 where 0 is completely worn out and 100 is brand new. | [optional] 
**PowerOutput** | **int** | The amount of power provided by this reactor. The more power a reactor provides to the ship, the lower the cooldown it gets when using a module or mount that taxes the ship&#39;s power. | 
**Requirements** | [**ShipRequirements**](ShipRequirements.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

