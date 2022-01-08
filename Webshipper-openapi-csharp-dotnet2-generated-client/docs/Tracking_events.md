# IO.Swagger.Model.TrackingEvents
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | One of &lt;em&gt;information_received&lt;/em&gt;, &lt;em&gt;in_transit&lt;/em&gt;, &lt;em&gt;out_for_delivery&lt;/em&gt;, &lt;em&gt;customs_clearance_delayed&lt;/em&gt;, &lt;em&gt;attempted_delivery&lt;/em&gt;, &lt;em&gt;ready_for_pickup&lt;/em&gt;, &lt;em&gt;delivered_to_drop_point&lt;/em&gt;, &lt;em&gt;delivered&lt;/em&gt;, &lt;em&gt;returned&lt;/em&gt;, &lt;em&gt;undeliverable&lt;/em&gt; or &lt;em&gt;unknown&lt;/em&gt; | [optional] 
**Time** | **string** | Time the event occured at the carrier | [optional] 
**Description** | **string** | Readable description of the event | [optional] 
**Location** | **string** |  | [optional] 
**Latitude** | [**decimal?**](BigDecimal.md) |  | [optional] 
**Longitude** | [**decimal?**](BigDecimal.md) |  | [optional] 
**TrackingNumber** | **string** | The tracking number for this event, if availiable | [optional] 
**EventId** | **string** | Unique event of the id | [optional] 
**TrackingLinkId** | **int?** |  | [optional] 
**TrackingLinkUrl** | **string** | The tracking link for this event, if availiable | [optional] 
**CreatedAt** | **string** | The time when the resource was created | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

