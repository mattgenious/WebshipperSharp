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
    public interface IShippingRateExpressionApi
    {
        /// <summary>
        /// List all Shipping Rate Expressions 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200106</returns>
        InlineResponse200106 ExpressionsGet (string filterId);
        /// <summary>
        /// Delete a Shipping Rate Expression 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200105</returns>
        InlineResponse200105 ExpressionsIdDelete (int? id);
        /// <summary>
        /// Show a single Shipping Rate Expression 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200105</returns>
        InlineResponse200105 ExpressionsIdGet (int? id);
        /// <summary>
        /// Update a Shipping Rate Expression 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200105</returns>
        InlineResponse200105 ExpressionsIdPatch (ExpressionsIdBody body, int? id);
        /// <summary>
        /// Create a Shipping Rate Expression 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200105</returns>
        InlineResponse200105 ExpressionsPost (ExpressionsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShippingRateExpressionApi : IShippingRateExpressionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingRateExpressionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ShippingRateExpressionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingRateExpressionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippingRateExpressionApi(String basePath)
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
        /// List all Shipping Rate Expressions 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200106</returns>
        public InlineResponse200106 ExpressionsGet (string filterId)
        {
    
            var path = "/expressions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ExpressionsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ExpressionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200106) ApiClient.Deserialize(response.Content, typeof(InlineResponse200106), response.Headers);
        }
    
        /// <summary>
        /// Delete a Shipping Rate Expression 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200105</returns>
        public InlineResponse200105 ExpressionsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ExpressionsIdDelete");
    
            var path = "/expressions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ExpressionsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ExpressionsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200105) ApiClient.Deserialize(response.Content, typeof(InlineResponse200105), response.Headers);
        }
    
        /// <summary>
        /// Show a single Shipping Rate Expression 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200105</returns>
        public InlineResponse200105 ExpressionsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ExpressionsIdGet");
    
            var path = "/expressions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ExpressionsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ExpressionsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200105) ApiClient.Deserialize(response.Content, typeof(InlineResponse200105), response.Headers);
        }
    
        /// <summary>
        /// Update a Shipping Rate Expression 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200105</returns>
        public InlineResponse200105 ExpressionsIdPatch (ExpressionsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ExpressionsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ExpressionsIdPatch");
    
            var path = "/expressions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ExpressionsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ExpressionsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200105) ApiClient.Deserialize(response.Content, typeof(InlineResponse200105), response.Headers);
        }
    
        /// <summary>
        /// Create a Shipping Rate Expression 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200105</returns>
        public InlineResponse200105 ExpressionsPost (ExpressionsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ExpressionsPost");
    
            var path = "/expressions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ExpressionsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ExpressionsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200105) ApiClient.Deserialize(response.Content, typeof(InlineResponse200105), response.Headers);
        }
    
    }
}
