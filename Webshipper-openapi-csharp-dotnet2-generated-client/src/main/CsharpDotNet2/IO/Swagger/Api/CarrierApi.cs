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
    public interface ICarrierApi
    {
        /// <summary>
        /// List all Carriers 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterBillable">Filter by billable</param>
        /// <param name="filterCarrierTypeCodes">Filter by carrier_type_codes</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 CarriersGet (string filterId, string filterBillable, string filterCarrierTypeCodes);
        /// <summary>
        /// Delete a Carrier 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 CarriersIdDelete (int? id);
        /// <summary>
        /// Show a single Carrier 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 CarriersIdGet (int? id);
        /// <summary>
        /// Update a Carrier 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 CarriersIdPatch (CarriersIdBody body, int? id);
        /// <summary>
        /// Create a Carrier 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 CarriersPost (CarriersBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CarrierApi : ICarrierApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CarrierApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CarrierApi(String basePath)
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
        /// List all Carriers 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterBillable">Filter by billable</param>
        /// <param name="filterCarrierTypeCodes">Filter by carrier_type_codes</param>
        /// <returns>InlineResponse20023</returns>
        public InlineResponse20023 CarriersGet (string filterId, string filterBillable, string filterCarrierTypeCodes)
        {
    
            var path = "/carriers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterBillable != null) queryParams.Add("filter[billable]", ApiClient.ParameterToString(filterBillable)); // query parameter
 if (filterCarrierTypeCodes != null) queryParams.Add("filter[carrier_type_codes]", ApiClient.ParameterToString(filterCarrierTypeCodes)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CarriersGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarriersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20023) ApiClient.Deserialize(response.Content, typeof(InlineResponse20023), response.Headers);
        }
    
        /// <summary>
        /// Delete a Carrier 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20022</returns>
        public InlineResponse20022 CarriersIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarriersIdDelete");
    
            var path = "/carriers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CarriersIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarriersIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        /// Show a single Carrier 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20022</returns>
        public InlineResponse20022 CarriersIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarriersIdGet");
    
            var path = "/carriers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CarriersIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarriersIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        /// Update a Carrier 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20022</returns>
        public InlineResponse20022 CarriersIdPatch (CarriersIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CarriersIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarriersIdPatch");
    
            var path = "/carriers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CarriersIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarriersIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        /// Create a Carrier 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20022</returns>
        public InlineResponse20022 CarriersPost (CarriersBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CarriersPost");
    
            var path = "/carriers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CarriersPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarriersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
    }
}
