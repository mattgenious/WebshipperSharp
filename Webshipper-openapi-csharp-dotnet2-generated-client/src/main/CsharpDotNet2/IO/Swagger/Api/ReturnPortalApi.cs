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
    public interface IReturnPortalApi
    {
        /// <summary>
        /// List all Return Portals 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20094</returns>
        InlineResponse20094 ReturnPortalsGet (string filterId);
        /// <summary>
        /// Delete a Return Portal 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20093</returns>
        InlineResponse20093 ReturnPortalsIdDelete (int? id);
        /// <summary>
        /// Show a single Return Portal 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20093</returns>
        InlineResponse20093 ReturnPortalsIdGet (int? id);
        /// <summary>
        /// Update a Return Portal 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20093</returns>
        InlineResponse20093 ReturnPortalsIdPatch (ReturnPortalsIdBody body, int? id);
        /// <summary>
        /// Create a Return Portal 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20093</returns>
        InlineResponse20093 ReturnPortalsPost (ReturnPortalsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReturnPortalApi : IReturnPortalApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnPortalApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReturnPortalApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnPortalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReturnPortalApi(String basePath)
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
        /// List all Return Portals 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20094</returns>
        public InlineResponse20094 ReturnPortalsGet (string filterId)
        {
    
            var path = "/return_portals";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnPortalsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnPortalsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20094) ApiClient.Deserialize(response.Content, typeof(InlineResponse20094), response.Headers);
        }
    
        /// <summary>
        /// Delete a Return Portal 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20093</returns>
        public InlineResponse20093 ReturnPortalsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReturnPortalsIdDelete");
    
            var path = "/return_portals/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnPortalsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnPortalsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20093) ApiClient.Deserialize(response.Content, typeof(InlineResponse20093), response.Headers);
        }
    
        /// <summary>
        /// Show a single Return Portal 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20093</returns>
        public InlineResponse20093 ReturnPortalsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReturnPortalsIdGet");
    
            var path = "/return_portals/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnPortalsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnPortalsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20093) ApiClient.Deserialize(response.Content, typeof(InlineResponse20093), response.Headers);
        }
    
        /// <summary>
        /// Update a Return Portal 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20093</returns>
        public InlineResponse20093 ReturnPortalsIdPatch (ReturnPortalsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReturnPortalsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReturnPortalsIdPatch");
    
            var path = "/return_portals/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnPortalsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnPortalsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20093) ApiClient.Deserialize(response.Content, typeof(InlineResponse20093), response.Headers);
        }
    
        /// <summary>
        /// Create a Return Portal 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20093</returns>
        public InlineResponse20093 ReturnPortalsPost (ReturnPortalsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReturnPortalsPost");
    
            var path = "/return_portals";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnPortalsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnPortalsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20093) ApiClient.Deserialize(response.Content, typeof(InlineResponse20093), response.Headers);
        }
    
    }
}
