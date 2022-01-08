# IO.Swagger.Model.CsvMappings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Separator** | **string** | The seperator in the file. Normally &#x27;;&#x27; or &#x27;,&#x27; | [optional] 
**TargetClass** | **string** | Must be one of the models &lt;code&gt;Order&lt;/code&gt; or &lt;code&gt;Shipment&lt;/code&gt; | [optional] 
**GroupedBy** | **int?** | Must be the index of the Order ID | [optional] 
**GroupedPath** | **string** | The sub-model which you are grouping. For order: order_lines_attributes | [optional] 
**IncludesHeader** | **bool?** | Determines if there is an ignorable header line in the file | [optional] 
**LinesAsPackage** | **bool?** |  | [optional] 
**RecreateOrderLines** | **bool?** |  | [optional] 
**SeparateOrderLineMapping** | **bool?** |  | [optional] 
**Name** | **string** | Name of the configuration | [optional] 
**ExampleInput** | **string** | Example input to make it easier to create the mapping in the UI. | [optional] 
**LineExampleInput** | **string** |  | [optional] 
**Rules** | **List&lt;string&gt;** | Array of flattened resources of the type CSV Rule | [optional] 
**ShipmentExportFormat** | **string** |  | [optional] 
**OrderExportFormat** | **string** |  | [optional] 
**CreateShipmentAutomatically** | **bool?** |  | [optional] 
**ForceAsync** | **bool?** |  | [optional] 
**ConcatPaths** | **bool?** |  | [optional] 
**SplitLargeRecords** | **bool?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

