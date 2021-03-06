# RingCentral.EngageDigital - the C# library for the Engage Digital API

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project using the published [RingCentral.Engage openapi-spec](https://raw.githubusercontent.com/grokify/go-ringcentral-engage/master/codegen/openapi-spec_v3.0.0.json)

- API version: 1.0
- SDK version: 1.0.5
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.10.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [CompareNETObjects](https://www.nuget.org/packages/CompareNETObjects) - 4.57.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
Install-Package CompareNETObjects
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out RingCentral.EngageDigital.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new AgentStatusApi(config);
            var agentId = agentId_example;  // string | 
            var status = status_example;  // string | A hash of channel_id => availability (must contain all channels). (optional) 
            var customStatusId = customStatusId_example;  // string | id of presence status (optional) (optional) 

            try
            {
                // Changing an agent's status
                AgentStatus result = apiInstance.ChangeAgentStatus(agentId, status, customStatusId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AgentStatusApi.ChangeAgentStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AgentStatusApi* | [**ChangeAgentStatus**](docs/AgentStatusApi.md#changeagentstatus) | **PUT** /status/{agentId} | Changing an agent's status
*AgentStatusApi* | [**GetAgentStatus**](docs/AgentStatusApi.md#getagentstatus) | **GET** /status/{agentId} | Get a connected agent status
*AgentStatusApi* | [**GetAllAgentStatus**](docs/AgentStatusApi.md#getallagentstatus) | **GET** /status | Get all connected agents status
*AttachmentsApi* | [**CreateAttachment**](docs/AttachmentsApi.md#createattachment) | **POST** /attachments | Creating an attachment
*AttachmentsApi* | [**GetAllAttachments**](docs/AttachmentsApi.md#getallattachments) | **GET** /attachments | Getting all attachments
*AttachmentsApi* | [**GetAttachment**](docs/AttachmentsApi.md#getattachment) | **GET** /attachments/{attachmentId} | Getting an attachment from its id
*CategoriesApi* | [**CreateCategory**](docs/CategoriesApi.md#createcategory) | **POST** /categories | Creating a category
*CategoriesApi* | [**DeleteCategory**](docs/CategoriesApi.md#deletecategory) | **DELETE** /categories/{categoryId} | Deleting a category
*CategoriesApi* | [**GetAllCategories**](docs/CategoriesApi.md#getallcategories) | **GET** /categories | Getting all categories
*CategoriesApi* | [**GetCategory**](docs/CategoriesApi.md#getcategory) | **GET** /categories/{categoryId} | Getting a category from its id
*CategoriesApi* | [**UpdateCategory**](docs/CategoriesApi.md#updatecategory) | **PUT** /categories/{categoryId} | Updating a category
*ChannelsApi* | [**GetAllChannels**](docs/ChannelsApi.md#getallchannels) | **GET** /channels | Getting all channels
*ChannelsApi* | [**GetChannel**](docs/ChannelsApi.md#getchannel) | **GET** /channels/{channelId} | Getting a channel from its id
*ChannelsApi* | [**UpdateChannel**](docs/ChannelsApi.md#updatechannel) | **PUT** /channels/{channelId} | Updating a channel
*CommunitiesApi* | [**GetAllCommunities**](docs/CommunitiesApi.md#getallcommunities) | **GET** /communities | Getting all communities
*CommunitiesApi* | [**GetCommunity**](docs/CommunitiesApi.md#getcommunity) | **GET** /communities/{communityId} | Getting a community from its id
*ContentsApi* | [**CategorizeContent**](docs/ContentsApi.md#categorizecontent) | **PUT** /contents/{contentId}/update_categories | Categorizing a content
*ContentsApi* | [**CreateContent**](docs/ContentsApi.md#createcontent) | **POST** /contents | Creating a content
*ContentsApi* | [**GetAllContents**](docs/ContentsApi.md#getallcontents) | **GET** /contents | Contents
*ContentsApi* | [**GetContent**](docs/ContentsApi.md#getcontent) | **GET** /contents/{contentId} | Getting a content from its id
*ContentsApi* | [**IgnoreContent**](docs/ContentsApi.md#ignorecontent) | **PUT** /contents/{contentId}/ignore | Ignoring a content
*CustomFieldsApi* | [**CreateCustomField**](docs/CustomFieldsApi.md#createcustomfield) | **POST** /custom_fields | Creating a custom field
*CustomFieldsApi* | [**DeleteCustomField**](docs/CustomFieldsApi.md#deletecustomfield) | **DELETE** /custom_fields/{customFieldId} | Deleting a custom field
*CustomFieldsApi* | [**GetAllCustomFields**](docs/CustomFieldsApi.md#getallcustomfields) | **GET** /custom_fields | Getting all custom fields
*CustomFieldsApi* | [**GetCustomField**](docs/CustomFieldsApi.md#getcustomfield) | **GET** /custom_fields/{customFieldId} | Getting a custom field from its id
*CustomFieldsApi* | [**UpdateCustomField**](docs/CustomFieldsApi.md#updatecustomfield) | **PUT** /custom_fields/{customFieldId} | Updating a custom field
*EventsApi* | [**GetAllEvents**](docs/EventsApi.md#getallevents) | **GET** /events | Getting all events
*EventsApi* | [**GetEvent**](docs/EventsApi.md#getevent) | **GET** /events/{eventId} | Getting an event from its id
*FoldersApi* | [**CreateFolder**](docs/FoldersApi.md#createfolder) | **POST** /folders | Creating a folder
*FoldersApi* | [**DeleteFolder**](docs/FoldersApi.md#deletefolder) | **DELETE** /folders/{folderId} | Deleting a folder
*FoldersApi* | [**GetAllFolders**](docs/FoldersApi.md#getallfolders) | **GET** /folders | Getting all folders
*FoldersApi* | [**GetFolder**](docs/FoldersApi.md#getfolder) | **GET** /folders/{folderId} | Getting a folder from its id
*FoldersApi* | [**UpdateFolder**](docs/FoldersApi.md#updatefolder) | **PUT** /folders/{folderId} | Updating a folder
*IdentitiesApi* | [**GetAllIdentities**](docs/IdentitiesApi.md#getallidentities) | **GET** /identities | Getting all identities
*IdentitiesApi* | [**GetIdentity**](docs/IdentitiesApi.md#getidentity) | **GET** /identities/{identityId} | Getting an identity from its id
*IdentityGroupsApi* | [**GetAllIdentityGroups**](docs/IdentityGroupsApi.md#getallidentitygroups) | **GET** /identity_groups | Getting all identity groups
*IdentityGroupsApi* | [**GetIdentityGroup**](docs/IdentityGroupsApi.md#getidentitygroup) | **GET** /identity_groups/{identityGroupId} | Getting an identity group from its id
*IdentityGroupsApi* | [**UpdateIdentityGroup**](docs/IdentityGroupsApi.md#updateidentitygroup) | **PUT** /identity_groups/{identityGroupId} | Updating an identity group
*InterventionCommentsApi* | [**CreateInterventionComment**](docs/InterventionCommentsApi.md#createinterventioncomment) | **POST** /intervention_comments | Creating an intervention comment
*InterventionCommentsApi* | [**DeleteInterventionComment**](docs/InterventionCommentsApi.md#deleteinterventioncomment) | **DELETE** /intervention_comments/{interventionCommentId} | Deleting an intervention comment
*InterventionCommentsApi* | [**GetAllInterventionComments**](docs/InterventionCommentsApi.md#getallinterventioncomments) | **GET** /intervention_comments | Getting all intervention comments
*InterventionCommentsApi* | [**GetInterventionComment**](docs/InterventionCommentsApi.md#getinterventioncomment) | **GET** /intervention_comments/{interventionCommentId} | Getting an intervention comment from its id
*InterventionsApi* | [**CancelIntervention**](docs/InterventionsApi.md#cancelintervention) | **DELETE** /interventions/{interventionId}/cancel | Cancelling an intervention
*InterventionsApi* | [**CategorizeIntervention**](docs/InterventionsApi.md#categorizeintervention) | **PUT** /interventions/{interventionId}/update_categories | Categorizing an intervention
*InterventionsApi* | [**CloseIntervention**](docs/InterventionsApi.md#closeintervention) | **PUT** /interventions/{interventionId}/close | Closing an intervention
*InterventionsApi* | [**CreateIntervention**](docs/InterventionsApi.md#createintervention) | **POST** /interventions | Creating an intervention
*InterventionsApi* | [**GetAllInterventions**](docs/InterventionsApi.md#getallinterventions) | **GET** /interventions | Getting all interventions
*InterventionsApi* | [**GetIntervention**](docs/InterventionsApi.md#getintervention) | **GET** /interventions/{interventionId} | Getting an intervention from its id
*InterventionsApi* | [**ReassignIntervention**](docs/InterventionsApi.md#reassignintervention) | **PUT** /interventions/{interventionId}/reassign | Reassigning an intervention
*LocalesApi* | [**GetAllLocales**](docs/LocalesApi.md#getalllocales) | **GET** /locales | Getting all locales
*PresenceStatusApi* | [**CreatePresenceStatus**](docs/PresenceStatusApi.md#createpresencestatus) | **POST** /presence_status | Creating a presence status
*PresenceStatusApi* | [**DeletePresenceStatus**](docs/PresenceStatusApi.md#deletepresencestatus) | **DELETE** /presence_status/{presenceStatusId} | Deleting a presence status
*PresenceStatusApi* | [**GetAllPresenceStatus**](docs/PresenceStatusApi.md#getallpresencestatus) | **GET** /presence_status | Getting all presence statuses
*PresenceStatusApi* | [**GetPresenceStatus**](docs/PresenceStatusApi.md#getpresencestatus) | **GET** /presence_status/{presenceStatusId} | Getting a presence status from its id
*PresenceStatusApi* | [**UpdatePresenceStatus**](docs/PresenceStatusApi.md#updatepresencestatus) | **PUT** /presence_status/{presenceStatusId} | Updating a presence status
*ReplyAssistantEntriesApi* | [**CreateReplyAssistantEntry**](docs/ReplyAssistantEntriesApi.md#createreplyassistantentry) | **POST** /reply_assistant/entries | Creating an entry
*ReplyAssistantEntriesApi* | [**DeleteReplyAssistantEntry**](docs/ReplyAssistantEntriesApi.md#deletereplyassistantentry) | **DELETE** /reply_assistant/entries/{replyAssistantEntryId} | Deleting a reply assistant entry
*ReplyAssistantEntriesApi* | [**GetAllReplyAssistantEntries**](docs/ReplyAssistantEntriesApi.md#getallreplyassistantentries) | **GET** /reply_assistant/entries | Getting​ a​ll​ reply assistant e​ntries
*ReplyAssistantEntriesApi* | [**GetReplyAssistantEntry**](docs/ReplyAssistantEntriesApi.md#getreplyassistantentry) | **GET** /reply_assistant/entries/{replyAssistantEntryId} | Getting a reply assistant entry from its id
*ReplyAssistantEntriesApi* | [**UpdateReplyAssistantEntry**](docs/ReplyAssistantEntriesApi.md#updatereplyassistantentry) | **PUT** /reply_assistant/entries/{replyAssistantEntryId} | Updating a reply assistant entry
*ReplyAssistantGroupsApi* | [**CreateReplyAssistantGroup**](docs/ReplyAssistantGroupsApi.md#createreplyassistantgroup) | **POST** /reply_assistant/groups | Creating a reply assistant group
*ReplyAssistantGroupsApi* | [**DeleteReplyAssistantGroup**](docs/ReplyAssistantGroupsApi.md#deletereplyassistantgroup) | **DELETE** /reply_assistant/groups/{replyAssistantGroupId} | Deleting a reply assistant group
*ReplyAssistantGroupsApi* | [**GetAllReplyAssistantGroups**](docs/ReplyAssistantGroupsApi.md#getallreplyassistantgroups) | **GET** /reply_assistant/groups | Getting​ a​ll​ reply assistant groups
*ReplyAssistantGroupsApi* | [**GetReplyAssistantGroup**](docs/ReplyAssistantGroupsApi.md#getreplyassistantgroup) | **GET** /reply_assistant/groups/{replyAssistantGroupId} | Getting a reply assistant group from its id
*ReplyAssistantGroupsApi* | [**UpdateReplyAssistantGroup**](docs/ReplyAssistantGroupsApi.md#updatereplyassistantgroup) | **PUT** /reply_assistant/groups/{replyAssistantGroupId} | Updating a reply assistant group
*ReplyAssistantVersionsApi* | [**CreateReplyAssistantVersion**](docs/ReplyAssistantVersionsApi.md#createreplyassistantversion) | **POST** /reply_assistant/versions | Creating a reply assistant version
*ReplyAssistantVersionsApi* | [**DeleteReplyAssistantVersion**](docs/ReplyAssistantVersionsApi.md#deletereplyassistantversion) | **DELETE** /reply_assistant/versions/{replyAssistantVersionId} | Deleting a reply assistant version
*ReplyAssistantVersionsApi* | [**GetAllReplyAssistantVersions**](docs/ReplyAssistantVersionsApi.md#getallreplyassistantversions) | **GET** /reply_assistant/versions | Getting​ a​ll​ reply assistant versions
*ReplyAssistantVersionsApi* | [**GetReplyAssistantVersion**](docs/ReplyAssistantVersionsApi.md#getreplyassistantversion) | **GET** /reply_assistant/versions/{replyAssistantVersionId} | Getting a reply assistant version from its id
*ReplyAssistantVersionsApi* | [**UpdateReplyAssistantVersion**](docs/ReplyAssistantVersionsApi.md#updatereplyassistantversion) | **PUT** /reply_assistant/versions/{replyAssistantVersionId} | Updating a reply assistant version
*RolesApi* | [**CreateRole**](docs/RolesApi.md#createrole) | **POST** /roles | Creating a role
*RolesApi* | [**GetAllRoles**](docs/RolesApi.md#getallroles) | **GET** /roles | Getting all roles
*RolesApi* | [**GetRole**](docs/RolesApi.md#getrole) | **GET** /roles/{roleId} | Getting a role from its id
*RolesApi* | [**UpdateRole**](docs/RolesApi.md#updaterole) | **PUT** /roles/{roleId} | Updating a role
*SettingsApi* | [**GetAllSettings**](docs/SettingsApi.md#getallsettings) | **GET** /settings | Getting all settings
*SettingsApi* | [**UpdateSettings**](docs/SettingsApi.md#updatesettings) | **PUT** /settings | Updating settings
*SourcesApi* | [**GetAllSources**](docs/SourcesApi.md#getallsources) | **GET** /content_sources | Getting all sources
*SourcesApi* | [**GetSource**](docs/SourcesApi.md#getsource) | **GET** /content_sources/{sourceId} | Getting a source from its id
*SourcesApi* | [**UpdateSource**](docs/SourcesApi.md#updatesource) | **PUT** /content_sources/{sourceId} | Updating a source
*TagsApi* | [**CreateTag**](docs/TagsApi.md#createtag) | **POST** /tags | Creating a tag
*TagsApi* | [**DeleteTag**](docs/TagsApi.md#deletetag) | **DELETE** /tags/{tagId} | Deleting a tag
*TagsApi* | [**GetAllTags**](docs/TagsApi.md#getalltags) | **GET** /tags | Getting all tags
*TagsApi* | [**GetTag**](docs/TagsApi.md#gettag) | **GET** /tags/{tagId} | Getting a tag from its id
*TagsApi* | [**UpdateTag**](docs/TagsApi.md#updatetag) | **PUT** /tags/{tagId} | Updating a tag
*TasksApi* | [**GetAllTasks**](docs/TasksApi.md#getalltasks) | **GET** /tasks | Getting all tasks
*TasksApi* | [**GetTask**](docs/TasksApi.md#gettask) | **GET** /tasks/{taskId} | Getting a task from its id
*TasksApi* | [**MoveTask**](docs/TasksApi.md#movetask) | **DELETE** /tasks/{taskId}/move | Move a task to another queue
*TasksApi* | [**TransferTask**](docs/TasksApi.md#transfertask) | **PUT** /tasks/{taskId}/transfer | Transferring a task
*TeamsApi* | [**CreateTeam**](docs/TeamsApi.md#createteam) | **POST** /teams | Creating a team
*TeamsApi* | [**DeleteTeam**](docs/TeamsApi.md#deleteteam) | **DELETE** /teams/{teamId} | Deleting a team
*TeamsApi* | [**GetAllTeams**](docs/TeamsApi.md#getallteams) | **GET** /teams | Getting all teams
*TeamsApi* | [**GetTeam**](docs/TeamsApi.md#getteam) | **GET** /teams/{teamId} | Getting a team from its id
*TeamsApi* | [**UpdateTeam**](docs/TeamsApi.md#updateteam) | **PUT** /teams/{teamId} | Updating a team
*ThreadsApi* | [**ArchiveThread**](docs/ThreadsApi.md#archivethread) | **PUT** /content_threads/{threadId}/ignore | Archiving a thread
*ThreadsApi* | [**CategorizeThread**](docs/ThreadsApi.md#categorizethread) | **PUT** /content_threads/{threadId}/update_categories | Categorizing a thread
*ThreadsApi* | [**CloseThread**](docs/ThreadsApi.md#closethread) | **PUT** /content_threads/{threadId}/close | Close a thread
*ThreadsApi* | [**GetAllThreads**](docs/ThreadsApi.md#getallthreads) | **GET** /content_threads | Getting all threads
*ThreadsApi* | [**GetThread**](docs/ThreadsApi.md#getthread) | **GET** /content_threads/{threadId} | Getting a thread from its id
*ThreadsApi* | [**OpenThread**](docs/ThreadsApi.md#openthread) | **GET** /content_threads/{threadId}/open | Open a thread
*TimeSheetsApi* | [**CreateTimeSheet**](docs/TimeSheetsApi.md#createtimesheet) | **POST** /time_sheets | Creating a time sheet
*TimeSheetsApi* | [**DeleteTimeSheet**](docs/TimeSheetsApi.md#deletetimesheet) | **DELETE** /time_sheets/{timeSheetId} | Deleting a time sheet
*TimeSheetsApi* | [**GetAllTimeSheets**](docs/TimeSheetsApi.md#getalltimesheets) | **GET** /time_sheets | Getting all time sheets
*TimeSheetsApi* | [**GetTimeSheet**](docs/TimeSheetsApi.md#gettimesheet) | **GET** /time_sheets/{timeSheetId} | Getting a time sheet from its id
*TimeSheetsApi* | [**UpdateTimeSheet**](docs/TimeSheetsApi.md#updatetimesheet) | **PUT** /time_sheets/{timeSheetId} | Updating a time sheet
*TimezonesApi* | [**GetAllTimezones**](docs/TimezonesApi.md#getalltimezones) | **GET** /timezones | Getting all timezones
*UsersApi* | [**CreateUser**](docs/UsersApi.md#createuser) | **POST** /users | Creating a user
*UsersApi* | [**DeleteUser**](docs/UsersApi.md#deleteuser) | **DELETE** /users/{userId} | Deleting a user
*UsersApi* | [**GetAllUsers**](docs/UsersApi.md#getallusers) | **GET** /users | Getting all users
*UsersApi* | [**GetUser**](docs/UsersApi.md#getuser) | **GET** /users/{userId} | Getting a user from its id
*UsersApi* | [**InviteUser**](docs/UsersApi.md#inviteuser) | **POST** /users/invite | Inviting a user
*UsersApi* | [**UpdateUser**](docs/UsersApi.md#updateuser) | **PUT** /users/{userId} | Updating a user
*WebhooksApi* | [**CreateWebhook**](docs/WebhooksApi.md#createwebhook) | **POST** /webhooks | Creating a webhook
*WebhooksApi* | [**DeleteWebhook**](docs/WebhooksApi.md#deletewebhook) | **DELETE** /webhooks/{webhookId} | Deleting a webhook
*WebhooksApi* | [**GetAllWebhooks**](docs/WebhooksApi.md#getallwebhooks) | **GET** /webhooks | Getting all webhooks
*WebhooksApi* | [**GetWebhook**](docs/WebhooksApi.md#getwebhook) | **GET** /webhooks/{webhookId} | Getting a webhook from its id
*WebhooksApi* | [**UpdateWebhook**](docs/WebhooksApi.md#updatewebhook) | **PUT** /webhooks/{webhookId} | Updating a webhook


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AgentCustomStatus](docs/AgentCustomStatus.md)
 - [Model.AgentStatus](docs/AgentStatus.md)
 - [Model.AgentStatusChannel](docs/AgentStatusChannel.md)
 - [Model.Attachment](docs/Attachment.md)
 - [Model.Category](docs/Category.md)
 - [Model.Channel](docs/Channel.md)
 - [Model.Community](docs/Community.md)
 - [Model.Content](docs/Content.md)
 - [Model.ContentAttachment](docs/ContentAttachment.md)
 - [Model.ContentBodyFormatted](docs/ContentBodyFormatted.md)
 - [Model.CustomField](docs/CustomField.md)
 - [Model.Event](docs/Event.md)
 - [Model.EventExtraInfo](docs/EventExtraInfo.md)
 - [Model.Folder](docs/Folder.md)
 - [Model.GetAllAgentStatusResponse](docs/GetAllAgentStatusResponse.md)
 - [Model.GetAllAttachmentsResponse](docs/GetAllAttachmentsResponse.md)
 - [Model.GetAllCategoriesResponse](docs/GetAllCategoriesResponse.md)
 - [Model.GetAllChannelsResponse](docs/GetAllChannelsResponse.md)
 - [Model.GetAllCommunitiesResponse](docs/GetAllCommunitiesResponse.md)
 - [Model.GetAllContentsResponse](docs/GetAllContentsResponse.md)
 - [Model.GetAllCustomFieldsResponse](docs/GetAllCustomFieldsResponse.md)
 - [Model.GetAllEventsResponse](docs/GetAllEventsResponse.md)
 - [Model.GetAllFoldersResponse](docs/GetAllFoldersResponse.md)
 - [Model.GetAllIdentitiesResponse](docs/GetAllIdentitiesResponse.md)
 - [Model.GetAllIdentityGroupsResponse](docs/GetAllIdentityGroupsResponse.md)
 - [Model.GetAllInterventionCommentsResponse](docs/GetAllInterventionCommentsResponse.md)
 - [Model.GetAllInterventionsResponse](docs/GetAllInterventionsResponse.md)
 - [Model.GetAllPresenceStatusResponse](docs/GetAllPresenceStatusResponse.md)
 - [Model.GetAllReplyAssistantEntriesResponse](docs/GetAllReplyAssistantEntriesResponse.md)
 - [Model.GetAllReplyAssistantGroupsResponse](docs/GetAllReplyAssistantGroupsResponse.md)
 - [Model.GetAllReplyAssistantVersionsResponse](docs/GetAllReplyAssistantVersionsResponse.md)
 - [Model.GetAllRolesResponse](docs/GetAllRolesResponse.md)
 - [Model.GetAllSourcesResponse](docs/GetAllSourcesResponse.md)
 - [Model.GetAllTagsResponse](docs/GetAllTagsResponse.md)
 - [Model.GetAllTasksResponse](docs/GetAllTasksResponse.md)
 - [Model.GetAllTeamsResponse](docs/GetAllTeamsResponse.md)
 - [Model.GetAllThreadsResponse](docs/GetAllThreadsResponse.md)
 - [Model.GetAllTimeSheetsResponse](docs/GetAllTimeSheetsResponse.md)
 - [Model.GetAllUsersResponse](docs/GetAllUsersResponse.md)
 - [Model.GetAllWebhooksResponse](docs/GetAllWebhooksResponse.md)
 - [Model.Identity](docs/Identity.md)
 - [Model.IdentityGroup](docs/IdentityGroup.md)
 - [Model.Intervention](docs/Intervention.md)
 - [Model.InterventionComment](docs/InterventionComment.md)
 - [Model.Locale](docs/Locale.md)
 - [Model.PresenceStatus](docs/PresenceStatus.md)
 - [Model.ReplyAssistantEntry](docs/ReplyAssistantEntry.md)
 - [Model.ReplyAssistantGroup](docs/ReplyAssistantGroup.md)
 - [Model.ReplyAssistantVersion](docs/ReplyAssistantVersion.md)
 - [Model.Restriction](docs/Restriction.md)
 - [Model.Role](docs/Role.md)
 - [Model.Settings](docs/Settings.md)
 - [Model.Source](docs/Source.md)
 - [Model.Tag](docs/Tag.md)
 - [Model.Task](docs/Task.md)
 - [Model.Team](docs/Team.md)
 - [Model.Thread](docs/Thread.md)
 - [Model.TimeSheet](docs/TimeSheet.md)
 - [Model.TimeSheetHoliday](docs/TimeSheetHoliday.md)
 - [Model.Timezone](docs/Timezone.md)
 - [Model.User](docs/User.md)
 - [Model.Webhook](docs/Webhook.md)
 - [Model.WebhookAccessToken](docs/WebhookAccessToken.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="bearerAuth"></a>
### bearerAuth

- **Type**: HTTP basic authentication

