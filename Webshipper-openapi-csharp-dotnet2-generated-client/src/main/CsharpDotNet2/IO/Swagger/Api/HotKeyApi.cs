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
    public interface IHotKeyApi
    {
        /// <summary>
        /// List all HotKeys 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20047</returns>
        InlineResponse20047 HotKeysGet (string filterId);
        /// <summary>
        /// Delete a HotKey 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20046</returns>
        InlineResponse20046 HotKeysIdDelete (int? id);
        /// <summary>
        /// Show a single HotKey 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20046</returns>
        InlineResponse20046 HotKeysIdGet (int? id);
        /// <summary>
        /// Update a HotKey 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20046</returns>
        InlineResponse20046 HotKeysIdPatch (HotKeysIdBody body, int? id);
        /// <summary>
        /// Create a HotKey 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20046</returns>
        InlineResponse20046 HotKeysPost (HotKeysBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HotKeyApi : IHotKeyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HotKeyApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HotKeyApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HotKeyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HotKeyApi(String basePath)
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
        /// List all HotKeys 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20047</returns>
        public InlineResponse20047 HotKeysGet (string filterId)
        {
    
            var path = "/hot_keys";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HotKeysGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HotKeysGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20047) ApiClient.Deserialize(response.Content, typeof(InlineResponse20047), response.Headers);
        }
    
        /// <summary>
        /// Delete a HotKey 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20046</returns>
        public InlineResponse20046 HotKeysIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HotKeysIdDelete");
    
            var path = "/hot_keys/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HotKeysIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HotKeysIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20046) ApiClient.Deserialize(response.Content, typeof(InlineResponse20046), response.Headers);
        }
    
        /// <summary>
        /// Show a single HotKey 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20046</returns>
        public InlineResponse20046 HotKeysIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HotKeysIdGet");
    
            var path = "/hot_keys/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HotKeysIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HotKeysIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20046) ApiClient.Deserialize(response.Content, typeof(InlineResponse20046), response.Headers);
        }
    
        /// <summary>
        /// Update a HotKey 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20046</returns>
        public InlineResponse20046 HotKeysIdPatch (HotKeysIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling HotKeysIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HotKeysIdPatch");
    
            var path = "/hot_keys/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HotKeysIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HotKeysIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20046) ApiClient.Deserialize(response.Content, typeof(InlineResponse20046), response.Headers);
        }
    
        /// <summary>
        /// Create a HotKey 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20046</returns>
        public InlineResponse20046 HotKeysPost (HotKeysBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling HotKeysPost");
    
            var path = "/hot_keys";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HotKeysPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HotKeysPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20046) ApiClient.Deserialize(response.Content, typeof(InlineResponse20046), response.Headers);
        }
    
    }
}
