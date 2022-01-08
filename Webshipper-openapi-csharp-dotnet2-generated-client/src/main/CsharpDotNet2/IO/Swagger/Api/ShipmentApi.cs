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
    public interface IShipmentApi
    {
        /// <summary>
        /// List all Shipments 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterReference">Filter by reference</param>
        /// <param name="filterSortingId">Filter by sorting_id</param>
        /// <param name="filterCreatedAt">Filter by created_at</param>
        /// <param name="filterUpdatedAt">Filter by updated_at</param>
        /// <param name="filterOrder">Filter by order</param>
        /// <param name="filterCarrier">Filter by carrier</param>
        /// <param name="filterSendTime">Filter by send_time</param>
        /// <param name="filterStatus">Filter by status</param>
        /// <param name="filterIsReturn">Filter by is_return</param>
        /// <param name="filterPrinterClient">Filter by printer_client</param>
        /// <param name="filterDeliveryAddress">Filter by delivery_address</param>
        /// <param name="filterTrackingNumber">Filter by tracking_number</param>
        /// <param name="filterFreeText">Filter by free_text</param>
        /// <param name="filterHasPickup">Filter by has_pickup</param>
        /// <returns>InlineResponse20098</returns>
        InlineResponse20098 ShipmentsGet (string filterId, string filterReference, string filterSortingId, string filterCreatedAt, string filterUpdatedAt, string filterOrder, string filterCarrier, string filterSendTime, string filterStatus, string filterIsReturn, string filterPrinterClient, string filterDeliveryAddress, string filterTrackingNumber, string filterFreeText, string filterHasPickup);
        /// <summary>
        /// Show a single Shipment 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20097</returns>
        InlineResponse20097 ShipmentsIdGet (int? id);
        /// <summary>
        /// Create a Shipment 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20097</returns>
        InlineResponse20097 ShipmentsPost (ShipmentsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShipmentApi : IShipmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ShipmentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShipmentApi(String basePath)
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
        /// List all Shipments 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterReference">Filter by reference</param>
        /// <param name="filterSortingId">Filter by sorting_id</param>
        /// <param name="filterCreatedAt">Filter by created_at</param>
        /// <param name="filterUpdatedAt">Filter by updated_at</param>
        /// <param name="filterOrder">Filter by order</param>
        /// <param name="filterCarrier">Filter by carrier</param>
        /// <param name="filterSendTime">Filter by send_time</param>
        /// <param name="filterStatus">Filter by status</param>
        /// <param name="filterIsReturn">Filter by is_return</param>
        /// <param name="filterPrinterClient">Filter by printer_client</param>
        /// <param name="filterDeliveryAddress">Filter by delivery_address</param>
        /// <param name="filterTrackingNumber">Filter by tracking_number</param>
        /// <param name="filterFreeText">Filter by free_text</param>
        /// <param name="filterHasPickup">Filter by has_pickup</param>
        /// <returns>InlineResponse20098</returns>
        public InlineResponse20098 ShipmentsGet (string filterId, string filterReference, string filterSortingId, string filterCreatedAt, string filterUpdatedAt, string filterOrder, string filterCarrier, string filterSendTime, string filterStatus, string filterIsReturn, string filterPrinterClient, string filterDeliveryAddress, string filterTrackingNumber, string filterFreeText, string filterHasPickup)
        {
    
            var path = "/shipments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterReference != null) queryParams.Add("filter[reference]", ApiClient.ParameterToString(filterReference)); // query parameter
 if (filterSortingId != null) queryParams.Add("filter[sorting_id]", ApiClient.ParameterToString(filterSortingId)); // query parameter
 if (filterCreatedAt != null) queryParams.Add("filter[created_at]", ApiClient.ParameterToString(filterCreatedAt)); // query parameter
 if (filterUpdatedAt != null) queryParams.Add("filter[updated_at]", ApiClient.ParameterToString(filterUpdatedAt)); // query parameter
 if (filterOrder != null) queryParams.Add("filter[order]", ApiClient.ParameterToString(filterOrder)); // query parameter
 if (filterCarrier != null) queryParams.Add("filter[carrier]", ApiClient.ParameterToString(filterCarrier)); // query parameter
 if (filterSendTime != null) queryParams.Add("filter[send_time]", ApiClient.ParameterToString(filterSendTime)); // query parameter
 if (filterStatus != null) queryParams.Add("filter[status]", ApiClient.ParameterToString(filterStatus)); // query parameter
 if (filterIsReturn != null) queryParams.Add("filter[is_return]", ApiClient.ParameterToString(filterIsReturn)); // query parameter
 if (filterPrinterClient != null) queryParams.Add("filter[printer_client]", ApiClient.ParameterToString(filterPrinterClient)); // query parameter
 if (filterDeliveryAddress != null) queryParams.Add("filter[delivery_address]", ApiClient.ParameterToString(filterDeliveryAddress)); // query parameter
 if (filterTrackingNumber != null) queryParams.Add("filter[tracking_number]", ApiClient.ParameterToString(filterTrackingNumber)); // query parameter
 if (filterFreeText != null) queryParams.Add("filter[free_text]", ApiClient.ParameterToString(filterFreeText)); // query parameter
 if (filterHasPickup != null) queryParams.Add("filter[has_pickup]", ApiClient.ParameterToString(filterHasPickup)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ShipmentsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShipmentsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20098) ApiClient.Deserialize(response.Content, typeof(InlineResponse20098), response.Headers);
        }
    
        /// <summary>
        /// Show a single Shipment 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20097</returns>
        public InlineResponse20097 ShipmentsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ShipmentsIdGet");
    
            var path = "/shipments/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShipmentsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShipmentsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20097) ApiClient.Deserialize(response.Content, typeof(InlineResponse20097), response.Headers);
        }
    
        /// <summary>
        /// Create a Shipment 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20097</returns>
        public InlineResponse20097 ShipmentsPost (ShipmentsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ShipmentsPost");
    
            var path = "/shipments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShipmentsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShipmentsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20097) ApiClient.Deserialize(response.Content, typeof(InlineResponse20097), response.Headers);
        }
    
    }
}
