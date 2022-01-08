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
    public interface IErrorTypeApi
    {
        /// <summary>
        /// List all Error Types 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20037</returns>
        InlineResponse20037 ErrorTypesGet (string filterId);
        /// <summary>
        /// Delete a Error Type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20036</returns>
        InlineResponse20036 ErrorTypesIdDelete (int? id);
        /// <summary>
        /// Show a single Error Type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20036</returns>
        InlineResponse20036 ErrorTypesIdGet (int? id);
        /// <summary>
        /// Update a Error Type 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20036</returns>
        InlineResponse20036 ErrorTypesIdPatch (ErrorTypesIdBody body, int? id);
        /// <summary>
        /// Create a Error Type 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20036</returns>
        InlineResponse20036 ErrorTypesPost (ErrorTypesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ErrorTypeApi : IErrorTypeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorTypeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ErrorTypeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ErrorTypeApi(String basePath)
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
        /// List all Error Types 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20037</returns>
        public InlineResponse20037 ErrorTypesGet (string filterId)
        {
    
            var path = "/error_types";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ErrorTypesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ErrorTypesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20037) ApiClient.Deserialize(response.Content, typeof(InlineResponse20037), response.Headers);
        }
    
        /// <summary>
        /// Delete a Error Type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20036</returns>
        public InlineResponse20036 ErrorTypesIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ErrorTypesIdDelete");
    
            var path = "/error_types/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ErrorTypesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ErrorTypesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20036) ApiClient.Deserialize(response.Content, typeof(InlineResponse20036), response.Headers);
        }
    
        /// <summary>
        /// Show a single Error Type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20036</returns>
        public InlineResponse20036 ErrorTypesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ErrorTypesIdGet");
    
            var path = "/error_types/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ErrorTypesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ErrorTypesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20036) ApiClient.Deserialize(response.Content, typeof(InlineResponse20036), response.Headers);
        }
    
        /// <summary>
        /// Update a Error Type 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20036</returns>
        public InlineResponse20036 ErrorTypesIdPatch (ErrorTypesIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ErrorTypesIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ErrorTypesIdPatch");
    
            var path = "/error_types/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ErrorTypesIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ErrorTypesIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20036) ApiClient.Deserialize(response.Content, typeof(InlineResponse20036), response.Headers);
        }
    
        /// <summary>
        /// Create a Error Type 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20036</returns>
        public InlineResponse20036 ErrorTypesPost (ErrorTypesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ErrorTypesPost");
    
            var path = "/error_types";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ErrorTypesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ErrorTypesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20036) ApiClient.Deserialize(response.Content, typeof(InlineResponse20036), response.Headers);
        }
    
    }
}
