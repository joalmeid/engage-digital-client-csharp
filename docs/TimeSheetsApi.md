# RingCentral.EngageDigital.Api.TimeSheetsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTimeSheet**](TimeSheetsApi.md#createtimesheet) | **POST** /time_sheets | Creating a time sheet
[**DeleteTimeSheet**](TimeSheetsApi.md#deletetimesheet) | **DELETE** /time_sheets/{timeSheetId} | Deleting a time sheet
[**GetAllTimeSheets**](TimeSheetsApi.md#getalltimesheets) | **GET** /time_sheets | Getting all time sheets
[**GetTimeSheet**](TimeSheetsApi.md#gettimesheet) | **GET** /time_sheets/{timeSheetId} | Getting a time sheet from its id
[**UpdateTimeSheet**](TimeSheetsApi.md#updatetimesheet) | **PUT** /time_sheets/{timeSheetId} | Updating a time sheet

<a name="createtimesheet"></a>
# **CreateTimeSheet**
> TimeSheet CreateTimeSheet (string label, bool? active = null, List<string> sourceIds = null, string holidaysRegion = null, string holidays = null, string mondayHours = null, string tuesdayHours = null, string wednesdayHours = null, string thursdayHours = null, string fridayHours = null, string saturdayHours = null, string sundayHours = null)

Creating a time sheet

This method creates a time sheet. In case of success it renders the time sheet, otherwise, it renders an error (422 HTTP code).  Authorization​: only users that can create time sheet.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreateTimeSheetExample
    {
        public void main()
        {
            var apiInstance = new TimeSheetsApi();
            var label = label_example;  // string | The label of the time sheet.
            var active = true;  // bool? | true or false, this field is used to enable/disable a time sheet. (optional) 
            var sourceIds = new List<string>(); // List<string> | An array containing id of each source using your time sheet. (optional) 
            var holidaysRegion = holidaysRegion_example;  // string | A string containing the first two letters of your country (example: \"fr\"/\"en\"/\"es\"), useful to bootstrap default holidays following to a country. (optional) 
            var holidays = holidays_example;  // string | An array containing one or more hash of holidays, a holiday must contain a name (string) and a date (string), the date must be in a valid format, a valid format is a format corresponding to your domain’s locale). (optional) 
            var mondayHours = mondayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. For example: “a-b,c-d”: “a” is the beginning of the first interval of the day, “b” is the ending of the first interval of the day, “c” is the beginning of the second interval of the day, “d” is the ending of the second interval of the day (optional) 
            var tuesdayHours = tuesdayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See `monday_hours` for the format. (optional) 
            var wednesdayHours = wednesdayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See `monday_hours` for the format. (optional) 
            var thursdayHours = thursdayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See `monday_hours` for the format. (optional) 
            var fridayHours = fridayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See `monday_hours` for the format. (optional) 
            var saturdayHours = saturdayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See `monday_hours` for the format. (optional) 
            var sundayHours = sundayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See `monday_hours` for the format. (optional) 

            try
            {
                // Creating a time sheet
                TimeSheet result = apiInstance.CreateTimeSheet(label, active, sourceIds, holidaysRegion, holidays, mondayHours, tuesdayHours, wednesdayHours, thursdayHours, fridayHours, saturdayHours, sundayHours);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSheetsApi.CreateTimeSheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **label** | **string**| The label of the time sheet. | 
 **active** | **bool?**| true or false, this field is used to enable/disable a time sheet. | [optional] 
 **sourceIds** | [**List&lt;string&gt;**](string.md)| An array containing id of each source using your time sheet. | [optional] 
 **holidaysRegion** | **string**| A string containing the first two letters of your country (example: \&quot;fr\&quot;/\&quot;en\&quot;/\&quot;es\&quot;), useful to bootstrap default holidays following to a country. | [optional] 
 **holidays** | **string**| An array containing one or more hash of holidays, a holiday must contain a name (string) and a date (string), the date must be in a valid format, a valid format is a format corresponding to your domain’s locale). | [optional] 
 **mondayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. For example: “a-b,c-d”: “a” is the beginning of the first interval of the day, “b” is the ending of the first interval of the day, “c” is the beginning of the second interval of the day, “d” is the ending of the second interval of the day | [optional] 
 **tuesdayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See &#x60;monday_hours&#x60; for the format. | [optional] 
 **wednesdayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See &#x60;monday_hours&#x60; for the format. | [optional] 
 **thursdayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See &#x60;monday_hours&#x60; for the format. | [optional] 
 **fridayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See &#x60;monday_hours&#x60; for the format. | [optional] 
 **saturdayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See &#x60;monday_hours&#x60; for the format. | [optional] 
 **sundayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See &#x60;monday_hours&#x60; for the format. | [optional] 

### Return type

[**TimeSheet**](TimeSheet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetimesheet"></a>
# **DeleteTimeSheet**
> TimeSheet DeleteTimeSheet (string timeSheetId)

Deleting a time sheet

This method destroys an existing time sheet. It renders time sheet itself. It renders a 404 if id is invalid.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class DeleteTimeSheetExample
    {
        public void main()
        {
            var apiInstance = new TimeSheetsApi();
            var timeSheetId = timeSheetId_example;  // string | 

            try
            {
                // Deleting a time sheet
                TimeSheet result = apiInstance.DeleteTimeSheet(timeSheetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSheetsApi.DeleteTimeSheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeSheetId** | **string**|  | 

### Return type

[**TimeSheet**](TimeSheet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getalltimesheets"></a>
# **GetAllTimeSheets**
> GetAllTimeSheetsResponse GetAllTimeSheets (int? offset = null, int? limit = null)

Getting all time sheets

This method renders time sheets ordered by active and label.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllTimeSheetsExample
    {
        public void main()
        {
            var apiInstance = new TimeSheetsApi();
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all time sheets
                GetAllTimeSheetsResponse result = apiInstance.GetAllTimeSheets(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSheetsApi.GetAllTimeSheets: " + e.Message );
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

[**GetAllTimeSheetsResponse**](GetAllTimeSheetsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettimesheet"></a>
# **GetTimeSheet**
> TimeSheet GetTimeSheet (string timeSheetId)

Getting a time sheet from its id

This method renders a time sheet from given id.  Authorization​: only users that can see time sheets in administration section.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetTimeSheetExample
    {
        public void main()
        {
            var apiInstance = new TimeSheetsApi();
            var timeSheetId = timeSheetId_example;  // string | 

            try
            {
                // Getting a time sheet from its id
                TimeSheet result = apiInstance.GetTimeSheet(timeSheetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSheetsApi.GetTimeSheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeSheetId** | **string**|  | 

### Return type

[**TimeSheet**](TimeSheet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetimesheet"></a>
# **UpdateTimeSheet**
> TimeSheet UpdateTimeSheet (string timeSheetId, bool? active = null, string label = null, List<string> sourceIds = null, string holidays = null, string mondayHours = null, string tuesdayHours = null, string wednesdayHours = null, string thursdayHours = null, string fridayHours = null, string saturdayHours = null, string sundayHours = null)

Updating a time sheet

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
    public class UpdateTimeSheetExample
    {
        public void main()
        {
            var apiInstance = new TimeSheetsApi();
            var timeSheetId = timeSheetId_example;  // string | 
            var active = true;  // bool? | true or false, this field is used to enable/disable a time sheet. (optional) 
            var label = label_example;  // string | The label of the time sheet. (optional) 
            var sourceIds = new List<string>(); // List<string> | An array containing id of each source using your time sheet. (optional) 
            var holidays = holidays_example;  // string | An array containing one or more hash of holidays, a holiday must contain a name (string) and a date (string), the date must be in a valid format, a valid format is a format corresponding to your domain’s locale). (optional) 
            var mondayHours = mondayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. For example: “a-b,c-d”: “a” is the beginning of the first interval of the day, “b” is the ending of the first interval of the day, “c” is the beginning of the second interval of the day, “d” is the ending of the second interval of the day (optional) 
            var tuesdayHours = tuesdayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See `monday_hours` for the format. (optional) 
            var wednesdayHours = wednesdayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See `monday_hours` for the format. (optional) 
            var thursdayHours = thursdayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See `monday_hours` for the format. (optional) 
            var fridayHours = fridayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See `monday_hours` for the format. (optional) 
            var saturdayHours = saturdayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See `monday_hours` for the format. (optional) 
            var sundayHours = sundayHours_example;  // string | this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See `monday_hours` for the format. (optional) 

            try
            {
                // Updating a time sheet
                TimeSheet result = apiInstance.UpdateTimeSheet(timeSheetId, active, label, sourceIds, holidays, mondayHours, tuesdayHours, wednesdayHours, thursdayHours, fridayHours, saturdayHours, sundayHours);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSheetsApi.UpdateTimeSheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeSheetId** | **string**|  | 
 **active** | **bool?**| true or false, this field is used to enable/disable a time sheet. | [optional] 
 **label** | **string**| The label of the time sheet. | [optional] 
 **sourceIds** | [**List&lt;string&gt;**](string.md)| An array containing id of each source using your time sheet. | [optional] 
 **holidays** | **string**| An array containing one or more hash of holidays, a holiday must contain a name (string) and a date (string), the date must be in a valid format, a valid format is a format corresponding to your domain’s locale). | [optional] 
 **mondayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. For example: “a-b,c-d”: “a” is the beginning of the first interval of the day, “b” is the ending of the first interval of the day, “c” is the beginning of the second interval of the day, “d” is the ending of the second interval of the day | [optional] 
 **tuesdayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See &#x60;monday_hours&#x60; for the format. | [optional] 
 **wednesdayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See &#x60;monday_hours&#x60; for the format. | [optional] 
 **thursdayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See &#x60;monday_hours&#x60; for the format. | [optional] 
 **fridayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See &#x60;monday_hours&#x60; for the format. | [optional] 
 **saturdayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See &#x60;monday_hours&#x60; for the format. | [optional] 
 **sundayHours** | **string**| this field define the time intervals of the day (in secs). An empty string means that there are no business hours on this day. See &#x60;monday_hours&#x60; for the format. | [optional] 

### Return type

[**TimeSheet**](TimeSheet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
