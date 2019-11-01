# Org.OpenAPITools.Api.RolesApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRole**](RolesApi.md#createrole) | **POST** /roles | Creating a role
[**GetAllRoles**](RolesApi.md#getallroles) | **GET** /roles | Getting all roles
[**GetRole**](RolesApi.md#getrole) | **GET** /roles/{roleId} | Getting a role from its id
[**UpdateRole**](RolesApi.md#updaterole) | **PUT** /roles/{roleId} | Updating a role


<a name="createrole"></a>
# **CreateRole**
> Role CreateRole (string label, bool? accessHelpCenter = null, bool? accessPreviousMessages = null, bool? accessPullMode = null, bool? adminStampAnswer = null, bool? approveContent = null, bool? assignIntervention = null, bool? authorBlockContent = null, bool? closeContentThread = null, bool? createAndDestroyExtension = null, bool? createCommunity = null, bool? createContentSource = null, bool? createUser = null, bool? delayExportContent = null, bool? deleteContentThread = null, bool? impersonateUser = null, bool? inviteUser = null, bool? manageApiAccessTokens = null, bool? manageAppSdkApplications = null, bool? manageAutomaticExportsTasks = null, bool? manageCategories = null, bool? manageChat = null, bool? manageCustomFields = null, bool? manageCustomNotifications = null, bool? manageEmailsTemplates = null, bool? manageFolders = null, bool? manageIce = null, bool? manageIdentities = null, bool? manageOwnNotifications = null, bool? manageReplyAssistant = null, bool? manageRoles = null, bool? manageRulesEngineRules = null, bool? manageSurveys = null, bool? manageTags = null, bool? manageTeams = null, bool? manageTopologies = null, bool? manageUsersOfMyTeams = null, bool? monitorTasks = null, bool? monitorTeamTasks = null, bool? muteContent = null, bool? openContentThread = null, bool? publishContent = null, bool? readCommunity = null, bool? readContentSource = null, bool? readEvent = null, bool? readExport = null, bool? readIdentity = null, bool? readOwnStats = null, bool? readPresence = null, bool? readStats = null, bool? readSurveys = null, bool? readUser = null, bool? receiveTasks = null, bool? replyWithAssistant = null, bool? searchContents = null, bool? searchEvent = null, bool? updateCommunity = null, bool? updateContentSource = null, bool? updateExtension = null, bool? updateIdentity = null, bool? updateIntervention = null, bool? updateOwnIntervention = null, bool? updateSettings = null, bool? updateTimeSheet = null, bool? updateUser = null, bool? useEmoji = null)

Creating a role

This method creates a new role. In case of success it renders the created role, otherwise, it renders an error (422 HTTP code).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new RolesApi(Configuration.Default);
            var label = label_example;  // string | 
            var accessHelpCenter = true;  // bool? |  (optional) 
            var accessPreviousMessages = true;  // bool? |  (optional) 
            var accessPullMode = true;  // bool? |  (optional) 
            var adminStampAnswer = true;  // bool? |  (optional) 
            var approveContent = true;  // bool? |  (optional) 
            var assignIntervention = true;  // bool? |  (optional) 
            var authorBlockContent = true;  // bool? |  (optional) 
            var closeContentThread = true;  // bool? |  (optional) 
            var createAndDestroyExtension = true;  // bool? |  (optional) 
            var createCommunity = true;  // bool? |  (optional) 
            var createContentSource = true;  // bool? |  (optional) 
            var createUser = true;  // bool? |  (optional) 
            var delayExportContent = true;  // bool? |  (optional) 
            var deleteContentThread = true;  // bool? |  (optional) 
            var impersonateUser = true;  // bool? |  (optional) 
            var inviteUser = true;  // bool? |  (optional) 
            var manageApiAccessTokens = true;  // bool? |  (optional) 
            var manageAppSdkApplications = true;  // bool? |  (optional) 
            var manageAutomaticExportsTasks = true;  // bool? | permission only available with the corresponding extension enabled (optional) 
            var manageCategories = true;  // bool? |  (optional) 
            var manageChat = true;  // bool? |  (optional) 
            var manageCustomFields = true;  // bool? |  (optional) 
            var manageCustomNotifications = true;  // bool? |  (optional) 
            var manageEmailsTemplates = true;  // bool? |  (optional) 
            var manageFolders = true;  // bool? |  (optional) 
            var manageIce = true;  // bool? |  (optional) 
            var manageIdentities = true;  // bool? |  (optional) 
            var manageOwnNotifications = true;  // bool? |  (optional) 
            var manageReplyAssistant = true;  // bool? | permission only available with the corresponding extension enabled (optional) 
            var manageRoles = true;  // bool? |  (optional) 
            var manageRulesEngineRules = true;  // bool? | permission only available with the corresponding extension enabled (optional) 
            var manageSurveys = true;  // bool? | permission only available with the corresponding extension enabled (optional) 
            var manageTags = true;  // bool? |  (optional) 
            var manageTeams = true;  // bool? |  (optional) 
            var manageTopologies = true;  // bool? |  (optional) 
            var manageUsersOfMyTeams = true;  // bool? |  (optional) 
            var monitorTasks = true;  // bool? |  (optional) 
            var monitorTeamTasks = true;  // bool? |  (optional) 
            var muteContent = true;  // bool? |  (optional) 
            var openContentThread = true;  // bool? |  (optional) 
            var publishContent = true;  // bool? |  (optional) 
            var readCommunity = true;  // bool? |  (optional) 
            var readContentSource = true;  // bool? |  (optional) 
            var readEvent = true;  // bool? |  (optional) 
            var readExport = true;  // bool? |  (optional) 
            var readIdentity = true;  // bool? |  (optional) 
            var readOwnStats = true;  // bool? |  (optional) 
            var readPresence = true;  // bool? |  (optional) 
            var readStats = true;  // bool? |  (optional) 
            var readSurveys = true;  // bool? | permission only available with the corresponding extension enabled (optional) 
            var readUser = true;  // bool? |  (optional) 
            var receiveTasks = true;  // bool? |  (optional) 
            var replyWithAssistant = true;  // bool? | permission only available with the corresponding extension enabled (optional) 
            var searchContents = true;  // bool? |  (optional) 
            var searchEvent = true;  // bool? |  (optional) 
            var updateCommunity = true;  // bool? |  (optional) 
            var updateContentSource = true;  // bool? |  (optional) 
            var updateExtension = true;  // bool? |  (optional) 
            var updateIdentity = true;  // bool? |  (optional) 
            var updateIntervention = true;  // bool? |  (optional) 
            var updateOwnIntervention = true;  // bool? |  (optional) 
            var updateSettings = true;  // bool? |  (optional) 
            var updateTimeSheet = true;  // bool? |  (optional) 
            var updateUser = true;  // bool? |  (optional) 
            var useEmoji = true;  // bool? |  (optional) 

            try
            {
                // Creating a role
                Role result = apiInstance.CreateRole(label, accessHelpCenter, accessPreviousMessages, accessPullMode, adminStampAnswer, approveContent, assignIntervention, authorBlockContent, closeContentThread, createAndDestroyExtension, createCommunity, createContentSource, createUser, delayExportContent, deleteContentThread, impersonateUser, inviteUser, manageApiAccessTokens, manageAppSdkApplications, manageAutomaticExportsTasks, manageCategories, manageChat, manageCustomFields, manageCustomNotifications, manageEmailsTemplates, manageFolders, manageIce, manageIdentities, manageOwnNotifications, manageReplyAssistant, manageRoles, manageRulesEngineRules, manageSurveys, manageTags, manageTeams, manageTopologies, manageUsersOfMyTeams, monitorTasks, monitorTeamTasks, muteContent, openContentThread, publishContent, readCommunity, readContentSource, readEvent, readExport, readIdentity, readOwnStats, readPresence, readStats, readSurveys, readUser, receiveTasks, replyWithAssistant, searchContents, searchEvent, updateCommunity, updateContentSource, updateExtension, updateIdentity, updateIntervention, updateOwnIntervention, updateSettings, updateTimeSheet, updateUser, useEmoji);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.CreateRole: " + e.Message );
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
 **label** | **string**|  | 
 **accessHelpCenter** | **bool?**|  | [optional] 
 **accessPreviousMessages** | **bool?**|  | [optional] 
 **accessPullMode** | **bool?**|  | [optional] 
 **adminStampAnswer** | **bool?**|  | [optional] 
 **approveContent** | **bool?**|  | [optional] 
 **assignIntervention** | **bool?**|  | [optional] 
 **authorBlockContent** | **bool?**|  | [optional] 
 **closeContentThread** | **bool?**|  | [optional] 
 **createAndDestroyExtension** | **bool?**|  | [optional] 
 **createCommunity** | **bool?**|  | [optional] 
 **createContentSource** | **bool?**|  | [optional] 
 **createUser** | **bool?**|  | [optional] 
 **delayExportContent** | **bool?**|  | [optional] 
 **deleteContentThread** | **bool?**|  | [optional] 
 **impersonateUser** | **bool?**|  | [optional] 
 **inviteUser** | **bool?**|  | [optional] 
 **manageApiAccessTokens** | **bool?**|  | [optional] 
 **manageAppSdkApplications** | **bool?**|  | [optional] 
 **manageAutomaticExportsTasks** | **bool?**| permission only available with the corresponding extension enabled | [optional] 
 **manageCategories** | **bool?**|  | [optional] 
 **manageChat** | **bool?**|  | [optional] 
 **manageCustomFields** | **bool?**|  | [optional] 
 **manageCustomNotifications** | **bool?**|  | [optional] 
 **manageEmailsTemplates** | **bool?**|  | [optional] 
 **manageFolders** | **bool?**|  | [optional] 
 **manageIce** | **bool?**|  | [optional] 
 **manageIdentities** | **bool?**|  | [optional] 
 **manageOwnNotifications** | **bool?**|  | [optional] 
 **manageReplyAssistant** | **bool?**| permission only available with the corresponding extension enabled | [optional] 
 **manageRoles** | **bool?**|  | [optional] 
 **manageRulesEngineRules** | **bool?**| permission only available with the corresponding extension enabled | [optional] 
 **manageSurveys** | **bool?**| permission only available with the corresponding extension enabled | [optional] 
 **manageTags** | **bool?**|  | [optional] 
 **manageTeams** | **bool?**|  | [optional] 
 **manageTopologies** | **bool?**|  | [optional] 
 **manageUsersOfMyTeams** | **bool?**|  | [optional] 
 **monitorTasks** | **bool?**|  | [optional] 
 **monitorTeamTasks** | **bool?**|  | [optional] 
 **muteContent** | **bool?**|  | [optional] 
 **openContentThread** | **bool?**|  | [optional] 
 **publishContent** | **bool?**|  | [optional] 
 **readCommunity** | **bool?**|  | [optional] 
 **readContentSource** | **bool?**|  | [optional] 
 **readEvent** | **bool?**|  | [optional] 
 **readExport** | **bool?**|  | [optional] 
 **readIdentity** | **bool?**|  | [optional] 
 **readOwnStats** | **bool?**|  | [optional] 
 **readPresence** | **bool?**|  | [optional] 
 **readStats** | **bool?**|  | [optional] 
 **readSurveys** | **bool?**| permission only available with the corresponding extension enabled | [optional] 
 **readUser** | **bool?**|  | [optional] 
 **receiveTasks** | **bool?**|  | [optional] 
 **replyWithAssistant** | **bool?**| permission only available with the corresponding extension enabled | [optional] 
 **searchContents** | **bool?**|  | [optional] 
 **searchEvent** | **bool?**|  | [optional] 
 **updateCommunity** | **bool?**|  | [optional] 
 **updateContentSource** | **bool?**|  | [optional] 
 **updateExtension** | **bool?**|  | [optional] 
 **updateIdentity** | **bool?**|  | [optional] 
 **updateIntervention** | **bool?**|  | [optional] 
 **updateOwnIntervention** | **bool?**|  | [optional] 
 **updateSettings** | **bool?**|  | [optional] 
 **updateTimeSheet** | **bool?**|  | [optional] 
 **updateUser** | **bool?**|  | [optional] 
 **useEmoji** | **bool?**|  | [optional] 

### Return type

[**Role**](Role.md)

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

<a name="getallroles"></a>
# **GetAllRoles**
> GetAllRolesResponse GetAllRoles (int? offset = null, int? limit = null)

Getting all roles

This method renders roles ordered by creation date (ascending).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAllRolesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new RolesApi(Configuration.Default);
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all roles
                GetAllRolesResponse result = apiInstance.GetAllRoles(offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.GetAllRoles: " + e.Message );
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
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllRolesResponse**](GetAllRolesResponse.md)

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

<a name="getrole"></a>
# **GetRole**
> Role GetRole (string roleId)

Getting a role from its id

This method renders a role from given id.  Authorization​: only users that can manage roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new RolesApi(Configuration.Default);
            var roleId = roleId_example;  // string | 

            try
            {
                // Getting a role from its id
                Role result = apiInstance.GetRole(roleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.GetRole: " + e.Message );
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
 **roleId** | **string**|  | 

### Return type

[**Role**](Role.md)

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

<a name="updaterole"></a>
# **UpdateRole**
> Role UpdateRole (string roleId, bool? accessHelpCenter = null, bool? accessPreviousMessages = null, bool? accessPullMode = null, bool? adminStampAnswer = null, bool? approveContent = null, bool? assignIntervention = null, bool? authorBlockContent = null, bool? closeContentThread = null, bool? createAndDestroyExtension = null, bool? createCommunity = null, bool? createContentSource = null, bool? createUser = null, bool? delayExportContent = null, bool? deleteContentThread = null, bool? impersonateUser = null, bool? inviteUser = null, bool? manageApiAccessTokens = null, bool? manageAppSdkApplications = null, bool? manageAutomaticExportsTasks = null, bool? manageCategories = null, bool? manageChat = null, bool? manageCustomFields = null, bool? manageCustomNotifications = null, bool? manageEmailsTemplates = null, bool? manageFolders = null, bool? manageIce = null, bool? manageIdentities = null, bool? manageOwnNotifications = null, bool? manageReplyAssistant = null, bool? manageRoles = null, bool? manageRulesEngineRules = null, bool? manageSurveys = null, bool? manageTags = null, bool? manageTeams = null, bool? manageTopologies = null, bool? manageUsersOfMyTeams = null, bool? monitorTasks = null, bool? monitorTeamTasks = null, bool? muteContent = null, bool? openContentThread = null, bool? publishContent = null, bool? readCommunity = null, bool? readContentSource = null, bool? readEvent = null, bool? readExport = null, bool? readIdentity = null, bool? readOwnStats = null, bool? readPresence = null, bool? readStats = null, bool? readSurveys = null, bool? readUser = null, bool? receiveTasks = null, bool? replyWithAssistant = null, bool? searchContents = null, bool? searchEvent = null, bool? updateCommunity = null, bool? updateContentSource = null, bool? updateExtension = null, bool? updateIdentity = null, bool? updateIntervention = null, bool? updateOwnIntervention = null, bool? updateSettings = null, bool? updateTimeSheet = null, bool? updateUser = null, bool? useEmoji = null)

Updating a role

This method updates an existing role from given attributes and renders it in case of success.  Authorization​: A user can’t update roles with more permissions than himself and can’t give a role a permission he doesn’t have.  Any permission updated with a user that does not have this permission will be ignored (The update is done, just not the unallowed permission)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new RolesApi(Configuration.Default);
            var roleId = roleId_example;  // string | 
            var accessHelpCenter = true;  // bool? |  (optional) 
            var accessPreviousMessages = true;  // bool? |  (optional) 
            var accessPullMode = true;  // bool? |  (optional) 
            var adminStampAnswer = true;  // bool? |  (optional) 
            var approveContent = true;  // bool? |  (optional) 
            var assignIntervention = true;  // bool? |  (optional) 
            var authorBlockContent = true;  // bool? |  (optional) 
            var closeContentThread = true;  // bool? |  (optional) 
            var createAndDestroyExtension = true;  // bool? |  (optional) 
            var createCommunity = true;  // bool? |  (optional) 
            var createContentSource = true;  // bool? |  (optional) 
            var createUser = true;  // bool? |  (optional) 
            var delayExportContent = true;  // bool? |  (optional) 
            var deleteContentThread = true;  // bool? |  (optional) 
            var impersonateUser = true;  // bool? |  (optional) 
            var inviteUser = true;  // bool? |  (optional) 
            var manageApiAccessTokens = true;  // bool? |  (optional) 
            var manageAppSdkApplications = true;  // bool? |  (optional) 
            var manageAutomaticExportsTasks = true;  // bool? | permission only available with the corresponding extension enabled (optional) 
            var manageCategories = true;  // bool? |  (optional) 
            var manageChat = true;  // bool? |  (optional) 
            var manageCustomFields = true;  // bool? |  (optional) 
            var manageCustomNotifications = true;  // bool? |  (optional) 
            var manageEmailsTemplates = true;  // bool? |  (optional) 
            var manageFolders = true;  // bool? |  (optional) 
            var manageIce = true;  // bool? |  (optional) 
            var manageIdentities = true;  // bool? |  (optional) 
            var manageOwnNotifications = true;  // bool? |  (optional) 
            var manageReplyAssistant = true;  // bool? | permission only available with the corresponding extension enabled (optional) 
            var manageRoles = true;  // bool? |  (optional) 
            var manageRulesEngineRules = true;  // bool? | permission only available with the corresponding extension enabled (optional) 
            var manageSurveys = true;  // bool? | permission only available with the corresponding extension enabled (optional) 
            var manageTags = true;  // bool? |  (optional) 
            var manageTeams = true;  // bool? |  (optional) 
            var manageTopologies = true;  // bool? |  (optional) 
            var manageUsersOfMyTeams = true;  // bool? |  (optional) 
            var monitorTasks = true;  // bool? |  (optional) 
            var monitorTeamTasks = true;  // bool? |  (optional) 
            var muteContent = true;  // bool? |  (optional) 
            var openContentThread = true;  // bool? |  (optional) 
            var publishContent = true;  // bool? |  (optional) 
            var readCommunity = true;  // bool? |  (optional) 
            var readContentSource = true;  // bool? |  (optional) 
            var readEvent = true;  // bool? |  (optional) 
            var readExport = true;  // bool? |  (optional) 
            var readIdentity = true;  // bool? |  (optional) 
            var readOwnStats = true;  // bool? |  (optional) 
            var readPresence = true;  // bool? |  (optional) 
            var readStats = true;  // bool? |  (optional) 
            var readSurveys = true;  // bool? | permission only available with the corresponding extension enabled (optional) 
            var readUser = true;  // bool? |  (optional) 
            var receiveTasks = true;  // bool? |  (optional) 
            var replyWithAssistant = true;  // bool? | permission only available with the corresponding extension enabled (optional) 
            var searchContents = true;  // bool? |  (optional) 
            var searchEvent = true;  // bool? |  (optional) 
            var updateCommunity = true;  // bool? |  (optional) 
            var updateContentSource = true;  // bool? |  (optional) 
            var updateExtension = true;  // bool? |  (optional) 
            var updateIdentity = true;  // bool? |  (optional) 
            var updateIntervention = true;  // bool? |  (optional) 
            var updateOwnIntervention = true;  // bool? |  (optional) 
            var updateSettings = true;  // bool? |  (optional) 
            var updateTimeSheet = true;  // bool? |  (optional) 
            var updateUser = true;  // bool? |  (optional) 
            var useEmoji = true;  // bool? |  (optional) 

            try
            {
                // Updating a role
                Role result = apiInstance.UpdateRole(roleId, accessHelpCenter, accessPreviousMessages, accessPullMode, adminStampAnswer, approveContent, assignIntervention, authorBlockContent, closeContentThread, createAndDestroyExtension, createCommunity, createContentSource, createUser, delayExportContent, deleteContentThread, impersonateUser, inviteUser, manageApiAccessTokens, manageAppSdkApplications, manageAutomaticExportsTasks, manageCategories, manageChat, manageCustomFields, manageCustomNotifications, manageEmailsTemplates, manageFolders, manageIce, manageIdentities, manageOwnNotifications, manageReplyAssistant, manageRoles, manageRulesEngineRules, manageSurveys, manageTags, manageTeams, manageTopologies, manageUsersOfMyTeams, monitorTasks, monitorTeamTasks, muteContent, openContentThread, publishContent, readCommunity, readContentSource, readEvent, readExport, readIdentity, readOwnStats, readPresence, readStats, readSurveys, readUser, receiveTasks, replyWithAssistant, searchContents, searchEvent, updateCommunity, updateContentSource, updateExtension, updateIdentity, updateIntervention, updateOwnIntervention, updateSettings, updateTimeSheet, updateUser, useEmoji);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.UpdateRole: " + e.Message );
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
 **roleId** | **string**|  | 
 **accessHelpCenter** | **bool?**|  | [optional] 
 **accessPreviousMessages** | **bool?**|  | [optional] 
 **accessPullMode** | **bool?**|  | [optional] 
 **adminStampAnswer** | **bool?**|  | [optional] 
 **approveContent** | **bool?**|  | [optional] 
 **assignIntervention** | **bool?**|  | [optional] 
 **authorBlockContent** | **bool?**|  | [optional] 
 **closeContentThread** | **bool?**|  | [optional] 
 **createAndDestroyExtension** | **bool?**|  | [optional] 
 **createCommunity** | **bool?**|  | [optional] 
 **createContentSource** | **bool?**|  | [optional] 
 **createUser** | **bool?**|  | [optional] 
 **delayExportContent** | **bool?**|  | [optional] 
 **deleteContentThread** | **bool?**|  | [optional] 
 **impersonateUser** | **bool?**|  | [optional] 
 **inviteUser** | **bool?**|  | [optional] 
 **manageApiAccessTokens** | **bool?**|  | [optional] 
 **manageAppSdkApplications** | **bool?**|  | [optional] 
 **manageAutomaticExportsTasks** | **bool?**| permission only available with the corresponding extension enabled | [optional] 
 **manageCategories** | **bool?**|  | [optional] 
 **manageChat** | **bool?**|  | [optional] 
 **manageCustomFields** | **bool?**|  | [optional] 
 **manageCustomNotifications** | **bool?**|  | [optional] 
 **manageEmailsTemplates** | **bool?**|  | [optional] 
 **manageFolders** | **bool?**|  | [optional] 
 **manageIce** | **bool?**|  | [optional] 
 **manageIdentities** | **bool?**|  | [optional] 
 **manageOwnNotifications** | **bool?**|  | [optional] 
 **manageReplyAssistant** | **bool?**| permission only available with the corresponding extension enabled | [optional] 
 **manageRoles** | **bool?**|  | [optional] 
 **manageRulesEngineRules** | **bool?**| permission only available with the corresponding extension enabled | [optional] 
 **manageSurveys** | **bool?**| permission only available with the corresponding extension enabled | [optional] 
 **manageTags** | **bool?**|  | [optional] 
 **manageTeams** | **bool?**|  | [optional] 
 **manageTopologies** | **bool?**|  | [optional] 
 **manageUsersOfMyTeams** | **bool?**|  | [optional] 
 **monitorTasks** | **bool?**|  | [optional] 
 **monitorTeamTasks** | **bool?**|  | [optional] 
 **muteContent** | **bool?**|  | [optional] 
 **openContentThread** | **bool?**|  | [optional] 
 **publishContent** | **bool?**|  | [optional] 
 **readCommunity** | **bool?**|  | [optional] 
 **readContentSource** | **bool?**|  | [optional] 
 **readEvent** | **bool?**|  | [optional] 
 **readExport** | **bool?**|  | [optional] 
 **readIdentity** | **bool?**|  | [optional] 
 **readOwnStats** | **bool?**|  | [optional] 
 **readPresence** | **bool?**|  | [optional] 
 **readStats** | **bool?**|  | [optional] 
 **readSurveys** | **bool?**| permission only available with the corresponding extension enabled | [optional] 
 **readUser** | **bool?**|  | [optional] 
 **receiveTasks** | **bool?**|  | [optional] 
 **replyWithAssistant** | **bool?**| permission only available with the corresponding extension enabled | [optional] 
 **searchContents** | **bool?**|  | [optional] 
 **searchEvent** | **bool?**|  | [optional] 
 **updateCommunity** | **bool?**|  | [optional] 
 **updateContentSource** | **bool?**|  | [optional] 
 **updateExtension** | **bool?**|  | [optional] 
 **updateIdentity** | **bool?**|  | [optional] 
 **updateIntervention** | **bool?**|  | [optional] 
 **updateOwnIntervention** | **bool?**|  | [optional] 
 **updateSettings** | **bool?**|  | [optional] 
 **updateTimeSheet** | **bool?**|  | [optional] 
 **updateUser** | **bool?**|  | [optional] 
 **useEmoji** | **bool?**|  | [optional] 

### Return type

[**Role**](Role.md)

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

