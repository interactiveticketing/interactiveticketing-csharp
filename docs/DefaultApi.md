# InteractiveTicketingSdk.Api.DefaultApi

All URIs are relative to *https://secure.interactiveticketing.com/developers/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventsEventIdAbandonedShoppingCartsGet**](DefaultApi.md#eventseventidabandonedshoppingcartsget) | **GET** /events/{eventId}/abandonedShoppingCarts | Query Abandoned Shopping Cart Data
[**EventsEventIdGet**](DefaultApi.md#eventseventidget) | **GET** /events/{eventId} | Fetch Event by ID
[**EventsEventIdOrdersBarcodeBarcodeGet**](DefaultApi.md#eventseventidordersbarcodebarcodeget) | **GET** /events/{eventId}/orders/barcode/{barcode} | Fetch Order by Barcode
[**EventsEventIdOrdersGet**](DefaultApi.md#eventseventidordersget) | **GET** /events/{eventId}/orders | Query Orders
[**EventsEventIdOrdersOrderIdGet**](DefaultApi.md#eventseventidordersorderidget) | **GET** /events/{eventId}/orders/{orderId} | Fetch Order by ID
[**EventsGet**](DefaultApi.md#eventsget) | **GET** /events | List All Events
[**ScanPost**](DefaultApi.md#scanpost) | **POST** /scan | Scan Ticket

<a name="eventseventidabandonedshoppingcartsget"></a>
# **EventsEventIdAbandonedShoppingCartsGet**
> PaginatedCartEmails EventsEventIdAbandonedShoppingCartsGet (int? eventId, int? fromCartEmailId = null, int? email = null, int? start = null, int? limit = null)

Query Abandoned Shopping Cart Data

Returns paginated list of cart data from the event. The `cartEmailId` is not unique across all events. Use `fromCartEmailId` parameter to loop through orders if you are pulling down all data.

### Example
```csharp
using System;
using System.Diagnostics;
using InteractiveTicketingSdk.Api;
using InteractiveTicketingSdk.Client;
using InteractiveTicketingSdk.Model;

namespace Example
{
    public class EventsEventIdAbandonedShoppingCartsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var eventId = 56;  // int? | ID of event to return
            var fromCartEmailId = 56;  // int? | Return entries with `cartEmailId` greater than `fromCartEmailId`. (optional) 
            var email = 56;  // int? | Return entries with matching email address. (optional) 
            var start = 56;  // int? | For pagination, return orders from `start` row index. (optional) 
            var limit = 56;  // int? | For pagination, limit results to `limit` number of rows. (optional) 

            try
            {
                // Query Abandoned Shopping Cart Data
                PaginatedCartEmails result = apiInstance.EventsEventIdAbandonedShoppingCartsGet(eventId, fromCartEmailId, email, start, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EventsEventIdAbandonedShoppingCartsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **int?**| ID of event to return | 
 **fromCartEmailId** | **int?**| Return entries with &#x60;cartEmailId&#x60; greater than &#x60;fromCartEmailId&#x60;. | [optional] 
 **email** | **int?**| Return entries with matching email address. | [optional] 
 **start** | **int?**| For pagination, return orders from &#x60;start&#x60; row index. | [optional] 
 **limit** | **int?**| For pagination, limit results to &#x60;limit&#x60; number of rows. | [optional] 

### Return type

[**PaginatedCartEmails**](PaginatedCartEmails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="eventseventidget"></a>
# **EventsEventIdGet**
> ModelEvent EventsEventIdGet (long? eventId)

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
                ModelEvent result = apiInstance.EventsEventIdGet(eventId);
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

[**ModelEvent**](ModelEvent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="eventseventidordersbarcodebarcodeget"></a>
# **EventsEventIdOrdersBarcodeBarcodeGet**
> Order EventsEventIdOrdersBarcodeBarcodeGet (long? eventId, string barcode)

Fetch Order by Barcode

Get single order with `eventId` and `barcode`.

### Example
```csharp
using System;
using System.Diagnostics;
using InteractiveTicketingSdk.Api;
using InteractiveTicketingSdk.Client;
using InteractiveTicketingSdk.Model;

namespace Example
{
    public class EventsEventIdOrdersBarcodeBarcodeGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var eventId = 789;  // long? | ID of event to return
            var barcode = barcode_example;  // string | Barcode from ticket of the order to return

            try
            {
                // Fetch Order by Barcode
                Order result = apiInstance.EventsEventIdOrdersBarcodeBarcodeGet(eventId, barcode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.EventsEventIdOrdersBarcodeBarcodeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **long?**| ID of event to return | 
 **barcode** | **string**| Barcode from ticket of the order to return | 

### Return type

[**Order**](Order.md)

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
> List<ModelEvent> EventsGet ()

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
                List&lt;ModelEvent&gt; result = apiInstance.EventsGet();
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

[**List<ModelEvent>**](ModelEvent.md)

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
