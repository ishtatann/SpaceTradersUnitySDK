# SpaceTradersUnitySDK.Api.SystemsApi

All URIs are relative to *https://api.spacetraders.io/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetJumpGate**](SystemsApi.md#getjumpgate) | **GET** /systems/{systemSymbol}/waypoints/{waypointSymbol}/jump-gate | Get Jump Gate |
| [**GetMarket**](SystemsApi.md#getmarket) | **GET** /systems/{systemSymbol}/waypoints/{waypointSymbol}/market | Get Market |
| [**GetShipyard**](SystemsApi.md#getshipyard) | **GET** /systems/{systemSymbol}/waypoints/{waypointSymbol}/shipyard | Get Shipyard |
| [**GetSystem**](SystemsApi.md#getsystem) | **GET** /systems/{systemSymbol} | Get System |
| [**GetSystemWaypoints**](SystemsApi.md#getsystemwaypoints) | **GET** /systems/{systemSymbol}/waypoints | List Waypoints in System |
| [**GetSystems**](SystemsApi.md#getsystems) | **GET** /systems | List Systems |
| [**GetWaypoint**](SystemsApi.md#getwaypoint) | **GET** /systems/{systemSymbol}/waypoints/{waypointSymbol} | Get Waypoint |

<a id="getjumpgate"></a>
# **GetJumpGate**
> GetJumpGate200Response GetJumpGate (string systemSymbol, string waypointSymbol)

Get Jump Gate

Get jump gate details for a waypoint. Requires a waypoint of type `JUMP_GATE` to use.  The response will return all systems that are have a Jump Gate in range of this Jump Gate. Those systems can be jumped to from this Jump Gate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetJumpGateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SystemsApi(config);
            var systemSymbol = "systemSymbol_example";  // string | The system symbol
            var waypointSymbol = "waypointSymbol_example";  // string | The waypoint symbol

            try
            {
                // Get Jump Gate
                GetJumpGate200Response result = apiInstance.GetJumpGate(systemSymbol, waypointSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemsApi.GetJumpGate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJumpGateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Jump Gate
    ApiResponse<GetJumpGate200Response> response = apiInstance.GetJumpGateWithHttpInfo(systemSymbol, waypointSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemsApi.GetJumpGateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **systemSymbol** | **string** | The system symbol |  |
| **waypointSymbol** | **string** | The waypoint symbol |  |

### Return type

[**GetJumpGate200Response**](GetJumpGate200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully fetched jump gate. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmarket"></a>
# **GetMarket**
> GetMarket200Response GetMarket (string systemSymbol, string waypointSymbol)

Get Market

Retrieve imports, exports and exchange data from a marketplace. Requires a waypoint that has the `Marketplace` trait to use.  Send a ship to the waypoint to access trade good prices and recent transactions. Refer to the [Market Overview page](https://docs.spacetraders.io/game-concepts/markets) to gain better a understanding of the market in the game.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetMarketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SystemsApi(config);
            var systemSymbol = "systemSymbol_example";  // string | The system symbol
            var waypointSymbol = "waypointSymbol_example";  // string | The waypoint symbol

            try
            {
                // Get Market
                GetMarket200Response result = apiInstance.GetMarket(systemSymbol, waypointSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemsApi.GetMarket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMarketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Market
    ApiResponse<GetMarket200Response> response = apiInstance.GetMarketWithHttpInfo(systemSymbol, waypointSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemsApi.GetMarketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **systemSymbol** | **string** | The system symbol |  |
| **waypointSymbol** | **string** | The waypoint symbol |  |

### Return type

[**GetMarket200Response**](GetMarket200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully fetched the market. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getshipyard"></a>
# **GetShipyard**
> GetShipyard200Response GetShipyard (string systemSymbol, string waypointSymbol)

Get Shipyard

Get the shipyard for a waypoint. Requires a waypoint that has the `Shipyard` trait to use. Send a ship to the waypoint to access data on ships that are currently available for purchase and recent transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetShipyardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SystemsApi(config);
            var systemSymbol = "systemSymbol_example";  // string | The system symbol
            var waypointSymbol = "waypointSymbol_example";  // string | The waypoint symbol

            try
            {
                // Get Shipyard
                GetShipyard200Response result = apiInstance.GetShipyard(systemSymbol, waypointSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemsApi.GetShipyard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetShipyardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Shipyard
    ApiResponse<GetShipyard200Response> response = apiInstance.GetShipyardWithHttpInfo(systemSymbol, waypointSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemsApi.GetShipyardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **systemSymbol** | **string** | The system symbol |  |
| **waypointSymbol** | **string** | The waypoint symbol |  |

### Return type

[**GetShipyard200Response**](GetShipyard200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully fetched the shipyard. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsystem"></a>
# **GetSystem**
> GetSystem200Response GetSystem (string systemSymbol)

Get System

Get the details of a system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetSystemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SystemsApi(config);
            var systemSymbol = "\"X1-OE\"";  // string | The system symbol (default to "X1-OE")

            try
            {
                // Get System
                GetSystem200Response result = apiInstance.GetSystem(systemSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemsApi.GetSystem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get System
    ApiResponse<GetSystem200Response> response = apiInstance.GetSystemWithHttpInfo(systemSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemsApi.GetSystemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **systemSymbol** | **string** | The system symbol | [default to &quot;X1-OE&quot;] |

### Return type

[**GetSystem200Response**](GetSystem200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully fetched the system. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsystemwaypoints"></a>
# **GetSystemWaypoints**
> GetSystemWaypoints200Response GetSystemWaypoints (string systemSymbol, int? page = null, int? limit = null)

List Waypoints in System

Return a paginated list of all of the waypoints for a given system.  If a waypoint is uncharted, it will return the `Uncharted` trait instead of its actual traits.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetSystemWaypointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SystemsApi(config);
            var systemSymbol = "systemSymbol_example";  // string | The system symbol
            var page = 1;  // int? | What entry offset to request (optional)  (default to 1)
            var limit = 10;  // int? | How many entries to return per page (optional)  (default to 10)

            try
            {
                // List Waypoints in System
                GetSystemWaypoints200Response result = apiInstance.GetSystemWaypoints(systemSymbol, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemsApi.GetSystemWaypoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemWaypointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Waypoints in System
    ApiResponse<GetSystemWaypoints200Response> response = apiInstance.GetSystemWaypointsWithHttpInfo(systemSymbol, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemsApi.GetSystemWaypointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **systemSymbol** | **string** | The system symbol |  |
| **page** | **int?** | What entry offset to request | [optional] [default to 1] |
| **limit** | **int?** | How many entries to return per page | [optional] [default to 10] |

### Return type

[**GetSystemWaypoints200Response**](GetSystemWaypoints200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully fetched all waypoints in the system. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsystems"></a>
# **GetSystems**
> GetSystems200Response GetSystems (int? page = null, int? limit = null)

List Systems

Return a paginated list of all systems.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetSystemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SystemsApi(config);
            var page = 1;  // int? | What entry offset to request (optional)  (default to 1)
            var limit = 10;  // int? | How many entries to return per page (optional)  (default to 10)

            try
            {
                // List Systems
                GetSystems200Response result = apiInstance.GetSystems(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemsApi.GetSystems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Systems
    ApiResponse<GetSystems200Response> response = apiInstance.GetSystemsWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemsApi.GetSystemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | What entry offset to request | [optional] [default to 1] |
| **limit** | **int?** | How many entries to return per page | [optional] [default to 10] |

### Return type

[**GetSystems200Response**](GetSystems200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully listed systems. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwaypoint"></a>
# **GetWaypoint**
> GetWaypoint200Response GetWaypoint (string systemSymbol, string waypointSymbol)

Get Waypoint

View the details of a waypoint.  If the waypoint is uncharted, it will return the 'Uncharted' trait instead of its actual traits.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetWaypointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SystemsApi(config);
            var systemSymbol = "systemSymbol_example";  // string | The system symbol
            var waypointSymbol = "waypointSymbol_example";  // string | The waypoint symbol

            try
            {
                // Get Waypoint
                GetWaypoint200Response result = apiInstance.GetWaypoint(systemSymbol, waypointSymbol);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemsApi.GetWaypoint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWaypointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Waypoint
    ApiResponse<GetWaypoint200Response> response = apiInstance.GetWaypointWithHttpInfo(systemSymbol, waypointSymbol);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemsApi.GetWaypointWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **systemSymbol** | **string** | The system symbol |  |
| **waypointSymbol** | **string** | The waypoint symbol |  |

### Return type

[**GetWaypoint200Response**](GetWaypoint200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully fetched waypoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

