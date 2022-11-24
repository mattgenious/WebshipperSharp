# IO.Swagger.Model.OrderChannels
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChannelLabel** | **string** | Label to identify the order channel. | [optional] 
**Attrs** | **List&lt;string&gt;** | Array of hashed with keys: &lt;code&gt;attr_key&lt;/code&gt;, &lt;code&gt;attr_value&lt;/code&gt;, &lt;code&gt;attr_name&lt;/code&gt;, &lt;code&gt;attr_type&lt;/code&gt;, &lt;code&gt;is_required&lt;/code&gt;, &lt;/code&gt;enums&lt;/code&gt;. See       documentation for Local Attributes | [optional] 
**AdditionalParameters** | **Object** | Optional hash, this is used when creating new order channels. | [optional] 
**SlipPrintMode** | **string** | Possible values: &#x27;dont_print&#x27;, &#x27;print_immediately&#x27; or &#x27;print_with_shipment&#x27;. | [optional] 
**ReturnLabelPrintMode** | **string** | Possible values: &#x27;dont_print&#x27;, &#x27;print_immediately&#x27;. | [optional] 
**ShippingLabelPrintMode** | **string** | Possible values: &#x27;dont_print&#x27;, &#x27;print_immediately&#x27;. | [optional] 
**DocumentPrintMode** | **string** | Possible values: &#x27;dont_print&#x27;, &#x27;print_immediately&#x27;. | [optional] 
**Logo** | **string** | Base64 representation of the logo of the order channel. | [optional] 
**ConfigurationToken** | **string** | Token to use for Webshipper modules. Tokens will only be generated for modules that require a configuration token. | [optional] 
**SyncStatus** | **int?** | Determines if the order channel is currently synchronising. Possible values are: &lt;code&gt;synchronize&lt;/code&gt;, &lt;code&gt;suspended&lt;/code&gt;, &lt;code&gt;paused&lt;/code&gt;. | [optional] 
**FailedSyncCount** | **int?** | Shows if recent synchronisation events have failed. | [optional] 
**FulfillAutomatically** | **bool?** | Whether or not to fulfill the order in the original order channel when a shipment is created. Default: true | [optional] 
**DropPointLimit** | **int?** |  | [optional] 
**CreateShipmentAutomatically** | **bool?** |  | [optional] 
**Health** | **string** |  | [optional] 
**ConvertCurrencyOnRateQuotes** | **bool?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

