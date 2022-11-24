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
    public interface IReportApi
    {
        /// <summary>
        /// List all Reports 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20086</returns>
        InlineResponse20086 ReportsGet (string filterId);
        /// <summary>
        /// Delete a Report 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20085</returns>
        InlineResponse20085 ReportsIdDelete (int? id);
        /// <summary>
        /// Show a single Report 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20085</returns>
        InlineResponse20085 ReportsIdGet (int? id);
        /// <summary>
        /// Update a Report 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20085</returns>
        InlineResponse20085 ReportsIdPatch (ReportsIdBody body, int? id);
        /// <summary>
        /// Create a Report 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20085</returns>
        InlineResponse20085 ReportsPost (ReportsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportApi : IReportApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportApi(String basePath)
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
        /// List all Reports 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20086</returns>
        public InlineResponse20086 ReportsGet (string filterId)
        {
    
            var path = "/reports";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20086) ApiClient.Deserialize(response.Content, typeof(InlineResponse20086), response.Headers);
        }
    
        /// <summary>
        /// Delete a Report 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20085</returns>
        public InlineResponse20085 ReportsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReportsIdDelete");
    
            var path = "/reports/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20085) ApiClient.Deserialize(response.Content, typeof(InlineResponse20085), response.Headers);
        }
    
        /// <summary>
        /// Show a single Report 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20085</returns>
        public InlineResponse20085 ReportsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReportsIdGet");
    
            var path = "/reports/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20085) ApiClient.Deserialize(response.Content, typeof(InlineResponse20085), response.Headers);
        }
    
        /// <summary>
        /// Update a Report 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20085</returns>
        public InlineResponse20085 ReportsIdPatch (ReportsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReportsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReportsIdPatch");
    
            var path = "/reports/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20085) ApiClient.Deserialize(response.Content, typeof(InlineResponse20085), response.Headers);
        }
    
        /// <summary>
        /// Create a Report 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20085</returns>
        public InlineResponse20085 ReportsPost (ReportsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReportsPost");
    
            var path = "/reports";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20085) ApiClient.Deserialize(response.Content, typeof(InlineResponse20085), response.Headers);
        }
    
    }
}
