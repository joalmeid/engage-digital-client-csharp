# RingCentral.EngageDigital.Api.TimezonesApi

All URIs are relative to *https://DOMAIN.api.engagement.dimelo.com/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllTimezones**](TimezonesApi.md#getalltimezones) | **GET** /timezones | Getting all timezones

<a name="getalltimezones"></a>
# **GetAllTimezones**
> List<Timezone> GetAllTimezones ()

Getting all timezones

This method renders all available timezones.

### Example
```csharp
using System;
using System.Diagnostics;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Model;

namespace Example
{
    public class GetAllTimezonesExample
    {
        public void main()
        {
            var apiInstance = new TimezonesApi();

            try
            {
                // Getting all timezones
                List&lt;Timezone&gt; result = apiInstance.GetAllTimezones();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimezonesApi.GetAllTimezones: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Timezone>**](Timezone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
