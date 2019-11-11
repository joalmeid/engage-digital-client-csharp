# RingCentral.EngageDigital.Api.CommunitiesApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllCommunities**](CommunitiesApi.md#getallcommunities) | **GET** /communities | Getting all communities
[**GetCommunity**](CommunitiesApi.md#getcommunity) | **GET** /communities/{communityId} | Getting a community from its id

<a name="getallcommunities"></a>
# **GetAllCommunities**
> GetAllCommunitiesResponse GetAllCommunities (int? offset = null, int? limit = null)

Getting all communities

This method renders communities ordered by creation date (ascending).

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllCommunitiesExample
    {
        public void main()
        {
            var apiInstance = new CommunitiesApi();
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all communities
                GetAllCommunitiesResponse result = apiInstance.GetAllCommunities(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunitiesApi.GetAllCommunities: " + e.Message );
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

[**GetAllCommunitiesResponse**](GetAllCommunitiesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcommunity"></a>
# **GetCommunity**
> Community GetCommunity (string communityId)

Getting a community from its id

This method renders a community from given id.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetCommunityExample
    {
        public void main()
        {
            var apiInstance = new CommunitiesApi();
            var communityId = communityId_example;  // string | 

            try
            {
                // Getting a community from its id
                Community result = apiInstance.GetCommunity(communityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunitiesApi.GetCommunity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **communityId** | **string**|  | 

### Return type

[**Community**](Community.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
