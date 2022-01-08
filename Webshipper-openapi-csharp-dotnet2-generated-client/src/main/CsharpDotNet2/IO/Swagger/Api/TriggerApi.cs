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
    public interface ITriggerApi
    {
        /// <summary>
        /// List all Triggers 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200119</returns>
        InlineResponse200119 TriggersGet (string filterId);
        /// <summary>
        /// Delete a Trigger 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200118</returns>
        InlineResponse200118 TriggersIdDelete (int? id);
        /// <summary>
        /// Show a single Trigger 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200118</returns>
        InlineResponse200118 TriggersIdGet (int? id);
        /// <summary>
        /// Update a Trigger 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200118</returns>
        InlineResponse200118 TriggersIdPatch (TriggersIdBody body, int? id);
        /// <summary>
        /// Create a Trigger 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200118</returns>
        InlineResponse200118 TriggersPost (TriggersBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TriggerApi : ITriggerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TriggerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TriggerApi(String basePath)
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
        /// List all Triggers 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200119</returns>
        public InlineResponse200119 TriggersGet (string filterId)
        {
    
            var path = "/triggers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TriggersGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TriggersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200119) ApiClient.Deserialize(response.Content, typeof(InlineResponse200119), response.Headers);
        }
    
        /// <summary>
        /// Delete a Trigger 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200118</returns>
        public InlineResponse200118 TriggersIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TriggersIdDelete");
    
            var path = "/triggers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TriggersIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TriggersIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200118) ApiClient.Deserialize(response.Content, typeof(InlineResponse200118), response.Headers);
        }
    
        /// <summary>
        /// Show a single Trigger 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200118</returns>
        public InlineResponse200118 TriggersIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TriggersIdGet");
    
            var path = "/triggers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TriggersIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TriggersIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200118) ApiClient.Deserialize(response.Content, typeof(InlineResponse200118), response.Headers);
        }
    
        /// <summary>
        /// Update a Trigger 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200118</returns>
        public InlineResponse200118 TriggersIdPatch (TriggersIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling TriggersIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TriggersIdPatch");
    
            var path = "/triggers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TriggersIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TriggersIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200118) ApiClient.Deserialize(response.Content, typeof(InlineResponse200118), response.Headers);
        }
    
        /// <summary>
        /// Create a Trigger 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200118</returns>
        public InlineResponse200118 TriggersPost (TriggersBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling TriggersPost");
    
            var path = "/triggers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TriggersPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TriggersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200118) ApiClient.Deserialize(response.Content, typeof(InlineResponse200118), response.Headers);
        }
    
    }
}
