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
    public interface IShippingAddressApi
    {
        /// <summary>
        /// List all Shipping Addresss 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterAttContact">Filter by att_contact</param>
        /// <param name="filterCompanyName">Filter by company_name</param>
        /// <param name="filterAddress1">Filter by address_1</param>
        /// <param name="filterAddress2">Filter by address_2</param>
        /// <param name="filterCountryCode">Filter by country_code</param>
        /// <param name="filterState">Filter by state</param>
        /// <param name="filterZip">Filter by zip</param>
        /// <param name="filterAddressType">Filter by address_type</param>
        /// <param name="filterSearch">Filter by search</param>
        /// <returns>InlineResponse200100</returns>
        InlineResponse200100 ShippingAddressesGet (string filterId, string filterAttContact, string filterCompanyName, string filterAddress1, string filterAddress2, string filterCountryCode, string filterState, string filterZip, string filterAddressType, string filterSearch);
        /// <summary>
        /// Delete a Shipping Address 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20099</returns>
        InlineResponse20099 ShippingAddressesIdDelete (int? id);
        /// <summary>
        /// Show a single Shipping Address 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20099</returns>
        InlineResponse20099 ShippingAddressesIdGet (int? id);
        /// <summary>
        /// Update a Shipping Address 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20099</returns>
        InlineResponse20099 ShippingAddressesIdPatch (ShippingAddressesIdBody body, int? id);
        /// <summary>
        /// Create a Shipping Address 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20099</returns>
        InlineResponse20099 ShippingAddressesPost (ShippingAddressesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShippingAddressApi : IShippingAddressApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingAddressApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ShippingAddressApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingAddressApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippingAddressApi(String basePath)
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
        /// List all Shipping Addresss 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterAttContact">Filter by att_contact</param>
        /// <param name="filterCompanyName">Filter by company_name</param>
        /// <param name="filterAddress1">Filter by address_1</param>
        /// <param name="filterAddress2">Filter by address_2</param>
        /// <param name="filterCountryCode">Filter by country_code</param>
        /// <param name="filterState">Filter by state</param>
        /// <param name="filterZip">Filter by zip</param>
        /// <param name="filterAddressType">Filter by address_type</param>
        /// <param name="filterSearch">Filter by search</param>
        /// <returns>InlineResponse200100</returns>
        public InlineResponse200100 ShippingAddressesGet (string filterId, string filterAttContact, string filterCompanyName, string filterAddress1, string filterAddress2, string filterCountryCode, string filterState, string filterZip, string filterAddressType, string filterSearch)
        {
    
            var path = "/shipping_addresses";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterAttContact != null) queryParams.Add("filter[att_contact]", ApiClient.ParameterToString(filterAttContact)); // query parameter
 if (filterCompanyName != null) queryParams.Add("filter[company_name]", ApiClient.ParameterToString(filterCompanyName)); // query parameter
 if (filterAddress1 != null) queryParams.Add("filter[address_1]", ApiClient.ParameterToString(filterAddress1)); // query parameter
 if (filterAddress2 != null) queryParams.Add("filter[address_2]", ApiClient.ParameterToString(filterAddress2)); // query parameter
 if (filterCountryCode != null) queryParams.Add("filter[country_code]", ApiClient.ParameterToString(filterCountryCode)); // query parameter
 if (filterState != null) queryParams.Add("filter[state]", ApiClient.ParameterToString(filterState)); // query parameter
 if (filterZip != null) queryParams.Add("filter[zip]", ApiClient.ParameterToString(filterZip)); // query parameter
 if (filterAddressType != null) queryParams.Add("filter[address_type]", ApiClient.ParameterToString(filterAddressType)); // query parameter
 if (filterSearch != null) queryParams.Add("filter[search]", ApiClient.ParameterToString(filterSearch)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingAddressesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingAddressesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200100) ApiClient.Deserialize(response.Content, typeof(InlineResponse200100), response.Headers);
        }
    
        /// <summary>
        /// Delete a Shipping Address 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20099</returns>
        public InlineResponse20099 ShippingAddressesIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ShippingAddressesIdDelete");
    
            var path = "/shipping_addresses/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingAddressesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingAddressesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20099) ApiClient.Deserialize(response.Content, typeof(InlineResponse20099), response.Headers);
        }
    
        /// <summary>
        /// Show a single Shipping Address 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20099</returns>
        public InlineResponse20099 ShippingAddressesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ShippingAddressesIdGet");
    
            var path = "/shipping_addresses/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingAddressesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingAddressesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20099) ApiClient.Deserialize(response.Content, typeof(InlineResponse20099), response.Headers);
        }
    
        /// <summary>
        /// Update a Shipping Address 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20099</returns>
        public InlineResponse20099 ShippingAddressesIdPatch (ShippingAddressesIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ShippingAddressesIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ShippingAddressesIdPatch");
    
            var path = "/shipping_addresses/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingAddressesIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingAddressesIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20099) ApiClient.Deserialize(response.Content, typeof(InlineResponse20099), response.Headers);
        }
    
        /// <summary>
        /// Create a Shipping Address 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20099</returns>
        public InlineResponse20099 ShippingAddressesPost (ShippingAddressesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ShippingAddressesPost");
    
            var path = "/shipping_addresses";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingAddressesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingAddressesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20099) ApiClient.Deserialize(response.Content, typeof(InlineResponse20099), response.Headers);
        }
    
    }
}
