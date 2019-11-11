# RingCentral.EngageDigital.Api.AgentStatusApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeAgentStatus**](AgentStatusApi.md#changeagentstatus) | **PUT** /status/{agentId} | Changing an agent&#x27;s status
[**GetAgentStatus**](AgentStatusApi.md#getagentstatus) | **GET** /status/{agentId} | Get a connected agent status
[**GetAllAgentStatus**](AgentStatusApi.md#getallagentstatus) | **GET** /status | Get all connected agents status

<a name="changeagentstatus"></a>
# **ChangeAgentStatus**
> AgentStatus ChangeAgentStatus (string agentId, string status = null, string customStatusId = null)

Changing an agent's status

This method updates an agent's availability. Can be used to set either channels statuses OR custom  status. If both parameters are provided, ignores custom status.The status parameter​ **MUST** b​e either “away” or “available”.  Authorization​: only users that have the right to monitor the task view.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class ChangeAgentStatusExample
    {
        public void main()
        {
            var apiInstance = new AgentStatusApi();
            var agentId = agentId_example;  // string | 
            var status = status_example;  // string | A hash of channel_id => availability (must contain all channels). (optional) 
            var customStatusId = customStatusId_example;  // string | id of presence status (optional) (optional) 

            try
            {
                // Changing an agent's status
                AgentStatus result = apiInstance.ChangeAgentStatus(agentId, status, customStatusId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentStatusApi.ChangeAgentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**|  | 
 **status** | **string**| A hash of channel_id &#x3D;&gt; availability (must contain all channels). | [optional] 
 **customStatusId** | **string**| id of presence status (optional) | [optional] 

### Return type

[**AgentStatus**](AgentStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getagentstatus"></a>
# **GetAgentStatus**
> AgentStatus GetAgentStatus (string agentId)

Get a connected agent status

This method get the status of a connected agent. Returns a 404 if the user does not exist (not_found) or if he’s not connected (disconnected).  Authorization​: only users that have the right to monitor the task view.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAgentStatusExample
    {
        public void main()
        {
            var apiInstance = new AgentStatusApi();
            var agentId = agentId_example;  // string | 

            try
            {
                // Get a connected agent status
                AgentStatus result = apiInstance.GetAgentStatus(agentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentStatusApi.GetAgentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**|  | 

### Return type

[**AgentStatus**](AgentStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallagentstatus"></a>
# **GetAllAgentStatus**
> List<AgentStatus> GetAllAgentStatus ()

Get all connected agents status

This method get all currently connected agents & their status.  Authorization​: only users that have the right to monitor the task view.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllAgentStatusExample
    {
        public void main()
        {
            var apiInstance = new AgentStatusApi();

            try
            {
                // Get all connected agents status
                List&lt;AgentStatus&gt; result = apiInstance.GetAllAgentStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentStatusApi.GetAllAgentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AgentStatus>**](AgentStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
