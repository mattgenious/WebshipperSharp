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
    public interface IActionApi
    {
        /// <summary>
        /// List all Actions 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 ActionsGet (string filterId);
        /// <summary>
        /// Delete a Action 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 ActionsIdDelete (int? id);
        /// <summary>
        /// Show a single Action 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 ActionsIdGet (int? id);
        /// <summary>
        /// Update a Action 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 ActionsIdPatch (ActionsIdBody body, int? id);
        /// <summary>
        /// Create a Action 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 ActionsPost (ActionsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ActionApi : IActionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ActionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActionApi(String basePath)
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
        /// List all Actions 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 ActionsGet (string filterId)
        {
    
            var path = "/actions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2005) ApiClient.Deserialize(response.Content, typeof(InlineResponse2005), response.Headers);
        }
    
        /// <summary>
        /// Delete a Action 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse2004</returns>
        public InlineResponse2004 ActionsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ActionsIdDelete");
    
            var path = "/actions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
        /// <summary>
        /// Show a single Action 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse2004</returns>
        public InlineResponse2004 ActionsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ActionsIdGet");
    
            var path = "/actions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
        /// <summary>
        /// Update a Action 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse2004</returns>
        public InlineResponse2004 ActionsIdPatch (ActionsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ActionsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ActionsIdPatch");
    
            var path = "/actions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
        /// <summary>
        /// Create a Action 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse2004</returns>
        public InlineResponse2004 ActionsPost (ActionsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ActionsPost");
    
            var path = "/actions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
    }
}
