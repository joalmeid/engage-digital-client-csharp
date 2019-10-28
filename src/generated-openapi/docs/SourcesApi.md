# Org.OpenAPITools.Api.SourcesApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllSources**](SourcesApi.md#getallsources) | **GET** /content_sources | Getting all sources
[**GetSource**](SourcesApi.md#getsource) | **GET** /content_sources/{sourceId} | Getting a source from its id
[**UpdateSource**](SourcesApi.md#updatesource) | **PUT** /content_sources/{sourceId} | Updating a source


<a name="getallsources"></a>
# **GetAllSources**
> GetAllSourcesResponse GetAllSources (int? offset = null, int? limit = null)

Getting all sources

This method renders sources ordered by creation date (ascending).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAllSourcesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new SourcesApi(Configuration.Default);
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all sources
                GetAllSourcesResponse result = apiInstance.GetAllSources(offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.GetAllSources: " + e.Message );
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

[**GetAllSourcesResponse**](GetAllSourcesResponse.md)

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

<a name="getsource"></a>
# **GetSource**
> Source GetSource (string sourceId)

Getting a source from its id

This method renders a source from given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSourceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new SourcesApi(Configuration.Default);
            var sourceId = sourceId_example;  // string | 

            try
            {
                // Getting a source from its id
                Source result = apiInstance.GetSource(sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.GetSource: " + e.Message );
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
 **sourceId** | **string**|  | 

### Return type

[**Source**](Source.md)

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

<a name="updatesource"></a>
# **UpdateSource**
> Source UpdateSource (string sourceId, string name = null, bool? active = null, string channelId = null, int? color = null, int? slaResponse = null, string slaExpiredStrategy = null, int? interventionMessagesBoost = null, int? transferredTasksBoost = null, bool? hiddenFromStats = null, List<string> defaultCategoryIds = null, List<string> userThreadDefaultCategoryIds = null, string defaultContentLanguage = null, bool? autoDetectContentLanguage = null, bool? contentArchiving = null, int? contentArchivingPeriod = null)

Updating a source

This method updates an existing source from given attributes and renders it in case of success.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateSourceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new SourcesApi(Configuration.Default);
            var sourceId = sourceId_example;  // string | 
            var name = name_example;  // string | Source name (optional) 
            var active = true;  // bool? | Activate/deactivate the source (Boolean) (optional) 
            var channelId = channelId_example;  // string | Channel (optional) 
            var color = 56;  // int? | Color of the icon (see S​ ource colors​) (Integer) (optional) 
            var slaResponse = 56;  // int? | Response time (seconds) (optional) 
            var slaExpiredStrategy = slaExpiredStrategy_example;  // string | SLA expired strategy (\"max\", \"half\" or \"base\") (optional) 
            var interventionMessagesBoost = 56;  // int? | Priority boost of messages with intervention (Integer) (optional) 
            var transferredTasksBoost = 56;  // int? | Priority boost of transferred tasks (Integer) (optional) 
            var hiddenFromStats = true;  // bool? | Hide from statistics (Boolean) (optional) 
            var defaultCategoryIds = new List<string>(); // List<string> | Default categories (optional) 
            var userThreadDefaultCategoryIds = new List<string>(); // List<string> | Default categories (agent messages) (optional) 
            var defaultContentLanguage = defaultContentLanguage_example;  // string | Default content language (optional) 
            var autoDetectContentLanguage = true;  // bool? | Auto-detect content language (Boolean) (optional) 
            var contentArchiving = true;  // bool? | Automatic archiving of old contents (Boolean) (optional) 
            var contentArchivingPeriod = 56;  // int? | Archive contents older than (seconds) (optional) 

            try
            {
                // Updating a source
                Source result = apiInstance.UpdateSource(sourceId, name, active, channelId, color, slaResponse, slaExpiredStrategy, interventionMessagesBoost, transferredTasksBoost, hiddenFromStats, defaultCategoryIds, userThreadDefaultCategoryIds, defaultContentLanguage, autoDetectContentLanguage, contentArchiving, contentArchivingPeriod);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.UpdateSource: " + e.Message );
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
 **sourceId** | **string**|  | 
 **name** | **string**| Source name | [optional] 
 **active** | **bool?**| Activate/deactivate the source (Boolean) | [optional] 
 **channelId** | **string**| Channel | [optional] 
 **color** | **int?**| Color of the icon (see S​ ource colors​) (Integer) | [optional] 
 **slaResponse** | **int?**| Response time (seconds) | [optional] 
 **slaExpiredStrategy** | **string**| SLA expired strategy (\&quot;max\&quot;, \&quot;half\&quot; or \&quot;base\&quot;) | [optional] 
 **interventionMessagesBoost** | **int?**| Priority boost of messages with intervention (Integer) | [optional] 
 **transferredTasksBoost** | **int?**| Priority boost of transferred tasks (Integer) | [optional] 
 **hiddenFromStats** | **bool?**| Hide from statistics (Boolean) | [optional] 
 **defaultCategoryIds** | [**List&lt;string&gt;**](string.md)| Default categories | [optional] 
 **userThreadDefaultCategoryIds** | [**List&lt;string&gt;**](string.md)| Default categories (agent messages) | [optional] 
 **defaultContentLanguage** | **string**| Default content language | [optional] 
 **autoDetectContentLanguage** | **bool?**| Auto-detect content language (Boolean) | [optional] 
 **contentArchiving** | **bool?**| Automatic archiving of old contents (Boolean) | [optional] 
 **contentArchivingPeriod** | **int?**| Archive contents older than (seconds) | [optional] 

### Return type

[**Source**](Source.md)

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

