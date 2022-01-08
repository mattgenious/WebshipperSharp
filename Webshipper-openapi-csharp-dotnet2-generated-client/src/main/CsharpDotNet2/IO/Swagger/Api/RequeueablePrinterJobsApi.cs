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
    public interface IRequeueablePrinterJobsApi
    {
        /// <summary>
        /// List all Requeueable Printer Jobss 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20090</returns>
        InlineResponse20090 PrinterRequeueJobsGet (string filterId);
        /// <summary>
        /// Delete a Requeueable Printer Jobs 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20089</returns>
        InlineResponse20089 PrinterRequeueJobsIdDelete (int? id);
        /// <summary>
        /// Show a single Requeueable Printer Jobs 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20089</returns>
        InlineResponse20089 PrinterRequeueJobsIdGet (int? id);
        /// <summary>
        /// Update a Requeueable Printer Jobs 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20089</returns>
        InlineResponse20089 PrinterRequeueJobsIdPatch (PrinterRequeueJobsIdBody body, int? id);
        /// <summary>
        /// Create a Requeueable Printer Jobs 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20089</returns>
        InlineResponse20089 PrinterRequeueJobsPost (PrinterRequeueJobsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RequeueablePrinterJobsApi : IRequeueablePrinterJobsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequeueablePrinterJobsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RequeueablePrinterJobsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RequeueablePrinterJobsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RequeueablePrinterJobsApi(String basePath)
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
        /// List all Requeueable Printer Jobss 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20090</returns>
        public InlineResponse20090 PrinterRequeueJobsGet (string filterId)
        {
    
            var path = "/printer_requeue_jobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterRequeueJobsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterRequeueJobsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20090) ApiClient.Deserialize(response.Content, typeof(InlineResponse20090), response.Headers);
        }
    
        /// <summary>
        /// Delete a Requeueable Printer Jobs 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20089</returns>
        public InlineResponse20089 PrinterRequeueJobsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PrinterRequeueJobsIdDelete");
    
            var path = "/printer_requeue_jobs/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterRequeueJobsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterRequeueJobsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20089) ApiClient.Deserialize(response.Content, typeof(InlineResponse20089), response.Headers);
        }
    
        /// <summary>
        /// Show a single Requeueable Printer Jobs 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20089</returns>
        public InlineResponse20089 PrinterRequeueJobsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PrinterRequeueJobsIdGet");
    
            var path = "/printer_requeue_jobs/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterRequeueJobsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterRequeueJobsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20089) ApiClient.Deserialize(response.Content, typeof(InlineResponse20089), response.Headers);
        }
    
        /// <summary>
        /// Update a Requeueable Printer Jobs 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20089</returns>
        public InlineResponse20089 PrinterRequeueJobsIdPatch (PrinterRequeueJobsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PrinterRequeueJobsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PrinterRequeueJobsIdPatch");
    
            var path = "/printer_requeue_jobs/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterRequeueJobsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterRequeueJobsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20089) ApiClient.Deserialize(response.Content, typeof(InlineResponse20089), response.Headers);
        }
    
        /// <summary>
        /// Create a Requeueable Printer Jobs 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20089</returns>
        public InlineResponse20089 PrinterRequeueJobsPost (PrinterRequeueJobsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PrinterRequeueJobsPost");
    
            var path = "/printer_requeue_jobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterRequeueJobsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterRequeueJobsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20089) ApiClient.Deserialize(response.Content, typeof(InlineResponse20089), response.Headers);
        }
    
    }
}
