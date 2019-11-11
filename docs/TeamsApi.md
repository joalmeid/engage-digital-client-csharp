# RingCentral.EngageDigital.Api.TeamsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTeam**](TeamsApi.md#createteam) | **POST** /teams | Creating a team
[**DeleteTeam**](TeamsApi.md#deleteteam) | **DELETE** /teams/{teamId} | Deleting a team
[**GetAllTeams**](TeamsApi.md#getallteams) | **GET** /teams | Getting all teams
[**GetTeam**](TeamsApi.md#getteam) | **GET** /teams/{teamId} | Getting a team from its id
[**UpdateTeam**](TeamsApi.md#updateteam) | **PUT** /teams/{teamId} | Updating a team

<a name="createteam"></a>
# **CreateTeam**
> Team CreateTeam (string name = null, List<string> leaderIds = null, List<string> userIds = null)

Creating a team

This method creates a new team. In case of success it renders the created tag, otherwise, it renders an error (422 HTTP code).

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreateTeamExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var name = name_example;  // string | Team name. (optional) 
            var leaderIds = new List<string>(); // List<string> | List of user id as leaders (optional) 
            var userIds = new List<string>(); // List<string> | List of user id as team members. (optional) 

            try
            {
                // Creating a team
                Team result = apiInstance.CreateTeam(name, leaderIds, userIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.CreateTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Team name. | [optional] 
 **leaderIds** | [**List&lt;string&gt;**](string.md)| List of user id as leaders | [optional] 
 **userIds** | [**List&lt;string&gt;**](string.md)| List of user id as team members. | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteteam"></a>
# **DeleteTeam**
> Team DeleteTeam (string teamId, string takeOverCategoryId = null)

Deleting a team

This method destroys an existing team. It renders the team itself. It renders a 404 if id is invalid.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class DeleteTeamExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | 
            var takeOverCategoryId = takeOverCategoryId_example;  // string | ID of a category to recategorize (optional). (optional) 

            try
            {
                // Deleting a team
                Team result = apiInstance.DeleteTeam(teamId, takeOverCategoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.DeleteTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**|  | 
 **takeOverCategoryId** | **string**| ID of a category to recategorize (optional). | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallteams"></a>
# **GetAllTeams**
> GetAllTeamsResponse GetAllTeams (int? offset = null, int? limit = null)

Getting all teams

This method renders teams ordered by creation date (ascending).

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllTeamsExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all teams
                GetAllTeamsResponse result = apiInstance.GetAllTeams(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetAllTeams: " + e.Message );
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

[**GetAllTeamsResponse**](GetAllTeamsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getteam"></a>
# **GetTeam**
> Team GetTeam (string teamId)

Getting a team from its id

This method renders a team from given id.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetTeamExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | 

            try
            {
                // Getting a team from its id
                Team result = apiInstance.GetTeam(teamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**|  | 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateteam"></a>
# **UpdateTeam**
> Team UpdateTeam (string teamId, string name = null, List<string> leaderIds = null, List<string> userIds = null)

Updating a team

This method updates an existing team from given attributes and renders it in case of success.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class UpdateTeamExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = teamId_example;  // string | 
            var name = name_example;  // string | Team name. (optional) 
            var leaderIds = new List<string>(); // List<string> | List of user id as leaders (optional) 
            var userIds = new List<string>(); // List<string> | List of user id as team members. (optional) 

            try
            {
                // Updating a team
                Team result = apiInstance.UpdateTeam(teamId, name, leaderIds, userIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.UpdateTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**|  | 
 **name** | **string**| Team name. | [optional] 
 **leaderIds** | [**List&lt;string&gt;**](string.md)| List of user id as leaders | [optional] 
 **userIds** | [**List&lt;string&gt;**](string.md)| List of user id as team members. | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
