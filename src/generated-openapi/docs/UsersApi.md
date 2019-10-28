# Org.OpenAPITools.Api.UsersApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUser**](UsersApi.md#createuser) | **POST** /users | Creating a user
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /users/{userId} | Deleting a user
[**GetAllUsers**](UsersApi.md#getallusers) | **GET** /users | Getting all users
[**GetUser**](UsersApi.md#getuser) | **GET** /users/{userId} | Getting a user from its id
[**InviteUser**](UsersApi.md#inviteuser) | **POST** /users/invite | Inviting a user
[**UpdateUser**](UsersApi.md#updateuser) | **PUT** /users/{userId} | Updating a user


<a name="createuser"></a>
# **CreateUser**
> User CreateUser (string email, string firstname, string lastname, string password, string roleId, List<string> categoryIds = null, bool? enabled = null, string externalId = null, string gender = null, List<string> identityIds = null, string locale = null, string nickname = null, List<string> teamIds = null, string timezone = null, List<string> spokenLanguages = null)

Creating a user

This method creates a new user. In case of success it renders the created user, otherwise, it renders an error (422 HTTP code).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new UsersApi(Configuration.Default);
            var email = email_example;  // string | User email (mandatory).
            var firstname = firstname_example;  // string | User firstname (mandatory).
            var lastname = lastname_example;  // string | User lastname (mandatory).
            var password = password_example;  // string | User plain password (mandatory).
            var roleId = roleId_example;  // string | User role id (mandatory).
            var categoryIds = new List<string>(); // List<string> | User list of category ids (multiple). (optional) 
            var enabled = true;  // bool? | Whether the user is enabled or not (boolean). (optional) 
            var externalId = externalId_example;  // string | User external id, used for SSO. (optional) 
            var gender = gender_example;  // string | User gender (\"man\" or \"woman\"). (optional) 
            var identityIds = new List<string>(); // List<string> | User list of identity ids (multiple). (optional) 
            var locale = locale_example;  // string | Language for the user interface. (optional) 
            var nickname = nickname_example;  // string | User nickname. (optional) 
            var teamIds = new List<string>(); // List<string> | User list of team ids (multiple). (optional) 
            var timezone = timezone_example;  // string | Use the timezone endpoint to get the timezone name (String), default is empty for domain timezone. (optional) 
            var spokenLanguages = new List<string>(); // List<string> | List of locales corresponding to the languages spoken by the user (multiple). (optional) 

            try
            {
                // Creating a user
                User result = apiInstance.CreateUser(email, firstname, lastname, password, roleId, categoryIds, enabled, externalId, gender, identityIds, locale, nickname, teamIds, timezone, spokenLanguages);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUser: " + e.Message );
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
 **email** | **string**| User email (mandatory). | 
 **firstname** | **string**| User firstname (mandatory). | 
 **lastname** | **string**| User lastname (mandatory). | 
 **password** | **string**| User plain password (mandatory). | 
 **roleId** | **string**| User role id (mandatory). | 
 **categoryIds** | [**List&lt;string&gt;**](string.md)| User list of category ids (multiple). | [optional] 
 **enabled** | **bool?**| Whether the user is enabled or not (boolean). | [optional] 
 **externalId** | **string**| User external id, used for SSO. | [optional] 
 **gender** | **string**| User gender (\&quot;man\&quot; or \&quot;woman\&quot;). | [optional] 
 **identityIds** | [**List&lt;string&gt;**](string.md)| User list of identity ids (multiple). | [optional] 
 **locale** | **string**| Language for the user interface. | [optional] 
 **nickname** | **string**| User nickname. | [optional] 
 **teamIds** | [**List&lt;string&gt;**](string.md)| User list of team ids (multiple). | [optional] 
 **timezone** | **string**| Use the timezone endpoint to get the timezone name (String), default is empty for domain timezone. | [optional] 
 **spokenLanguages** | [**List&lt;string&gt;**](string.md)| List of locales corresponding to the languages spoken by the user (multiple). | [optional] 

### Return type

[**User**](User.md)

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

<a name="deleteuser"></a>
# **DeleteUser**
> User DeleteUser (string userId)

Deleting a user

This method deletes the given user. In case of success it renders the deleted user, otherwise, it renders an error (422 HTTP code).  Authorization​: only users that can update users. The user affiliated to the token must have at least all the permissions of the other user. If the user affiliated to the token has the manage_users_of_my_teams permission, the deleted user will need to belong to at least one of the teams he’s the leader of.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | 

            try
            {
                // Deleting a user
                User result = apiInstance.DeleteUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
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
 **userId** | **string**|  | 

### Return type

[**User**](User.md)

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

<a name="getallusers"></a>
# **GetAllUsers**
> GetAllUsersResponse GetAllUsers (string email = null, string categoryId = null, string identityId = null, string externalId = null, string roleId = null, string teamId = null, int? offset = null, int? limit = null)

Getting all users

This method renders users ordered by creation date (descending).  Authorization​: only users that can view users. If the user affiliated to the token has the manage_users_of_my_teams permission, only the users belonging to at least one of the teams he’s the leader of will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAllUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new UsersApi(Configuration.Default);
            var email = email_example;  // string | To filter users on given email. (optional) 
            var categoryId = categoryId_example;  // string | To filter users on given category id. (optional) 
            var identityId = identityId_example;  // string | To filter users on given identity id. (optional) 
            var externalId = externalId_example;  // string | To filter users on given external id. (optional) 
            var roleId = roleId_example;  // string | To filter users on given role id. (optional) 
            var teamId = teamId_example;  // string | To filter users on given team id. (optional) 
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all users
                GetAllUsersResponse result = apiInstance.GetAllUsers(email, categoryId, identityId, externalId, roleId, teamId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetAllUsers: " + e.Message );
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
 **email** | **string**| To filter users on given email. | [optional] 
 **categoryId** | **string**| To filter users on given category id. | [optional] 
 **identityId** | **string**| To filter users on given identity id. | [optional] 
 **externalId** | **string**| To filter users on given external id. | [optional] 
 **roleId** | **string**| To filter users on given role id. | [optional] 
 **teamId** | **string**| To filter users on given team id. | [optional] 
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllUsersResponse**](GetAllUsersResponse.md)

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

<a name="getuser"></a>
# **GetUser**
> User GetUser (string userId)

Getting a user from its id

This method renders a user from given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | 

            try
            {
                // Getting a user from its id
                User result = apiInstance.GetUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
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
 **userId** | **string**|  | 

### Return type

[**User**](User.md)

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

<a name="inviteuser"></a>
# **InviteUser**
> User InviteUser (string email, string firstname, string lastname, string roleId, List<string> categoryIds = null, bool? enabled = null, string externalId = null, string gender = null, List<string> identityIds = null, string locale = null, string nickname = null, List<string> teamIds = null, string timezone = null, List<string> spokenLanguages = null)

Inviting a user

This method invites a new user. In case of success it renders the created user, otherwise, it renders an error (422 HTTP code).  Authorization​: only users that can invite other users. If the user affiliated to the token has the manage_users_of_my_teams permission, the invited user will need to belong to at least one of the teams he’s the leader of. It will not be possible to assign the user to other teams.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InviteUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new UsersApi(Configuration.Default);
            var email = email_example;  // string | User email (mandatory).
            var firstname = firstname_example;  // string | User firstname (mandatory).
            var lastname = lastname_example;  // string | User lastname (mandatory).
            var roleId = roleId_example;  // string | User role id (mandatory).
            var categoryIds = new List<string>(); // List<string> | User list of category ids (multiple). (optional) 
            var enabled = true;  // bool? | Whether the user is enabled or not (boolean). (optional) 
            var externalId = externalId_example;  // string | User external id. (optional) 
            var gender = gender_example;  // string | User gender (\"man\" or \"woman\"). (optional) 
            var identityIds = new List<string>(); // List<string> | User list of identity ids (multiple). (optional) 
            var locale = locale_example;  // string | Language for the user interface. (optional) 
            var nickname = nickname_example;  // string | User nickname. (optional) 
            var teamIds = new List<string>(); // List<string> | User list of team ids (multiple). (optional) 
            var timezone = timezone_example;  // string | Use the timezone endpoint to get the timezone name (String), default is empty for (optional) 
            var spokenLanguages = new List<string>(); // List<string> | List of locales corresponding to the languages spoken by the user (multiple). (optional) 

            try
            {
                // Inviting a user
                User result = apiInstance.InviteUser(email, firstname, lastname, roleId, categoryIds, enabled, externalId, gender, identityIds, locale, nickname, teamIds, timezone, spokenLanguages);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.InviteUser: " + e.Message );
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
 **email** | **string**| User email (mandatory). | 
 **firstname** | **string**| User firstname (mandatory). | 
 **lastname** | **string**| User lastname (mandatory). | 
 **roleId** | **string**| User role id (mandatory). | 
 **categoryIds** | [**List&lt;string&gt;**](string.md)| User list of category ids (multiple). | [optional] 
 **enabled** | **bool?**| Whether the user is enabled or not (boolean). | [optional] 
 **externalId** | **string**| User external id. | [optional] 
 **gender** | **string**| User gender (\&quot;man\&quot; or \&quot;woman\&quot;). | [optional] 
 **identityIds** | [**List&lt;string&gt;**](string.md)| User list of identity ids (multiple). | [optional] 
 **locale** | **string**| Language for the user interface. | [optional] 
 **nickname** | **string**| User nickname. | [optional] 
 **teamIds** | [**List&lt;string&gt;**](string.md)| User list of team ids (multiple). | [optional] 
 **timezone** | **string**| Use the timezone endpoint to get the timezone name (String), default is empty for | [optional] 
 **spokenLanguages** | [**List&lt;string&gt;**](string.md)| List of locales corresponding to the languages spoken by the user (multiple). | [optional] 

### Return type

[**User**](User.md)

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

<a name="updateuser"></a>
# **UpdateUser**
> User UpdateUser (string userId, List<string> categoryIds = null, string email = null, bool? enabled = null, string externalId = null, string firstname = null, string gender = null, List<string> identityIds = null, string lastname = null, string locale = null, string nickname = null, string password = null, string roleId = null, List<string> teamIds = null, string timezone = null, List<string> spokenLanguages = null)

Updating a user

This method updates users from given attributes and renders it in case of success.  Authorization​: only users that can update users. If the user affiliated to the token has the `manage_users_of_my_teams` permission, the updated user will need to belong to at least one of the teams he’s the leader of. The teams the user affiliated to the token is the leader of will be the only ones which can be added or removed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var categoryIds = new List<string>(); // List<string> | User list of category ids (multiple). (optional) 
            var email = email_example;  // string | User email. (optional) 
            var enabled = true;  // bool? | Whether the user is enabled or not (boolean). (optional) 
            var externalId = externalId_example;  // string | User external id, used for SSO. (optional) 
            var firstname = firstname_example;  // string | User firstname. (optional) 
            var gender = gender_example;  // string | User gender (\"man\" or \"woman\"). (optional) 
            var identityIds = new List<string>(); // List<string> | User list of identity ids (multiple). (optional) 
            var lastname = lastname_example;  // string | User lastname. (optional) 
            var locale = locale_example;  // string | Language for the user interface. (optional) 
            var nickname = nickname_example;  // string | User nickname. (optional) 
            var password = password_example;  // string | User plain password. (optional) 
            var roleId = roleId_example;  // string | User role id. (optional) 
            var teamIds = new List<string>(); // List<string> | User list of team ids (multiple). (optional) 
            var timezone = timezone_example;  // string | Use the timezone endpoint to get the timezone name (String), default is empty for domain timezone. (optional) 
            var spokenLanguages = new List<string>(); // List<string> | List of locales corresponding to the languages spoken by the user (multiple). (optional) 

            try
            {
                // Updating a user
                User result = apiInstance.UpdateUser(userId, categoryIds, email, enabled, externalId, firstname, gender, identityIds, lastname, locale, nickname, password, roleId, teamIds, timezone, spokenLanguages);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message );
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
 **userId** | **string**|  | 
 **categoryIds** | [**List&lt;string&gt;**](string.md)| User list of category ids (multiple). | [optional] 
 **email** | **string**| User email. | [optional] 
 **enabled** | **bool?**| Whether the user is enabled or not (boolean). | [optional] 
 **externalId** | **string**| User external id, used for SSO. | [optional] 
 **firstname** | **string**| User firstname. | [optional] 
 **gender** | **string**| User gender (\&quot;man\&quot; or \&quot;woman\&quot;). | [optional] 
 **identityIds** | [**List&lt;string&gt;**](string.md)| User list of identity ids (multiple). | [optional] 
 **lastname** | **string**| User lastname. | [optional] 
 **locale** | **string**| Language for the user interface. | [optional] 
 **nickname** | **string**| User nickname. | [optional] 
 **password** | **string**| User plain password. | [optional] 
 **roleId** | **string**| User role id. | [optional] 
 **teamIds** | [**List&lt;string&gt;**](string.md)| User list of team ids (multiple). | [optional] 
 **timezone** | **string**| Use the timezone endpoint to get the timezone name (String), default is empty for domain timezone. | [optional] 
 **spokenLanguages** | [**List&lt;string&gt;**](string.md)| List of locales corresponding to the languages spoken by the user (multiple). | [optional] 

### Return type

[**User**](User.md)

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

