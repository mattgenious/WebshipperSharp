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
    public interface IStoreApi
    {
        /// <summary>
        /// List all Stores 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200114</returns>
        InlineResponse200114 StoresGet (string filterId);
        /// <summary>
        /// Delete a Store 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200113</returns>
        InlineResponse200113 StoresIdDelete (int? id);
        /// <summary>
        /// Show a single Store 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200113</returns>
        InlineResponse200113 StoresIdGet (int? id);
        /// <summary>
        /// Update a Store 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200113</returns>
        InlineResponse200113 StoresIdPatch (StoresIdBody body, int? id);
        /// <summary>
        /// Create a Store 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200113</returns>
        InlineResponse200113 StoresPost (StoresBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StoreApi : IStoreApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StoreApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StoreApi(String basePath)
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
        /// List all Stores 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200114</returns>
        public InlineResponse200114 StoresGet (string filterId)
        {
    
            var path = "/stores";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StoresGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StoresGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200114) ApiClient.Deserialize(response.Content, typeof(InlineResponse200114), response.Headers);
        }
    
        /// <summary>
        /// Delete a Store 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200113</returns>
        public InlineResponse200113 StoresIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StoresIdDelete");
    
            var path = "/stores/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StoresIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StoresIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200113) ApiClient.Deserialize(response.Content, typeof(InlineResponse200113), response.Headers);
        }
    
        /// <summary>
        /// Show a single Store 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200113</returns>
        public InlineResponse200113 StoresIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StoresIdGet");
    
            var path = "/stores/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StoresIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StoresIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200113) ApiClient.Deserialize(response.Content, typeof(InlineResponse200113), response.Headers);
        }
    
        /// <summary>
        /// Update a Store 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200113</returns>
        public InlineResponse200113 StoresIdPatch (StoresIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling StoresIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StoresIdPatch");
    
            var path = "/stores/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StoresIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StoresIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200113) ApiClient.Deserialize(response.Content, typeof(InlineResponse200113), response.Headers);
        }
    
        /// <summary>
        /// Create a Store 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200113</returns>
        public InlineResponse200113 StoresPost (StoresBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling StoresPost");
    
            var path = "/stores";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StoresPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StoresPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200113) ApiClient.Deserialize(response.Content, typeof(InlineResponse200113), response.Headers);
        }
    
    }
}
