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
    public interface IReportTypeApi
    {
        /// <summary>
        /// List all Report Types 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20088</returns>
        InlineResponse20088 ReportTypesGet (string filterId);
        /// <summary>
        /// Delete a Report Type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20087</returns>
        InlineResponse20087 ReportTypesIdDelete (int? id);
        /// <summary>
        /// Show a single Report Type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20087</returns>
        InlineResponse20087 ReportTypesIdGet (int? id);
        /// <summary>
        /// Update a Report Type 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20087</returns>
        InlineResponse20087 ReportTypesIdPatch (ReportTypesIdBody body, int? id);
        /// <summary>
        /// Create a Report Type 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20087</returns>
        InlineResponse20087 ReportTypesPost (ReportTypesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportTypeApi : IReportTypeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportTypeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportTypeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportTypeApi(String basePath)
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
        /// List all Report Types 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20088</returns>
        public InlineResponse20088 ReportTypesGet (string filterId)
        {
    
            var path = "/report_types";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportTypesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportTypesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20088) ApiClient.Deserialize(response.Content, typeof(InlineResponse20088), response.Headers);
        }
    
        /// <summary>
        /// Delete a Report Type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20087</returns>
        public InlineResponse20087 ReportTypesIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReportTypesIdDelete");
    
            var path = "/report_types/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportTypesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportTypesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20087) ApiClient.Deserialize(response.Content, typeof(InlineResponse20087), response.Headers);
        }
    
        /// <summary>
        /// Show a single Report Type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20087</returns>
        public InlineResponse20087 ReportTypesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReportTypesIdGet");
    
            var path = "/report_types/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportTypesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportTypesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20087) ApiClient.Deserialize(response.Content, typeof(InlineResponse20087), response.Headers);
        }
    
        /// <summary>
        /// Update a Report Type 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20087</returns>
        public InlineResponse20087 ReportTypesIdPatch (ReportTypesIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReportTypesIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReportTypesIdPatch");
    
            var path = "/report_types/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportTypesIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportTypesIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20087) ApiClient.Deserialize(response.Content, typeof(InlineResponse20087), response.Headers);
        }
    
        /// <summary>
        /// Create a Report Type 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20087</returns>
        public InlineResponse20087 ReportTypesPost (ReportTypesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReportTypesPost");
    
            var path = "/report_types";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportTypesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportTypesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20087) ApiClient.Deserialize(response.Content, typeof(InlineResponse20087), response.Headers);
        }
    
    }
}
