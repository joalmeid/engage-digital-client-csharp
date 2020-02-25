# RingCentral.EngageDigital.Api.ReplyAssistantGroupsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateReplyAssistantGroup**](ReplyAssistantGroupsApi.md#createreplyassistantgroup) | **POST** /reply_assistant/groups | Creating a reply assistant group
[**DeleteReplyAssistantGroup**](ReplyAssistantGroupsApi.md#deletereplyassistantgroup) | **DELETE** /reply_assistant/groups/{replyAssistantGroupId} | Deleting a reply assistant group
[**GetAllReplyAssistantGroups**](ReplyAssistantGroupsApi.md#getallreplyassistantgroups) | **GET** /reply_assistant/groups | Getting​ a​ll​ reply assistant groups
[**GetReplyAssistantGroup**](ReplyAssistantGroupsApi.md#getreplyassistantgroup) | **GET** /reply_assistant/groups/{replyAssistantGroupId} | Getting a reply assistant group from its id
[**UpdateReplyAssistantGroup**](ReplyAssistantGroupsApi.md#updatereplyassistantgroup) | **PUT** /reply_assistant/groups/{replyAssistantGroupId} | Updating a reply assistant group


<a name="createreplyassistantgroup"></a>
# **CreateReplyAssistantGroup**
> ReplyAssistantGroup CreateReplyAssistantGroup (string name, Collection<string> entryIds = null, bool? autocomplete = null, int? position = null)

Creating a reply assistant group

This method creates an entry group. In case of success it renders the group, otherwise, it renders an error (422 HTTP code).  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreateReplyAssistantGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ReplyAssistantGroupsApi(config);
            var name = name_example;  // string | The name of the group.
            var entryIds = new Collection<string>(); // Collection<string> | List of the reply assistant entries in this group. (optional) 
            var autocomplete = true;  // bool? | Used for autocompletion in chat. (optional) 
            var position = 56;  // int? | Used to determine the order of the groups in the interface, in ascending order. (optional) 

            try
            {
                // Creating a reply assistant group
                ReplyAssistantGroup result = apiInstance.CreateReplyAssistantGroup(name, entryIds, autocomplete, position);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplyAssistantGroupsApi.CreateReplyAssistantGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the group. | 
 **entryIds** | [**Collection&lt;string&gt;**](string.md)| List of the reply assistant entries in this group. | [optional] 
 **autocomplete** | **bool?**| Used for autocompletion in chat. | [optional] 
 **position** | **int?**| Used to determine the order of the groups in the interface, in ascending order. | [optional] 

### Return type

[**ReplyAssistantGroup**](ReplyAssistantGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereplyassistantgroup"></a>
# **DeleteReplyAssistantGroup**
> ReplyAssistantGroup DeleteReplyAssistantGroup (string replyAssistantGroupId)

Deleting a reply assistant group

This method destroys an existing group. It renders the group itself. It renders a 404 if id is invalid.  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class DeleteReplyAssistantGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ReplyAssistantGroupsApi(config);
            var replyAssistantGroupId = replyAssistantGroupId_example;  // string | 

            try
            {
                // Deleting a reply assistant group
                ReplyAssistantGroup result = apiInstance.DeleteReplyAssistantGroup(replyAssistantGroupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplyAssistantGroupsApi.DeleteReplyAssistantGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replyAssistantGroupId** | **string**|  | 

### Return type

[**ReplyAssistantGroup**](ReplyAssistantGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallreplyassistantgroups"></a>
# **GetAllReplyAssistantGroups**
> GetAllReplyAssistantGroupsResponse GetAllReplyAssistantGroups (int? offset = null, int? limit = null)

Getting​ a​ll​ reply assistant groups

This method renders all groups ordered by creation date (ascending).  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllReplyAssistantGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ReplyAssistantGroupsApi(config);
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting​ a​ll​ reply assistant groups
                GetAllReplyAssistantGroupsResponse result = apiInstance.GetAllReplyAssistantGroups(offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplyAssistantGroupsApi.GetAllReplyAssistantGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllReplyAssistantGroupsResponse**](GetAllReplyAssistantGroupsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplyassistantgroup"></a>
# **GetReplyAssistantGroup**
> ReplyAssistantGroup GetReplyAssistantGroup (string replyAssistantGroupId)

Getting a reply assistant group from its id

This method renders an entry group from given id.  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetReplyAssistantGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ReplyAssistantGroupsApi(config);
            var replyAssistantGroupId = replyAssistantGroupId_example;  // string | 

            try
            {
                // Getting a reply assistant group from its id
                ReplyAssistantGroup result = apiInstance.GetReplyAssistantGroup(replyAssistantGroupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplyAssistantGroupsApi.GetReplyAssistantGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replyAssistantGroupId** | **string**|  | 

### Return type

[**ReplyAssistantGroup**](ReplyAssistantGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereplyassistantgroup"></a>
# **UpdateReplyAssistantGroup**
> ReplyAssistantGroup UpdateReplyAssistantGroup (string replyAssistantGroupId, string name = null, Collection<string> entryIds = null, bool? autocomplete = null, int? position = null)

Updating a reply assistant group

This method updates an existing group from given attributes and renders it in case of success.  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class UpdateReplyAssistantGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ReplyAssistantGroupsApi(config);
            var replyAssistantGroupId = replyAssistantGroupId_example;  // string | 
            var name = name_example;  // string | The name of the group. (optional) 
            var entryIds = new Collection<string>(); // Collection<string> | List of the reply assistant entries in this group. (optional) 
            var autocomplete = true;  // bool? | Used for autocompletion in chat. (optional) 
            var position = 56;  // int? | Used to determine the order of the groups in the interface, in ascending order. (optional) 

            try
            {
                // Updating a reply assistant group
                ReplyAssistantGroup result = apiInstance.UpdateReplyAssistantGroup(replyAssistantGroupId, name, entryIds, autocomplete, position);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplyAssistantGroupsApi.UpdateReplyAssistantGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replyAssistantGroupId** | **string**|  | 
 **name** | **string**| The name of the group. | [optional] 
 **entryIds** | [**Collection&lt;string&gt;**](string.md)| List of the reply assistant entries in this group. | [optional] 
 **autocomplete** | **bool?**| Used for autocompletion in chat. | [optional] 
 **position** | **int?**| Used to determine the order of the groups in the interface, in ascending order. | [optional] 

### Return type

[**ReplyAssistantGroup**](ReplyAssistantGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

