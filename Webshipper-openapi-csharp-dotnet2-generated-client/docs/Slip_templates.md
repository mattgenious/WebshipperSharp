# IO.Swagger.Model.SlipTemplates
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name to identify the template. | [optional] 
**SlipSize** | **int?** | Size of the parcel slip. Possible values: &lt;code&gt;A4&lt;/code&gt; and &lt;code&gt;4X6&lt;/code&gt; | [optional] 
**AdditionalContent** | **string** | Content after the table of order lines for A4-based parcel slips. | [optional] 
**AdditionalContentAlign** | **int?** | Alignment of additional_content. Possible values: &lt;code&gt;center&lt;/code&gt;, &lt;code&gt;right&lt;/code&gt;, &lt;code&gt;left&lt;/code&gt; | [optional] 
**BarcodeContent** | **string** | Content of the barcode | [optional] 
**HeaderContent** | **string** | Content of the slip header | [optional] 
**TopLeftContentHeader** | **string** | Header of the top left corner | [optional] 
**TopRightContentHeader** | **string** | Header of the top right corner | [optional] 
**TopLeftContent** | **string** | Content of the top left corner | [optional] 
**TopRightContent** | **string** | Content of the top right corner | [optional] 
**FooterContent** | **string** | Content of the footer | [optional] 
**SlipTemplateColumns** | **string** | Array of columns. Column objects contains: &lt;code&gt;name&lt;/code&gt;&lt;code&gt;content&lt;/code&gt;, &lt;code&gt;text_alignment&lt;/code&gt;(right, left, center), &lt;code&gt;width&lt;/code&gt; (in percentage) | [optional] 
**TableColor** | **string** | HEX color including # | [optional] 
**TableTextColor** | **string** | HEX color including # | [optional] 
**UpdatedAt** | **string** | The time when resource was last updated or when it was created if it was never updated | [optional] 
**CreatedAt** | **string** | The time when the resource was created | [optional] 
**SortKey** | **string** | The key to sort the order-lines by | [optional] 
**ReturnsOnly** | **bool?** |  | [optional] 
**DisableInlineFormatting** | **bool?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

