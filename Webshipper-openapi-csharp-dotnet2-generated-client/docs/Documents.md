# IO.Swagger.Model.Documents
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShipmentId** | **int?** | Id of the shipment it belongs to | [optional] 
**DocumentSize** | **string** | Enum for the paper size. valid values: &lt;code&gt;A4&lt;/code&gt; | [optional] 
**DocumentFormat** | **string** | Enum for the document format. Valid values: &lt;code&gt;PDF&lt;/code&gt; | [optional] 
**Base64** | **string** | Base64 representation of the document. Only required when creating. | [optional] 
**IsSpecial** | **bool?** | Used to indicate if this document is a special document, like static customs documents. Special documents will be displayed in Webshipper under Settings &gt; Documents. | [optional] 
**Name** | **string** | Used for special documents | [optional] 
**Description** | **string** | Used for special documents | [optional] 
**DocumentType** | **int?** | One of: &#x27;shipping_document&#x27;, &#x27;other&#x27;, &#x27;customs_document&#x27;, &#x27;invoice&#x27;, &#x27;certificate&#x27;, &#x27;proforma&#x27;, &#x27;nafta_certificate&#x27;, &#x27;commercial&#x27;, &#x27;awb&#x27;. Documents returned from the carrier are always shipping_document.  | [optional] 
**IsPaperless** | **bool?** | Used to indicate if a shipment is paperless | [optional] 
**UpdatedAt** | **string** | The time when resource was last updated or when it was created if it was never updated | [optional] 
**CreatedAt** | **string** | The time when the resource was created | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

