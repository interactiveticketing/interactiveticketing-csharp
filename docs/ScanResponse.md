# InteractiveTicketingSdk.Model.ScanResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Valid** | **bool?** | True indicates scan passed validation | [optional] 
**Code** | **string** | Returns code string | [optional] 
**Message** | **string** | Returns message | [optional] 
**Details** | **string** | Returns details | [optional] 
**ScanTime** | **string** | Returns current time used for the scan | [optional] 
**Method** | **string** | single, mobile, or passbook based on suffix on barcodes | [optional] 
**Barcode** | **string** | The barcode for the scan | [optional] 
**ScanPointId** | **string** | The scanPointId for the scan | [optional] 
**TestMode** | **bool?** | True if test mode is used | [optional] 
**_Event** | [**ModelEvent**](ModelEvent.md) |  | [optional] 
**Ticket** | [**Ticket**](Ticket.md) |  | [optional] 
**OfflineTicket** | [**OfflineTicket**](OfflineTicket.md) |  | [optional] 
**ThirdPartyTicket** | [**ThirdPartyTicket**](ThirdPartyTicket.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

