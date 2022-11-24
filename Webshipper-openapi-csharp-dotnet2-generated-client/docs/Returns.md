# IO.Swagger.Model.Returns
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | One of pending, sent, arrived, processed, error or approved | [optional] 
**ErrorMessage** | **string** |  | [optional] 
**ReturnLines** | **List&lt;string&gt;** | Array of ReturnLine objects. Contains fields order_line_id, quantity, cause_id, cause_description and images. When creating, images should be an array of data uri containing the base64 encoding of the image, example: &lt;em&gt;data:image/jpeg;base64,AAQSkZJ......RgABAQEAlgCWAAD&lt;/em&gt; | [optional] 
**Base64** | **string** | Base 64 encoding of return slip | [optional] 
**Secret** | **string** | Read only token for publicly accessing status of the return order | [optional] 
**InternalComment** | **string** |  | [optional] 
**UpdatedAt** | **string** | The time when resource was last updated or when it was created if it was never updated | [optional] 
**CreatedAt** | **string** | The time when the resource was created | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

