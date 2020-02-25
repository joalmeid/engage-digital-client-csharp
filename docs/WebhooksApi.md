# RingCentral.EngageDigital.Api.WebhooksApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWebhook**](WebhooksApi.md#createwebhook) | **POST** /webhooks | Creating a webhook
[**DeleteWebhook**](WebhooksApi.md#deletewebhook) | **DELETE** /webhooks/{webhookId} | Deleting a webhook
[**GetAllWebhooks**](WebhooksApi.md#getallwebhooks) | **GET** /webhooks | Getting all webhooks
[**GetWebhook**](WebhooksApi.md#getwebhook) | **GET** /webhooks/{webhookId} | Getting a webhook from its id
[**UpdateWebhook**](WebhooksApi.md#updatewebhook) | **PUT** /webhooks/{webhookId} | Updating a webhook


<a name="createwebhook"></a>
# **CreateWebhook**
> Webhook CreateWebhook (string accessToken, string label, string url, Collection<string> registeredEvents, bool? active = null, bool? stagingUse = null, string verifyToken = null, string secret = null)

Creating a webhook

This method creates a webhook. In case of success it renders the webhook, otherwise, it renders an error (422 HTTP code).  Authorization​: All users having the manage_api_access_tokens permission or all users having an api access token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreateWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new WebhooksApi(config);
            var accessToken = accessToken_example;  // string | Access token.
            var label = label_example;  // string | The label of the webhook.
            var url = url_example;  // string | The url of a webhook. This is used to determine the endpoint of your webhook, where
            var registeredEvents = registeredEvents_example;  // Collection<string> | An array containing all the events that your webhook wants to subscribe.
            var active = true;  // bool? | true or false, this field is used to enable/disable a webhook. (optional) 
            var stagingUse = true;  // bool? | true or false, this field is used to determine if a webhook will be run in staging (optional) 
            var verifyToken = verifyToken_example;  // string | The token used in your webhook. (optional) 
            var secret = secret_example;  // string | The secret key that will be served as a ​`X-Dimelo-Secret​` header in every request. (optional) 

            try
            {
                // Creating a webhook
                Webhook result = apiInstance.CreateWebhook(accessToken, label, url, registeredEvents, active, stagingUse, verifyToken, secret);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.CreateWebhook: " + e.Message );
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
 **accessToken** | **string**| Access token. | 
 **label** | **string**| The label of the webhook. | 
 **url** | **string**| The url of a webhook. This is used to determine the endpoint of your webhook, where | 
 **registeredEvents** | **Collection&lt;string&gt;**| An array containing all the events that your webhook wants to subscribe. | 
 **active** | **bool?**| true or false, this field is used to enable/disable a webhook. | [optional] 
 **stagingUse** | **bool?**| true or false, this field is used to determine if a webhook will be run in staging | [optional] 
 **verifyToken** | **string**| The token used in your webhook. | [optional] 
 **secret** | **string**| The secret key that will be served as a ​&#x60;X-Dimelo-Secret​&#x60; header in every request. | [optional] 

### Return type

[**Webhook**](Webhook.md)

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

<a name="deletewebhook"></a>
# **DeleteWebhook**
> Webhook DeleteWebhook (string webhookId, string accessToken)

Deleting a webhook

This method destroys an existing webhook. It renders webhook itself. It renders a 404 if id is invalid.  Authorization​: All users having the manage_api_access_tokens permission or all users having an api access token belonging to the webhook you’re deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class DeleteWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new WebhooksApi(config);
            var webhookId = webhookId_example;  // string | 
            var accessToken = accessToken_example;  // string | Access token.

            try
            {
                // Deleting a webhook
                Webhook result = apiInstance.DeleteWebhook(webhookId, accessToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhook: " + e.Message );
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
 **webhookId** | **string**|  | 
 **accessToken** | **string**| Access token. | 

### Return type

[**Webhook**](Webhook.md)

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

<a name="getallwebhooks"></a>
# **GetAllWebhooks**
> GetAllWebhooksResponse GetAllWebhooks (string accessToken, int? offset = null, int? limit = null)

Getting all webhooks

This method renders webhooks ordered by active and staging_use (descending).  Authorization​: users having manage_api_access_tokens permission can see all webhooks / users don’t having the manage_api_access_tokens permission can see only the webhooks belonging to access token created by them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllWebhooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new WebhooksApi(config);
            var accessToken = accessToken_example;  // string | Access token.
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all webhooks
                GetAllWebhooksResponse result = apiInstance.GetAllWebhooks(accessToken, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetAllWebhooks: " + e.Message );
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
 **accessToken** | **string**| Access token. | 
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllWebhooksResponse**](GetAllWebhooksResponse.md)

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

<a name="getwebhook"></a>
# **GetWebhook**
> Webhook GetWebhook (string webhookId, string accessToken)

Getting a webhook from its id

This method renders a webhook from given id.  Authorization​: users having manage_api_access_tokens permission can see any webhook / users don’t having the `manage_api_access_tokens` permission can see only the webhook in case the webhook is associated to an access token created by them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new WebhooksApi(config);
            var webhookId = webhookId_example;  // string | 
            var accessToken = accessToken_example;  // string | Access token.

            try
            {
                // Getting a webhook from its id
                Webhook result = apiInstance.GetWebhook(webhookId, accessToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhook: " + e.Message );
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
 **webhookId** | **string**|  | 
 **accessToken** | **string**| Access token. | 

### Return type

[**Webhook**](Webhook.md)

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

<a name="updatewebhook"></a>
# **UpdateWebhook**
> Webhook UpdateWebhook (string webhookId, string accessToken, bool? active = null, string label = null, bool? stagingUse = null, string url = null, string verifyToken = null, string secret = null, Collection<string> registeredEvents = null)

Updating a webhook

This method updates an existing webhook from given attributes and renders it in case of success.  Authorization​: All users having the manage_api_access_tokens permission or all users having an api access token belonging to the webhook you’re updating.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class UpdateWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new WebhooksApi(config);
            var webhookId = webhookId_example;  // string | 
            var accessToken = accessToken_example;  // string | Access token.
            var active = true;  // bool? | true or false, this field is used to enable/disable a webhook. (optional) 
            var label = label_example;  // string | The label of the webhook. (optional) 
            var stagingUse = true;  // bool? | true or false, this field is used to determine if a webhook will be run in staging (optional) 
            var url = url_example;  // string | The url of a webhook. This is used to determine the endpoint of your webhook, where (optional) 
            var verifyToken = verifyToken_example;  // string | The token used in your webhook. (optional) 
            var secret = secret_example;  // string | The secret key that will be served as a ​`X-Dimelo-Secret​` header in every request. (optional) 
            var registeredEvents = new Collection<string>(); // Collection<string> | An array containing all the events that your webhook wants to subscribe. (optional) 

            try
            {
                // Updating a webhook
                Webhook result = apiInstance.UpdateWebhook(webhookId, accessToken, active, label, stagingUse, url, verifyToken, secret, registeredEvents);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.UpdateWebhook: " + e.Message );
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
 **webhookId** | **string**|  | 
 **accessToken** | **string**| Access token. | 
 **active** | **bool?**| true or false, this field is used to enable/disable a webhook. | [optional] 
 **label** | **string**| The label of the webhook. | [optional] 
 **stagingUse** | **bool?**| true or false, this field is used to determine if a webhook will be run in staging | [optional] 
 **url** | **string**| The url of a webhook. This is used to determine the endpoint of your webhook, where | [optional] 
 **verifyToken** | **string**| The token used in your webhook. | [optional] 
 **secret** | **string**| The secret key that will be served as a ​&#x60;X-Dimelo-Secret​&#x60; header in every request. | [optional] 
 **registeredEvents** | [**Collection&lt;string&gt;**](string.md)| An array containing all the events that your webhook wants to subscribe. | [optional] 

### Return type

[**Webhook**](Webhook.md)

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

