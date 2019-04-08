# InteractiveTicketingSdk - the C# library for the Developer API

Get your API Key from the [Dashboard](/dashboard/).<br/>Send all API requests with http header `X-API-Key: YOUR-API-KEY-HERE`.<br/>Base URL: `https://secure.interactiveticketing.com/developers/api/v1`<br/>Contact support@interactiveticketing.com for help.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: v1
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using InteractiveTicketingSdk.Api;
using InteractiveTicketingSdk.Client;
using InteractiveTicketingSdk.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using InteractiveTicketingSdk.Api;
using InteractiveTicketingSdk.Client;
using InteractiveTicketingSdk.Model;

namespace Example
{
    public class Example
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://secure.interactiveticketing.com/developers/api/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**EventsEventIdGet**](docs/DefaultApi.md#eventseventidget) | **GET** /events/{eventId} | Single Event
*DefaultApi* | [**EventsEventIdOrdersGet**](docs/DefaultApi.md#eventseventidordersget) | **GET** /events/{eventId}/orders | Search Orders
*DefaultApi* | [**EventsEventIdOrdersOrderIdGet**](docs/DefaultApi.md#eventseventidordersorderidget) | **GET** /events/{eventId}/orders/{orderId} | Single Order
*DefaultApi* | [**EventsGet**](docs/DefaultApi.md#eventsget) | **GET** /events | All Events

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Client](docs/Client.md)
 - [Model.Device](docs/Device.md)
 - [Model.Event](docs/Event.md)
 - [Model.Order](docs/Order.md)
 - [Model.PaginatedOrders](docs/PaginatedOrders.md)
 - [Model.Scan](docs/Scan.md)
 - [Model.ScanPoint](docs/ScanPoint.md)
 - [Model.ScanPointConfig](docs/ScanPointConfig.md)
 - [Model.Survey](docs/Survey.md)
 - [Model.Ticket](docs/Ticket.md)
 - [Model.Transaction](docs/Transaction.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
