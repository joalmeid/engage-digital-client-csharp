# RingCentral.EngageDigital.Api.FoldersApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFolder**](FoldersApi.md#createfolder) | **POST** /folders | Creating a folder
[**DeleteFolder**](FoldersApi.md#deletefolder) | **DELETE** /folders/{folderId} | Deleting a folder
[**GetAllFolders**](FoldersApi.md#getallfolders) | **GET** /folders | Getting all folders
[**GetFolder**](FoldersApi.md#getfolder) | **GET** /folders/{folderId} | Getting a folder from its id
[**UpdateFolder**](FoldersApi.md#updatefolder) | **PUT** /folders/{folderId} | Updating a folder

<a name="createfolder"></a>
# **CreateFolder**
> Folder CreateFolder (string label = null, string parentId = null, int? position = null, string query = null, bool? renderThreadsCount = null, List<string> roleRestrictionOnly = null, List<string> teamRestrictionOnly = null)

Creating a folder

This method creates a new folder. In case of success it renders the created folder, otherwise an error (422 HTTP code).

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreateFolderExample
    {
        public void main()
        {
            var apiInstance = new FoldersApi();
            var label = label_example;  // string | Folder’s label (mandatory). (optional) 
            var parentId = parentId_example;  // string | ID of the parent folder. (optional) 
            var position = 56;  // int? | position of the folder.  (optional) 
            var query = query_example;  // string | query of the folder as described in ​Search API documentation.​\\n\\nExample: “​active_and_assigned_to_me:true” (optional) 
            var renderThreadsCount = true;  // bool? | boolean describing display of the number of threads.  (optional) 
            var roleRestrictionOnly = new List<string>(); // List<string> | list of roles allowed to see this folder. This parameter has to be a hash otherwise it will raise a 400 error. The key should be \"only\". For example: `&role_restriction[only][]=4e5596cdae70f677b5000002` (optional) 
            var teamRestrictionOnly = new List<string>(); // List<string> | list of teams allowed to see this folder. Same thing as role_restriction: team_restriction parameter has to be a hash with the key \"only\". (optional) 

            try
            {
                // Creating a folder
                Folder result = apiInstance.CreateFolder(label, parentId, position, query, renderThreadsCount, roleRestrictionOnly, teamRestrictionOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.CreateFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **label** | **string**| Folder’s label (mandatory). | [optional] 
 **parentId** | **string**| ID of the parent folder. | [optional] 
 **position** | **int?**| position of the folder.  | [optional] 
 **query** | **string**| query of the folder as described in ​Search API documentation.​\\n\\nExample: “​active_and_assigned_to_me:true” | [optional] 
 **renderThreadsCount** | **bool?**| boolean describing display of the number of threads.  | [optional] 
 **roleRestrictionOnly** | [**List&lt;string&gt;**](string.md)| list of roles allowed to see this folder. This parameter has to be a hash otherwise it will raise a 400 error. The key should be \&quot;only\&quot;. For example: &#x60;&amp;role_restriction[only][]&#x3D;4e5596cdae70f677b5000002&#x60; | [optional] 
 **teamRestrictionOnly** | [**List&lt;string&gt;**](string.md)| list of teams allowed to see this folder. Same thing as role_restriction: team_restriction parameter has to be a hash with the key \&quot;only\&quot;. | [optional] 

### Return type

[**Folder**](Folder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletefolder"></a>
# **DeleteFolder**
> Folder DeleteFolder (string folderId)

Deleting a folder

This method destroys an existing folder. It renders the folder itself. It renders a 404 if id is invalid.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class DeleteFolderExample
    {
        public void main()
        {
            var apiInstance = new FoldersApi();
            var folderId = folderId_example;  // string | 

            try
            {
                // Deleting a folder
                Folder result = apiInstance.DeleteFolder(folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.DeleteFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderId** | **string**|  | 

### Return type

[**Folder**](Folder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallfolders"></a>
# **GetAllFolders**
> GetAllFoldersResponse GetAllFolders (int? offset = null, int? limit = null)

Getting all folders

This method renders folders.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllFoldersExample
    {
        public void main()
        {
            var apiInstance = new FoldersApi();
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all folders
                GetAllFoldersResponse result = apiInstance.GetAllFolders(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.GetAllFolders: " + e.Message );
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

[**GetAllFoldersResponse**](GetAllFoldersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getfolder"></a>
# **GetFolder**
> Folder GetFolder (string folderId)

Getting a folder from its id

This method renders a folder from given id.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetFolderExample
    {
        public void main()
        {
            var apiInstance = new FoldersApi();
            var folderId = folderId_example;  // string | 

            try
            {
                // Getting a folder from its id
                Folder result = apiInstance.GetFolder(folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderId** | **string**|  | 

### Return type

[**Folder**](Folder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatefolder"></a>
# **UpdateFolder**
> Folder UpdateFolder (string folderId, string label = null, string parentId = null, int? position = null, string query = null, bool? renderThreadsCount = null, List<string> roleRestrictionOnly = null, List<string> teamRestrictionOnly = null)

Updating a folder

This method updates an existing folder from given attributes and renders it in case of success.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class UpdateFolderExample
    {
        public void main()
        {
            var apiInstance = new FoldersApi();
            var folderId = folderId_example;  // string | 
            var label = label_example;  // string | Folder’s label (mandatory). (optional) 
            var parentId = parentId_example;  // string | ID of the parent folder. (optional) 
            var position = 56;  // int? | position of the folder.  (optional) 
            var query = query_example;  // string | query of the folder as described in ​Search API documentation.​\\n\\nExample: “​active_and_assigned_to_me:true” (optional) 
            var renderThreadsCount = true;  // bool? | boolean describing display of the number of threads.  (optional) 
            var roleRestrictionOnly = new List<string>(); // List<string> | list of roles allowed to see this folder. This parameter has to be a hash otherwise it will raise a 400 error. The key should be \"only\". For example: `&role_restriction[only][]=4e5596cdae70f677b5000002` (optional) 
            var teamRestrictionOnly = new List<string>(); // List<string> | list of teams allowed to see this folder. Same thing as role_restriction: team_restriction parameter has to be a hash with the key \"only\". (optional) 

            try
            {
                // Updating a folder
                Folder result = apiInstance.UpdateFolder(folderId, label, parentId, position, query, renderThreadsCount, roleRestrictionOnly, teamRestrictionOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.UpdateFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderId** | **string**|  | 
 **label** | **string**| Folder’s label (mandatory). | [optional] 
 **parentId** | **string**| ID of the parent folder. | [optional] 
 **position** | **int?**| position of the folder.  | [optional] 
 **query** | **string**| query of the folder as described in ​Search API documentation.​\\n\\nExample: “​active_and_assigned_to_me:true” | [optional] 
 **renderThreadsCount** | **bool?**| boolean describing display of the number of threads.  | [optional] 
 **roleRestrictionOnly** | [**List&lt;string&gt;**](string.md)| list of roles allowed to see this folder. This parameter has to be a hash otherwise it will raise a 400 error. The key should be \&quot;only\&quot;. For example: &#x60;&amp;role_restriction[only][]&#x3D;4e5596cdae70f677b5000002&#x60; | [optional] 
 **teamRestrictionOnly** | [**List&lt;string&gt;**](string.md)| list of teams allowed to see this folder. Same thing as role_restriction: team_restriction parameter has to be a hash with the key \&quot;only\&quot;. | [optional] 

### Return type

[**Folder**](Folder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
