# RingCentral.EngageDigital.Api.ReplyAssistantVersionsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateReplyAssistantVersion**](ReplyAssistantVersionsApi.md#createreplyassistantversion) | **POST** /reply_assistant/versions | Creating a reply assistant version
[**DeleteReplyAssistantVersion**](ReplyAssistantVersionsApi.md#deletereplyassistantversion) | **DELETE** /reply_assistant/versions/{replyAssistantVersionId} | Deleting a reply assistant version
[**GetAllReplyAssistantVersions**](ReplyAssistantVersionsApi.md#getallreplyassistantversions) | **GET** /reply_assistant/versions | Getting​ a​ll​ reply assistant versions
[**GetReplyAssistantVersion**](ReplyAssistantVersionsApi.md#getreplyassistantversion) | **GET** /reply_assistant/versions/{replyAssistantVersionId} | Getting a reply assistant version from its id
[**UpdateReplyAssistantVersion**](ReplyAssistantVersionsApi.md#updatereplyassistantversion) | **PUT** /reply_assistant/versions/{replyAssistantVersionId} | Updating a reply assistant version


<a name="createreplyassistantversion"></a>
# **CreateReplyAssistantVersion**
> ReplyAssistantVersion CreateReplyAssistantVersion (string body, string entryId, Collection<string> sourceIds = null, string format = null, string language = null)

Creating a reply assistant version

This method creates a reply assistant version. In case of success it renders the version, otherwise, it renders an error (422 HTTP code, 404 if the entry_id is invalid).  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreateReplyAssistantVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ReplyAssistantVersionsApi(config);
            var body = body_example;  // string | Body of the version
            var entryId = entryId_example;  // string | Reply assistant entry id (mandatory)
            var sourceIds = new Collection<string>(); // Collection<string> | Source ids (array) (optional) 
            var format = format_example;  // string | Either “text” or “html” (optional) 
            var language = language_example;  // string | Language (ex: “fr”) (optional) 

            try
            {
                // Creating a reply assistant version
                ReplyAssistantVersion result = apiInstance.CreateReplyAssistantVersion(body, entryId, sourceIds, format, language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplyAssistantVersionsApi.CreateReplyAssistantVersion: " + e.Message );
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
 **body** | **string**| Body of the version | 
 **entryId** | **string**| Reply assistant entry id (mandatory) | 
 **sourceIds** | [**Collection&lt;string&gt;**](string.md)| Source ids (array) | [optional] 
 **format** | **string**| Either “text” or “html” | [optional] 
 **language** | **string**| Language (ex: “fr”) | [optional] 

### Return type

[**ReplyAssistantVersion**](ReplyAssistantVersion.md)

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

<a name="deletereplyassistantversion"></a>
# **DeleteReplyAssistantVersion**
> ReplyAssistantVersion DeleteReplyAssistantVersion (string replyAssistantVersionId)

Deleting a reply assistant version

This method destroys an existing version. It renders the version itself. It renders a 404 if id is invalid.  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class DeleteReplyAssistantVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ReplyAssistantVersionsApi(config);
            var replyAssistantVersionId = replyAssistantVersionId_example;  // string | 

            try
            {
                // Deleting a reply assistant version
                ReplyAssistantVersion result = apiInstance.DeleteReplyAssistantVersion(replyAssistantVersionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplyAssistantVersionsApi.DeleteReplyAssistantVersion: " + e.Message );
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
 **replyAssistantVersionId** | **string**|  | 

### Return type

[**ReplyAssistantVersion**](ReplyAssistantVersion.md)

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

<a name="getallreplyassistantversions"></a>
# **GetAllReplyAssistantVersions**
> GetAllReplyAssistantVersionsResponse GetAllReplyAssistantVersions (int? offset = null, int? limit = null)

Getting​ a​ll​ reply assistant versions

This method renders all reply assistant versions ordered by creation date (ascending).  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllReplyAssistantVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ReplyAssistantVersionsApi(config);
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting​ a​ll​ reply assistant versions
                GetAllReplyAssistantVersionsResponse result = apiInstance.GetAllReplyAssistantVersions(offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplyAssistantVersionsApi.GetAllReplyAssistantVersions: " + e.Message );
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

[**GetAllReplyAssistantVersionsResponse**](GetAllReplyAssistantVersionsResponse.md)

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

<a name="getreplyassistantversion"></a>
# **GetReplyAssistantVersion**
> ReplyAssistantVersion GetReplyAssistantVersion (string replyAssistantVersionId)

Getting a reply assistant version from its id

This method renders a version from given id.  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetReplyAssistantVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ReplyAssistantVersionsApi(config);
            var replyAssistantVersionId = replyAssistantVersionId_example;  // string | 

            try
            {
                // Getting a reply assistant version from its id
                ReplyAssistantVersion result = apiInstance.GetReplyAssistantVersion(replyAssistantVersionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplyAssistantVersionsApi.GetReplyAssistantVersion: " + e.Message );
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
 **replyAssistantVersionId** | **string**|  | 

### Return type

[**ReplyAssistantVersion**](ReplyAssistantVersion.md)

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

<a name="updatereplyassistantversion"></a>
# **UpdateReplyAssistantVersion**
> ReplyAssistantVersion UpdateReplyAssistantVersion (string replyAssistantVersionId, string body = null, string entryId = null, Collection<string> sourceIds = null, string format = null, string language = null)

Updating a reply assistant version

This method updates an existing version from given attributes and renders it in case of success.  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class UpdateReplyAssistantVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ReplyAssistantVersionsApi(config);
            var replyAssistantVersionId = replyAssistantVersionId_example;  // string | 
            var body = body_example;  // string | Body of the version (optional) 
            var entryId = entryId_example;  // string | Reply assistant entry id. (optional) 
            var sourceIds = new Collection<string>(); // Collection<string> | Source ids (array) (optional) 
            var format = format_example;  // string | Either “text” or “html” (optional) 
            var language = language_example;  // string | Language (ex: “fr”) (optional) 

            try
            {
                // Updating a reply assistant version
                ReplyAssistantVersion result = apiInstance.UpdateReplyAssistantVersion(replyAssistantVersionId, body, entryId, sourceIds, format, language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplyAssistantVersionsApi.UpdateReplyAssistantVersion: " + e.Message );
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
 **replyAssistantVersionId** | **string**|  | 
 **body** | **string**| Body of the version | [optional] 
 **entryId** | **string**| Reply assistant entry id. | [optional] 
 **sourceIds** | [**Collection&lt;string&gt;**](string.md)| Source ids (array) | [optional] 
 **format** | **string**| Either “text” or “html” | [optional] 
 **language** | **string**| Language (ex: “fr”) | [optional] 

### Return type

[**ReplyAssistantVersion**](ReplyAssistantVersion.md)

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

