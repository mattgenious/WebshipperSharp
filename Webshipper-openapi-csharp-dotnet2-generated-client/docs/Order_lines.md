# IO.Swagger.Model.OrderLines
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sku** | **string** | Stock Keeping Unit of the order line | [optional] 
**Description** | **string** | Description of the goods | [optional] 
**Quantity** | **int?** | Quantity of goods | [optional] 
**Location** | **string** | The warehouse location of the items. | [optional] 
**TarifNumber** | **string** | HS Tarif code for paperless customs | [optional] 
**CountryOfOrigin** | **string** | The country of origin of the goods. | [optional] 
**UnitPrice** | [**decimal?**](BigDecimal.md) | The unit price of goods in the currency of the order | [optional] 
**PackageId** | **int?** | Whether the items are associated with a parcel of a shipment. | [optional] 
**DiscountedUnitPrice** | **string** | The unit price after discounts has been applied in the currency of the order | [optional] 
**DiscountValue** | [**decimal?**](BigDecimal.md) | The discount for the order line, in the type given by discount_type | [optional] 
**DiscountType** | **int?** | The type of discount, eg. percent or fixed | [optional] 
**VatPercent** | [**decimal?**](BigDecimal.md) | The VAT rate in percentage. | [optional] 
**OrderId** | **int?** |  | [optional] 
**Status** | **int?** | Possible enum values: pending, dispatched or returned | [optional] 
**ExtRef** | **string** | External reference of the order line. | [optional] 
**Weight** | [**decimal?**](BigDecimal.md) | Weight per unit. | [optional] 
**WeightUnit** | **string** | Weight unit. Possible values: &lt;code&gt;oz&lt;/code&gt;, &lt;code&gt;g&lt;/code&gt;, &lt;code&gt;lbs&lt;/code&gt;, &lt;code&gt;kg&lt;/code&gt;. Defaults to &lt;code&gt;g&lt;/code&gt; | [optional] 
**CreatedAt** | **string** | The time when the resource was created | [optional] 
**UpdatedAt** | **string** | The time when resource was last updated or when it was created if it was never updated | [optional] 
**IsVirtual** | **bool?** |  | [optional] 
**DangerousGoodsDetails** | **Object** | Optional object of key value pairs used for providing information of dangerous goods. For use with DGOffice, use keys: article_no, package_type_id and packaging_instruction_type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

