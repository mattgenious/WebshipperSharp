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
    public interface IWebhookFailureApi
    {
        /// <summary>
        /// List all Webhook Failures 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200129</returns>
        InlineResponse200129 WebhookFailuresGet (string filterId);
        /// <summary>
        /// Delete a Webhook Failure 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200128</returns>
        InlineResponse200128 WebhookFailuresIdDelete (int? id);
        /// <summary>
        /// Show a single Webhook Failure 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200128</returns>
        InlineResponse200128 WebhookFailuresIdGet (int? id);
        /// <summary>
        /// Update a Webhook Failure 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200128</returns>
        InlineResponse200128 WebhookFailuresIdPatch (WebhookFailuresIdBody body, int? id);
        /// <summary>
        /// Create a Webhook Failure 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200128</returns>
        InlineResponse200128 WebhookFailuresPost (WebhookFailuresBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebhookFailureApi : IWebhookFailureApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookFailureApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WebhookFailureApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookFailureApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebhookFailureApi(String basePath)
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
        /// List all Webhook Failures 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200129</returns>
        public InlineResponse200129 WebhookFailuresGet (string filterId)
        {
    
            var path = "/webhook_failures";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WebhookFailuresGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WebhookFailuresGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200129) ApiClient.Deserialize(response.Content, typeof(InlineResponse200129), response.Headers);
        }
    
        /// <summary>
        /// Delete a Webhook Failure 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200128</returns>
        public InlineResponse200128 WebhookFailuresIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WebhookFailuresIdDelete");
    
            var path = "/webhook_failures/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WebhookFailuresIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WebhookFailuresIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200128) ApiClient.Deserialize(response.Content, typeof(InlineResponse200128), response.Headers);
        }
    
        /// <summary>
        /// Show a single Webhook Failure 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200128</returns>
        public InlineResponse200128 WebhookFailuresIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WebhookFailuresIdGet");
    
            var path = "/webhook_failures/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WebhookFailuresIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WebhookFailuresIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200128) ApiClient.Deserialize(response.Content, typeof(InlineResponse200128), response.Headers);
        }
    
        /// <summary>
        /// Update a Webhook Failure 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200128</returns>
        public InlineResponse200128 WebhookFailuresIdPatch (WebhookFailuresIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling WebhookFailuresIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WebhookFailuresIdPatch");
    
            var path = "/webhook_failures/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WebhookFailuresIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WebhookFailuresIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200128) ApiClient.Deserialize(response.Content, typeof(InlineResponse200128), response.Headers);
        }
    
        /// <summary>
        /// Create a Webhook Failure 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200128</returns>
        public InlineResponse200128 WebhookFailuresPost (WebhookFailuresBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling WebhookFailuresPost");
    
            var path = "/webhook_failures";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WebhookFailuresPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WebhookFailuresPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200128) ApiClient.Deserialize(response.Content, typeof(InlineResponse200128), response.Headers);
        }
    
    }
}
