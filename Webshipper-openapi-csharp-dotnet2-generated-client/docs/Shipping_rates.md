# IO.Swagger.Model.ShippingRates
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierId** | **int?** | Id of the carrier which the shipping rate belongs to | [optional] 
**OrderChannelId** | **int?** | Id of the order channel which the shipping rate belongs to | [optional] 
**Name** | **string** | Name to be displayed in the e-commerce system. | [optional] 
**CarrierServiceCode** | **string** | The carrier&#x27;s service code which must be used when generating parcels with this shipping rate. | [optional] 
**RequireDropPoint** | **bool?** | Determines if the shipping rate requires a drop point to be assigned. | [optional] 
**VisibleFor** | **int?** | Enum - determines whether the rate is returned for all customers, private_customers or business customers. This must be one of the following values:  &lt;code&gt;any&lt;/code&gt;, &lt;code&gt;privat_customers&lt;/code&gt;, &lt;code&gt;business_customers&lt;/code&gt; | [optional] 
**ServiceAttributes** | **string** | Array of flattened resources of type &lt;code&gt;Service Attribute&lt;/code&gt;. Depends on the carrier service&#x27;s requirements. Service Attribute has the following attributes:  &lt;code&gt;attr_key&lt;/code&gt;, &lt;code&gt;attr_value&lt;/code&gt;. You may use the Webshipper Template Language (WTL) for the values. | [optional] 
**Dimensions** | **string** | Predefined dimensions which are a assigned when using the shipping rate. Attributes are: &lt;code&gt;height&lt;/code&gt;,&lt;code&gt;width&lt;/code&gt; and &lt;code&gt;length&lt;/code&gt;. The Webshipper Template Language (WTL) may be used for the values. | [optional] 
**AddOns** | **string** | Array of add_ons supported by the carrier service. | [optional] 
**IsReturn** | **bool?** | Defines whether the rate is a return (inbound) rate or a standard rate (outbound). Please be aware that this attribute must match the carrier&#x27;s service type. | [optional] 
**CarriersEmail** | **bool?** | When this is set to true, the shipping rate will enable e-mail notifications from the carrier. | [optional] 
**CommentMap** | **string** | Defines what content is included in the comment field. The Webshipper Template Language (WTL) may be used in this field. For example:  {{order.external_comment}} | [optional] 
**ReferenceMap** | **string** | Defines what content is included in the reference field. The Webshipper Template Language (WTL) may be used in this field. For example: {{order.visible_ref}} | [optional] 
**CarriersSms** | **bool?** | When this is set to true, the shipping rate will enable SMS notifications from the carrier. | [optional] 
**Dutiable** | **bool?** | Defines whether the goods sent using this shipping rate are dutiable. | [optional] 
**IsHidden** | **bool?** | Attribute to indicate if the shipping rate is visible to order channels | [optional] 
**ClickCollect** | **bool?** |  | [optional] 
**Reference** | **string** |  | [optional] 
**UpdatedAt** | **string** | The time when resource was last updated or when it was created if it was never updated | [optional] 
**CreatedAt** | **string** | The time when the resource was created | [optional] 
**DefaultColliType** | **string** | Predefined colli type to be used when using the shipping rate. Must be supported by the carrier. | [optional] 
**SenderAddressId** | **int?** |  | [optional] 
**ReturnAddressId** | **int?** |  | [optional] 
**InvoiceSettings** | **string** |  | [optional] 
**Regions** | **string** | Flattended array of Regions. See section on Shipping Regions and Expressions for more details | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

