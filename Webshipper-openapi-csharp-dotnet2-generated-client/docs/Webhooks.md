# IO.Swagger.Model.Webhooks
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | The HTTP endpoint to be called. Webhooks always use POST as the request method. | [optional] 
**Topic** | **string** | Which event should trigger the webhooks. Supported topics:     &lt;ul&gt;       &lt;li&gt;&lt;strong&gt;order/created&lt;/strong&gt; triggered when an order is created.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;order/updated&lt;/strong&gt; triggered when an order is updated.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;order/deleted&lt;/strong&gt; triggered when an order was deleted.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;shipment/created&lt;/strong&gt; triggered when a shipment is created.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;shipment/updated&lt;/strong&gt; triggered when a shipment is updated.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;shipment/deleted&lt;/strong&gt; triggered when a shipment was deleted.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;return/created&lt;/strong&gt; triggered when a return is created.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;return/updated&lt;/strong&gt; triggered when a return is updated.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;return/deleted&lt;/strong&gt; triggered when a return was deleted.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;report/created&lt;/strong&gt; triggered when a report is created.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;report/updated&lt;/strong&gt; triggered when a report is updated.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;report/deleted&lt;/strong&gt; triggered when a report was deleted.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;trackingevent/created&lt;/strong&gt; triggered when a tracking event is created.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;trackingevent/updated&lt;/strong&gt; triggered when a tracking event is updated.&lt;/li&gt;       &lt;li&gt;&lt;strong&gt;trackingevent/deleted&lt;/strong&gt; triggered when a tracking event was deleted.&lt;/li&gt;     &lt;/ul&gt; | [optional] 
**Enabled** | **bool?** | This is a boolean attribute that specifies whether the webhook is active. | [optional] 
**Secret** | **string** | The secret used to sign the HMAC. | [optional] 
**Health** | **string** |  | [optional] 
**LatestError** | **string** | The most recent error message. | [optional] 
**Condition** | **string** |  | [optional] 
**CreatedAt** | **string** | The time when the resource was created | [optional] 
**UpdatedAt** | **string** | The time when resource was last updated or when it was created if it was never updated | [optional] 
**Carriers** | **string** |  | [optional] 
**OrderChannels** | **List&lt;string&gt;** | Array of objects containing keys id and channel_label if condition describes a list of allowed order channels, &lt;code&gt;null&lt;/code&gt; otherwise.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

