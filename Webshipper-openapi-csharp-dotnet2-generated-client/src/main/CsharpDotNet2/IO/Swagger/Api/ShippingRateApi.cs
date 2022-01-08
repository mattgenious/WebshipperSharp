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
    public interface IShippingRateApi
    {
        /// <summary>
        /// List all Shipping Rates 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterOrderChannelId">Filter by order_channel_id</param>
        /// <param name="filterIsReturn">Filter by is_return</param>
        /// <param name="filterIsHidden">Filter by is_hidden</param>
        /// <param name="filterServiceCode">Filter by service_code</param>
        /// <returns>InlineResponse200104</returns>
        InlineResponse200104 ShippingRatesGet (string filterId, string filterOrderChannelId, string filterIsReturn, string filterIsHidden, string filterServiceCode);
        /// <summary>
        /// Delete a Shipping Rate 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200103</returns>
        InlineResponse200103 ShippingRatesIdDelete (int? id);
        /// <summary>
        /// Show a single Shipping Rate 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200103</returns>
        InlineResponse200103 ShippingRatesIdGet (int? id);
        /// <summary>
        /// Update a Shipping Rate 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200103</returns>
        InlineResponse200103 ShippingRatesIdPatch (ShippingRatesIdBody body, int? id);
        /// <summary>
        /// Create a Shipping Rate 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200103</returns>
        InlineResponse200103 ShippingRatesPost (ShippingRatesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShippingRateApi : IShippingRateApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingRateApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ShippingRateApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingRateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippingRateApi(String basePath)
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
        /// List all Shipping Rates 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterOrderChannelId">Filter by order_channel_id</param>
        /// <param name="filterIsReturn">Filter by is_return</param>
        /// <param name="filterIsHidden">Filter by is_hidden</param>
        /// <param name="filterServiceCode">Filter by service_code</param>
        /// <returns>InlineResponse200104</returns>
        public InlineResponse200104 ShippingRatesGet (string filterId, string filterOrderChannelId, string filterIsReturn, string filterIsHidden, string filterServiceCode)
        {
    
            var path = "/shipping_rates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterOrderChannelId != null) queryParams.Add("filter[order_channel_id]", ApiClient.ParameterToString(filterOrderChannelId)); // query parameter
 if (filterIsReturn != null) queryParams.Add("filter[is_return]", ApiClient.ParameterToString(filterIsReturn)); // query parameter
 if (filterIsHidden != null) queryParams.Add("filter[is_hidden]", ApiClient.ParameterToString(filterIsHidden)); // query parameter
 if (filterServiceCode != null) queryParams.Add("filter[service_code]", ApiClient.ParameterToString(filterServiceCode)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingRatesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingRatesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200104) ApiClient.Deserialize(response.Content, typeof(InlineResponse200104), response.Headers);
        }
    
        /// <summary>
        /// Delete a Shipping Rate 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200103</returns>
        public InlineResponse200103 ShippingRatesIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ShippingRatesIdDelete");
    
            var path = "/shipping_rates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingRatesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingRatesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200103) ApiClient.Deserialize(response.Content, typeof(InlineResponse200103), response.Headers);
        }
    
        /// <summary>
        /// Show a single Shipping Rate 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200103</returns>
        public InlineResponse200103 ShippingRatesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ShippingRatesIdGet");
    
            var path = "/shipping_rates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingRatesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingRatesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200103) ApiClient.Deserialize(response.Content, typeof(InlineResponse200103), response.Headers);
        }
    
        /// <summary>
        /// Update a Shipping Rate 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200103</returns>
        public InlineResponse200103 ShippingRatesIdPatch (ShippingRatesIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ShippingRatesIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ShippingRatesIdPatch");
    
            var path = "/shipping_rates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingRatesIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingRatesIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200103) ApiClient.Deserialize(response.Content, typeof(InlineResponse200103), response.Headers);
        }
    
        /// <summary>
        /// Create a Shipping Rate 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200103</returns>
        public InlineResponse200103 ShippingRatesPost (ShippingRatesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ShippingRatesPost");
    
            var path = "/shipping_rates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingRatesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingRatesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200103) ApiClient.Deserialize(response.Content, typeof(InlineResponse200103), response.Headers);
        }
    
    }
}
