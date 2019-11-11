# RingCentral.EngageDigital.Api.TasksApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllTasks**](TasksApi.md#getalltasks) | **GET** /tasks | Getting all tasks
[**GetTask**](TasksApi.md#gettask) | **GET** /tasks/{taskId} | Getting a task from its id
[**MoveTask**](TasksApi.md#movetask) | **DELETE** /tasks/{taskId}/move | Move a task to another queue
[**TransferTask**](TasksApi.md#transfertask) | **PUT** /tasks/{taskId}/transfer | Transferring a task

<a name="getalltasks"></a>
# **GetAllTasks**
> GetAllTasksResponse GetAllTasks (string queue = null, string channelId = null, string step = null, int? offset = null, int? limit = null)

Getting all tasks

This method renders tasks ordered by priority (highest first) and then by creation date (latest first).  Authorization​: only users that can read tasks.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllTasksExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var queue = queue_example;  // string | To filter tasks on given queue name (filters on the “global” queue by default).The most commonly used queues are: “global” (contains every task pending assignation), “workbin_{agent_id}” (contains every tasks assigned to the {agent_id} agent, “history” (contains every processed tasks), and “undelivered” (contains every undelivered tasks). If queue is set to “workbins” all the tasks currently in a workbin will be returned. (optional) 
            var channelId = channelId_example;  // string | To filter tasks on given channel id. (optional) 
            var step = step_example;  // string | To filter tasks on the step they’re currently in. (optional) 
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all tasks
                GetAllTasksResponse result = apiInstance.GetAllTasks(queue, channelId, step, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetAllTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queue** | **string**| To filter tasks on given queue name (filters on the “global” queue by default).The most commonly used queues are: “global” (contains every task pending assignation), “workbin_{agent_id}” (contains every tasks assigned to the {agent_id} agent, “history” (contains every processed tasks), and “undelivered” (contains every undelivered tasks). If queue is set to “workbins” all the tasks currently in a workbin will be returned. | [optional] 
 **channelId** | **string**| To filter tasks on given channel id. | [optional] 
 **step** | **string**| To filter tasks on the step they’re currently in. | [optional] 
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllTasksResponse**](GetAllTasksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettask"></a>
# **GetTask**
> Task GetTask (string taskId)

Getting a task from its id

This method renders a task from given id.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetTaskExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | 

            try
            {
                // Getting a task from its id
                Task result = apiInstance.GetTask(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**|  | 

### Return type

[**Task**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="movetask"></a>
# **MoveTask**
> Task MoveTask (string taskId, string queue)

Move a task to another queue

This method changes a task queue and renders it in case of success. Only accepts “undelivered” and special queue defined in topology (e.g. triage).  Authorization​: only users that have the right to monitor the task view.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class MoveTaskExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | 
            var queue = queue_example;  // string | Name of the queue task has to be moved in.

            try
            {
                // Move a task to another queue
                Task result = apiInstance.MoveTask(taskId, queue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.MoveTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**|  | 
 **queue** | **string**| Name of the queue task has to be moved in. | 

### Return type

[**Task**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="transfertask"></a>
# **TransferTask**
> Task TransferTask (string taskId, List<string> agentIds = null, string bypass = null, List<string> categoryIds = null, string language = null, List<string> teamIds = null, string comment = null)

Transferring a task

This method transfers an existing task and renders it in case of success.  Authorization​: only users that have the right to monitor the task view.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class TransferTaskExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | 
            var agentIds = new List<string>(); // List<string> | List of agents to transfer the task to (multiple). (optional) 
            var bypass = bypass_example;  // string | Force the transfer to the first agent in agent_ids if set. When bypass is used, (optional) 
            var categoryIds = new List<string>(); // List<string> | Filter agents receiving the task depending on their categories. (optional) 
            var language = language_example;  // string | Filter agents receiving the task depending on their spoken languages. (optional) 
            var teamIds = new List<string>(); // List<string> | Filter agents receiving the task depending on their teams. (optional) 
            var comment = comment_example;  // string | Add a comment to the task. (optional) 

            try
            {
                // Transferring a task
                Task result = apiInstance.TransferTask(taskId, agentIds, bypass, categoryIds, language, teamIds, comment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TransferTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**|  | 
 **agentIds** | [**List&lt;string&gt;**](string.md)| List of agents to transfer the task to (multiple). | [optional] 
 **bypass** | **string**| Force the transfer to the first agent in agent_ids if set. When bypass is used, | [optional] 
 **categoryIds** | [**List&lt;string&gt;**](string.md)| Filter agents receiving the task depending on their categories. | [optional] 
 **language** | **string**| Filter agents receiving the task depending on their spoken languages. | [optional] 
 **teamIds** | [**List&lt;string&gt;**](string.md)| Filter agents receiving the task depending on their teams. | [optional] 
 **comment** | **string**| Add a comment to the task. | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
