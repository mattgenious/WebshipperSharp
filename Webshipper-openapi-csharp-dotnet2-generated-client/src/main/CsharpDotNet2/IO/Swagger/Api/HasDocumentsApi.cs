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
    public interface IHasDocumentsApi
    {
        /// <summary>
        /// List all Has Documentss 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20045</returns>
        InlineResponse20045 HasDocumentsGet (string filterId);
        /// <summary>
        /// Delete a Has Documents 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20044</returns>
        InlineResponse20044 HasDocumentsIdDelete (int? id);
        /// <summary>
        /// Show a single Has Documents 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20044</returns>
        InlineResponse20044 HasDocumentsIdGet (int? id);
        /// <summary>
        /// Update a Has Documents 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20044</returns>
        InlineResponse20044 HasDocumentsIdPatch (HasDocumentsIdBody body, int? id);
        /// <summary>
        /// Create a Has Documents 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20044</returns>
        InlineResponse20044 HasDocumentsPost (HasDocumentsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HasDocumentsApi : IHasDocumentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HasDocumentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HasDocumentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HasDocumentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HasDocumentsApi(String basePath)
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
        /// List all Has Documentss 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20045</returns>
        public InlineResponse20045 HasDocumentsGet (string filterId)
        {
    
            var path = "/has_documents";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HasDocumentsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HasDocumentsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20045) ApiClient.Deserialize(response.Content, typeof(InlineResponse20045), response.Headers);
        }
    
        /// <summary>
        /// Delete a Has Documents 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20044</returns>
        public InlineResponse20044 HasDocumentsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HasDocumentsIdDelete");
    
            var path = "/has_documents/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HasDocumentsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HasDocumentsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20044) ApiClient.Deserialize(response.Content, typeof(InlineResponse20044), response.Headers);
        }
    
        /// <summary>
        /// Show a single Has Documents 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20044</returns>
        public InlineResponse20044 HasDocumentsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HasDocumentsIdGet");
    
            var path = "/has_documents/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HasDocumentsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HasDocumentsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20044) ApiClient.Deserialize(response.Content, typeof(InlineResponse20044), response.Headers);
        }
    
        /// <summary>
        /// Update a Has Documents 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20044</returns>
        public InlineResponse20044 HasDocumentsIdPatch (HasDocumentsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling HasDocumentsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HasDocumentsIdPatch");
    
            var path = "/has_documents/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HasDocumentsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HasDocumentsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20044) ApiClient.Deserialize(response.Content, typeof(InlineResponse20044), response.Headers);
        }
    
        /// <summary>
        /// Create a Has Documents 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20044</returns>
        public InlineResponse20044 HasDocumentsPost (HasDocumentsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling HasDocumentsPost");
    
            var path = "/has_documents";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HasDocumentsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HasDocumentsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20044) ApiClient.Deserialize(response.Content, typeof(InlineResponse20044), response.Headers);
        }
    
    }
}
