# RingCentral.EngageDigital.Api.IdentitiesApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllIdentities**](IdentitiesApi.md#getallidentities) | **GET** /identities | Getting all identities
[**GetIdentity**](IdentitiesApi.md#getidentity) | **GET** /identities/{identityId} | Getting an identity from its id


<a name="getallidentities"></a>
# **GetAllIdentities**
> GetAllIdentitiesResponse GetAllIdentities (string communityId = null, string identityGroupId = null, string userId = null, string sort = null, string foreignId = null, string uuid = null, int? offset = null, int? limit = null)

Getting all identities

This method renders identities ordered by creation date (descending). Only identities in sources where token’s user has “read” permission are returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllIdentitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new IdentitiesApi(config);
            var communityId = communityId_example;  // string | To filter identities on given community id. (optional) 
            var identityGroupId = identityGroupId_example;  // string | To filter on given group id. (optional) 
            var userId = userId_example;  // string | To filter identities on given user id. (optional) 
            var sort = sort_example;  // string | To change the criteria chosen to sort the identities. The value can be “created_at” or (optional) 
            var foreignId = foreignId_example;  // string | To filter identities on given user id (optional) 
            var uuid = uuid_example;  // string | To filter identities on given uuid (optional) 
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all identities
                GetAllIdentitiesResponse result = apiInstance.GetAllIdentities(communityId, identityGroupId, userId, sort, foreignId, uuid, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentitiesApi.GetAllIdentities: " + e.Message );
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
 **communityId** | **string**| To filter identities on given community id. | [optional] 
 **identityGroupId** | **string**| To filter on given group id. | [optional] 
 **userId** | **string**| To filter identities on given user id. | [optional] 
 **sort** | **string**| To change the criteria chosen to sort the identities. The value can be “created_at” or | [optional] 
 **foreignId** | **string**| To filter identities on given user id | [optional] 
 **uuid** | **string**| To filter identities on given uuid | [optional] 
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllIdentitiesResponse**](GetAllIdentitiesResponse.md)

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

<a name="getidentity"></a>
# **GetIdentity**
> Identity GetIdentity (string identityId)

Getting an identity from its id

This method renders an identity from given id. If token’s user does not have “read” on identity’s source community a 404 HTTP response will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetIdentityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new IdentitiesApi(config);
            var identityId = identityId_example;  // string | 

            try
            {
                // Getting an identity from its id
                Identity result = apiInstance.GetIdentity(identityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentitiesApi.GetIdentity: " + e.Message );
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
 **identityId** | **string**|  | 

### Return type

[**Identity**](Identity.md)

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

