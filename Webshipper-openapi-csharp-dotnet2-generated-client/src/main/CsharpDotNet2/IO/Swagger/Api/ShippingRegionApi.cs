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
    public interface IShippingRegionApi
    {
        /// <summary>
        /// List all Shipping Regions 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200108</returns>
        InlineResponse200108 RegionsGet (string filterId);
        /// <summary>
        /// Delete a Shipping Region 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200107</returns>
        InlineResponse200107 RegionsIdDelete (int? id);
        /// <summary>
        /// Show a single Shipping Region 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200107</returns>
        InlineResponse200107 RegionsIdGet (int? id);
        /// <summary>
        /// Update a Shipping Region 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200107</returns>
        InlineResponse200107 RegionsIdPatch (RegionsIdBody body, int? id);
        /// <summary>
        /// Create a Shipping Region 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200107</returns>
        InlineResponse200107 RegionsPost (RegionsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShippingRegionApi : IShippingRegionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingRegionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ShippingRegionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingRegionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippingRegionApi(String basePath)
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
        /// List all Shipping Regions 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200108</returns>
        public InlineResponse200108 RegionsGet (string filterId)
        {
    
            var path = "/regions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RegionsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RegionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200108) ApiClient.Deserialize(response.Content, typeof(InlineResponse200108), response.Headers);
        }
    
        /// <summary>
        /// Delete a Shipping Region 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200107</returns>
        public InlineResponse200107 RegionsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RegionsIdDelete");
    
            var path = "/regions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RegionsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RegionsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200107) ApiClient.Deserialize(response.Content, typeof(InlineResponse200107), response.Headers);
        }
    
        /// <summary>
        /// Show a single Shipping Region 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200107</returns>
        public InlineResponse200107 RegionsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RegionsIdGet");
    
            var path = "/regions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RegionsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RegionsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200107) ApiClient.Deserialize(response.Content, typeof(InlineResponse200107), response.Headers);
        }
    
        /// <summary>
        /// Update a Shipping Region 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200107</returns>
        public InlineResponse200107 RegionsIdPatch (RegionsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling RegionsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RegionsIdPatch");
    
            var path = "/regions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RegionsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RegionsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200107) ApiClient.Deserialize(response.Content, typeof(InlineResponse200107), response.Headers);
        }
    
        /// <summary>
        /// Create a Shipping Region 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200107</returns>
        public InlineResponse200107 RegionsPost (RegionsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling RegionsPost");
    
            var path = "/regions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RegionsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RegionsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200107) ApiClient.Deserialize(response.Content, typeof(InlineResponse200107), response.Headers);
        }
    
    }
}
