# SpaceTradersUnitySDK.Model.ShipReactor
The reactor of the ship. The reactor is responsible for powering the ship's systems and weapons.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Symbol** | **string** | Symbol of the reactor. | 
**Name** | **string** | Name of the reactor. | 
**Description** | **string** | Description of the reactor. | 
**Condition** | **double** | The repairable condition of a component. A value of 0 indicates the component needs significant repairs, while a value of 1 indicates the component is in near perfect condition. As the condition of a component is repaired, the overall integrity of the component decreases. | 
**Integrity** | **double** | The overall integrity of the component, which determines the performance of the component. A value of 0 indicates that the component is almost completely degraded, while a value of 1 indicates that the component is in near perfect condition. The integrity of the component is non-repairable, and represents permanent wear over time. | 
**PowerOutput** | **int** | The amount of power provided by this reactor. The more power a reactor provides to the ship, the lower the cooldown it gets when using a module or mount that taxes the ship&#39;s power. | 
**Requirements** | [**ShipRequirements**](ShipRequirements.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

