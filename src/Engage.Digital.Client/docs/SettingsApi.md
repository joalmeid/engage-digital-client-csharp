# Org.OpenAPITools.Api.SettingsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllSettings**](SettingsApi.md#getallsettings) | **GET** /settings | Getting all settings
[**UpdateSettings**](SettingsApi.md#updatesettings) | **PUT** /settings | Updating settings


<a name="getallsettings"></a>
# **GetAllSettings**
> Settings GetAllSettings ()

Getting all settings

This method renders all settings of your domain.  Authorization​: only users that can update settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAllSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new SettingsApi(Configuration.Default);

            try
            {
                // Getting all settings
                Settings result = apiInstance.GetAllSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetAllSettings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Settings**](Settings.md)

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

<a name="updatesettings"></a>
# **UpdateSettings**
> Settings UpdateSettings (int? activityPresenceThreshold = null, bool? activityTracking = null, string beginningOfWeek = null, bool? categoryTagging = null, string contentLanguages = null, bool? dashboard = null, bool? denyIframeIntegration = null, bool? disablePasswordAutocomplete = null, int? expirePasswordAfter = null, bool? expirePasswordEnabled = null, bool? exportInSeconds = null, bool? foldUselessContents = null, int? fteDuration = null, bool? identityMerge = null, List<int> interventionDeferRates = null, int? interventionDeferThreshold = null, List<int> interventionRates = null, string locale = null, bool? multiLang = null, string name = null, bool? passwordArchivableEnabled = null, int? passwordArchivableSize = null, int? passwordMinLength = null, bool? passwordNonWord = null, bool? passwordNumbers = null, bool? passwordRecoveryDisabled = null, bool? pushEnabled = null, bool? replyAsAnyIdentity = null, bool? rtlSupport = null, bool? selfApprovalRequired = null, int? sessionTimeout = null, bool? spellchecking = null, string style = null, bool? thirdPartyServicesDisabled = null, string timezone = null, bool? trackJs = null, string type = null, int? urgentTaskThreshold = null, bool? useSystemFont = null)

Updating settings

This method updates the current domain settings.  Authorization​: only users that can update settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateSettingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new SettingsApi(Configuration.Default);
            var activityPresenceThreshold = 56;  // int? | (in hours). (optional) 
            var activityTracking = true;  // bool? | ​Enable activity tracking (Boolean) (optional) 
            var beginningOfWeek = beginningOfWeek_example;  // string | (Day of week) (optional) 
            var categoryTagging = true;  // bool? | A​ ctivate the forced categorization by source.​ (Boolean) (optional) 
            var contentLanguages = contentLanguages_example;  // string | (See format) (optional) 
            var dashboard = true;  // bool? | Activate the dashboard (Boolean) (optional) 
            var denyIframeIntegration = true;  // bool? | Prevent the DD to be embed by other websites (Boolean) (optional) 
            var disablePasswordAutocomplete = true;  // bool? | (Boolean) (optional) 
            var expirePasswordAfter = 56;  // int? | password expiration delay (in seconds) (optional) 
            var expirePasswordEnabled = true;  // bool? | enable password expiration (Boolean) (optional) 
            var exportInSeconds = true;  // bool? | provide durations in seconds in export (Boolean) (optional) 
            var foldUselessContents = true;  // bool? | fold archived contents (Boolean) (optional) 
            var fteDuration = 56;  // int? | FTE data period (in hours) (optional) 
            var identityMerge = true;  // bool? | enable identity merge (Boolean) (optional) 
            var interventionDeferRates = new List<int>(); // List<int> | (Array of times in seconds) (optional) 
            var interventionDeferThreshold = 56;  // int? | (in seconds) (optional) 
            var interventionRates = new List<int>(); // List<int> | (Array of times in seconds) (optional) 
            var locale = locale_example;  // string | locale code (String) (optional) 
            var multiLang = true;  // bool? | activate multi language support for messages (Boolean) (optional) 
            var name = name_example;  // string | Name of the Dimelo Digital (String) (optional) 
            var passwordArchivableEnabled = true;  // bool? | prohibit reusing old passwords (Boolean) (optional) 
            var passwordArchivableSize = 56;  // int? | number of archived passwords (optional) 
            var passwordMinLength = 56;  // int? | minimum character length (optional) 
            var passwordNonWord = true;  // bool? | should contain at least 1 non alphanumeric char (Boolean) (optional) 
            var passwordNumbers = true;  // bool? | should contain at least 1 number (Boolean) (optional) 
            var passwordRecoveryDisabled = true;  // bool? | disable password recovery by email (Boolean) (optional) 
            var pushEnabled = true;  // bool? | Enable push mode (Boolean) (optional) 
            var replyAsAnyIdentity = true;  // bool? | Enable reply as any identity (Boolean) (optional) 
            var rtlSupport = true;  // bool? | Enable right to left support (Boolean) (optional) 
            var selfApprovalRequired = true;  // bool? | ​Allow authors to ask approval of their messages (Boolean) (optional) 
            var sessionTimeout = 56;  // int? | Session timeout (in minutes) (optional) 
            var spellchecking = true;  // bool? | Enable spellchecking (Boolean) (optional) 
            var style = style_example;  // string | Defines the DD’s design (String) (optional) 
            var thirdPartyServicesDisabled = true;  // bool? | Disable third-party services (tracking...) (Boolean) (optional) 
            var timezone = timezone_example;  // string | Use the timezone endpoint to get the timezone name (String) (optional) 
            var trackJs = true;  // bool? | Track JS errors (Boolean) (optional) 
            var type = type_example;  // string | Can be ‘demo’, ‘production’ or ‘archived’ (optional) 
            var urgentTaskThreshold = 56;  // int? | Chat max response time (in seconds) (optional) 
            var useSystemFont = true;  // bool? | Experimental (Boolean) (optional) 

            try
            {
                // Updating settings
                Settings result = apiInstance.UpdateSettings(activityPresenceThreshold, activityTracking, beginningOfWeek, categoryTagging, contentLanguages, dashboard, denyIframeIntegration, disablePasswordAutocomplete, expirePasswordAfter, expirePasswordEnabled, exportInSeconds, foldUselessContents, fteDuration, identityMerge, interventionDeferRates, interventionDeferThreshold, interventionRates, locale, multiLang, name, passwordArchivableEnabled, passwordArchivableSize, passwordMinLength, passwordNonWord, passwordNumbers, passwordRecoveryDisabled, pushEnabled, replyAsAnyIdentity, rtlSupport, selfApprovalRequired, sessionTimeout, spellchecking, style, thirdPartyServicesDisabled, timezone, trackJs, type, urgentTaskThreshold, useSystemFont);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.UpdateSettings: " + e.Message );
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
 **activityPresenceThreshold** | **int?**| (in hours). | [optional] 
 **activityTracking** | **bool?**| ​Enable activity tracking (Boolean) | [optional] 
 **beginningOfWeek** | **string**| (Day of week) | [optional] 
 **categoryTagging** | **bool?**| A​ ctivate the forced categorization by source.​ (Boolean) | [optional] 
 **contentLanguages** | **string**| (See format) | [optional] 
 **dashboard** | **bool?**| Activate the dashboard (Boolean) | [optional] 
 **denyIframeIntegration** | **bool?**| Prevent the DD to be embed by other websites (Boolean) | [optional] 
 **disablePasswordAutocomplete** | **bool?**| (Boolean) | [optional] 
 **expirePasswordAfter** | **int?**| password expiration delay (in seconds) | [optional] 
 **expirePasswordEnabled** | **bool?**| enable password expiration (Boolean) | [optional] 
 **exportInSeconds** | **bool?**| provide durations in seconds in export (Boolean) | [optional] 
 **foldUselessContents** | **bool?**| fold archived contents (Boolean) | [optional] 
 **fteDuration** | **int?**| FTE data period (in hours) | [optional] 
 **identityMerge** | **bool?**| enable identity merge (Boolean) | [optional] 
 **interventionDeferRates** | [**List&lt;int&gt;**](int.md)| (Array of times in seconds) | [optional] 
 **interventionDeferThreshold** | **int?**| (in seconds) | [optional] 
 **interventionRates** | [**List&lt;int&gt;**](int.md)| (Array of times in seconds) | [optional] 
 **locale** | **string**| locale code (String) | [optional] 
 **multiLang** | **bool?**| activate multi language support for messages (Boolean) | [optional] 
 **name** | **string**| Name of the Dimelo Digital (String) | [optional] 
 **passwordArchivableEnabled** | **bool?**| prohibit reusing old passwords (Boolean) | [optional] 
 **passwordArchivableSize** | **int?**| number of archived passwords | [optional] 
 **passwordMinLength** | **int?**| minimum character length | [optional] 
 **passwordNonWord** | **bool?**| should contain at least 1 non alphanumeric char (Boolean) | [optional] 
 **passwordNumbers** | **bool?**| should contain at least 1 number (Boolean) | [optional] 
 **passwordRecoveryDisabled** | **bool?**| disable password recovery by email (Boolean) | [optional] 
 **pushEnabled** | **bool?**| Enable push mode (Boolean) | [optional] 
 **replyAsAnyIdentity** | **bool?**| Enable reply as any identity (Boolean) | [optional] 
 **rtlSupport** | **bool?**| Enable right to left support (Boolean) | [optional] 
 **selfApprovalRequired** | **bool?**| ​Allow authors to ask approval of their messages (Boolean) | [optional] 
 **sessionTimeout** | **int?**| Session timeout (in minutes) | [optional] 
 **spellchecking** | **bool?**| Enable spellchecking (Boolean) | [optional] 
 **style** | **string**| Defines the DD’s design (String) | [optional] 
 **thirdPartyServicesDisabled** | **bool?**| Disable third-party services (tracking...) (Boolean) | [optional] 
 **timezone** | **string**| Use the timezone endpoint to get the timezone name (String) | [optional] 
 **trackJs** | **bool?**| Track JS errors (Boolean) | [optional] 
 **type** | **string**| Can be ‘demo’, ‘production’ or ‘archived’ | [optional] 
 **urgentTaskThreshold** | **int?**| Chat max response time (in seconds) | [optional] 
 **useSystemFont** | **bool?**| Experimental (Boolean) | [optional] 

### Return type

[**Settings**](Settings.md)

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

