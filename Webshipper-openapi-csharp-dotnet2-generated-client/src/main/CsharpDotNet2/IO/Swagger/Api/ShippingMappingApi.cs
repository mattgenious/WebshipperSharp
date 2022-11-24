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
    public interface IShippingMappingApi
    {
        /// <summary>
        /// List all Shipping Mappings 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterOrderChannelId">Filter by order_channel_id</param>
        /// <param name="filterOrderChannel">Filter by order_channel</param>
        /// <param name="filterShippingCode">Filter by shipping_code</param>
        /// <returns>InlineResponse200102</returns>
        InlineResponse200102 ShippingMappingsGet (string filterId, string filterOrderChannelId, string filterOrderChannel, string filterShippingCode);
        /// <summary>
        /// Delete a Shipping Mapping 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200101</returns>
        InlineResponse200101 ShippingMappingsIdDelete (int? id);
        /// <summary>
        /// Show a single Shipping Mapping 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200101</returns>
        InlineResponse200101 ShippingMappingsIdGet (int? id);
        /// <summary>
        /// Update a Shipping Mapping 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200101</returns>
        InlineResponse200101 ShippingMappingsIdPatch (ShippingMappingsIdBody body, int? id);
        /// <summary>
        /// Create a Shipping Mapping 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200101</returns>
        InlineResponse200101 ShippingMappingsPost (ShippingMappingsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShippingMappingApi : IShippingMappingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingMappingApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ShippingMappingApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingMappingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippingMappingApi(String basePath)
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
        /// List all Shipping Mappings 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterOrderChannelId">Filter by order_channel_id</param>
        /// <param name="filterOrderChannel">Filter by order_channel</param>
        /// <param name="filterShippingCode">Filter by shipping_code</param>
        /// <returns>InlineResponse200102</returns>
        public InlineResponse200102 ShippingMappingsGet (string filterId, string filterOrderChannelId, string filterOrderChannel, string filterShippingCode)
        {
    
            var path = "/shipping_mappings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterOrderChannelId != null) queryParams.Add("filter[order_channel_id]", ApiClient.ParameterToString(filterOrderChannelId)); // query parameter
 if (filterOrderChannel != null) queryParams.Add("filter[order_channel]", ApiClient.ParameterToString(filterOrderChannel)); // query parameter
 if (filterShippingCode != null) queryParams.Add("filter[shipping_code]", ApiClient.ParameterToString(filterShippingCode)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingMappingsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingMappingsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200102) ApiClient.Deserialize(response.Content, typeof(InlineResponse200102), response.Headers);
        }
    
        /// <summary>
        /// Delete a Shipping Mapping 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200101</returns>
        public InlineResponse200101 ShippingMappingsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ShippingMappingsIdDelete");
    
            var path = "/shipping_mappings/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingMappingsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingMappingsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200101) ApiClient.Deserialize(response.Content, typeof(InlineResponse200101), response.Headers);
        }
    
        /// <summary>
        /// Show a single Shipping Mapping 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200101</returns>
        public InlineResponse200101 ShippingMappingsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ShippingMappingsIdGet");
    
            var path = "/shipping_mappings/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingMappingsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingMappingsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200101) ApiClient.Deserialize(response.Content, typeof(InlineResponse200101), response.Headers);
        }
    
        /// <summary>
        /// Update a Shipping Mapping 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200101</returns>
        public InlineResponse200101 ShippingMappingsIdPatch (ShippingMappingsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ShippingMappingsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ShippingMappingsIdPatch");
    
            var path = "/shipping_mappings/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingMappingsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingMappingsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200101) ApiClient.Deserialize(response.Content, typeof(InlineResponse200101), response.Headers);
        }
    
        /// <summary>
        /// Create a Shipping Mapping 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200101</returns>
        public InlineResponse200101 ShippingMappingsPost (ShippingMappingsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ShippingMappingsPost");
    
            var path = "/shipping_mappings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingMappingsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingMappingsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200101) ApiClient.Deserialize(response.Content, typeof(InlineResponse200101), response.Headers);
        }
    
    }
}
