# InteractiveTicketingSdk.Api.DefaultApi

All URIs are relative to *https://secure.interactiveticketing.com/developers/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventsEventIdGet**](DefaultApi.md#eventseventidget) | **GET** /events/{eventId} | Fetch Event by ID
[**EventsEventIdOrdersGet**](DefaultApi.md#eventseventidordersget) | **GET** /events/{eventId}/orders | Query Orders
[**EventsEventIdOrdersOrderIdGet**](DefaultApi.md#eventseventidordersorderidget) | **GET** /events/{eventId}/orders/{orderId} | Fetch Order by ID
[**EventsGet**](DefaultApi.md#eventsget) | **GET** /events | List All Events
[**ScanPost**](DefaultApi.md#scanpost) | **POST** /scan | Scan Ticket

<a name="eventseventidget"></a>
# **EventsEventIdGet**
> Event EventsEventIdGet (long? eventId)

Fetch Event by ID

Get single event with `eventId`.

### Example
```csharp
using System;
using System.Diagnostics;
using InteractiveTicketingSdk.Api;
using InteractiveTicketingSdk.Client;
using InteractiveTicketingSdk.Model;

namespace Example
{
    public class EventsEventIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var eventId = 789;  // long? | ID of event to return

            try
            {
                // Fetch Event by ID
                Event result = apiInstance.EventsEventIdGet(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EventsEventIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **long?**| ID of event to return | 

### Return type

[**Event**](Event.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="eventseventidordersget"></a>
# **EventsEventIdOrdersGet**
> PaginatedOrders EventsEventIdOrdersGet (int? eventId, int? fromOrderId = null, int? start = null, int? limit = null, bool? testMode = null, string orderType = null)

Query Orders

Returns paginated list of orders from the event. The `orderId` is not unique across all events. Use `fromOrderId` parameter to loop through orders if you are pulling down all data.

### Example
```csharp
using System;
using System.Diagnostics;
using InteractiveTicketingSdk.Api;
using InteractiveTicketingSdk.Client;
using InteractiveTicketingSdk.Model;

namespace Example
{
    public class EventsEventIdOrdersGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var eventId = 56;  // int? | ID of event to return
            var fromOrderId = 56;  // int? | Return orders with `orderId` greater than `fromOrderId`. (optional) 
            var start = 56;  // int? | For pagination, return orders from `start` row index. (optional) 
            var limit = 56;  // int? | For pagination, limit results to `limit` number of rows. (optional) 
            var testMode = true;  // bool? | Query test orders only. (optional) 
            var orderType = orderType_example;  // string | To query only `web`, `pos`, or `kiosk` orders. (optional) 

            try
            {
                // Query Orders
                PaginatedOrders result = apiInstance.EventsEventIdOrdersGet(eventId, fromOrderId, start, limit, testMode, orderType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EventsEventIdOrdersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**| ID of event to return | 
 **fromOrderId** | **int?**| Return orders with &#x60;orderId&#x60; greater than &#x60;fromOrderId&#x60;. | [optional] 
 **start** | **int?**| For pagination, return orders from &#x60;start&#x60; row index. | [optional] 
 **limit** | **int?**| For pagination, limit results to &#x60;limit&#x60; number of rows. | [optional] 
 **testMode** | **bool?**| Query test orders only. | [optional] 
 **orderType** | **string**| To query only &#x60;web&#x60;, &#x60;pos&#x60;, or &#x60;kiosk&#x60; orders. | [optional] 

### Return type

[**PaginatedOrders**](PaginatedOrders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="eventseventidordersorderidget"></a>
# **EventsEventIdOrdersOrderIdGet**
> Order EventsEventIdOrdersOrderIdGet (long? eventId, long? orderId)

Fetch Order by ID

Get single order with `eventId` and `orderId`.

### Example
```csharp
using System;
using System.Diagnostics;
using InteractiveTicketingSdk.Api;
using InteractiveTicketingSdk.Client;
using InteractiveTicketingSdk.Model;

namespace Example
{
    public class EventsEventIdOrdersOrderIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var eventId = 789;  // long? | ID of event to return
            var orderId = 789;  // long? | ID of order to return

            try
            {
                // Fetch Order by ID
                Order result = apiInstance.EventsEventIdOrdersOrderIdGet(eventId, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EventsEventIdOrdersOrderIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **long?**| ID of event to return | 
 **orderId** | **long?**| ID of order to return | 

### Return type

[**Order**](Order.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="eventsget"></a>
# **EventsGet**
> List<Event> EventsGet ()

List All Events

Get list of all your events with their `eventId`.

### Example
```csharp
using System;
using System.Diagnostics;
using InteractiveTicketingSdk.Api;
using InteractiveTicketingSdk.Client;
using InteractiveTicketingSdk.Model;

namespace Example
{
    public class EventsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                // List All Events
                List&lt;Event&gt; result = apiInstance.EventsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EventsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Event>**](Event.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="scanpost"></a>
# **ScanPost**
> ScanResponse ScanPost (ScanRequest body)

Scan Ticket

Scan a ticket or third party barcode.

### Example
```csharp
using System;
using System.Diagnostics;
using InteractiveTicketingSdk.Api;
using InteractiveTicketingSdk.Client;
using InteractiveTicketingSdk.Model;

namespace Example
{
    public class ScanPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ScanRequest(); // ScanRequest | List of user object

            try
            {
                // Scan Ticket
                ScanResponse result = apiInstance.ScanPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ScanPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ScanRequest**](ScanRequest.md)| List of user object | 

### Return type

[**ScanResponse**](ScanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
