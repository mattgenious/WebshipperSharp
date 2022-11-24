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
    public interface IOAuthAccessTokenApi
    {
        /// <summary>
        /// List all OAuth Access Tokens 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20060</returns>
        InlineResponse20060 OauthAccessTokensGet (string filterId);
        /// <summary>
        /// Show a single OAuth Access Token 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20059</returns>
        InlineResponse20059 OauthAccessTokensIdGet (int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OAuthAccessTokenApi : IOAuthAccessTokenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAccessTokenApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OAuthAccessTokenApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAccessTokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OAuthAccessTokenApi(String basePath)
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
        /// List all OAuth Access Tokens 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20060</returns>
        public InlineResponse20060 OauthAccessTokensGet (string filterId)
        {
    
            var path = "/oauth_access_tokens";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OauthAccessTokensGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OauthAccessTokensGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20060) ApiClient.Deserialize(response.Content, typeof(InlineResponse20060), response.Headers);
        }
    
        /// <summary>
        /// Show a single OAuth Access Token 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20059</returns>
        public InlineResponse20059 OauthAccessTokensIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OauthAccessTokensIdGet");
    
            var path = "/oauth_access_tokens/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OauthAccessTokensIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OauthAccessTokensIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20059) ApiClient.Deserialize(response.Content, typeof(InlineResponse20059), response.Headers);
        }
    
    }
}
