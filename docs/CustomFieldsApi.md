# RingCentral.EngageDigital.Api.CustomFieldsApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomField**](CustomFieldsApi.md#createcustomfield) | **POST** /custom_fields | Creating a custom field
[**DeleteCustomField**](CustomFieldsApi.md#deletecustomfield) | **DELETE** /custom_fields/{customFieldId} | Deleting a custom field
[**GetAllCustomFields**](CustomFieldsApi.md#getallcustomfields) | **GET** /custom_fields | Getting all custom fields
[**GetCustomField**](CustomFieldsApi.md#getcustomfield) | **GET** /custom_fields/{customFieldId} | Getting a custom field from its id
[**UpdateCustomField**](CustomFieldsApi.md#updatecustomfield) | **PUT** /custom_fields/{customFieldId} | Updating a custom field

<a name="createcustomfield"></a>
# **CreateCustomField**
> CustomField CreateCustomField (string associatedTypeName, string label, string key = null, string type = null, List<string> choices = null, bool? multiple = null, int? position = null)

Creating a custom field

This method creates a custom field. In case of success it renders the custom field, otherwise, it renders an error (422 HTTP code).  Authorization​: only users that can create custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class CreateCustomFieldExample
    {
        public void main()
        {
            var apiInstance = new CustomFieldsApi();
            var associatedTypeName = associatedTypeName_example;  // string | The associated type of custom field. It can be IdentityGroup or Intervention.
            var label = label_example;  // string | The label of the custom field.
            var key = key_example;  // string | The key of the custom field (example: customer_id). This is used to determine how it is stored on identity groups. (optional) 
            var type = type_example;  // string | The type of the custom field. It can be string, boolean, text, integer, float, single_choice, (optional) 
            var choices = new List<string>(); // List<string> | A list of choices to be for single_choice, or multiple_choice types. This must be given (optional) 
            var multiple = true;  // bool? | true or false, this as no effect on single_choice, multiple_choice or boolean types (optional) 
            var position = 56;  // int? | an integer that indicates custom field’s position between others (default: -1). (optional) 

            try
            {
                // Creating a custom field
                CustomField result = apiInstance.CreateCustomField(associatedTypeName, label, key, type, choices, multiple, position);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.CreateCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **associatedTypeName** | **string**| The associated type of custom field. It can be IdentityGroup or Intervention. | 
 **label** | **string**| The label of the custom field. | 
 **key** | **string**| The key of the custom field (example: customer_id). This is used to determine how it is stored on identity groups. | [optional] 
 **type** | **string**| The type of the custom field. It can be string, boolean, text, integer, float, single_choice, | [optional] 
 **choices** | [**List&lt;string&gt;**](string.md)| A list of choices to be for single_choice, or multiple_choice types. This must be given | [optional] 
 **multiple** | **bool?**| true or false, this as no effect on single_choice, multiple_choice or boolean types | [optional] 
 **position** | **int?**| an integer that indicates custom field’s position between others (default: -1). | [optional] 

### Return type

[**CustomField**](CustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecustomfield"></a>
# **DeleteCustomField**
> CustomField DeleteCustomField (string customFieldId)

Deleting a custom field

This method destroys an existing custom field. It renders custom field itself. It renders a 404 if id is invalid.  Authorization​: only users that are able to destroy custom fields..

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class DeleteCustomFieldExample
    {
        public void main()
        {
            var apiInstance = new CustomFieldsApi();
            var customFieldId = customFieldId_example;  // string | 

            try
            {
                // Deleting a custom field
                CustomField result = apiInstance.DeleteCustomField(customFieldId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.DeleteCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **string**|  | 

### Return type

[**CustomField**](CustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallcustomfields"></a>
# **GetAllCustomFields**
> GetAllCustomFieldsResponse GetAllCustomFields (int? offset = null, int? limit = null)

Getting all custom fields

This method renders custom fields ordered by position (ascending).  Authorization​: only users that can see custom fields in administration section.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new CustomFieldsApi();
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all custom fields
                GetAllCustomFieldsResponse result = apiInstance.GetAllCustomFields(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.GetAllCustomFields: " + e.Message );
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

[**GetAllCustomFieldsResponse**](GetAllCustomFieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcustomfield"></a>
# **GetCustomField**
> CustomField GetCustomField (string customFieldId)

Getting a custom field from its id

This method renders a custom field from given id.  Authorization​: only users that can see custom fields in administration section.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetCustomFieldExample
    {
        public void main()
        {
            var apiInstance = new CustomFieldsApi();
            var customFieldId = customFieldId_example;  // string | 

            try
            {
                // Getting a custom field from its id
                CustomField result = apiInstance.GetCustomField(customFieldId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.GetCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **string**|  | 

### Return type

[**CustomField**](CustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecustomfield"></a>
# **UpdateCustomField**
> CustomField UpdateCustomField (string customFieldId, string label = null, List<string> choices = null, int? position = null)

Updating a custom field

This method updates an existing custom field from given attributes and renders it in case of success.  Authorization​: only users that are able to update custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class UpdateCustomFieldExample
    {
        public void main()
        {
            var apiInstance = new CustomFieldsApi();
            var customFieldId = customFieldId_example;  // string | 
            var label = label_example;  // string | Custom field’s label. (optional) 
            var choices = new List<string>(); // List<string> |  (optional) 
            var position = 56;  // int? | Custom field’s position. (optional) 

            try
            {
                // Updating a custom field
                CustomField result = apiInstance.UpdateCustomField(customFieldId, label, choices, position);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.UpdateCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **string**|  | 
 **label** | **string**| Custom field’s label. | [optional] 
 **choices** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **position** | **int?**| Custom field’s position. | [optional] 

### Return type

[**CustomField**](CustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
