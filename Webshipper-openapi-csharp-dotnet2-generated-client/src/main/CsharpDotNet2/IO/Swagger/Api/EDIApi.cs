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
    public interface IEDIApi
    {
        /// <summary>
        /// List all EDIs 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterShipmentId">Filter by shipment_id</param>
        /// <param name="filterWaybillId">Filter by waybill_id</param>
        /// <returns>InlineResponse20033</returns>
        InlineResponse20033 EdisGet (string filterId, string filterShipmentId, string filterWaybillId);
        /// <summary>
        /// Show a single EDI 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20032</returns>
        InlineResponse20032 EdisIdGet (int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EDIApi : IEDIApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EDIApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EDIApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EDIApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EDIApi(String basePath)
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
        /// List all EDIs 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterShipmentId">Filter by shipment_id</param>
        /// <param name="filterWaybillId">Filter by waybill_id</param>
        /// <returns>InlineResponse20033</returns>
        public InlineResponse20033 EdisGet (string filterId, string filterShipmentId, string filterWaybillId)
        {
    
            var path = "/edis";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterShipmentId != null) queryParams.Add("filter[shipment_id]", ApiClient.ParameterToString(filterShipmentId)); // query parameter
 if (filterWaybillId != null) queryParams.Add("filter[waybill_id]", ApiClient.ParameterToString(filterWaybillId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EdisGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EdisGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20033) ApiClient.Deserialize(response.Content, typeof(InlineResponse20033), response.Headers);
        }
    
        /// <summary>
        /// Show a single EDI 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20032</returns>
        public InlineResponse20032 EdisIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EdisIdGet");
    
            var path = "/edis/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EdisIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EdisIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20032) ApiClient.Deserialize(response.Content, typeof(InlineResponse20032), response.Headers);
        }
    
    }
}
