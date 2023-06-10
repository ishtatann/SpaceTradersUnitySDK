# SpaceTradersUnitySDK.Api.AgentsApi

All URIs are relative to *https://api.spacetraders.io/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMyAgent**](AgentsApi.md#getmyagent) | **GET** /my/agent | Get Agent |

<a id="getmyagent"></a>
# **GetMyAgent**
> GetMyAgent200Response GetMyAgent ()

Get Agent

Fetch your agent's details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpaceTradersUnitySDK.Api;
using SpaceTradersUnitySDK.Client;
using SpaceTradersUnitySDK.Model;

namespace Example
{
    public class GetMyAgentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.spacetraders.io/v2";
            // Configure Bearer token for authorization: AgentToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentsApi(config);

            try
            {
                // Get Agent
                GetMyAgent200Response result = apiInstance.GetMyAgent();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.GetMyAgent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyAgentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Agent
    ApiResponse<GetMyAgent200Response> response = apiInstance.GetMyAgentWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.GetMyAgentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetMyAgent200Response**](GetMyAgent200Response.md)

### Authorization

[AgentToken](../README.md#AgentToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully fetched agent details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

