# IO.Swagger.Model.BulkImportOrders
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ids** | **string** | Order ids to import from the order channel | [optional] 
**OrderChannelId** | **string** | Id of the order channel to import orders from | [optional] 
**Async** | **string** | Run the import asyncronously, default is false unless importing more than one order or from more than one order channel | [optional] 
**Reimport** | **string** | Reimport orders from the order channel. WARNING: This will overwrite any changes to the order made in Webshipper and import the order as it is in the order channel | [optional] 
**TimeStart** | **string** | Time from when orders should be imported, all orders after this time is imported from the order channel. This option is not supported by all order channels and there might be some limitations depending on the order channel | [optional] 
**TimeEnd** | **string** | Time to when orders should be imported, all orders before this time is imported from the order channel. This option is not supported by all order channels and there might be some limitations depending on the order channel | [optional] 
**Statuses** | **string** | Statuses of orders to import, all orders with the given statuses are imported from the order channel. This option is not supported by all order channels and there might be some limitations depending on the order channel | [optional] 
**BulkImports** | **string** | List of bulk imports with the same attributes as above. This can be used to import multiple orders from multiple order channels at once. Options specified in the root object is used globally, but is overridable by specififying the option for specific bulk_import in the list. | [optional] 
**Source** | **string** | Source of the orders to import. This will default to API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

