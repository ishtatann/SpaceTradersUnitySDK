# SpaceTradersUnitySDK.Api.FleetApi

All URIs are relative to *https://api.spacetraders.io/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateChart**](FleetApi.md#createchart) | **POST** /my/ships/{shipSymbol}/chart | Create Chart |
| [**CreateShipShipScan**](FleetApi.md#createshipshipscan) | **POST** /my/ships/{shipSymbol}/scan/ships | Scan Ships |
| [**CreateShipSystemScan**](FleetApi.md#createshipsystemscan) | **POST** /my/ships/{shipSymbol}/scan/systems | Scan Systems |
| [**CreateShipWaypointScan**](FleetApi.md#createshipwaypointscan) | **POST** /my/ships/{shipSymbol}/scan/waypoints | Scan Waypoints |
| [**CreateSurvey**](FleetApi.md#createsurvey) | **POST** /my/ships/{shipSymbol}/survey | Create Survey |
| [**DockShip**](FleetApi.md#dockship) | **POST** /my/ships/{shipSymbol}/dock | Dock Ship |
| [**ExtractResources**](FleetApi.md#extractresources) | **POST** /my/ships/{shipSymbol}/extract | Extract Resources |
| [**GetMounts**](FleetApi.md#getmounts) | **GET** /my/ships/{shipSymbol}/mounts | Get Mounts |
| [**GetMyShip**](FleetApi.md#getmyship) | **GET** /my/ships/{shipSymbol} | Get Ship |
| [**GetMyShipCargo**](FleetApi.md#getmyshipcargo) | **GET** /my/ships/{shipSymbol}/cargo | Get Ship Cargo |
| [**GetMyShips**](FleetApi.md#getmyships) | **GET** /my/ships | List Ships |
| [**GetShipCooldown**](FleetApi.md#getshipcooldown) | **GET** /my/ships/{shipSymbol}/cooldown | Get Ship Cooldown |
| [**GetShipNav**](FleetApi.md#getshipnav) | **GET** /my/ships/{shipSymbol}/nav | Get Ship Nav |
| [**InstallMount**](FleetApi.md#installmount) | **POST** /my/ships/{shipSymbol}/mounts/install | Install Mount |
| [**Jettison**](FleetApi.md#jettison) | **POST** /my/ships/{shipSymbol}/jettison | Jettison Cargo |
| [**JumpShip**](FleetApi.md#jumpship) | **POST** /my/ships/{shipSymbol}/jump | Jump Ship |
| [**NavigateShip**](FleetApi.md#navigateship) | **POST** /my/ships/{shipSymbol}/navigate | Navigate Ship |
| [**NegotiateContract**](FleetApi.md#negotiatecontract) | **POST** /my/ships/{shipSymbol}/negotiate/contract | Negotiate Contract |
| [**OrbitShip**](FleetApi.md#orbitship) | **POST** /my/ships/{shipSymbol}/orbit | Orbit Ship |
| [**PatchShipNav**](FleetApi.md#patchshipnav) | **PATCH** /my/ships/{shipSymbol}/nav | Patch Ship Nav |
| [**PurchaseCargo**](FleetApi.md#purchasecargo) | **POST** /my/ships/{shipSymbol}/purchase | Purchase Cargo |
| [**PurchaseShip**](FleetApi.md#purchaseship) | **POST** /my/ships | Purchase Ship |
| [**RefuelShip**](FleetApi.md#refuelship) | **POST** /my/ships/{shipSymbol}/refuel | Refuel Ship |
| [**RemoveMount**](FleetApi.md#removemount) | **POST** /my/ships/{shipSymbol}/mounts/remove | Remove Mount |
| [**SellCargo**](FleetApi.md#sellcargo) | **POST** /my/ships/{shipSymbol}/sell | Sell Cargo |
| [**ShipRefine**](FleetApi.md#shiprefine) | **POST** /my/ships/{shipSymbol}/refine | Ship Refine |
| [**TransferCargo**](FleetApi.md#transfercargo) | **POST** /my/ships/{shipSymbol}/transfer | Transfer Cargo |
| [**WarpShip**](FleetApi.md#warpship) | **POST** /my/ships/{shipSymbol}/warp | Warp Ship |

<a id="createchart"></a>
# **CreateChart**
> CreateChart201Response CreateChart (string shipSymbol)

Create Chart

Command a ship to chart the current waypoint.  Waypoints in the universe are uncharted by default. These locations will not show up in the API until they have been charted by a ship.  Charting a location will record your agent as the one who created the chart.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class CreateChartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | The symbol of the ship

            try
            {
                // Create Chart
                CreateChart201Response result = apiInstance.CreateChart(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.CreateChart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateChartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Chart
    ApiResponse<CreateChart201Response> response = apiInstance.CreateChartWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.CreateChartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** | The symbol of the ship |  |

### Return type

[**CreateChart201Response**](CreateChart201Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createshipshipscan"></a>
# **CreateShipShipScan**
> CreateShipShipScan201Response CreateShipShipScan (string shipSymbol)

Scan Ships

Activate your ship's sensor arrays to scan for ship information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class CreateShipShipScanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 

            try
            {
                // Scan Ships
                CreateShipShipScan201Response result = apiInstance.CreateShipShipScan(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.CreateShipShipScan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateShipShipScanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Scan Ships
    ApiResponse<CreateShipShipScan201Response> response = apiInstance.CreateShipShipScanWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.CreateShipShipScanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |

### Return type

[**CreateShipShipScan201Response**](CreateShipShipScan201Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createshipsystemscan"></a>
# **CreateShipSystemScan**
> CreateShipSystemScan201Response CreateShipSystemScan (string shipSymbol)

Scan Systems

Activate your ship's sensor arrays to scan for system information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class CreateShipSystemScanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 

            try
            {
                // Scan Systems
                CreateShipSystemScan201Response result = apiInstance.CreateShipSystemScan(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.CreateShipSystemScan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateShipSystemScanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Scan Systems
    ApiResponse<CreateShipSystemScan201Response> response = apiInstance.CreateShipSystemScanWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.CreateShipSystemScanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |

### Return type

[**CreateShipSystemScan201Response**](CreateShipSystemScan201Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createshipwaypointscan"></a>
# **CreateShipWaypointScan**
> CreateShipWaypointScan201Response CreateShipWaypointScan (string shipSymbol)

Scan Waypoints

Activate your ship's sensor arrays to scan for waypoint information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class CreateShipWaypointScanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 

            try
            {
                // Scan Waypoints
                CreateShipWaypointScan201Response result = apiInstance.CreateShipWaypointScan(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.CreateShipWaypointScan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateShipWaypointScanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Scan Waypoints
    ApiResponse<CreateShipWaypointScan201Response> response = apiInstance.CreateShipWaypointScanWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.CreateShipWaypointScanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |

### Return type

[**CreateShipWaypointScan201Response**](CreateShipWaypointScan201Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsurvey"></a>
# **CreateSurvey**
> CreateSurvey201Response CreateSurvey (string shipSymbol)

Create Survey

If you want to target specific yields for an extraction, you can survey a waypoint, such as an asteroid field, and send the survey in the body of the extract request. Each survey may have multiple deposits, and if a symbol shows up more than once, that indicates a higher chance of extracting that resource.  Your ship will enter a cooldown between consecutive survey requests. Surveys will eventually expire after a period of time. Multiple ships can use the same survey for extraction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class CreateSurveyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | The symbol of the ship

            try
            {
                // Create Survey
                CreateSurvey201Response result = apiInstance.CreateSurvey(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.CreateSurvey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSurveyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Survey
    ApiResponse<CreateSurvey201Response> response = apiInstance.CreateSurveyWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.CreateSurveyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** | The symbol of the ship |  |

### Return type

[**CreateSurvey201Response**](CreateSurvey201Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dockship"></a>
# **DockShip**
> DockShip200Response DockShip (string shipSymbol)

Dock Ship

Attempt to dock your ship at it's current location. Docking will only succeed if the waypoint is a dockable location, and your ship is capable of docking at the time of the request.  The endpoint is idempotent - successive calls will succeed even if the ship is already docked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class DockShipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | The symbol of the ship

            try
            {
                // Dock Ship
                DockShip200Response result = apiInstance.DockShip(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.DockShip: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DockShipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dock Ship
    ApiResponse<DockShip200Response> response = apiInstance.DockShipWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.DockShipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** | The symbol of the ship |  |

### Return type

[**DockShip200Response**](DockShip200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The ship has successfully docked at it&#39;s current location. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="extractresources"></a>
# **ExtractResources**
> ExtractResources201Response ExtractResources (string shipSymbol, ExtractResourcesRequest extractResourcesRequest = null)

Extract Resources

Extract resources from the waypoint into your ship. Send an optional survey as the payload to target specific yields.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class ExtractResourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | The ship symbol
            var extractResourcesRequest = new ExtractResourcesRequest(); // ExtractResourcesRequest |  (optional) 

            try
            {
                // Extract Resources
                ExtractResources201Response result = apiInstance.ExtractResources(shipSymbol, extractResourcesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.ExtractResources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractResourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract Resources
    ApiResponse<ExtractResources201Response> response = apiInstance.ExtractResourcesWithHttpInfo(shipSymbol, extractResourcesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.ExtractResourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** | The ship symbol |  |
| **extractResourcesRequest** | [**ExtractResourcesRequest**](ExtractResourcesRequest.md) |  | [optional]  |

### Return type

[**ExtractResources201Response**](ExtractResources201Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmounts"></a>
# **GetMounts**
> GetMounts200Response GetMounts (string shipSymbol)

Get Mounts

Get the mounts on a ship.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetMountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 

            try
            {
                // Get Mounts
                GetMounts200Response result = apiInstance.GetMounts(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.GetMounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Mounts
    ApiResponse<GetMounts200Response> response = apiInstance.GetMountsWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.GetMountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |

### Return type

[**GetMounts200Response**](GetMounts200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmyship"></a>
# **GetMyShip**
> GetMyShip200Response GetMyShip (string shipSymbol)

Get Ship

Retrieve the details of your ship.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetMyShipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 

            try
            {
                // Get Ship
                GetMyShip200Response result = apiInstance.GetMyShip(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.GetMyShip: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyShipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Ship
    ApiResponse<GetMyShip200Response> response = apiInstance.GetMyShipWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.GetMyShipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |

### Return type

[**GetMyShip200Response**](GetMyShip200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmyshipcargo"></a>
# **GetMyShipCargo**
> GetMyShipCargo200Response GetMyShipCargo (string shipSymbol)

Get Ship Cargo

Retrieve the cargo of your ship.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetMyShipCargoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | The symbol of the ship

            try
            {
                // Get Ship Cargo
                GetMyShipCargo200Response result = apiInstance.GetMyShipCargo(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.GetMyShipCargo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyShipCargoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Ship Cargo
    ApiResponse<GetMyShipCargo200Response> response = apiInstance.GetMyShipCargoWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.GetMyShipCargoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** | The symbol of the ship |  |

### Return type

[**GetMyShipCargo200Response**](GetMyShipCargo200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmyships"></a>
# **GetMyShips**
> GetMyShips200Response GetMyShips (long? page = null, long? limit = null)

List Ships

Retrieve all of your ships.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetMyShipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var page = 789L;  // long? | What entry offset to request (optional) 
            var limit = 789L;  // long? | How many entries to return per page (optional) 

            try
            {
                // List Ships
                GetMyShips200Response result = apiInstance.GetMyShips(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.GetMyShips: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyShipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Ships
    ApiResponse<GetMyShips200Response> response = apiInstance.GetMyShipsWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.GetMyShipsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **long?** | What entry offset to request | [optional]  |
| **limit** | **long?** | How many entries to return per page | [optional]  |

### Return type

[**GetMyShips200Response**](GetMyShips200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getshipcooldown"></a>
# **GetShipCooldown**
> GetShipCooldown200Response GetShipCooldown (string shipSymbol)

Get Ship Cooldown

Retrieve the details of your ship's reactor cooldown. Some actions such as activating your jump drive, scanning, or extracting resources taxes your reactor and results in a cooldown.  Your ship cannot perform additional actions until your cooldown has expired. The duration of your cooldown is relative to the power consumption of the related modules or mounts for the action taken.  Response returns a 204 status code (no-content) when the ship has no cooldown.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetShipCooldownExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 

            try
            {
                // Get Ship Cooldown
                GetShipCooldown200Response result = apiInstance.GetShipCooldown(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.GetShipCooldown: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetShipCooldownWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Ship Cooldown
    ApiResponse<GetShipCooldown200Response> response = apiInstance.GetShipCooldownWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.GetShipCooldownWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |

### Return type

[**GetShipCooldown200Response**](GetShipCooldown200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **204** | No cooldown |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getshipnav"></a>
# **GetShipNav**
> GetShipNav200Response GetShipNav (string shipSymbol)

Get Ship Nav

Get the current nav status of a ship.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetShipNavExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | The ship symbol

            try
            {
                // Get Ship Nav
                GetShipNav200Response result = apiInstance.GetShipNav(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.GetShipNav: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetShipNavWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Ship Nav
    ApiResponse<GetShipNav200Response> response = apiInstance.GetShipNavWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.GetShipNavWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** | The ship symbol |  |

### Return type

[**GetShipNav200Response**](GetShipNav200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The current nav status of the ship. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="installmount"></a>
# **InstallMount**
> InstallMount201Response InstallMount (string shipSymbol, InstallMountRequest installMountRequest = null)

Install Mount

Install a mount on a ship.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class InstallMountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 
            var installMountRequest = new InstallMountRequest(); // InstallMountRequest |  (optional) 

            try
            {
                // Install Mount
                InstallMount201Response result = apiInstance.InstallMount(shipSymbol, installMountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.InstallMount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallMountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Install Mount
    ApiResponse<InstallMount201Response> response = apiInstance.InstallMountWithHttpInfo(shipSymbol, installMountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.InstallMountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |
| **installMountRequest** | [**InstallMountRequest**](InstallMountRequest.md) |  | [optional]  |

### Return type

[**InstallMount201Response**](InstallMount201Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="jettison"></a>
# **Jettison**
> Jettison200Response Jettison (string shipSymbol, JettisonRequest jettisonRequest = null)

Jettison Cargo

Jettison cargo from your ship's cargo hold.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class JettisonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 
            var jettisonRequest = new JettisonRequest(); // JettisonRequest |  (optional) 

            try
            {
                // Jettison Cargo
                Jettison200Response result = apiInstance.Jettison(shipSymbol, jettisonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.Jettison: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JettisonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Jettison Cargo
    ApiResponse<Jettison200Response> response = apiInstance.JettisonWithHttpInfo(shipSymbol, jettisonRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.JettisonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |
| **jettisonRequest** | [**JettisonRequest**](JettisonRequest.md) |  | [optional]  |

### Return type

[**Jettison200Response**](Jettison200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="jumpship"></a>
# **JumpShip**
> JumpShip200Response JumpShip (string shipSymbol, JumpShipRequest jumpShipRequest = null)

Jump Ship

Jump your ship instantly to a target system. When used while in orbit or docked to a jump gate waypoint, any ship can use this command. When used elsewhere, jumping requires a jump drive unit and consumes a unit of antimatter (which needs to be in your cargo).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class JumpShipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 
            var jumpShipRequest = new JumpShipRequest(); // JumpShipRequest |  (optional) 

            try
            {
                // Jump Ship
                JumpShip200Response result = apiInstance.JumpShip(shipSymbol, jumpShipRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.JumpShip: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JumpShipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Jump Ship
    ApiResponse<JumpShip200Response> response = apiInstance.JumpShipWithHttpInfo(shipSymbol, jumpShipRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.JumpShipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |
| **jumpShipRequest** | [**JumpShipRequest**](JumpShipRequest.md) |  | [optional]  |

### Return type

[**JumpShip200Response**](JumpShip200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="navigateship"></a>
# **NavigateShip**
> NavigateShip200Response NavigateShip (string shipSymbol, NavigateShipRequest navigateShipRequest = null)

Navigate Ship

Navigate to a target destination. The destination must be located within the same system as the ship. Navigating will consume the necessary fuel and supplies from the ship's manifest, and will pay out crew wages from the agent's account.  The returned response will detail the route information including the expected time of arrival. Most ship actions are unavailable until the ship has arrived at it's destination.  To travel between systems, see the ship's warp or jump actions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class NavigateShipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | The ship symbol
            var navigateShipRequest = new NavigateShipRequest(); // NavigateShipRequest |  (optional) 

            try
            {
                // Navigate Ship
                NavigateShip200Response result = apiInstance.NavigateShip(shipSymbol, navigateShipRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.NavigateShip: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NavigateShipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Navigate Ship
    ApiResponse<NavigateShip200Response> response = apiInstance.NavigateShipWithHttpInfo(shipSymbol, navigateShipRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.NavigateShipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** | The ship symbol |  |
| **navigateShipRequest** | [**NavigateShipRequest**](NavigateShipRequest.md) |  | [optional]  |

### Return type

[**NavigateShip200Response**](NavigateShip200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successful transit information including the route details and changes to ship fuel, supplies, and crew wages paid. The route includes the expected time of arrival. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="negotiatecontract"></a>
# **NegotiateContract**
> NegotiateContract200Response NegotiateContract (string shipSymbol, Object body = null)

Negotiate Contract

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class NegotiateContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 
            var body = null;  // Object |  (optional) 

            try
            {
                // Negotiate Contract
                NegotiateContract200Response result = apiInstance.NegotiateContract(shipSymbol, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.NegotiateContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NegotiateContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Negotiate Contract
    ApiResponse<NegotiateContract200Response> response = apiInstance.NegotiateContractWithHttpInfo(shipSymbol, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.NegotiateContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |
| **body** | **Object** |  | [optional]  |

### Return type

[**NegotiateContract200Response**](NegotiateContract200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orbitship"></a>
# **OrbitShip**
> OrbitShip200Response OrbitShip (string shipSymbol)

Orbit Ship

Attempt to move your ship into orbit at it's current location. The request will only succeed if your ship is capable of moving into orbit at the time of the request.  The endpoint is idempotent - successive calls will succeed even if the ship is already in orbit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class OrbitShipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | The symbol of the ship

            try
            {
                // Orbit Ship
                OrbitShip200Response result = apiInstance.OrbitShip(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.OrbitShip: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrbitShipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Orbit Ship
    ApiResponse<OrbitShip200Response> response = apiInstance.OrbitShipWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.OrbitShipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** | The symbol of the ship |  |

### Return type

[**OrbitShip200Response**](OrbitShip200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The ship has successfully moved into orbit at it&#39;s current location. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchshipnav"></a>
# **PatchShipNav**
> GetShipNav200Response PatchShipNav (string shipSymbol, PatchShipNavRequest patchShipNavRequest = null)

Patch Ship Nav

Update the nav data of a ship, such as the flight mode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class PatchShipNavExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | The ship symbol
            var patchShipNavRequest = new PatchShipNavRequest(); // PatchShipNavRequest |  (optional) 

            try
            {
                // Patch Ship Nav
                GetShipNav200Response result = apiInstance.PatchShipNav(shipSymbol, patchShipNavRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.PatchShipNav: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchShipNavWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch Ship Nav
    ApiResponse<GetShipNav200Response> response = apiInstance.PatchShipNavWithHttpInfo(shipSymbol, patchShipNavRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.PatchShipNavWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** | The ship symbol |  |
| **patchShipNavRequest** | [**PatchShipNavRequest**](PatchShipNavRequest.md) |  | [optional]  |

### Return type

[**GetShipNav200Response**](GetShipNav200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated nav status of the ship. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="purchasecargo"></a>
# **PurchaseCargo**
> PurchaseCargo201Response PurchaseCargo (string shipSymbol, PurchaseCargoRequest purchaseCargoRequest = null)

Purchase Cargo

Purchase cargo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class PurchaseCargoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 
            var purchaseCargoRequest = new PurchaseCargoRequest(); // PurchaseCargoRequest |  (optional) 

            try
            {
                // Purchase Cargo
                PurchaseCargo201Response result = apiInstance.PurchaseCargo(shipSymbol, purchaseCargoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.PurchaseCargo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseCargoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Purchase Cargo
    ApiResponse<PurchaseCargo201Response> response = apiInstance.PurchaseCargoWithHttpInfo(shipSymbol, purchaseCargoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.PurchaseCargoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |
| **purchaseCargoRequest** | [**PurchaseCargoRequest**](PurchaseCargoRequest.md) |  | [optional]  |

### Return type

[**PurchaseCargo201Response**](PurchaseCargo201Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="purchaseship"></a>
# **PurchaseShip**
> PurchaseShip201Response PurchaseShip (PurchaseShipRequest purchaseShipRequest = null)

Purchase Ship

Purchase a ship

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class PurchaseShipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var purchaseShipRequest = new PurchaseShipRequest(); // PurchaseShipRequest |  (optional) 

            try
            {
                // Purchase Ship
                PurchaseShip201Response result = apiInstance.PurchaseShip(purchaseShipRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.PurchaseShip: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseShipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Purchase Ship
    ApiResponse<PurchaseShip201Response> response = apiInstance.PurchaseShipWithHttpInfo(purchaseShipRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.PurchaseShipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **purchaseShipRequest** | [**PurchaseShipRequest**](PurchaseShipRequest.md) |  | [optional]  |

### Return type

[**PurchaseShip201Response**](PurchaseShip201Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refuelship"></a>
# **RefuelShip**
> RefuelShip200Response RefuelShip (string shipSymbol)

Refuel Ship

Refuel your ship from the local market.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class RefuelShipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 

            try
            {
                // Refuel Ship
                RefuelShip200Response result = apiInstance.RefuelShip(shipSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.RefuelShip: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefuelShipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Refuel Ship
    ApiResponse<RefuelShip200Response> response = apiInstance.RefuelShipWithHttpInfo(shipSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.RefuelShipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |

### Return type

[**RefuelShip200Response**](RefuelShip200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removemount"></a>
# **RemoveMount**
> RemoveMount201Response RemoveMount (string shipSymbol, RemoveMountRequest removeMountRequest = null)

Remove Mount

Remove a mount from a ship.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class RemoveMountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 
            var removeMountRequest = new RemoveMountRequest(); // RemoveMountRequest |  (optional) 

            try
            {
                // Remove Mount
                RemoveMount201Response result = apiInstance.RemoveMount(shipSymbol, removeMountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.RemoveMount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveMountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Mount
    ApiResponse<RemoveMount201Response> response = apiInstance.RemoveMountWithHttpInfo(shipSymbol, removeMountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.RemoveMountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |
| **removeMountRequest** | [**RemoveMountRequest**](RemoveMountRequest.md) |  | [optional]  |

### Return type

[**RemoveMount201Response**](RemoveMount201Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sellcargo"></a>
# **SellCargo**
> SellCargo201Response SellCargo (string shipSymbol, SellCargoRequest sellCargoRequest = null)

Sell Cargo

Sell cargo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class SellCargoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 
            var sellCargoRequest = new SellCargoRequest(); // SellCargoRequest |  (optional) 

            try
            {
                // Sell Cargo
                SellCargo201Response result = apiInstance.SellCargo(shipSymbol, sellCargoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.SellCargo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SellCargoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sell Cargo
    ApiResponse<SellCargo201Response> response = apiInstance.SellCargoWithHttpInfo(shipSymbol, sellCargoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.SellCargoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |
| **sellCargoRequest** | [**SellCargoRequest**](SellCargoRequest.md) |  | [optional]  |

### Return type

[**SellCargo201Response**](SellCargo201Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="shiprefine"></a>
# **ShipRefine**
> ShipRefine200Response ShipRefine (string shipSymbol, ShipRefineRequest shipRefineRequest = null)

Ship Refine

Attempt to refine the raw materials on your ship. The request will only succeed if your ship is capable of refining at the time of the request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class ShipRefineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | The symbol of the ship
            var shipRefineRequest = new ShipRefineRequest(); // ShipRefineRequest |  (optional) 

            try
            {
                // Ship Refine
                ShipRefine200Response result = apiInstance.ShipRefine(shipSymbol, shipRefineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.ShipRefine: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipRefineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ship Refine
    ApiResponse<ShipRefine200Response> response = apiInstance.ShipRefineWithHttpInfo(shipSymbol, shipRefineRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.ShipRefineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** | The symbol of the ship |  |
| **shipRefineRequest** | [**ShipRefineRequest**](ShipRefineRequest.md) |  | [optional]  |

### Return type

[**ShipRefine200Response**](ShipRefine200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The ship has successfully started refining. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="transfercargo"></a>
# **TransferCargo**
> TransferCargo200Response TransferCargo (string shipSymbol, TransferCargoRequest transferCargoRequest = null)

Transfer Cargo

Transfer cargo between ships.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class TransferCargoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 
            var transferCargoRequest = new TransferCargoRequest(); // TransferCargoRequest |  (optional) 

            try
            {
                // Transfer Cargo
                TransferCargo200Response result = apiInstance.TransferCargo(shipSymbol, transferCargoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.TransferCargo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransferCargoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transfer Cargo
    ApiResponse<TransferCargo200Response> response = apiInstance.TransferCargoWithHttpInfo(shipSymbol, transferCargoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.TransferCargoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |
| **transferCargoRequest** | [**TransferCargoRequest**](TransferCargoRequest.md) |  | [optional]  |

### Return type

[**TransferCargo200Response**](TransferCargo200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="warpship"></a>
# **WarpShip**
> NavigateShip200Response WarpShip (string shipSymbol, NavigateShipRequest navigateShipRequest = null)

Warp Ship

Warp your ship to a target destination in another system. Warping will consume the necessary fuel and supplies from the ship's manifest, and will pay out crew wages from the agent's account.  The returned response will detail the route information including the expected time of arrival. Most ship actions are unavailable until the ship has arrived at it's destination.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class WarpShipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FleetApi(config);
            var shipSymbol = "shipSymbol_example";  // string | 
            var navigateShipRequest = new NavigateShipRequest(); // NavigateShipRequest |  (optional) 

            try
            {
                // Warp Ship
                NavigateShip200Response result = apiInstance.WarpShip(shipSymbol, navigateShipRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FleetApi.WarpShip: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarpShipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Warp Ship
    ApiResponse<NavigateShip200Response> response = apiInstance.WarpShipWithHttpInfo(shipSymbol, navigateShipRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FleetApi.WarpShipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipSymbol** | **string** |  |  |
| **navigateShipRequest** | [**NavigateShipRequest**](NavigateShipRequest.md) |  | [optional]  |

### Return type

[**NavigateShip200Response**](NavigateShip200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successful transit information including the route details and changes to ship fuel, supplies, and crew wages paid. The route includes the expected time of arrival. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

