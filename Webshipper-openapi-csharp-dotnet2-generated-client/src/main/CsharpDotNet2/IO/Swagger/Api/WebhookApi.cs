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
    public interface IWebhookApi
    {
        /// <summary>
        /// List all Webhooks 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200127</returns>
        InlineResponse200127 WebhooksGet (string filterId);
        /// <summary>
        /// Delete a Webhook 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200126</returns>
        InlineResponse200126 WebhooksIdDelete (int? id);
        /// <summary>
        /// Show a single Webhook 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200126</returns>
        InlineResponse200126 WebhooksIdGet (int? id);
        /// <summary>
        /// Update a Webhook 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200126</returns>
        InlineResponse200126 WebhooksIdPatch (WebhooksIdBody body, int? id);
        /// <summary>
        /// Create a Webhook 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200126</returns>
        InlineResponse200126 WebhooksPost (WebhooksBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebhookApi : IWebhookApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WebhookApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebhookApi(String basePath)
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
        /// List all Webhooks 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200127</returns>
        public InlineResponse200127 WebhooksGet (string filterId)
        {
    
            var path = "/webhooks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WebhooksGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WebhooksGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200127) ApiClient.Deserialize(response.Content, typeof(InlineResponse200127), response.Headers);
        }
    
        /// <summary>
        /// Delete a Webhook 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200126</returns>
        public InlineResponse200126 WebhooksIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WebhooksIdDelete");
    
            var path = "/webhooks/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WebhooksIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WebhooksIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200126) ApiClient.Deserialize(response.Content, typeof(InlineResponse200126), response.Headers);
        }
    
        /// <summary>
        /// Show a single Webhook 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200126</returns>
        public InlineResponse200126 WebhooksIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WebhooksIdGet");
    
            var path = "/webhooks/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WebhooksIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WebhooksIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200126) ApiClient.Deserialize(response.Content, typeof(InlineResponse200126), response.Headers);
        }
    
        /// <summary>
        /// Update a Webhook 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200126</returns>
        public InlineResponse200126 WebhooksIdPatch (WebhooksIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling WebhooksIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WebhooksIdPatch");
    
            var path = "/webhooks/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WebhooksIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WebhooksIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200126) ApiClient.Deserialize(response.Content, typeof(InlineResponse200126), response.Headers);
        }
    
        /// <summary>
        /// Create a Webhook 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200126</returns>
        public InlineResponse200126 WebhooksPost (WebhooksBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling WebhooksPost");
    
            var path = "/webhooks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WebhooksPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WebhooksPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200126) ApiClient.Deserialize(response.Content, typeof(InlineResponse200126), response.Headers);
        }
    
    }
}
