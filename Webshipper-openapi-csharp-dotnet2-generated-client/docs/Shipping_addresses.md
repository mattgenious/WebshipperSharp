# IO.Swagger.Model.ShippingAddresses
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttContact** | **string** | Att person. To generate parcels either att_contact &lt;strong&gt;or&lt;/strong&gt; company_name is required | [optional] 
**CompanyName** | **string** | Company name. To generate parcels either att_contact &lt;strong&gt;or&lt;/strong&gt; company_name is required | [optional] 
**Address1** | **string** | Address line 1 | [optional] 
**Address2** | **string** | Address line 2 | [optional] 
**CountryCode** | **string** | ISO 3166-1 alpha-2 code | [optional] 
**State** | **string** | Sub-division of country, if applicable. State code. ISO 3166-2 alpha-2 | [optional] 
**Phone** | **string** | Phone number of the entity. This can be used for SMS notifications. | [optional] 
**Email** | **string** | E-mail address of the entity. This can be used for e-mail notifications. | [optional] 
**Zip** | **string** | Postal code of the entity. This is required for most destination countries. | [optional] 
**City** | **string** | City of the entity. This is required for most destination countries. | [optional] 
**VatNo** | **string** | The VAT number of the entity. This is only required for address_type &lt;code&gt;sold_from&lt;/code&gt; | [optional] 
**AddressType** | **string** | Used for special addresses for order channels. This will be one of the following: &lt;code&gt;recipient&lt;/code&gt;, &lt;code&gt;sender&lt;/code&gt;, &lt;code&gt;sold_from&lt;/code&gt;, &lt;code&gt;pickup&lt;/code&gt;, &lt;code&gt;return&lt;/code&gt;, &lt;code&gt;order_address&lt;/code&gt; | [optional] 
**ExtLocation** | **string** |  | [optional] 
**Voec** | **string** |  | [optional] 
**Eori** | **string** |  | [optional] 
**Sprn** | **string** |  | [optional] 
**PersonalCustomsNo** | **string** |  | [optional] 
**CompanyCustomsNumbers** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

