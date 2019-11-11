# RingCentral.EngageDigital.Api.LocalesApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllLocales**](LocalesApi.md#getalllocales) | **GET** /locales | Getting all locales

<a name="getalllocales"></a>
# **GetAllLocales**
> List<Locale> GetAllLocales ()

Getting all locales

This method renders all available locales.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllLocalesExample
    {
        public void main()
        {
            var apiInstance = new LocalesApi();

            try
            {
                // Getting all locales
                List&lt;Locale&gt; result = apiInstance.GetAllLocales();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalesApi.GetAllLocales: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Locale>**](Locale.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
