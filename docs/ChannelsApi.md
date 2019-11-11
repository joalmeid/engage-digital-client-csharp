# RingCentral.EngageDigital.Api.ChannelsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllChannels**](ChannelsApi.md#getallchannels) | **GET** /channels | Getting all channels
[**GetChannel**](ChannelsApi.md#getchannel) | **GET** /channels/{channelId} | Getting a channel from its id
[**UpdateChannel**](ChannelsApi.md#updatechannel) | **PUT** /channels/{channelId} | Updating a channel

<a name="getallchannels"></a>
# **GetAllChannels**
> GetAllChannelsResponse GetAllChannels (int? offset = null, int? limit = null)

Getting all channels

This method renders all channels ordered by date of creation.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllChannelsExample
    {
        public void main()
        {
            var apiInstance = new ChannelsApi();
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all channels
                GetAllChannelsResponse result = apiInstance.GetAllChannels(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetAllChannels: " + e.Message );
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

[**GetAllChannelsResponse**](GetAllChannelsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getchannel"></a>
# **GetChannel**
> Channel GetChannel (string channelId)

Getting a channel from its id

This method renders a channel from given id.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetChannelExample
    {
        public void main()
        {
            var apiInstance = new ChannelsApi();
            var channelId = channelId_example;  // string | 

            try
            {
                // Getting a channel from its id
                Channel result = apiInstance.GetChannel(channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.GetChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelId** | **string**|  | 

### Return type

[**Channel**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatechannel"></a>
# **UpdateChannel**
> Channel UpdateChannel (string channelId, string name = null, List<string> sourceIds = null, int? softCapability = null, int? hardCapability = null, int? taskTimeoutSeconds = null)

Updating a channel

This method updates an existing channel from given attributes and renders it in case of success.  Authorization​: only users that are able to update channels.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class UpdateChannelExample
    {
        public void main()
        {
            var apiInstance = new ChannelsApi();
            var channelId = channelId_example;  // string | 
            var name = name_example;  // string | The name of the channel. (optional) 
            var sourceIds = new List<string>(); // List<string> | An array containing id of each source assigned to a channel (multiple). (optional) 
            var softCapability = 56;  // int? | Number of tasks that can be assigned to agent by the routing before they are considered \"occupied\". (optional) 
            var hardCapability = 56;  // int? | M​aximum number of tasks that can be assigned to agents. (optional) 
            var taskTimeoutSeconds = 56;  // int? | this field defines the time before a task expires (in seconds). (optional) 

            try
            {
                // Updating a channel
                Channel result = apiInstance.UpdateChannel(channelId, name, sourceIds, softCapability, hardCapability, taskTimeoutSeconds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelsApi.UpdateChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelId** | **string**|  | 
 **name** | **string**| The name of the channel. | [optional] 
 **sourceIds** | [**List&lt;string&gt;**](string.md)| An array containing id of each source assigned to a channel (multiple). | [optional] 
 **softCapability** | **int?**| Number of tasks that can be assigned to agent by the routing before they are considered \&quot;occupied\&quot;. | [optional] 
 **hardCapability** | **int?**| M​aximum number of tasks that can be assigned to agents. | [optional] 
 **taskTimeoutSeconds** | **int?**| this field defines the time before a task expires (in seconds). | [optional] 

### Return type

[**Channel**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
