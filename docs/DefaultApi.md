# InteractiveTicketingSdk.Api.DefaultApi

All URIs are relative to *https://secure.interactiveticketing.com/developers/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventsEventIdGet**](DefaultApi.md#eventseventidget) | **GET** /events/{eventId} | Single Event
[**EventsEventIdOrdersGet**](DefaultApi.md#eventseventidordersget) | **GET** /events/{eventId}/orders | Search Orders
[**EventsEventIdOrdersOrderIdGet**](DefaultApi.md#eventseventidordersorderidget) | **GET** /events/{eventId}/orders/{orderId} | Single Order
[**EventsGet**](DefaultApi.md#eventsget) | **GET** /events | All Events

<a name="eventseventidget"></a>
# **EventsEventIdGet**
> Event EventsEventIdGet (long? eventId)

Single Event

Get single event with `eventId`

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
                // Single Event
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

Search Orders

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
                // Search Orders
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

Single Order

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
                // Single Order
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

All Events

Get list of all events with their `eventId` for your user key

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
                // All Events
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
