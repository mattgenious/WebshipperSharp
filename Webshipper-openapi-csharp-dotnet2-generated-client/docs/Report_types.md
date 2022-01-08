# IO.Swagger.Model.ReportTypes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | [optional] 
**Columns** | **List&lt;string&gt;** | Array of objects with keys &lt;code&gt;header&lt;/code&gt; and &lt;code&gt;content&lt;/code&gt; | [optional] 
**Parameters** | **List&lt;string&gt;** | Array of objects with keys &lt;code&gt;parameter_key&lt;/code&gt; and &lt;code&gt;parameter_value&lt;/code&gt; | [optional] 
**Resource** | **string** |  | [optional] 
**HeaderColumns** | **List&lt;string&gt;** | Array of objects with keys &lt;code&gt;header&lt;/code&gt; and &lt;code&gt;content&lt;/code&gt; that will be used to display the header content of the report | [optional] 
**FooterContent** | **string** |  | [optional] 
**Conditions** | **List&lt;string&gt;** | Array of objects describing how to load the resources. Contains keys &lt;code&gt;condition_key&lt;/code&gt;, &lt;code&gt;condition_operator&lt;/code&gt;, &lt;code&gt;condition_value&lt;/code&gt;. | [optional] 
**IncludeDeleted** | **bool?** | If true the report will included deleted records. Default: &lt;code&gt;false&lt;/code&gt; | [optional] 
**UseCarrierEod** | **bool?** | When set to true it will attempt to fetch the end of day list directly from the carrier. When this option is enabled, only pdf reports are available. | [optional] 
**CreatedAt** | **string** | The time when the resource was created | [optional] 
**UpdatedAt** | **string** | The time when resource was last updated or when it was created if it was never updated | [optional] 
**Schedule** | **string** |  | [optional] 
**DefaultFormat** | **string** |  | [optional] 
**MailOnRun** | **bool?** |  | [optional] 
**Mail** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

