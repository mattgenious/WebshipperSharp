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
    public interface IPackageApi
    {
        /// <summary>
        /// List all Packages 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20072</returns>
        InlineResponse20072 PackagesGet (string filterId);
        /// <summary>
        /// Show a single Package 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20071</returns>
        InlineResponse20071 PackagesIdGet (int? id);
        /// <summary>
        /// Create a Package 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20071</returns>
        InlineResponse20071 PackagesPost (PackagesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PackageApi : IPackageApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PackageApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PackageApi(String basePath)
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
        /// List all Packages 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20072</returns>
        public InlineResponse20072 PackagesGet (string filterId)
        {
    
            var path = "/packages";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20072) ApiClient.Deserialize(response.Content, typeof(InlineResponse20072), response.Headers);
        }
    
        /// <summary>
        /// Show a single Package 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20071</returns>
        public InlineResponse20071 PackagesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PackagesIdGet");
    
            var path = "/packages/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20071) ApiClient.Deserialize(response.Content, typeof(InlineResponse20071), response.Headers);
        }
    
        /// <summary>
        /// Create a Package 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20071</returns>
        public InlineResponse20071 PackagesPost (PackagesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PackagesPost");
    
            var path = "/packages";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20071) ApiClient.Deserialize(response.Content, typeof(InlineResponse20071), response.Headers);
        }
    
    }
}
