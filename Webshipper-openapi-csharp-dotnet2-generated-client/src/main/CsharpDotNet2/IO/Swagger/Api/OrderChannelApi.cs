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
    public interface IOrderChannelApi
    {
        /// <summary>
        /// List all Order Channels 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterAttr">Filter by attr</param>
        /// <returns>InlineResponse20066</returns>
        InlineResponse20066 OrderChannelsGet (string filterId, string filterAttr);
        /// <summary>
        /// Delete a Order Channel 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20065</returns>
        InlineResponse20065 OrderChannelsIdDelete (int? id);
        /// <summary>
        /// Show a single Order Channel 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20065</returns>
        InlineResponse20065 OrderChannelsIdGet (int? id);
        /// <summary>
        /// Update a Order Channel 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20065</returns>
        InlineResponse20065 OrderChannelsIdPatch (OrderChannelsIdBody body, int? id);
        /// <summary>
        /// Create a Order Channel 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20065</returns>
        InlineResponse20065 OrderChannelsPost (OrderChannelsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderChannelApi : IOrderChannelApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderChannelApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderChannelApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderChannelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderChannelApi(String basePath)
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
        /// List all Order Channels 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterAttr">Filter by attr</param>
        /// <returns>InlineResponse20066</returns>
        public InlineResponse20066 OrderChannelsGet (string filterId, string filterAttr)
        {
    
            var path = "/order_channels";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterAttr != null) queryParams.Add("filter[attr]", ApiClient.ParameterToString(filterAttr)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChannelsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChannelsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20066) ApiClient.Deserialize(response.Content, typeof(InlineResponse20066), response.Headers);
        }
    
        /// <summary>
        /// Delete a Order Channel 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20065</returns>
        public InlineResponse20065 OrderChannelsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderChannelsIdDelete");
    
            var path = "/order_channels/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChannelsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChannelsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20065) ApiClient.Deserialize(response.Content, typeof(InlineResponse20065), response.Headers);
        }
    
        /// <summary>
        /// Show a single Order Channel 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20065</returns>
        public InlineResponse20065 OrderChannelsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderChannelsIdGet");
    
            var path = "/order_channels/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChannelsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChannelsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20065) ApiClient.Deserialize(response.Content, typeof(InlineResponse20065), response.Headers);
        }
    
        /// <summary>
        /// Update a Order Channel 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20065</returns>
        public InlineResponse20065 OrderChannelsIdPatch (OrderChannelsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling OrderChannelsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OrderChannelsIdPatch");
    
            var path = "/order_channels/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChannelsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChannelsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20065) ApiClient.Deserialize(response.Content, typeof(InlineResponse20065), response.Headers);
        }
    
        /// <summary>
        /// Create a Order Channel 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20065</returns>
        public InlineResponse20065 OrderChannelsPost (OrderChannelsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling OrderChannelsPost");
    
            var path = "/order_channels";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChannelsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChannelsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20065) ApiClient.Deserialize(response.Content, typeof(InlineResponse20065), response.Headers);
        }
    
    }
}
