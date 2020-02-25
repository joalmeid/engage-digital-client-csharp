# RingCentral.EngageDigital.Api.PresenceStatusApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePresenceStatus**](PresenceStatusApi.md#createpresencestatus) | **POST** /presence_status | Creating a presence status
[**DeletePresenceStatus**](PresenceStatusApi.md#deletepresencestatus) | **DELETE** /presence_status/{presenceStatusId} | Deleting a presence status
[**GetAllPresenceStatus**](PresenceStatusApi.md#getallpresencestatus) | **GET** /presence_status | Getting all presence statuses
[**GetPresenceStatus**](PresenceStatusApi.md#getpresencestatus) | **GET** /presence_status/{presenceStatusId} | Getting a presence status from its id
[**UpdatePresenceStatus**](PresenceStatusApi.md#updatepresencestatus) | **PUT** /presence_status/{presenceStatusId} | Updating a presence status


<a name="createpresencestatus"></a>
# **CreatePresenceStatus**
> PresenceStatus CreatePresenceStatus (string name)

Creating a presence status

This method creates a presence status. In case of success it renders the presence status, otherwise, it renders an error (422 HTTP code).  Authorization​: only users that have the right to monitor the task view.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreatePresenceStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new PresenceStatusApi(config);
            var name = name_example;  // string | The name of the presence status.

            try
            {
                // Creating a presence status
                PresenceStatus result = apiInstance.CreatePresenceStatus(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PresenceStatusApi.CreatePresenceStatus: " + e.Message );
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
 **name** | **string**| The name of the presence status. | 

### Return type

[**PresenceStatus**](PresenceStatus.md)

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

<a name="deletepresencestatus"></a>
# **DeletePresenceStatus**
> PresenceStatus DeletePresenceStatus (string presenceStatusId)

Deleting a presence status

This method destroys an existing presence status. It renders presence status itself. It renders a 404 if id is invalid.  Authorization​: only users that have the right to monitor the task view.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class DeletePresenceStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new PresenceStatusApi(config);
            var presenceStatusId = presenceStatusId_example;  // string | 

            try
            {
                // Deleting a presence status
                PresenceStatus result = apiInstance.DeletePresenceStatus(presenceStatusId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PresenceStatusApi.DeletePresenceStatus: " + e.Message );
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
 **presenceStatusId** | **string**|  | 

### Return type

[**PresenceStatus**](PresenceStatus.md)

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

<a name="getallpresencestatus"></a>
# **GetAllPresenceStatus**
> GetAllPresenceStatusResponse GetAllPresenceStatus (int? offset = null, int? limit = null)

Getting all presence statuses

This method renders all presence statuses ordered by name (in alphabetical order).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllPresenceStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new PresenceStatusApi(config);
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all presence statuses
                GetAllPresenceStatusResponse result = apiInstance.GetAllPresenceStatus(offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PresenceStatusApi.GetAllPresenceStatus: " + e.Message );
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

[**GetAllPresenceStatusResponse**](GetAllPresenceStatusResponse.md)

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

<a name="getpresencestatus"></a>
# **GetPresenceStatus**
> PresenceStatus GetPresenceStatus (string presenceStatusId)

Getting a presence status from its id

This method renders a presence status from given id.  Authorization​: only users that have the right to monitor the task view.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetPresenceStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new PresenceStatusApi(config);
            var presenceStatusId = presenceStatusId_example;  // string | 

            try
            {
                // Getting a presence status from its id
                PresenceStatus result = apiInstance.GetPresenceStatus(presenceStatusId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PresenceStatusApi.GetPresenceStatus: " + e.Message );
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
 **presenceStatusId** | **string**|  | 

### Return type

[**PresenceStatus**](PresenceStatus.md)

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

<a name="updatepresencestatus"></a>
# **UpdatePresenceStatus**
> PresenceStatus UpdatePresenceStatus (string presenceStatusId, string name)

Updating a presence status

This method updates an existing presence status from given attributes and renders it in case of success.  Authorization​: only users that have the right to monitor the task view.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class UpdatePresenceStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new PresenceStatusApi(config);
            var presenceStatusId = presenceStatusId_example;  // string | 
            var name = name_example;  // string | The name of the presence status.

            try
            {
                // Updating a presence status
                PresenceStatus result = apiInstance.UpdatePresenceStatus(presenceStatusId, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PresenceStatusApi.UpdatePresenceStatus: " + e.Message );
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
 **presenceStatusId** | **string**|  | 
 **name** | **string**| The name of the presence status. | 

### Return type

[**PresenceStatus**](PresenceStatus.md)

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

