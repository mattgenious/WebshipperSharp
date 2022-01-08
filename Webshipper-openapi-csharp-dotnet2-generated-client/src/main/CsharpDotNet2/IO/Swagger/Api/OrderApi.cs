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
    public interface IOrderApi
    {
        /// <summary>
        /// List all Orders 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterExtRef">Filter by ext_ref</param>
        /// <param name="filterSortingId">Filter by sorting_id</param>
        /// <param name="filterCreatedAt">Filter by created_at</param>
        /// <param name="filterUpdatedAt">Filter by updated_at</param>
        /// <param name="filterStatus">Filter by status</param>
        /// <param name="filterVisibleRef">Filter by visible_ref</param>
        /// <param name="filterSlipPrinted">Filter by slip_printed</param>
        /// <param name="filterLabelPrinted">Filter by label_printed</param>
        /// <param name="filterLockState">Filter by lock_state</param>
        /// <param name="filterOrderChannel">Filter by order_channel</param>
        /// <param name="filterOrderChannelId">Filter by order_channel_id</param>
        /// <param name="filterShippingRate">Filter by shipping_rate</param>
        /// <param name="filterShippingRateId">Filter by shipping_rate_id</param>
        /// <param name="filterCarrier">Filter by carrier</param>
        /// <param name="filterSku">Filter by sku</param>
        /// <param name="filterFreeText">Filter by free_text</param>
        /// <param name="filterTag">Filter by tag</param>
        /// <param name="filterDeliveryCountryCode">Filter by delivery_country_code</param>
        /// <returns>InlineResponse20064</returns>
        InlineResponse20064 OrdersGet (string filterId, string filterExtRef, string filterSortingId, string filterCreatedAt, string filterUpdatedAt, string filterStatus, string filterVisibleRef, string filterSlipPrinted, string filterLabelPrinted, string filterLockState, string filterOrderChannel, string filterOrderChannelId, string filterShippingRate, string filterShippingRateId, string filterCarrier, string filterSku, string filterFreeText, string filterTag, string filterDeliveryCountryCode);
        /// <summary>
        /// Delete a Order 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20063</returns>
        InlineResponse20063 OrdersIdDelete (int? id);
        /// <summary>
        /// Show a single Order 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20063</returns>
        InlineResponse20063 OrdersIdGet (int? id);
        /// <summary>
        /// Update a Order 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20063</returns>
        InlineResponse20063 OrdersIdPatch (OrdersIdBody body, int? id);
        /// <summary>
        /// Create a Order 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20063</returns>
        InlineResponse20063 OrdersPost (OrdersBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderApi : IOrderApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderApi(String basePath)
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
        /// List all Orders 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterExtRef">Filter by ext_ref</param>
        /// <param name="filterSortingId">Filter by sorting_id</param>
        /// <param name="filterCreatedAt">Filter by created_at</param>
        /// <param name="filterUpdatedAt">Filter by updated_at</param>
        /// <param name="filterStatus">Filter by status</param>
        /// <param name="filterVisibleRef">Filter by visible_ref</param>
        /// <param name="filterSlipPrinted">Filter by slip_printed</param>
        /// <param name="filterLabelPrinted">Filter by label_printed</param>
        /// <param name="filterLockState">Filter by lock_state</param>
        /// <param name="filterOrderChannel">Filter by order_channel</param>
        /// <param name="filterOrderChannelId">Filter by order_channel_id</param>
        /// <param name="filterShippingRate">Filter by shipping_rate</param>
        /// <param name="filterShippingRateId">Filter by shipping_rate_id</param>
        /// <param name="filterCarrier">Filter by carrier</param>
        /// <param name="filterSku">Filter by sku</param>
        /// <param name="filterFreeText">Filter by free_text</param>
        /// <param name="filterTag">Filter by tag</param>
        /// <param name="filterDeliveryCountryCode">Filter by delivery_country_code</param>
        /// <returns>InlineResponse20064</returns>
        public InlineResponse20064 OrdersGet (string filterId, string filterExtRef, string filterSortingId, string filterCreatedAt, string filterUpdatedAt, string filterStatus, string filterVisibleRef, string filterSlipPrinted, string filterLabelPrinted, string filterLockState, string filterOrderChannel, string filterOrderChannelId, string filterShippingRate, string filterShippingRateId, string filterCarrier, string filterSku, string filterFreeText, string filterTag, string filterDeliveryCountryCode)
        {
    
            var path = "/orders";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterExtRef != null) queryParams.Add("filter[ext_ref]", ApiClient.ParameterToString(filterExtRef)); // query parameter
 if (filterSortingId != null) queryParams.Add("filter[sorting_id]", ApiClient.ParameterToString(filterSortingId)); // query parameter
 if (filterCreatedAt != null) queryParams.Add("filter[created_at]", ApiClient.ParameterToString(filterCreatedAt)); // query parameter
 if (filterUpdatedAt != null) queryParams.Add("filter[updated_at]", ApiClient.ParameterToString(filterUpdatedAt)); // query parameter
 if (filterStatus != null) queryParams.Add("filter[status]", ApiClient.ParameterToString(filterStatus)); // query parameter
 if (filterVisibleRef != null) queryParams.Add("filter[visible_ref]", ApiClient.ParameterToString(filterVisibleRef)); // query parameter
 if (filterSlipPrinted != null) queryParams.Add("filter[slip_printed]", ApiClient.ParameterToString(filterSlipPrinted)); // query parameter
 if (filterLabelPrinted != null) queryParams.Add("filter[label_printed]", ApiClient.ParameterToString(filterLabelPrinted)); // query parameter
 if (filterLockState != null) queryParams.Add("filter[lock_state]", ApiClient.ParameterToString(filterLockState)); // query parameter
 if (filterOrderChannel != null) queryParams.Add("filter[order_channel]", ApiClient.ParameterToString(filterOrderChannel)); // query parameter
 if (filterOrderChannelId != null) queryParams.Add("filter[order_channel_id]", ApiClient.ParameterToString(filterOrderChannelId)); // query parameter
 if (filterShippingRate != null) queryParams.Add("filter[shipping_rate]", ApiClient.ParameterToString(filterShippingRate)); // query parameter
 if (filterShippingRateId != null) queryParams.Add("filter[shipping_rate_id]", ApiClient.ParameterToString(filterShippingRateId)); // query parameter
 if (filterCarrier != null) queryParams.Add("filter[carrier]", ApiClient.ParameterToString(filterCarrier)); // query parameter
 if (filterSku != null) queryParams.Add("filter[sku]", ApiClient.ParameterToString(filterSku)); // query parameter
 if (filterFreeText != null) queryParams.Add("filter[free_text]", ApiClient.ParameterToString(filterFreeText)); // query parameter
 if (filterTag != null) queryParams.Add("filter[tag]", ApiClient.ParameterToString(filterTag)); // query parameter
 if (filterDeliveryCountryCode != null) queryParams.Add("filter[delivery_country_code]", ApiClient.ParameterToString(filterDeliveryCountryCode)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrdersGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrdersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20064) ApiClient.Deserialize(response.Content, typeof(InlineResponse20064), response.Headers);
        }
    
        /// <summary>
        /// Delete a Order 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20063</returns>
        public InlineResponse20063 OrdersIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrdersIdDelete");
    
            var path = "/orders/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrdersIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrdersIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20063) ApiClient.Deserialize(response.Content, typeof(InlineResponse20063), response.Headers);
        }
    
        /// <summary>
        /// Show a single Order 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20063</returns>
        public InlineResponse20063 OrdersIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrdersIdGet");
    
            var path = "/orders/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrdersIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrdersIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20063) ApiClient.Deserialize(response.Content, typeof(InlineResponse20063), response.Headers);
        }
    
        /// <summary>
        /// Update a Order 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20063</returns>
        public InlineResponse20063 OrdersIdPatch (OrdersIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling OrdersIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrdersIdPatch");
    
            var path = "/orders/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrdersIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrdersIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20063) ApiClient.Deserialize(response.Content, typeof(InlineResponse20063), response.Headers);
        }
    
        /// <summary>
        /// Create a Order 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20063</returns>
        public InlineResponse20063 OrdersPost (OrdersBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling OrdersPost");
    
            var path = "/orders";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrdersPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrdersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20063) ApiClient.Deserialize(response.Content, typeof(InlineResponse20063), response.Headers);
        }
    
    }
}
