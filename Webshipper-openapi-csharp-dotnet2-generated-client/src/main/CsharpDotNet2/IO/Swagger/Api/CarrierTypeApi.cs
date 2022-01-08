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
    public interface ICarrierTypeApi
    {
        /// <summary>
        /// List all Carrier Types 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterCarrierCode">Filter by carrier_code</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 CarrierTypesGet (string filterId, string filterCarrierCode);
        /// <summary>
        /// Show a single Carrier Type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 CarrierTypesIdGet (int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CarrierTypeApi : ICarrierTypeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierTypeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CarrierTypeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CarrierTypeApi(String basePath)
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
        /// List all Carrier Types 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterCarrierCode">Filter by carrier_code</param>
        /// <returns>InlineResponse20027</returns>
        public InlineResponse20027 CarrierTypesGet (string filterId, string filterCarrierCode)
        {
    
            var path = "/carrier_types";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterCarrierCode != null) queryParams.Add("filter[carrier_code]", ApiClient.ParameterToString(filterCarrierCode)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CarrierTypesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarrierTypesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20027) ApiClient.Deserialize(response.Content, typeof(InlineResponse20027), response.Headers);
        }
    
        /// <summary>
        /// Show a single Carrier Type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20026</returns>
        public InlineResponse20026 CarrierTypesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierTypesIdGet");
    
            var path = "/carrier_types/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CarrierTypesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarrierTypesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20026) ApiClient.Deserialize(response.Content, typeof(InlineResponse20026), response.Headers);
        }
    
    }
}
