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
    public interface IReturnOrderApi
    {
        /// <summary>
        /// List all Return Orders 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterSecret">Filter by secret</param>
        /// <param name="filterStatus">Filter by status</param>
        /// <param name="filterPortalId">Filter by portal_id</param>
        /// <param name="filterFreeText">Filter by free_text</param>
        /// <param name="filterReturnCauses">Filter by return_causes</param>
        /// <returns>InlineResponse20092</returns>
        InlineResponse20092 ReturnsGet (string filterId, string filterSecret, string filterStatus, string filterPortalId, string filterFreeText, string filterReturnCauses);
        /// <summary>
        /// Delete a Return Order 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20091</returns>
        InlineResponse20091 ReturnsIdDelete (int? id);
        /// <summary>
        /// Show a single Return Order 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20091</returns>
        InlineResponse20091 ReturnsIdGet (int? id);
        /// <summary>
        /// Update a Return Order 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20091</returns>
        InlineResponse20091 ReturnsIdPatch (ReturnsIdBody body, int? id);
        /// <summary>
        /// Create a Return Order 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20091</returns>
        InlineResponse20091 ReturnsPost (ReturnsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReturnOrderApi : IReturnOrderApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnOrderApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReturnOrderApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnOrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReturnOrderApi(String basePath)
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
        /// List all Return Orders 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterSecret">Filter by secret</param>
        /// <param name="filterStatus">Filter by status</param>
        /// <param name="filterPortalId">Filter by portal_id</param>
        /// <param name="filterFreeText">Filter by free_text</param>
        /// <param name="filterReturnCauses">Filter by return_causes</param>
        /// <returns>InlineResponse20092</returns>
        public InlineResponse20092 ReturnsGet (string filterId, string filterSecret, string filterStatus, string filterPortalId, string filterFreeText, string filterReturnCauses)
        {
    
            var path = "/returns";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterSecret != null) queryParams.Add("filter[secret]", ApiClient.ParameterToString(filterSecret)); // query parameter
 if (filterStatus != null) queryParams.Add("filter[status]", ApiClient.ParameterToString(filterStatus)); // query parameter
 if (filterPortalId != null) queryParams.Add("filter[portal_id]", ApiClient.ParameterToString(filterPortalId)); // query parameter
 if (filterFreeText != null) queryParams.Add("filter[free_text]", ApiClient.ParameterToString(filterFreeText)); // query parameter
 if (filterReturnCauses != null) queryParams.Add("filter[return_causes]", ApiClient.ParameterToString(filterReturnCauses)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20092) ApiClient.Deserialize(response.Content, typeof(InlineResponse20092), response.Headers);
        }
    
        /// <summary>
        /// Delete a Return Order 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20091</returns>
        public InlineResponse20091 ReturnsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReturnsIdDelete");
    
            var path = "/returns/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20091) ApiClient.Deserialize(response.Content, typeof(InlineResponse20091), response.Headers);
        }
    
        /// <summary>
        /// Show a single Return Order 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20091</returns>
        public InlineResponse20091 ReturnsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReturnsIdGet");
    
            var path = "/returns/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20091) ApiClient.Deserialize(response.Content, typeof(InlineResponse20091), response.Headers);
        }
    
        /// <summary>
        /// Update a Return Order 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20091</returns>
        public InlineResponse20091 ReturnsIdPatch (ReturnsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReturnsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReturnsIdPatch");
    
            var path = "/returns/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20091) ApiClient.Deserialize(response.Content, typeof(InlineResponse20091), response.Headers);
        }
    
        /// <summary>
        /// Create a Return Order 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20091</returns>
        public InlineResponse20091 ReturnsPost (ReturnsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReturnsPost");
    
            var path = "/returns";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReturnsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20091) ApiClient.Deserialize(response.Content, typeof(InlineResponse20091), response.Headers);
        }
    
    }
}
