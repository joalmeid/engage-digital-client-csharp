# RingCentral.EngageDigital.Api.IdentityGroupsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllIdentityGroups**](IdentityGroupsApi.md#getallidentitygroups) | **GET** /identity_groups | Getting all identity groups
[**GetIdentityGroup**](IdentityGroupsApi.md#getidentitygroup) | **GET** /identity_groups/{identityGroupId} | Getting an identity group from its id
[**UpdateIdentityGroup**](IdentityGroupsApi.md#updateidentitygroup) | **PUT** /identity_groups/{identityGroupId} | Updating an identity group


<a name="getallidentitygroups"></a>
# **GetAllIdentityGroups**
> GetAllIdentityGroupsResponse GetAllIdentityGroups (string firstname = null, string lastname = null, string email = null, string uuid = null, string sort = null, int? offset = null, int? limit = null)

Getting all identity groups

This method renders identity groups ordered by creation date (descending). Note that identity_group are created in a lazily only when data are manually added to an identity OR a two identity are merged altogether. That means that some identity DON’T have identity_group, and identity_group do not cover all identities.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllIdentityGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new IdentityGroupsApi(config);
            var firstname = firstname_example;  // string | To filter groups on given firstname. (optional) 
            var lastname = lastname_example;  // string | To filter groups on given lastname. (optional) 
            var email = email_example;  // string | To filter groups that have given email. (optional) 
            var uuid = uuid_example;  // string | To filter groups that have given uuid. (optional) 
            var sort = sort_example;  // string | To change the criteria chosen to sort the identities. The value can be “created_at” or “updated_at”. (optional) 
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all identity groups
                GetAllIdentityGroupsResponse result = apiInstance.GetAllIdentityGroups(firstname, lastname, email, uuid, sort, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityGroupsApi.GetAllIdentityGroups: " + e.Message );
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
 **firstname** | **string**| To filter groups on given firstname. | [optional] 
 **lastname** | **string**| To filter groups on given lastname. | [optional] 
 **email** | **string**| To filter groups that have given email. | [optional] 
 **uuid** | **string**| To filter groups that have given uuid. | [optional] 
 **sort** | **string**| To change the criteria chosen to sort the identities. The value can be “created_at” or “updated_at”. | [optional] 
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllIdentityGroupsResponse**](GetAllIdentityGroupsResponse.md)

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

<a name="getidentitygroup"></a>
# **GetIdentityGroup**
> IdentityGroup GetIdentityGroup (string identityGroupId)

Getting an identity group from its id

This method renders an identity group from given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetIdentityGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new IdentityGroupsApi(config);
            var identityGroupId = identityGroupId_example;  // string | 

            try
            {
                // Getting an identity group from its id
                IdentityGroup result = apiInstance.GetIdentityGroup(identityGroupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityGroupsApi.GetIdentityGroup: " + e.Message );
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
 **identityGroupId** | **string**|  | 

### Return type

[**IdentityGroup**](IdentityGroup.md)

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

<a name="updateidentitygroup"></a>
# **UpdateIdentityGroup**
> IdentityGroup UpdateIdentityGroup (string identityGroupId, string company = null, string customFieldValuesCustomFieldKey = null, Collection<string> emails = null, string firstname = null, string gender = null, Collection<string> homePhones = null, string lastname = null, Collection<string> mobilePhones = null, string notes = null, Collection<string> tagIds = null)

Updating an identity group

This method updates an identity group from given attributes and renders it in case of success.  Authorization​: no.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class UpdateIdentityGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new IdentityGroupsApi(config);
            var identityGroupId = identityGroupId_example;  // string | 
            var company = company_example;  // string | Identity company. (optional) 
            var customFieldValuesCustomFieldKey = customFieldValuesCustomFieldKey_example;  // string | Identity custom field with key « custom_field_key ». It (optional) 
            var emails = new Collection<string>(); // Collection<string> | Identity emails (multiple). (optional) 
            var firstname = firstname_example;  // string | Identity firstname. (optional) 
            var gender = gender_example;  // string | Identity’s gender. It can be \"man\", \"woman\" or empty. (optional) 
            var homePhones = new Collection<string>(); // Collection<string> | Identity home phones (mutiple). (optional) 
            var lastname = lastname_example;  // string | Identity lastname. (optional) 
            var mobilePhones = new Collection<string>(); // Collection<string> | Identity mobile phones (multiple). (optional) 
            var notes = notes_example;  // string | Identity notes. (optional) 
            var tagIds = new Collection<string>(); // Collection<string> | Identity tag ids (multiple). (optional) 

            try
            {
                // Updating an identity group
                IdentityGroup result = apiInstance.UpdateIdentityGroup(identityGroupId, company, customFieldValuesCustomFieldKey, emails, firstname, gender, homePhones, lastname, mobilePhones, notes, tagIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityGroupsApi.UpdateIdentityGroup: " + e.Message );
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
 **identityGroupId** | **string**|  | 
 **company** | **string**| Identity company. | [optional] 
 **customFieldValuesCustomFieldKey** | **string**| Identity custom field with key « custom_field_key ». It | [optional] 
 **emails** | [**Collection&lt;string&gt;**](string.md)| Identity emails (multiple). | [optional] 
 **firstname** | **string**| Identity firstname. | [optional] 
 **gender** | **string**| Identity’s gender. It can be \&quot;man\&quot;, \&quot;woman\&quot; or empty. | [optional] 
 **homePhones** | [**Collection&lt;string&gt;**](string.md)| Identity home phones (mutiple). | [optional] 
 **lastname** | **string**| Identity lastname. | [optional] 
 **mobilePhones** | [**Collection&lt;string&gt;**](string.md)| Identity mobile phones (multiple). | [optional] 
 **notes** | **string**| Identity notes. | [optional] 
 **tagIds** | [**Collection&lt;string&gt;**](string.md)| Identity tag ids (multiple). | [optional] 

### Return type

[**IdentityGroup**](IdentityGroup.md)

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

