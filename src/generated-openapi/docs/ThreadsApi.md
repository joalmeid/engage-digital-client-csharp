# Org.OpenAPITools.Api.ThreadsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveThread**](ThreadsApi.md#archivethread) | **PUT** /content_threads/{threadId}/ignore | Archiving a thread
[**CategorizeThread**](ThreadsApi.md#categorizethread) | **PUT** /content_threads/{threadId}/update_categories | Categorizing a thread
[**CloseThread**](ThreadsApi.md#closethread) | **PUT** /content_threads/{threadId}/close | Close a thread
[**GetAllThreads**](ThreadsApi.md#getallthreads) | **GET** /content_threads | Getting all threads
[**GetThread**](ThreadsApi.md#getthread) | **GET** /content_threads/{threadId} | Getting a thread from its id
[**OpenThread**](ThreadsApi.md#openthread) | **GET** /content_threads/{threadId}/open | Open a thread


<a name="archivethread"></a>
# **ArchiveThread**
> Thread ArchiveThread (string threadId)

Archiving a thread

Archives the contents of a thread. If token’s user does not have “read” on thread’s source a 404 HTTP response will be returned.  If the thread is already being archived, a 409 HTTP response will be returned.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveThreadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ThreadsApi(Configuration.Default);
            var threadId = threadId_example;  // string | 

            try
            {
                // Archiving a thread
                Thread result = apiInstance.ArchiveThread(threadId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.ArchiveThread: " + e.Message );
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
 **threadId** | **string**|  | 

### Return type

[**Thread**](Thread.md)

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

<a name="categorizethread"></a>
# **CategorizeThread**
> Thread CategorizeThread (string threadId, List<string> threadCategoryIds = null)

Categorizing a thread

This method updates the categories of a thread. If token’s user does not have “read” on thread’s source a 404 HTTP response will be returned.  If the thread is already being categorized, a 409 HTTP response will be returned.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategorizeThreadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ThreadsApi(Configuration.Default);
            var threadId = threadId_example;  // string | 
            var threadCategoryIds = new List<string>(); // List<string> | An array containing the new categories to set on the thread. (optional) 

            try
            {
                // Categorizing a thread
                Thread result = apiInstance.CategorizeThread(threadId, threadCategoryIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.CategorizeThread: " + e.Message );
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
 **threadId** | **string**|  | 
 **threadCategoryIds** | [**List&lt;string&gt;**](string.md)| An array containing the new categories to set on the thread. | [optional] 

### Return type

[**Thread**](Thread.md)

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

<a name="closethread"></a>
# **CloseThread**
> Thread CloseThread (string threadId)

Close a thread

Thread closure/opening is only available for the following sources: * Emails * Answers * Ideas * Facebook Messenger * Google+ * Lithium * Mobile Messaging  Starts a job to close a thread. It returns the thread but as the job is asynchronous, the state of the “close” attribute in the returned object do not is the one when the job started.  If token’s user does not have “read” on thread’s source a 404 HTTP response will be returned. Returns a 403 if the thread cannot be closed or if the user does not have the permission to close a thread.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CloseThreadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ThreadsApi(Configuration.Default);
            var threadId = threadId_example;  // string | 

            try
            {
                // Close a thread
                Thread result = apiInstance.CloseThread(threadId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.CloseThread: " + e.Message );
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
 **threadId** | **string**|  | 

### Return type

[**Thread**](Thread.md)

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

<a name="getallthreads"></a>
# **GetAllThreads**
> GetAllThreadsResponse GetAllThreads (int? q = null, int? offset = null, int? limit = null)

Getting all threads

This method renders threads ordered by last content date (descending). Only threads in sources where token’s user has “read” permission are returned.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAllThreadsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ThreadsApi(Configuration.Default);
            var q = 56;  // int? | A search query to filter threads. Please refer to ​Search & filtering parameters​ for more details. (optional) 
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all threads
                GetAllThreadsResponse result = apiInstance.GetAllThreads(q, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.GetAllThreads: " + e.Message );
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
 **q** | **int?**| A search query to filter threads. Please refer to ​Search &amp; filtering parameters​ for more details. | [optional] 
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllThreadsResponse**](GetAllThreadsResponse.md)

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

<a name="getthread"></a>
# **GetThread**
> Thread GetThread (string threadId)

Getting a thread from its id

This method renders a thread from given id. If token’s user does not have “read” on thread’s source a 404 HTTP response will be returned.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetThreadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ThreadsApi(Configuration.Default);
            var threadId = threadId_example;  // string | 

            try
            {
                // Getting a thread from its id
                Thread result = apiInstance.GetThread(threadId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.GetThread: " + e.Message );
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
 **threadId** | **string**|  | 

### Return type

[**Thread**](Thread.md)

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

<a name="openthread"></a>
# **OpenThread**
> Thread OpenThread (string threadId)

Open a thread

Thread closure/opening is only available for the following sources:  * Emails * Answers * Ideas * Facebook Messenger * Google+ * Lithium * Mobile Messaging  Starts a job to open a thread. It returns the thread but as the job is asynchronous, the state of the “close” attribute in the returned object is the one when the job started.  If token’s user does not have “read” on thread’s source a 404 HTTP response will be returned. Returns a 403 if the thread cannot be opened or if the user does not have the permission to open a thread.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OpenThreadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ThreadsApi(Configuration.Default);
            var threadId = threadId_example;  // string | 

            try
            {
                // Open a thread
                Thread result = apiInstance.OpenThread(threadId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.OpenThread: " + e.Message );
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
 **threadId** | **string**|  | 

### Return type

[**Thread**](Thread.md)

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

