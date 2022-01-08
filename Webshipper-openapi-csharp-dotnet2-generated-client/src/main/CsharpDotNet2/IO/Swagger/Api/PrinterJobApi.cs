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
    public interface IPrinterJobApi
    {
        /// <summary>
        /// List all Printer Jobs 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterPrinterClientId">Filter by printer_client_id</param>
        /// <param name="filterCreatedAt">Filter by created_at</param>
        /// <param name="filterCompleted">Filter by completed</param>
        /// <param name="filterError">Filter by error</param>
        /// <param name="filterTryCount">Filter by try_count</param>
        /// <param name="filterPrinterId">Filter by printer_id</param>
        /// <returns>InlineResponse20084</returns>
        InlineResponse20084 PrinterJobsGet (string filterId, string filterPrinterClientId, string filterCreatedAt, string filterCompleted, string filterError, string filterTryCount, string filterPrinterId);
        /// <summary>
        /// Delete a Printer Job 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20083</returns>
        InlineResponse20083 PrinterJobsIdDelete (int? id);
        /// <summary>
        /// Show a single Printer Job 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20083</returns>
        InlineResponse20083 PrinterJobsIdGet (int? id);
        /// <summary>
        /// Update a Printer Job 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20083</returns>
        InlineResponse20083 PrinterJobsIdPatch (PrinterJobsIdBody body, int? id);
        /// <summary>
        /// Create a Printer Job 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20083</returns>
        InlineResponse20083 PrinterJobsPost (PrinterJobsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PrinterJobApi : IPrinterJobApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterJobApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PrinterJobApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterJobApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PrinterJobApi(String basePath)
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
        /// List all Printer Jobs 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterPrinterClientId">Filter by printer_client_id</param>
        /// <param name="filterCreatedAt">Filter by created_at</param>
        /// <param name="filterCompleted">Filter by completed</param>
        /// <param name="filterError">Filter by error</param>
        /// <param name="filterTryCount">Filter by try_count</param>
        /// <param name="filterPrinterId">Filter by printer_id</param>
        /// <returns>InlineResponse20084</returns>
        public InlineResponse20084 PrinterJobsGet (string filterId, string filterPrinterClientId, string filterCreatedAt, string filterCompleted, string filterError, string filterTryCount, string filterPrinterId)
        {
    
            var path = "/printer_jobs";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterPrinterClientId != null) queryParams.Add("filter[printer_client_id]", ApiClient.ParameterToString(filterPrinterClientId)); // query parameter
 if (filterCreatedAt != null) queryParams.Add("filter[created_at]", ApiClient.ParameterToString(filterCreatedAt)); // query parameter
 if (filterCompleted != null) queryParams.Add("filter[completed]", ApiClient.ParameterToString(filterCompleted)); // query parameter
 if (filterError != null) queryParams.Add("filter[error]", ApiClient.ParameterToString(filterError)); // query parameter
 if (filterTryCount != null) queryParams.Add("filter[try_count]", ApiClient.ParameterToString(filterTryCount)); // query parameter
 if (filterPrinterId != null) queryParams.Add("filter[printer_id]", ApiClient.ParameterToString(filterPrinterId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterJobsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterJobsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20084) ApiClient.Deserialize(response.Content, typeof(InlineResponse20084), response.Headers);
        }
    
        /// <summary>
        /// Delete a Printer Job 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20083</returns>
        public InlineResponse20083 PrinterJobsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PrinterJobsIdDelete");
    
            var path = "/printer_jobs/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterJobsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterJobsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20083) ApiClient.Deserialize(response.Content, typeof(InlineResponse20083), response.Headers);
        }
    
        /// <summary>
        /// Show a single Printer Job 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20083</returns>
        public InlineResponse20083 PrinterJobsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PrinterJobsIdGet");
    
            var path = "/printer_jobs/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterJobsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterJobsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20083) ApiClient.Deserialize(response.Content, typeof(InlineResponse20083), response.Headers);
        }
    
        /// <summary>
        /// Update a Printer Job 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20083</returns>
        public InlineResponse20083 PrinterJobsIdPatch (PrinterJobsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PrinterJobsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PrinterJobsIdPatch");
    
            var path = "/printer_jobs/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterJobsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterJobsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20083) ApiClient.Deserialize(response.Content, typeof(InlineResponse20083), response.Headers);
        }
    
        /// <summary>
        /// Create a Printer Job 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20083</returns>
        public InlineResponse20083 PrinterJobsPost (PrinterJobsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PrinterJobsPost");
    
            var path = "/printer_jobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterJobsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterJobsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20083) ApiClient.Deserialize(response.Content, typeof(InlineResponse20083), response.Headers);
        }
    
    }
}
