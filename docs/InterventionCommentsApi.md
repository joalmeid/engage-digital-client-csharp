# RingCentral.EngageDigital.Api.InterventionCommentsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInterventionComment**](InterventionCommentsApi.md#createinterventioncomment) | **POST** /intervention_comments | Creating an intervention comment
[**DeleteInterventionComment**](InterventionCommentsApi.md#deleteinterventioncomment) | **DELETE** /intervention_comments/{interventionCommentId} | Deleting an intervention comment
[**GetAllInterventionComments**](InterventionCommentsApi.md#getallinterventioncomments) | **GET** /intervention_comments | Getting all intervention comments
[**GetInterventionComment**](InterventionCommentsApi.md#getinterventioncomment) | **GET** /intervention_comments/{interventionCommentId} | Getting an intervention comment from its id

<a name="createinterventioncomment"></a>
# **CreateInterventionComment**
> InterventionComment CreateInterventionComment (string body, string interventionId, string userId)

Creating an intervention comment

This method creates a new intervention comment. In case of success it renders the created comment, otherwise, it renders an error (422 HTTP code). It creates comment as token’s user. If token’s user does not have “read” on given intervention’s source a 404 HTTP response will be returned.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreateInterventionCommentExample
    {
        public void main()
        {
            var apiInstance = new InterventionCommentsApi();
            var body = body_example;  // string | The comment body (mandatory).
            var interventionId = interventionId_example;  // string | The comment intervention id (mandatory).
            var userId = userId_example;  // string | The comment user id (mandatory).

            try
            {
                // Creating an intervention comment
                InterventionComment result = apiInstance.CreateInterventionComment(body, interventionId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionCommentsApi.CreateInterventionComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| The comment body (mandatory). | 
 **interventionId** | **string**| The comment intervention id (mandatory). | 
 **userId** | **string**| The comment user id (mandatory). | 

### Return type

[**InterventionComment**](InterventionComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteinterventioncomment"></a>
# **DeleteInterventionComment**
> InterventionComment DeleteInterventionComment (string interventionCommentId)

Deleting an intervention comment

This method destroys an intervention comment. It renders comment itself. If token’s user does not have “read” on comment’s source a 404 HTTP response will be returned.  Authorization​: no.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class DeleteInterventionCommentExample
    {
        public void main()
        {
            var apiInstance = new InterventionCommentsApi();
            var interventionCommentId = interventionCommentId_example;  // string | 

            try
            {
                // Deleting an intervention comment
                InterventionComment result = apiInstance.DeleteInterventionComment(interventionCommentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionCommentsApi.DeleteInterventionComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interventionCommentId** | **string**|  | 

### Return type

[**InterventionComment**](InterventionComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallinterventioncomments"></a>
# **GetAllInterventionComments**
> GetAllInterventionCommentsResponse GetAllInterventionComments (string interventionId = null, string threadId = null, string userId = null, string identityId = null, int? offset = null, int? limit = null)

Getting all intervention comments

This method renders interventions comments ordered by creation date (descending). Only comments in sources where token’s user has “read” permission are returned.  Authorization​: no.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllInterventionCommentsExample
    {
        public void main()
        {
            var apiInstance = new InterventionCommentsApi();
            var interventionId = interventionId_example;  // string | To filter comments on given intervention id. (optional) 
            var threadId = threadId_example;  // string | To filter comments on given thread id. (optional) 
            var userId = userId_example;  // string | To filter comments on given user id. (optional) 
            var identityId = identityId_example;  // string | To filter comments on given identity id. (optional) 
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all intervention comments
                GetAllInterventionCommentsResponse result = apiInstance.GetAllInterventionComments(interventionId, threadId, userId, identityId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionCommentsApi.GetAllInterventionComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interventionId** | **string**| To filter comments on given intervention id. | [optional] 
 **threadId** | **string**| To filter comments on given thread id. | [optional] 
 **userId** | **string**| To filter comments on given user id. | [optional] 
 **identityId** | **string**| To filter comments on given identity id. | [optional] 
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllInterventionCommentsResponse**](GetAllInterventionCommentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinterventioncomment"></a>
# **GetInterventionComment**
> InterventionComment GetInterventionComment (string interventionCommentId)

Getting an intervention comment from its id

This method renders an intervention comment from given id. If token’s user does not have “read” on comment’s source a 404 HTTP response will be returned.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetInterventionCommentExample
    {
        public void main()
        {
            var apiInstance = new InterventionCommentsApi();
            var interventionCommentId = interventionCommentId_example;  // string | 

            try
            {
                // Getting an intervention comment from its id
                InterventionComment result = apiInstance.GetInterventionComment(interventionCommentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionCommentsApi.GetInterventionComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interventionCommentId** | **string**|  | 

### Return type

[**InterventionComment**](InterventionComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
