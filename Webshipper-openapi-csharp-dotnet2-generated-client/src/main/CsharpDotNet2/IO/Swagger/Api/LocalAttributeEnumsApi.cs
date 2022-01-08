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
    public interface ILocalAttributeEnumsApi
    {
        /// <summary>
        /// List all Local Attribute Enumss 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20053</returns>
        InlineResponse20053 LocalAttrEnumsGet (string filterId);
        /// <summary>
        /// Show a single Local Attribute Enums 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20052</returns>
        InlineResponse20052 LocalAttrEnumsIdGet (int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LocalAttributeEnumsApi : ILocalAttributeEnumsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalAttributeEnumsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LocalAttributeEnumsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalAttributeEnumsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocalAttributeEnumsApi(String basePath)
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
        /// List all Local Attribute Enumss 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20053</returns>
        public InlineResponse20053 LocalAttrEnumsGet (string filterId)
        {
    
            var path = "/local_attr_enums";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LocalAttrEnumsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LocalAttrEnumsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20053) ApiClient.Deserialize(response.Content, typeof(InlineResponse20053), response.Headers);
        }
    
        /// <summary>
        /// Show a single Local Attribute Enums 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20052</returns>
        public InlineResponse20052 LocalAttrEnumsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LocalAttrEnumsIdGet");
    
            var path = "/local_attr_enums/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LocalAttrEnumsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LocalAttrEnumsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20052) ApiClient.Deserialize(response.Content, typeof(InlineResponse20052), response.Headers);
        }
    
    }
}
