# RingCentral.EngageDigital.Api.ContentsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CategorizeContent**](ContentsApi.md#categorizecontent) | **PUT** /contents/{contentId}/update_categories | Categorizing a content
[**CreateContent**](ContentsApi.md#createcontent) | **POST** /contents | Creating a content
[**GetAllContents**](ContentsApi.md#getallcontents) | **GET** /contents | Contents
[**GetContent**](ContentsApi.md#getcontent) | **GET** /contents/{contentId} | Getting a content from its id
[**IgnoreContent**](ContentsApi.md#ignorecontent) | **PUT** /contents/{contentId}/ignore | Ignoring a content


<a name="categorizecontent"></a>
# **CategorizeContent**
> Content CategorizeContent (string contentId, Collection<string> categoryIds)

Categorizing a content

This method updates the categories of a content. If token’s user does not have “read” on this content’s source a 404 HTTP response will be returned.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CategorizeContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ContentsApi(config);
            var contentId = contentId_example;  // string | 
            var categoryIds = new Collection<string>(); // Collection<string> | An array containing the new categories to set on the content.

            try
            {
                // Categorizing a content
                Content result = apiInstance.CategorizeContent(contentId, categoryIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentsApi.CategorizeContent: " + e.Message );
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
 **contentId** | **string**|  | 
 **categoryIds** | [**Collection&lt;string&gt;**](string.md)| An array containing the new categories to set on the content. | 

### Return type

[**Content**](Content.md)

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

<a name="createcontent"></a>
# **CreateContent**
> Content CreateContent (string body, string authorId = null, string inReplyToId = null, int? _private = null, string sourceId = null, Collection<string> attachmentIds = null, string title = null, Collection<string> to = null, Collection<string> cc = null, Collection<string> bcc = null)

Creating a content

This method allows you to create an new content. It can be a reply to another content or a content that initiate discussion. It use token’s user as content user if he is authorized. Content will be created in Dimelo Digital and pushed asynchronously to the source.  Replying to a customer content is usually possible (unless the source/conversation is read only).  Composing a content on the contrary depend on the source itself: * The source may not support it (and be purely reactive like Instagram, Messenger ...) * Some sources (usually public account) like Twitter or Facebook page allows to publish content without targeting specific individuals. * Some sources (usually non public media) require specific targeting (phone number for SMS, email address for email, customer_id ...) to be able to create a content. This is source specific and detailed under the generic parameters.  Authorization​: only users that can reply or initiate discussion (= compose) on given source. it renders also an error if in_reply_to isn’t synchronized or if in_reply_to content is not under an ​open intervention.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreateContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ContentsApi(config);
            var body = body_example;  // string | The content’s body. This parameter is mandatory.
            var authorId = authorId_example;  // string | The identity id of content. This parameter is not mandatory, by default it use the token’s user first identity on source. (optional) 
            var inReplyToId = inReplyToId_example;  // string | The content’s id you want to reply to. If omitted, a new discussion will be created. If source does not support to initiate discussion this parameter is mandatory. (optional) 
            var _private = 56;  // int? | Created contents are public by default, set this parameter to \"1\" in order to create a private reply. It is NOT supported on every source. (optional) 
            var sourceId = sourceId_example;  // string | The source to create content to. If you specify `in_reply_to_id` parameter, source will be determined from it. Otherwise, this parameter is mandatory. (optional) 
            var attachmentIds = new Collection<string>(); // Collection<string> | An array containing the attachments’ ids that need to be attached to this content. (optional) 
            var title = title_example;  // string | For an email source. The subject of the email. This parameter is mandatory when initiating a discussion. (optional) 
            var to = new Collection<string>(); // Collection<string> | For an email or SMS source. For an email, an array containing the email addresses used in the “To” section of the email. This parameter is mandatory when initiating a discussion. For a SMS, the number the SMS will be sent to. It must start with 00 or +, example: +33634231224 or 0033634231224. This parameter is mandatory when initiating a discussion. (optional) 
            var cc = new Collection<string>(); // Collection<string> | For an email source. An array containing the email addresses used in the “Cc” section of the email. (optional) 
            var bcc = new Collection<string>(); // Collection<string> | For an email source. An array containing the email addresses used in the “Bcc” section of the email. (optional) 

            try
            {
                // Creating a content
                Content result = apiInstance.CreateContent(body, authorId, inReplyToId, _private, sourceId, attachmentIds, title, to, cc, bcc);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentsApi.CreateContent: " + e.Message );
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
 **body** | **string**| The content’s body. This parameter is mandatory. | 
 **authorId** | **string**| The identity id of content. This parameter is not mandatory, by default it use the token’s user first identity on source. | [optional] 
 **inReplyToId** | **string**| The content’s id you want to reply to. If omitted, a new discussion will be created. If source does not support to initiate discussion this parameter is mandatory. | [optional] 
 **_private** | **int?**| Created contents are public by default, set this parameter to \&quot;1\&quot; in order to create a private reply. It is NOT supported on every source. | [optional] 
 **sourceId** | **string**| The source to create content to. If you specify &#x60;in_reply_to_id&#x60; parameter, source will be determined from it. Otherwise, this parameter is mandatory. | [optional] 
 **attachmentIds** | [**Collection&lt;string&gt;**](string.md)| An array containing the attachments’ ids that need to be attached to this content. | [optional] 
 **title** | **string**| For an email source. The subject of the email. This parameter is mandatory when initiating a discussion. | [optional] 
 **to** | [**Collection&lt;string&gt;**](string.md)| For an email or SMS source. For an email, an array containing the email addresses used in the “To” section of the email. This parameter is mandatory when initiating a discussion. For a SMS, the number the SMS will be sent to. It must start with 00 or +, example: +33634231224 or 0033634231224. This parameter is mandatory when initiating a discussion. | [optional] 
 **cc** | [**Collection&lt;string&gt;**](string.md)| For an email source. An array containing the email addresses used in the “Cc” section of the email. | [optional] 
 **bcc** | [**Collection&lt;string&gt;**](string.md)| For an email source. An array containing the email addresses used in the “Bcc” section of the email. | [optional] 

### Return type

[**Content**](Content.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcontents"></a>
# **GetAllContents**
> GetAllContentsResponse GetAllContents (string q = null, int? offset = null, int? limit = null)

Contents

This method renders contents ordered by creation date (descending). Only contents in sources where token’s user has “read” permission are returned.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllContentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ContentsApi(config);
            var q = q_example;  // string | To filter contents on given query. Query works exactly like threads query but only have those keywords: intervention,identity, identity_group, source, status_in, thread or text. Order can be created_at.desc (default) or created_at.asc. e.g. q=intervention:\"7f946431b6eebffafae642cc\"%20source:\"d19c81948c137d86dac77216\" Please refer to ​Search & filtering parameters​ for more details. (optional) 
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Contents
                GetAllContentsResponse result = apiInstance.GetAllContents(q, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentsApi.GetAllContents: " + e.Message );
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
 **q** | **string**| To filter contents on given query. Query works exactly like threads query but only have those keywords: intervention,identity, identity_group, source, status_in, thread or text. Order can be created_at.desc (default) or created_at.asc. e.g. q&#x3D;intervention:\&quot;7f946431b6eebffafae642cc\&quot;%20source:\&quot;d19c81948c137d86dac77216\&quot; Please refer to ​Search &amp; filtering parameters​ for more details. | [optional] 
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllContentsResponse**](GetAllContentsResponse.md)

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

<a name="getcontent"></a>
# **GetContent**
> Content GetContent (string contentId)

Getting a content from its id

This method renders a content from given id. If token’s user does not have “read” on content’s source a 404 HTTP response will be returned.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ContentsApi(config);
            var contentId = contentId_example;  // string | 

            try
            {
                // Getting a content from its id
                Content result = apiInstance.GetContent(contentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentsApi.GetContent: " + e.Message );
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
 **contentId** | **string**|  | 

### Return type

[**Content**](Content.md)

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

<a name="ignorecontent"></a>
# **IgnoreContent**
> Content IgnoreContent (string contentId)

Ignoring a content

Ignores a content. If token’s user does not have “read” on content’s source a 404 HTTP response will be returned.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class IgnoreContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new ContentsApi(config);
            var contentId = contentId_example;  // string | 

            try
            {
                // Ignoring a content
                Content result = apiInstance.IgnoreContent(contentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentsApi.IgnoreContent: " + e.Message );
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
 **contentId** | **string**|  | 

### Return type

[**Content**](Content.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

