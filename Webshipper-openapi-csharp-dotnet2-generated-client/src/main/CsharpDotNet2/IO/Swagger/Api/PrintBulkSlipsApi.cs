using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPrintBulkSlipsApi
    {
        /// <summary>
        /// List all Print Bulk Slipss 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20076</returns>
        InlineResponse20076 BulkPrinterJobsGet (string filterId);
        /// <summary>
        /// Delete a Print Bulk Slips 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20075</returns>
        InlineResponse20075 BulkPrinterJobsIdDelete (int? id);
        /// <summary>
        /// Show a single Print Bulk Slips 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20075</returns>
        InlineResponse20075 BulkPrinterJobsIdGet (int? id);
        /// <summary>
        /// Update a Print Bulk Slips 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20075</returns>
        InlineResponse20075 BulkPrinterJobsIdPatch (BulkPrinterJobsIdBody body, int? id);
        /// <summary>
        /// Create a Print Bulk Slips 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20075</returns>
        InlineResponse20075 BulkPrinterJobsPost (BulkPrinterJobsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PrintBulkSlipsApi : IPrintBulkSlipsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintBulkSlipsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PrintBulkSlipsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintBulkSlipsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PrintBulkSlipsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// List all Print Bulk Slipss 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20076</returns>
        public InlineResponse20076 BulkPrinterJobsGet (string filterId)
        {
    
            var path = "/bulk_printer_jobs";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BulkPrinterJobsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BulkPrinterJobsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20076) ApiClient.Deserialize(response.Content, typeof(InlineResponse20076), response.Headers);
        }
    
        /// <summary>
        /// Delete a Print Bulk Slips 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20075</returns>
        public InlineResponse20075 BulkPrinterJobsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BulkPrinterJobsIdDelete");
    
            var path = "/bulk_printer_jobs/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BulkPrinterJobsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BulkPrinterJobsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20075) ApiClient.Deserialize(response.Content, typeof(InlineResponse20075), response.Headers);
        }
    
        /// <summary>
        /// Show a single Print Bulk Slips 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20075</returns>
        public InlineResponse20075 BulkPrinterJobsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BulkPrinterJobsIdGet");
    
            var path = "/bulk_printer_jobs/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BulkPrinterJobsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BulkPrinterJobsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20075) ApiClient.Deserialize(response.Content, typeof(InlineResponse20075), response.Headers);
        }
    
        /// <summary>
        /// Update a Print Bulk Slips 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20075</returns>
        public InlineResponse20075 BulkPrinterJobsIdPatch (BulkPrinterJobsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling BulkPrinterJobsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BulkPrinterJobsIdPatch");
    
            var path = "/bulk_printer_jobs/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BulkPrinterJobsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BulkPrinterJobsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20075) ApiClient.Deserialize(response.Content, typeof(InlineResponse20075), response.Headers);
        }
    
        /// <summary>
        /// Create a Print Bulk Slips 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20075</returns>
        public InlineResponse20075 BulkPrinterJobsPost (BulkPrinterJobsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling BulkPrinterJobsPost");
    
            var path = "/bulk_printer_jobs";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BulkPrinterJobsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BulkPrinterJobsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20075) ApiClient.Deserialize(response.Content, typeof(InlineResponse20075), response.Headers);
        }
    
    }
}
