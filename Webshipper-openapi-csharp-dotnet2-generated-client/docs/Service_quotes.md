# IO.Swagger.Model.ServiceQuotes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool?** | True if quote was successful | [optional] 
**CarrierId** | **int?** | The id of the carrier to quote | [optional] 
**ServiceCode** | **string** | Service code of the carrier. This is optional. When omitted, all supported services will be returned. | [optional] 
**SendTime** | **string** | ISO 8601 formatted | [optional] 
**SendDate** | **string** |  | [optional] 
**Packages** | **List&lt;string&gt;** | Array of objects, each containing key &lt;code&gt;weight&lt;/code&gt;. At least one package is required. | [optional] 
**DeliveryAddress** | **Object** | Delivery address for the quote | [optional] 
**SenderAddress** | **Object** | Sender address for the quote | [optional] 
**Services** | **List&lt;string&gt;** | Read only. Populated in response with an array of objects containing the following keys: &lt;ul class&#x3D;&#x27;list-doc&#x27;&gt;  &lt;li&gt;&lt;code&gt;service_name&lt;/code&gt;&lt;/li&gt;  &lt;li&gt;&lt;code&gt;service_code&lt;/code&gt;&lt;/li&gt;  &lt;li&gt;&lt;code&gt;is_return&lt;/code&gt;&lt;/li&gt;    &lt;li&gt;&lt;code&gt;supports_paperless&lt;/code&gt;&lt;/li&gt;    &lt;li&gt;&lt;code&gt;requires_drop_point&lt;/code&gt;&lt;/li&gt;    &lt;li&gt;&lt;code&gt;cost_price&lt;/code&gt;&lt;/li&gt;    &lt;li&gt;&lt;code&gt;currency&lt;/code&gt;&lt;/li&gt;    &lt;li&gt;&lt;code&gt;vat_percent&lt;/code&gt;&lt;/li&gt;    &lt;li&gt;&lt;code&gt;estimated_delivery_date_from&lt;/code&gt;&lt;/li&gt;    &lt;li&gt;&lt;code&gt;estimated_delivery_date_to&lt;/code&gt;&lt;/li&gt;    &lt;li&gt;    &lt;code&gt;add_ons&lt;/code&gt; &lt;div class&#x3D;&#x27;text-muted&#x27;&gt;Array containing objects&lt;/div&gt;   &lt;ul class&#x3D;&#x27;list-doc&#x27;&gt;     &lt;li&gt;&lt;code&gt;add_on_name&lt;/code&gt;&lt;/li&gt;     &lt;li&gt;&lt;code&gt;add_on_code&lt;/code&gt;&lt;/li&gt;   &lt;/ul&gt; &lt;/li&gt;    &lt;li&gt;&lt;code&gt;parameters&lt;/code&gt;&lt;/li&gt; &lt;div class&#x3D;&#x27;text-muted&#x27;&gt;Array containing objects&lt;/div&gt;    &lt;ul class&#x3D;&#x27;list-doc&#x27;&gt;     &lt;li&gt;&lt;code&gt;attr_name&lt;/code&gt;&lt;/li&gt;     &lt;li&gt;&lt;code&gt;attr_key&lt;/code&gt;&lt;/li&gt;     &lt;li&gt;&lt;code&gt;attr_type&lt;/code&gt;&lt;/li&gt;    &lt;/ul&gt;    &lt;li&gt;&lt;code&gt;country_combinations&lt;/code&gt;&lt;/li&gt;    &lt;li&gt;&lt;code&gt;barcode_requirement&lt;/code&gt;&lt;/li&gt;    &lt;li&gt;&lt;code&gt;waybill_requirement&lt;/code&gt;&lt;/li&gt;    &lt;li&gt;&lt;code&gt;booking_quote_info&lt;/code&gt;&lt;/li&gt;    &lt;li&gt;&lt;code&gt;supported_colli_types&lt;/code&gt;&lt;/li&gt;  &lt;/ul&gt; | [optional] 
**AddOns** | **string** | Carrier add-ons for the quote | [optional] 
**ServiceAttributes** | **string** | Service attributes for the carrier | [optional] 
**IsReturn** | **string** | Determines if you are quoting for return (inbound) services or standard (outbound) services. | [optional] 
**Dutiable** | **string** | Determines if the goods for the quote are dutiable | [optional] 
**CostSheetId** | **string** | Used if you want only a price from a specific cost sheet | [optional] 
**Timeout** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

