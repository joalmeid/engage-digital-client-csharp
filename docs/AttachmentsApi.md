# RingCentral.EngageDigital.Api.AttachmentsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAttachment**](AttachmentsApi.md#createattachment) | **POST** /attachments | Creating an attachment
[**GetAllAttachments**](AttachmentsApi.md#getallattachments) | **GET** /attachments | Getting all attachments
[**GetAttachment**](AttachmentsApi.md#getattachment) | **GET** /attachments/{attachmentId} | Getting an attachment from its id

<a name="createattachment"></a>
# **CreateAttachment**
> Attachment CreateAttachment (Body body = null)

Creating an attachment

This method allows you to create an new attachment.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreateAttachmentExample
    {
        public void main()
        {
            var apiInstance = new AttachmentsApi();
            var body = new Body(); // Body |  (optional) 

            try
            {
                // Creating an attachment
                Attachment result = apiInstance.CreateAttachment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.CreateAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)|  | [optional] 

### Return type

[**Attachment**](Attachment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data:
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallattachments"></a>
# **GetAllAttachments**
> GetAllAttachmentsResponse GetAllAttachments (int? offset = null, int? limit = null)

Getting all attachments

This method renders attachments ordered by creation date (descending).

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllAttachmentsExample
    {
        public void main()
        {
            var apiInstance = new AttachmentsApi();
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all attachments
                GetAllAttachmentsResponse result = apiInstance.GetAllAttachments(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.GetAllAttachments: " + e.Message );
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

[**GetAllAttachmentsResponse**](GetAllAttachmentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getattachment"></a>
# **GetAttachment**
> Attachment GetAttachment (string attachmentId)

Getting an attachment from its id

This method renders an attachment from given id.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAttachmentExample
    {
        public void main()
        {
            var apiInstance = new AttachmentsApi();
            var attachmentId = attachmentId_example;  // string | 

            try
            {
                // Getting an attachment from its id
                Attachment result = apiInstance.GetAttachment(attachmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.GetAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **string**|  | 

### Return type

[**Attachment**](Attachment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
