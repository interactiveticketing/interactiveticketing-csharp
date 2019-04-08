# InteractiveTicketingSdk.Model.Transaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **int?** | The transaction ID | [optional] 
**DateTime** | **string** | The transaction time iso-8601 | [optional] 
**IsRefund** | **bool?** | The transaction is a refund | [optional] 
**Amount** | **string** | The transaction amount | [optional] 
**Type** | **string** | credit | cash | other | triPos | [optional] 
**CardTransactionId** | **string** | The payment gateway transaction identifier | [optional] 
**CardType** | **string** | The payment credit card type code | [optional] 
**CardLastFour** | **string** | The payment credit card last four digits | [optional] 
**CardName** | **string** | The payment credit card customer name on card | [optional] 
**ReferenceTransactionId** | **string** | Applicable to refund transaction, reference to the original &#x60;cardTransactionId&#x60; | [optional] 
**BillStreet** | **string** | Billing street address | [optional] 
**BillCity** | **string** | Billing city | [optional] 
**BillStateProvince** | **string** | Billing state or province | [optional] 
**BillPostalCode** | **string** | Billing post code / zip | [optional] 
**BillCountry** | **string** | Billing country | [optional] 
**RefundReason** | **string** | Applicable to refund transactions | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

