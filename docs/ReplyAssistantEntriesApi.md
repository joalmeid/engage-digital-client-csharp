# RingCentral.EngageDigital.Api.ReplyAssistantEntriesApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateReplyAssistantEntry**](ReplyAssistantEntriesApi.md#createreplyassistantentry) | **POST** /reply_assistant/entries | Creating an entry
[**DeleteReplyAssistantEntry**](ReplyAssistantEntriesApi.md#deletereplyassistantentry) | **DELETE** /reply_assistant/entries/{replyAssistantEntryId} | Deleting a reply assistant entry
[**GetAllReplyAssistantEntries**](ReplyAssistantEntriesApi.md#getallreplyassistantentries) | **GET** /reply_assistant/entries | Getting​ a​ll​ reply assistant e​ntries
[**GetReplyAssistantEntry**](ReplyAssistantEntriesApi.md#getreplyassistantentry) | **GET** /reply_assistant/entries/{replyAssistantEntryId} | Getting a reply assistant entry from its id
[**UpdateReplyAssistantEntry**](ReplyAssistantEntriesApi.md#updatereplyassistantentry) | **PUT** /reply_assistant/entries/{replyAssistantEntryId} | Updating a reply assistant entry

<a name="createreplyassistantentry"></a>
# **CreateReplyAssistantEntry**
> ReplyAssistantEntry CreateReplyAssistantEntry (string label)

Creating an entry

This method creates a reply assistant entry. In case of success it renders the entry, otherwise, it renders an error (422 HTTP code).  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreateReplyAssistantEntryExample
    {
        public void main()
        {
            var apiInstance = new ReplyAssistantEntriesApi();
            var label = label_example;  // string | The name of the entry.

            try
            {
                // Creating an entry
                ReplyAssistantEntry result = apiInstance.CreateReplyAssistantEntry(label);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplyAssistantEntriesApi.CreateReplyAssistantEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **label** | **string**| The name of the entry. | 

### Return type

[**ReplyAssistantEntry**](ReplyAssistantEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletereplyassistantentry"></a>
# **DeleteReplyAssistantEntry**
> ReplyAssistantEntry DeleteReplyAssistantEntry (string replyAssistantEntryId)

Deleting a reply assistant entry

This method destroys an existing entry. It renders the entry itself. It renders a 404 if id is invalid.  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class DeleteReplyAssistantEntryExample
    {
        public void main()
        {
            var apiInstance = new ReplyAssistantEntriesApi();
            var replyAssistantEntryId = replyAssistantEntryId_example;  // string | 

            try
            {
                // Deleting a reply assistant entry
                ReplyAssistantEntry result = apiInstance.DeleteReplyAssistantEntry(replyAssistantEntryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplyAssistantEntriesApi.DeleteReplyAssistantEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replyAssistantEntryId** | **string**|  | 

### Return type

[**ReplyAssistantEntry**](ReplyAssistantEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallreplyassistantentries"></a>
# **GetAllReplyAssistantEntries**
> GetAllReplyAssistantEntriesResponse GetAllReplyAssistantEntries (int? offset = null, int? limit = null)

Getting​ a​ll​ reply assistant e​ntries

This method renders all entries ordered by creation date (ascending).  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllReplyAssistantEntriesExample
    {
        public void main()
        {
            var apiInstance = new ReplyAssistantEntriesApi();
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting​ a​ll​ reply assistant e​ntries
                GetAllReplyAssistantEntriesResponse result = apiInstance.GetAllReplyAssistantEntries(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplyAssistantEntriesApi.GetAllReplyAssistantEntries: " + e.Message );
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

[**GetAllReplyAssistantEntriesResponse**](GetAllReplyAssistantEntriesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getreplyassistantentry"></a>
# **GetReplyAssistantEntry**
> ReplyAssistantEntry GetReplyAssistantEntry (string replyAssistantEntryId)

Getting a reply assistant entry from its id

This method renders an entry from given id.  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetReplyAssistantEntryExample
    {
        public void main()
        {
            var apiInstance = new ReplyAssistantEntriesApi();
            var replyAssistantEntryId = replyAssistantEntryId_example;  // string | 

            try
            {
                // Getting a reply assistant entry from its id
                ReplyAssistantEntry result = apiInstance.GetReplyAssistantEntry(replyAssistantEntryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplyAssistantEntriesApi.GetReplyAssistantEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replyAssistantEntryId** | **string**|  | 

### Return type

[**ReplyAssistantEntry**](ReplyAssistantEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatereplyassistantentry"></a>
# **UpdateReplyAssistantEntry**
> ReplyAssistantEntry UpdateReplyAssistantEntry (string replyAssistantEntryId, string label = null, string foreignId = null, List<string> categoryIds = null, List<string> shortcuts = null, string entryGroupId = null, List<string> sourceIds = null)

Updating a reply assistant entry

This method updates an existing entry from given attributes and renders it in case of success.  Authorization​: only users that have the right to manage reply assistant.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class UpdateReplyAssistantEntryExample
    {
        public void main()
        {
            var apiInstance = new ReplyAssistantEntriesApi();
            var replyAssistantEntryId = replyAssistantEntryId_example;  // string | 
            var label = label_example;  // string | The name of the entry. (optional) 
            var foreignId = foreignId_example;  // string | The internal/company id of the entry. This is used to match Engage Digital entry’s id with the company one. Example: KB042. (optional) 
            var categoryIds = new List<string>(); // List<string> | To restrict the entry to a set of Engage Digital categories. Then, KB entries that do not match message’s categories to which you are replying will not be suggested. (optional) 
            var shortcuts = new List<string>(); // List<string> | entry shortcuts (optional) 
            var entryGroupId = entryGroupId_example;  // string | Entry group id. (optional) 
            var sourceIds = new List<string>(); // List<string> | Source ids (array) (optional) 

            try
            {
                // Updating a reply assistant entry
                ReplyAssistantEntry result = apiInstance.UpdateReplyAssistantEntry(replyAssistantEntryId, label, foreignId, categoryIds, shortcuts, entryGroupId, sourceIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplyAssistantEntriesApi.UpdateReplyAssistantEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replyAssistantEntryId** | **string**|  | 
 **label** | **string**| The name of the entry. | [optional] 
 **foreignId** | **string**| The internal/company id of the entry. This is used to match Engage Digital entry’s id with the company one. Example: KB042. | [optional] 
 **categoryIds** | [**List&lt;string&gt;**](string.md)| To restrict the entry to a set of Engage Digital categories. Then, KB entries that do not match message’s categories to which you are replying will not be suggested. | [optional] 
 **shortcuts** | [**List&lt;string&gt;**](string.md)| entry shortcuts | [optional] 
 **entryGroupId** | **string**| Entry group id. | [optional] 
 **sourceIds** | [**List&lt;string&gt;**](string.md)| Source ids (array) | [optional] 

### Return type

[**ReplyAssistantEntry**](ReplyAssistantEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
