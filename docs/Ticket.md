# InteractiveTicketingSdk.Model.Ticket
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TicketId** | **int?** | The ticket ID | [optional] 
**OrderId** | **int?** | The ticket order ID | [optional] 
**Barcode** | **string** | The ticket barcode | [optional] 
**Canceled** | **bool?** | Canceled / Voided ticket | [optional] 
**Name** | **string** | Name of ticket | [optional] 
**Details** | **string** | Details about the ticket | [optional] 
**Price** | **string** | Purchase price for the ticket | [optional] 
**SlotDate** | **string** | Applicable to timed ticketing | [optional] 
**SlotTime** | **string** | Applicable to timed ticketing | [optional] 
**SlotAllDay** | **bool?** | Applicable to timed ticketing | [optional] 
**NameOnTicket** | **string** | Customer name printed on ticket | [optional] 
**SeatEventTitle** | **string** | Applicable to reserved seating | [optional] 
**SeatVenueTitle** | **string** | Applicable to reserved seating | [optional] 
**SeatSection** | **string** | Applicable to reserved seating | [optional] 
**SeatCustom1** | **string** | Applicable to reserved seating | [optional] 
**SeatCustom2** | **string** | Applicable to reserved seating | [optional] 
**SeatRow** | **string** | Applicable to reserved seating | [optional] 
**SeatRowLabel** | **string** | Applicable to reserved seating | [optional] 
**SeatNumber** | **int?** | Applicable to reserved seating | [optional] 
**SeatNumberLabel** | **string** | Applicable to reserved seating | [optional] 
**SeatText** | **string** | Applicable to reserved seating | [optional] 
**NoPrint** | **bool?** | Indicates tickets that should not be printed | [optional] 
**NoBarcode** | **bool?** | Indicates tickets that should not be barcoded | [optional] 
**Discount** | **string** | Discounts applied to the ticket | [optional] 
**Fee** | **string** | Oranization charged service fee | [optional] 
**Tax** | **string** | Oranization chaarged tax | [optional] 
**Refund** | **string** | Alloted refund back to ticket (for reports) | [optional] 
**PromoCode** | **string** | Applicable to promo code discounts | [optional] 
**PromoName** | **string** | Applicable to promo code discounts | [optional] 
**PromoDescription** | **string** | Applicable to promo code discounts | [optional] 
**Department** | [**Department**](Department.md) |  | [optional] 
**Scans** | [**List&lt;Scan&gt;**](Scan.md) | Array of ticket scan activity | [optional] 
**ScanPointConfig** | [**ScanPointConfig**](ScanPointConfig.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

