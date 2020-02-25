# RingCentral.EngageDigital.Api.EventsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllEvents**](EventsApi.md#getallevents) | **GET** /events | Getting all events
[**GetEvent**](EventsApi.md#getevent) | **GET** /events/{eventId} | Getting an event from its id


<a name="getallevents"></a>
# **GetAllEvents**
> GetAllEventsResponse GetAllEvents (string q = null, int? offset = null, int? limit = null)

Getting all events

This method renders events ordered by creation date (descending).  Authorization​: Only users whose role can search event permission.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new EventsApi(config);
            var q = q_example;  // string | To filter events on given query. Query works exactly like threads query but only have those keywords: content, content_thread, name_in, created_before, created_after, user. Order can be created_at.desc (default) or created_at.asc. e.g. q=name_in:\"content.replied\"%20content_thread:\"7f946431b6eebffafae642cc\"%20created_after:\"2014-03-20\"%20user:\"4ee91f197aa58d01b500000f\"%20order:\"created_at.asc\" * DateTime parameters should be ISO-8601 * you can specify multiple value for a given keyword: q=name_in:’content.replied’&name_in:’content.ignored’ Please refer to ​Search & filtering parameters​ for more details. (optional) 
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all events
                GetAllEventsResponse result = apiInstance.GetAllEvents(q, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetAllEvents: " + e.Message );
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
 **q** | **string**| To filter events on given query. Query works exactly like threads query but only have those keywords: content, content_thread, name_in, created_before, created_after, user. Order can be created_at.desc (default) or created_at.asc. e.g. q&#x3D;name_in:\&quot;content.replied\&quot;%20content_thread:\&quot;7f946431b6eebffafae642cc\&quot;%20created_after:\&quot;2014-03-20\&quot;%20user:\&quot;4ee91f197aa58d01b500000f\&quot;%20order:\&quot;created_at.asc\&quot; * DateTime parameters should be ISO-8601 * you can specify multiple value for a given keyword: q&#x3D;name_in:’content.replied’&amp;name_in:’content.ignored’ Please refer to ​Search &amp; filtering parameters​ for more details. | [optional] 
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllEventsResponse**](GetAllEventsResponse.md)

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

<a name="getevent"></a>
# **GetEvent**
> Event GetEvent (string eventId)

Getting an event from its id

This method renders an event from given id. If token’s user role does not have “search event” permission a 404 HTTP response will be returned.  Authorization​: Only users who’s role can search event permission.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new EventsApi(config);
            var eventId = eventId_example;  // string | 

            try
            {
                // Getting an event from its id
                Event result = apiInstance.GetEvent(eventId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetEvent: " + e.Message );
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
 **eventId** | **string**|  | 

### Return type

[**Event**](Event.md)

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

