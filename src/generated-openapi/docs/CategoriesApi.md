# Org.OpenAPITools.Api.CategoriesApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCategory**](CategoriesApi.md#createcategory) | **POST** /categories | Creating a category
[**DeleteCategory**](CategoriesApi.md#deletecategory) | **DELETE** /categories/{categoryId} | Deleting a category
[**GetAllCategories**](CategoriesApi.md#getallcategories) | **GET** /categories | Getting all categories
[**GetCategory**](CategoriesApi.md#getcategory) | **GET** /categories/{categoryId} | Getting a category from its id
[**UpdateCategory**](CategoriesApi.md#updatecategory) | **PUT** /categories/{categoryId} | Updating a category


<a name="createcategory"></a>
# **CreateCategory**
> Category CreateCategory (string name = null, string parentId = null, int? color = null, bool? mandatory = null, bool? multiple = null, bool? postQualification = null, bool? unselectable = null, List<string> sourceIds = null)

Creating a category

This method creates a new team. In case of success it renders the created tag, otherwise, it renders an error (422 HTTP code).  Note: The fields ​`mandatory`,​ `​multiple`,​ ​`post_qualification​`, `s​ource_ids`​ and `u​nselectable​` are accounted for only if the Category has no parent.  Authorization​: only users that can manage teams.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCategoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new CategoriesApi(Configuration.Default);
            var name = name_example;  // string | Category name. (optional) 
            var parentId = parentId_example;  // string | ID of parent category. (optional) 
            var color = 56;  // int? | displayed color for the category, see Category colors.  (optional) 
            var mandatory = true;  // bool? | mandatory categorization (Boolean). (optional) 
            var multiple = true;  // bool? | allow to assign multiple child categories (Boolean). (optional) 
            var postQualification = true;  // bool? | post qualification (Boolean). (optional) 
            var unselectable = true;  // bool? | root category is unselectable (Boolean). (optional) 
            var sourceIds = new List<string>(); // List<string> | List of source id. (optional) 

            try
            {
                // Creating a category
                Category result = apiInstance.CreateCategory(name, parentId, color, mandatory, multiple, postQualification, unselectable, sourceIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.CreateCategory: " + e.Message );
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
 **name** | **string**| Category name. | [optional] 
 **parentId** | **string**| ID of parent category. | [optional] 
 **color** | **int?**| displayed color for the category, see Category colors.  | [optional] 
 **mandatory** | **bool?**| mandatory categorization (Boolean). | [optional] 
 **multiple** | **bool?**| allow to assign multiple child categories (Boolean). | [optional] 
 **postQualification** | **bool?**| post qualification (Boolean). | [optional] 
 **unselectable** | **bool?**| root category is unselectable (Boolean). | [optional] 
 **sourceIds** | [**List&lt;string&gt;**](string.md)| List of source id. | [optional] 

### Return type

[**Category**](Category.md)

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

<a name="deletecategory"></a>
# **DeleteCategory**
> Category DeleteCategory (string categoryId, string takeOverCategoryId = null)

Deleting a category

This method destroys an existing category. It renders the category itself. It renders a 404 if id is invalid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCategoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new CategoriesApi(Configuration.Default);
            var categoryId = categoryId_example;  // string | 
            var takeOverCategoryId = takeOverCategoryId_example;  // string | ID of a category to recategorize (optional). (optional) 

            try
            {
                // Deleting a category
                Category result = apiInstance.DeleteCategory(categoryId, takeOverCategoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.DeleteCategory: " + e.Message );
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
 **categoryId** | **string**|  | 
 **takeOverCategoryId** | **string**| ID of a category to recategorize (optional). | [optional] 

### Return type

[**Category**](Category.md)

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

<a name="getallcategories"></a>
# **GetAllCategories**
> GetAllCategoriesResponse GetAllCategories (string parentId = null, int? offset = null, int? limit = null)

Getting all categories

This method renders categories ordered by creation date (ascending).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAllCategoriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new CategoriesApi(Configuration.Default);
            var parentId = parentId_example;  // string | To filter categories on given category parent id. (optional) 
            var offset = 56;  // int? | The record index to start. Default value is 0. (optional) 
            var limit = 56;  // int? | The max number of records to return. Default value is 30, max value is 150. (optional) 

            try
            {
                // Getting all categories
                GetAllCategoriesResponse result = apiInstance.GetAllCategories(parentId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetAllCategories: " + e.Message );
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
 **parentId** | **string**| To filter categories on given category parent id. | [optional] 
 **offset** | **int?**| The record index to start. Default value is 0. | [optional] 
 **limit** | **int?**| The max number of records to return. Default value is 30, max value is 150. | [optional] 

### Return type

[**GetAllCategoriesResponse**](GetAllCategoriesResponse.md)

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

<a name="getcategory"></a>
# **GetCategory**
> Category GetCategory (string categoryId)

Getting a category from its id

This method renders a category from given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCategoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new CategoriesApi(Configuration.Default);
            var categoryId = categoryId_example;  // string | 

            try
            {
                // Getting a category from its id
                Category result = apiInstance.GetCategory(categoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategory: " + e.Message );
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
 **categoryId** | **string**|  | 

### Return type

[**Category**](Category.md)

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

<a name="updatecategory"></a>
# **UpdateCategory**
> Category UpdateCategory (string categoryId, string name = null, string parentId = null, int? color = null, bool? mandatory = null, bool? multiple = null, bool? postQualification = null, bool? unselectable = null, List<string> sourceIds = null)

Updating a category

This method creates a new team. In case of success it renders the created tag, otherwise, it renders an error (422 HTTP code).  Note: The fields ​`mandatory`,​ ​`multiple`,​ ​`post_qualification​`, `s​ource_ids​` and `u​nselectable​` are accounted for only if the Category has no parent.  Authorization​: only users that can manage teams.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCategoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://DOMAIN.api.engagement.dimelo.com/1.0";
            var apiInstance = new CategoriesApi(Configuration.Default);
            var categoryId = categoryId_example;  // string | 
            var name = name_example;  // string | Category name. (optional) 
            var parentId = parentId_example;  // string | ID of parent category. (optional) 
            var color = 56;  // int? | displayed color for the category, see Category colors.  (optional) 
            var mandatory = true;  // bool? | mandatory categorization (Boolean). (optional) 
            var multiple = true;  // bool? | allow to assign multiple child categories (Boolean). (optional) 
            var postQualification = true;  // bool? | post qualification (Boolean). (optional) 
            var unselectable = true;  // bool? | root category is unselectable (Boolean). (optional) 
            var sourceIds = new List<string>(); // List<string> | List of source id. (optional) 

            try
            {
                // Updating a category
                Category result = apiInstance.UpdateCategory(categoryId, name, parentId, color, mandatory, multiple, postQualification, unselectable, sourceIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.UpdateCategory: " + e.Message );
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
 **categoryId** | **string**|  | 
 **name** | **string**| Category name. | [optional] 
 **parentId** | **string**| ID of parent category. | [optional] 
 **color** | **int?**| displayed color for the category, see Category colors.  | [optional] 
 **mandatory** | **bool?**| mandatory categorization (Boolean). | [optional] 
 **multiple** | **bool?**| allow to assign multiple child categories (Boolean). | [optional] 
 **postQualification** | **bool?**| post qualification (Boolean). | [optional] 
 **unselectable** | **bool?**| root category is unselectable (Boolean). | [optional] 
 **sourceIds** | [**List&lt;string&gt;**](string.md)| List of source id. | [optional] 

### Return type

[**Category**](Category.md)

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

