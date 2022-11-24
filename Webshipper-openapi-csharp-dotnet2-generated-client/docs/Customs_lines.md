# IO.Swagger.Model.CustomsLines
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sku** | **string** | Stock Keeping Unit | [optional] 
**Description** | **string** | Goods description | [optional] 
**Quantity** | **int?** | Quantity of the customs line | [optional] 
**TarifNumber** | **string** | Tariff number / HS code | [optional] 
**CountryOfOrigin** | **string** | Country of origin of the customs line - ISO 3166-1 alpha-2 | [optional] 
**UnitPrice** | [**decimal?**](BigDecimal.md) | Unit price of a single quantity customs line | [optional] 
**VatPercent** | [**decimal?**](BigDecimal.md) | Vat percent of the customs line | [optional] 
**Currency** | **string** | Currency ISO-4217 | [optional] 
**Weight** | [**decimal?**](BigDecimal.md) | Weight of a single quantity customs line | [optional] 
**WeightUnit** | **int?** | Weight unit of the customs line - One of &#x27;g&#x27;, &#x27;oz&#x27;, &#x27;lbs&#x27; or &#x27;kg&#x27; | [optional] 
**Discount** | [**decimal?**](BigDecimal.md) | Discount of a single quantity customs line | [optional] 
**DangerousGoodsDetails** | **Object** | Optional object of key value pairs used for providing information of dangerous goods. For use with DGOffice, use keys: article_no, package_type_id and packaging_instruction_type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

