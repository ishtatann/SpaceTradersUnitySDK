# SpaceTradersUnitySDK.Model.Waypoint
A waypoint is a location that ships can travel to such as a Planet, Moon or Space Station.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Symbol** | **string** | Symbol fo the waypoint. | 
**Type** | **WaypointType** |  | 
**SystemSymbol** | **string** | The symbol of the system this waypoint belongs to. | 
**X** | **int** | Position in the universe in the x axis. | 
**Y** | **int** | Position in the universe in the Y axis. | 
**Orbitals** | [**List&lt;WaypointOrbital&gt;**](WaypointOrbital.md) | Waypoints that orbit this waypoint. | 
**Faction** | [**WaypointFaction**](WaypointFaction.md) |  | [optional] 
**Traits** | [**List&lt;WaypointTrait&gt;**](WaypointTrait.md) | The traits of the waypoint. | 
**Chart** | [**Chart**](Chart.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

