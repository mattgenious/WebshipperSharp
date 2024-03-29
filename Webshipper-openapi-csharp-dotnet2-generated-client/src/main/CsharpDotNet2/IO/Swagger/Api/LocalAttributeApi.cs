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
    public interface ILocalAttributeApi
    {
        /// <summary>
        /// List all Local Attributes 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20051</returns>
        InlineResponse20051 LocalAttrsGet (string filterId);
        /// <summary>
        /// Show a single Local Attribute 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20050</returns>
        InlineResponse20050 LocalAttrsIdGet (int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LocalAttributeApi : ILocalAttributeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalAttributeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LocalAttributeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalAttributeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocalAttributeApi(String basePath)
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
        /// List all Local Attributes 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20051</returns>
        public InlineResponse20051 LocalAttrsGet (string filterId)
        {
    
            var path = "/local_attrs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LocalAttrsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LocalAttrsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20051) ApiClient.Deserialize(response.Content, typeof(InlineResponse20051), response.Headers);
        }
    
        /// <summary>
        /// Show a single Local Attribute 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20050</returns>
        public InlineResponse20050 LocalAttrsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LocalAttrsIdGet");
    
            var path = "/local_attrs/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LocalAttrsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LocalAttrsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20050) ApiClient.Deserialize(response.Content, typeof(InlineResponse20050), response.Headers);
        }
    
    }
}
