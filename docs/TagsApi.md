# RingCentral.EngageDigital.Api.TagsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTag**](TagsApi.md#createtag) | **POST** /tags | Creating a tag
[**DeleteTag**](TagsApi.md#deletetag) | **DELETE** /tags/{tagId} | Deleting a tag
[**GetAllTags**](TagsApi.md#getalltags) | **GET** /tags | Getting all tags
[**GetTag**](TagsApi.md#gettag) | **GET** /tags/{tagId} | Getting a tag from its id
[**UpdateTag**](TagsApi.md#updatetag) | **PUT** /tags/{tagId} | Updating a tag

<a name="createtag"></a>
# **CreateTag**
> Tag CreateTag (string name)

Creating a tag

This method creates a new tag. In case of success it renders the created tag, otherwise, it renders an error (422 HTTP code).

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreateTagExample
    {
        public void main()
        {
            var apiInstance = new TagsApi();
            var name = name_example;  // string | Tag name (mandatory).

            try
            {
                // Creating a tag
                Tag result = apiInstance.CreateTag(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.CreateTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Tag name (mandatory). | 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetag"></a>
# **DeleteTag**
> Tag DeleteTag (string tagId)

Deleting a tag

This method destroys an existing tag. It renders tag itself. It renders a 404 if id is invalid.  Authorization​: only users that are able to destroy tags.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class DeleteTagExample
    {
        public void main()
        {
            var apiInstance = new TagsApi();
            var tagId = tagId_example;  // string | 

            try
            {
                // Deleting a tag
                Tag result = apiInstance.DeleteTag(tagId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.DeleteTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagId** | **string**|  | 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getalltags"></a>
# **GetAllTags**
> GetAllTagsResponse GetAllTags (int? offset = null, int? limit = null)

Getting all tags

This method renders tags ordered by name (ascending).

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllTagsExample
    {
        public void main()
        {
            var apiInstance = new TagsApi();
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all tags
                GetAllTagsResponse result = apiInstance.GetAllTags(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.GetAllTags: " + e.Message );
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

[**GetAllTagsResponse**](GetAllTagsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettag"></a>
# **GetTag**
> Tag GetTag (string tagId)

Getting a tag from its id

This method renders a tag from given id.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetTagExample
    {
        public void main()
        {
            var apiInstance = new TagsApi();
            var tagId = tagId_example;  // string | 

            try
            {
                // Getting a tag from its id
                Tag result = apiInstance.GetTag(tagId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.GetTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagId** | **string**|  | 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetag"></a>
# **UpdateTag**
> Tag UpdateTag (string tagId, string name)

Updating a tag

This method updates an existing tag from given attributes and renders it in case of success.  Authorization​: only users that are able to update tags.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class UpdateTagExample
    {
        public void main()
        {
            var apiInstance = new TagsApi();
            var tagId = tagId_example;  // string | 
            var name = name_example;  // string | Tag’s label.

            try
            {
                // Updating a tag
                Tag result = apiInstance.UpdateTag(tagId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.UpdateTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagId** | **string**|  | 
 **name** | **string**| Tag’s label. | 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
