# InteractiveTicketingSdk.Model.Order
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **int?** | The order ID | [optional] 
**DateTime** | **string** | The order time iso-8601 | [optional] 
**TestOrder** | **bool?** | True indicates a test order | [optional] 
**OrderType** | **string** | web | pos | kiosk | [optional] 
**FirstName** | **string** | Customer first name | [optional] 
**LastName** | **string** | Customer last name | [optional] 
**Email** | **string** | Customer email address | [optional] 
**Phone** | **string** | Customer phone number | [optional] 
**MobilePhone** | **string** | Customer mobile phone number | [optional] 
**Street** | **string** | Customer street address | [optional] 
**City** | **string** | Customer city | [optional] 
**StateProvince** | **string** | Customer state or province name | [optional] 
**Country** | **string** | Customer country | [optional] 
**PostalCode** | **string** | Customer postal code / zip | [optional] 
**Fees** | **string** | Organization charged service fee | [optional] 
**Taxes** | **string** | Organization charged taxes | [optional] 
**Donations** | **string** | Organization charged donations | [optional] 
**GrandTotal** | **string** | Total charges | [optional] 
**Coupons** | **int?** | Coupons | [optional] 
**CouponsTotal** | **int?** | Coupons Total | [optional] 
**IPAddress** | **string** | Customer IP Address | [optional] 
**BrowserName** | **string** | Customer Browser | [optional] 
**BrowserDevice** | **string** | mobile | desktop | [optional] 
**SourceCode** | **string** | Source code passed to the purchase interface s&#x3D;myTrackingCode | [optional] 
**SearchTag** | **string** | Custom searchTag applied to order to bookmark it | [optional] 
**Survey** | [**List&lt;Survey&gt;**](Survey.md) | Array of additional form question responses | [optional] 
**Transactions** | [**List&lt;Transaction&gt;**](Transaction.md) | Array of payment/refund transactions | [optional] 
**Tickets** | [**List&lt;Ticket&gt;**](Ticket.md) | Array of tickets ordered | [optional] 
**PosCashierName** | **string** | Applicable to pos orders | [optional] 
**SuspectFlags** | [**List&lt;SuspectFlag&gt;**](SuspectFlag.md) | Array of reasons the order is flagged as suspicious | [optional] 
**IsSuspicious** | **bool?** | True indicates if order is flagged as suspicious | [optional] 
**SuspiciousResolved** | **bool?** | True indicates if a suspicous order was approved in the dashboard | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

