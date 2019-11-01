# Org.OpenAPITools.Api.InterventionsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelIntervention**](InterventionsApi.md#cancelintervention) | **DELETE** /interventions/{interventionId}/cancel | Cancelling an intervention
[**CategorizeIntervention**](InterventionsApi.md#categorizeintervention) | **PUT** /interventions/{interventionId}/update_categories | Categorizing an intervention
[**CloseIntervention**](InterventionsApi.md#closeintervention) | **PUT** /interventions/{interventionId}/close | Closing an intervention
[**CreateIntervention**](InterventionsApi.md#createintervention) | **POST** /interventions | Creating an intervention
[**GetAllInterventions**](InterventionsApi.md#getallinterventions) | **GET** /interventions | Getting all interventions
[**GetIntervention**](InterventionsApi.md#getintervention) | **GET** /interventions/{interventionId} | Getting an intervention from its id
[**ReassignIntervention**](InterventionsApi.md#reassignintervention) | **PUT** /interventions/{interventionId}/reassign | Reassigning an intervention


<a name="cancelintervention"></a>
# **CancelIntervention**
> Intervention CancelIntervention (string interventionId)

Cancelling an intervention

This method cancels (destroys) an intervention. It renders intervention itself. If token’s user does not have “read” on intervention’s source a 404 HTTP response will be returned.  Caveats:  * If the intervention is already being canceled, it will return a 409 error. * To be able to close an intervention, it must meet the following criteria otherwise a 403 will be raised:   * Intervention MUST NOT already be closed  * Intervention MUST NOT have agent replies   * Access-Token agent MUST have read access on the source  Authorization​: no, but it renders an error if intervention can’t be destroyed (see caveats).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CancelInterventionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new InterventionsApi(Configuration.Default);
            var interventionId = interventionId_example;  // string | 

            try
            {
                // Cancelling an intervention
                Intervention result = apiInstance.CancelIntervention(interventionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterventionsApi.CancelIntervention: " + e.Message );
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
 **interventionId** | **string**|  | 

### Return type

[**Intervention**](Intervention.md)

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

<a name="categorizeintervention"></a>
# **CategorizeIntervention**
> Intervention CategorizeIntervention (string interventionId, List<string> categoryIds)

Categorizing an intervention

This method updates the categories of an intervention. If token’s user does not have “read” on the intervention’s source a 404 HTTP response will be returned.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategorizeInterventionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new InterventionsApi(Configuration.Default);
            var interventionId = interventionId_example;  // string | 
            var categoryIds = new List<string>(); // List<string> | 

            try
            {
                // Categorizing an intervention
                Intervention result = apiInstance.CategorizeIntervention(interventionId, categoryIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterventionsApi.CategorizeIntervention: " + e.Message );
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
 **interventionId** | **string**|  | 
 **categoryIds** | [**List&lt;string&gt;**](string.md)|  | 

### Return type

[**Intervention**](Intervention.md)

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

<a name="closeintervention"></a>
# **CloseIntervention**
> Intervention CloseIntervention (string interventionId)

Closing an intervention

This method closes an intervention. Caveats:  * If the intervention is already being closed, it will return a 409 error. * To be able to close an intervention, it must meet the following criteria otherwise a 403 will be raised:    * Intervention MUST NOT already be closed    * Intervention MUST have agent replies   * Access-Token agent MUST be the owner of the intervention or have the permission to edit permissions    * Access-Token agent MUST have read access on the source  Authorization​: no, but it renders an error if intervention can’t be closed (see caveats)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CloseInterventionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new InterventionsApi(Configuration.Default);
            var interventionId = interventionId_example;  // string | 

            try
            {
                // Closing an intervention
                Intervention result = apiInstance.CloseIntervention(interventionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterventionsApi.CloseIntervention: " + e.Message );
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
 **interventionId** | **string**|  | 

### Return type

[**Intervention**](Intervention.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **409** | If the intervention is already being closed, it will return a 409 error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createintervention"></a>
# **CreateIntervention**
> GetAllInterventionsResponse CreateIntervention (string contentId)

Creating an intervention

This method creates a new intervention or reopen it. In case of success it renders the intervention, otherwise, it renders an error (422 HTTP code). This method opens intervention as access token’s user.  Authorization​: no, but it renders an error if intervention can’t be created or reopened (already opened, etc.).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateInterventionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new InterventionsApi(Configuration.Default);
            var contentId = contentId_example;  // string | The content to create intervention on (mandatory).

            try
            {
                // Creating an intervention
                GetAllInterventionsResponse result = apiInstance.CreateIntervention(contentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterventionsApi.CreateIntervention: " + e.Message );
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
 **contentId** | **string**| The content to create intervention on (mandatory). | 

### Return type

[**GetAllInterventionsResponse**](GetAllInterventionsResponse.md)

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

<a name="getallinterventions"></a>
# **GetAllInterventions**
> GetAllInterventionsResponse GetAllInterventions (string threadId = null, string userId = null, string identityGroupId = null, List<string> identityId = null, string sort = null, int? offset = null, int? limit = null)

Getting all interventions

This method renders interventions ordered by creation date (descending). Only interventions in sources where token’s user has “read” permission are returned.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAllInterventionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new InterventionsApi(Configuration.Default);
            var threadId = threadId_example;  // string | To filter interventions on given thread id. (optional) 
            var userId = userId_example;  // string | To filter interventions on given user id. (optional) 
            var identityGroupId = identityGroupId_example;  // string | To filter interventions on given identity_group_id. This will return interventions associated to any identity in the indentity_group. (optional) 
            var identityId = new List<string>(); // List<string> | To filter interventions on given identity_id(s). Can be a single value or an array. (optional) 
            var sort = sort_example;  // string | To change the criteria chosen to sort the interventions. The value can be “created_at” or “updated_at”. (optional) 
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all interventions
                GetAllInterventionsResponse result = apiInstance.GetAllInterventions(threadId, userId, identityGroupId, identityId, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterventionsApi.GetAllInterventions: " + e.Message );
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
 **threadId** | **string**| To filter interventions on given thread id. | [optional] 
 **userId** | **string**| To filter interventions on given user id. | [optional] 
 **identityGroupId** | **string**| To filter interventions on given identity_group_id. This will return interventions associated to any identity in the indentity_group. | [optional] 
 **identityId** | [**List&lt;string&gt;**](string.md)| To filter interventions on given identity_id(s). Can be a single value or an array. | [optional] 
 **sort** | **string**| To change the criteria chosen to sort the interventions. The value can be “created_at” or “updated_at”. | [optional] 
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllInterventionsResponse**](GetAllInterventionsResponse.md)

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

<a name="getintervention"></a>
# **GetIntervention**
> Intervention GetIntervention (string interventionId)

Getting an intervention from its id

This method renders an intervention from given id. If token’s user does not have “read” on intervention’s source a 404 HTTP response will be returned.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetInterventionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new InterventionsApi(Configuration.Default);
            var interventionId = interventionId_example;  // string | 

            try
            {
                // Getting an intervention from its id
                Intervention result = apiInstance.GetIntervention(interventionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterventionsApi.GetIntervention: " + e.Message );
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
 **interventionId** | **string**|  | 

### Return type

[**Intervention**](Intervention.md)

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

<a name="reassignintervention"></a>
# **ReassignIntervention**
> Intervention ReassignIntervention (string interventionId, string userId)

Reassigning an intervention

This method updates the user in charge of the intervention  Authorization​: Only users who can update interventions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReassignInterventionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new InterventionsApi(Configuration.Default);
            var interventionId = interventionId_example;  // string | 
            var userId = userId_example;  // string | 

            try
            {
                // Reassigning an intervention
                Intervention result = apiInstance.ReassignIntervention(interventionId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InterventionsApi.ReassignIntervention: " + e.Message );
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
 **interventionId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

[**Intervention**](Intervention.md)

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

