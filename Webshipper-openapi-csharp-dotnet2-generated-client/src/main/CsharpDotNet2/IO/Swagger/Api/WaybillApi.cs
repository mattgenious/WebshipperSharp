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
    public interface IWaybillApi
    {
        /// <summary>
        /// List all Waybills 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200125</returns>
        InlineResponse200125 WaybillsGet (string filterId);
        /// <summary>
        /// Delete a Waybill 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200124</returns>
        InlineResponse200124 WaybillsIdDelete (int? id);
        /// <summary>
        /// Show a single Waybill 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200124</returns>
        InlineResponse200124 WaybillsIdGet (int? id);
        /// <summary>
        /// Update a Waybill 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200124</returns>
        InlineResponse200124 WaybillsIdPatch (WaybillsIdBody body, int? id);
        /// <summary>
        /// Create a Waybill 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200124</returns>
        InlineResponse200124 WaybillsPost (WaybillsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WaybillApi : IWaybillApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaybillApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WaybillApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WaybillApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WaybillApi(String basePath)
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
        /// List all Waybills 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200125</returns>
        public InlineResponse200125 WaybillsGet (string filterId)
        {
    
            var path = "/waybills";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WaybillsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaybillsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200125) ApiClient.Deserialize(response.Content, typeof(InlineResponse200125), response.Headers);
        }
    
        /// <summary>
        /// Delete a Waybill 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200124</returns>
        public InlineResponse200124 WaybillsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WaybillsIdDelete");
    
            var path = "/waybills/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WaybillsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaybillsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200124) ApiClient.Deserialize(response.Content, typeof(InlineResponse200124), response.Headers);
        }
    
        /// <summary>
        /// Show a single Waybill 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200124</returns>
        public InlineResponse200124 WaybillsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WaybillsIdGet");
    
            var path = "/waybills/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WaybillsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaybillsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200124) ApiClient.Deserialize(response.Content, typeof(InlineResponse200124), response.Headers);
        }
    
        /// <summary>
        /// Update a Waybill 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200124</returns>
        public InlineResponse200124 WaybillsIdPatch (WaybillsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling WaybillsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WaybillsIdPatch");
    
            var path = "/waybills/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WaybillsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaybillsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200124) ApiClient.Deserialize(response.Content, typeof(InlineResponse200124), response.Headers);
        }
    
        /// <summary>
        /// Create a Waybill 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200124</returns>
        public InlineResponse200124 WaybillsPost (WaybillsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling WaybillsPost");
    
            var path = "/waybills";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WaybillsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaybillsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200124) ApiClient.Deserialize(response.Content, typeof(InlineResponse200124), response.Headers);
        }
    
    }
}
