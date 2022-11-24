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
    public interface IReturnShippingMethodApi
    {
        /// <summary>
        /// List all Return Shipping Methods 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20096</returns>
        InlineResponse20096 ReturnShippingMethodsGet (string filterId);
        /// <summary>
        /// Delete a Return Shipping Method 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20095</returns>
        InlineResponse20095 ReturnShippingMethodsIdDelete (int? id);
        /// <summary>
        /// Show a single Return Shipping Method 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20095</returns>
        InlineResponse20095 ReturnShippingMethodsIdGet (int? id);
        /// <summary>
        /// Update a Return Shipping Method 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20095</returns>
        InlineResponse20095 ReturnShippingMethodsIdPatch (ReturnShippingMethodsIdBody body, int? id);
        /// <summary>
        /// Create a Return Shipping Method 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20095</returns>
        InlineResponse20095 ReturnShippingMethodsPost (ReturnShippingMethodsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReturnShippingMethodApi : IReturnShippingMethodApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnShippingMethodApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReturnShippingMethodApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnShippingMethodApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReturnShippingMethodApi(String basePath)
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
        /// List all Return Shipping Methods 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20096</returns>
        public InlineResponse20096 ReturnShippingMethodsGet (string filterId)
        {
    
            var path = "/return_shipping_methods";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnShippingMethodsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnShippingMethodsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20096) ApiClient.Deserialize(response.Content, typeof(InlineResponse20096), response.Headers);
        }
    
        /// <summary>
        /// Delete a Return Shipping Method 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20095</returns>
        public InlineResponse20095 ReturnShippingMethodsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReturnShippingMethodsIdDelete");
    
            var path = "/return_shipping_methods/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnShippingMethodsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnShippingMethodsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20095) ApiClient.Deserialize(response.Content, typeof(InlineResponse20095), response.Headers);
        }
    
        /// <summary>
        /// Show a single Return Shipping Method 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20095</returns>
        public InlineResponse20095 ReturnShippingMethodsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReturnShippingMethodsIdGet");
    
            var path = "/return_shipping_methods/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnShippingMethodsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnShippingMethodsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20095) ApiClient.Deserialize(response.Content, typeof(InlineResponse20095), response.Headers);
        }
    
        /// <summary>
        /// Update a Return Shipping Method 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20095</returns>
        public InlineResponse20095 ReturnShippingMethodsIdPatch (ReturnShippingMethodsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReturnShippingMethodsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReturnShippingMethodsIdPatch");
    
            var path = "/return_shipping_methods/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnShippingMethodsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnShippingMethodsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20095) ApiClient.Deserialize(response.Content, typeof(InlineResponse20095), response.Headers);
        }
    
        /// <summary>
        /// Create a Return Shipping Method 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20095</returns>
        public InlineResponse20095 ReturnShippingMethodsPost (ReturnShippingMethodsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReturnShippingMethodsPost");
    
            var path = "/return_shipping_methods";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnShippingMethodsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnShippingMethodsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20095) ApiClient.Deserialize(response.Content, typeof(InlineResponse20095), response.Headers);
        }
    
    }
}
