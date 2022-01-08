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
    public interface ISlipTemplatePreviewApi
    {
        /// <summary>
        /// List all Slip Template Previews 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200112</returns>
        InlineResponse200112 SlipTemplatePreviewsGet (string filterId);
        /// <summary>
        /// Delete a Slip Template Preview 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200111</returns>
        InlineResponse200111 SlipTemplatePreviewsIdDelete (int? id);
        /// <summary>
        /// Show a single Slip Template Preview 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200111</returns>
        InlineResponse200111 SlipTemplatePreviewsIdGet (int? id);
        /// <summary>
        /// Update a Slip Template Preview 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200111</returns>
        InlineResponse200111 SlipTemplatePreviewsIdPatch (SlipTemplatePreviewsIdBody body, int? id);
        /// <summary>
        /// Create a Slip Template Preview 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200111</returns>
        InlineResponse200111 SlipTemplatePreviewsPost (SlipTemplatePreviewsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SlipTemplatePreviewApi : ISlipTemplatePreviewApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlipTemplatePreviewApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SlipTemplatePreviewApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SlipTemplatePreviewApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SlipTemplatePreviewApi(String basePath)
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
        /// List all Slip Template Previews 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200112</returns>
        public InlineResponse200112 SlipTemplatePreviewsGet (string filterId)
        {
    
            var path = "/slip_template_previews";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatePreviewsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatePreviewsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200112) ApiClient.Deserialize(response.Content, typeof(InlineResponse200112), response.Headers);
        }
    
        /// <summary>
        /// Delete a Slip Template Preview 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200111</returns>
        public InlineResponse200111 SlipTemplatePreviewsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SlipTemplatePreviewsIdDelete");
    
            var path = "/slip_template_previews/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatePreviewsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatePreviewsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200111) ApiClient.Deserialize(response.Content, typeof(InlineResponse200111), response.Headers);
        }
    
        /// <summary>
        /// Show a single Slip Template Preview 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200111</returns>
        public InlineResponse200111 SlipTemplatePreviewsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SlipTemplatePreviewsIdGet");
    
            var path = "/slip_template_previews/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatePreviewsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatePreviewsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200111) ApiClient.Deserialize(response.Content, typeof(InlineResponse200111), response.Headers);
        }
    
        /// <summary>
        /// Update a Slip Template Preview 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200111</returns>
        public InlineResponse200111 SlipTemplatePreviewsIdPatch (SlipTemplatePreviewsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SlipTemplatePreviewsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SlipTemplatePreviewsIdPatch");
    
            var path = "/slip_template_previews/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatePreviewsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatePreviewsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200111) ApiClient.Deserialize(response.Content, typeof(InlineResponse200111), response.Headers);
        }
    
        /// <summary>
        /// Create a Slip Template Preview 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200111</returns>
        public InlineResponse200111 SlipTemplatePreviewsPost (SlipTemplatePreviewsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SlipTemplatePreviewsPost");
    
            var path = "/slip_template_previews";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatePreviewsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatePreviewsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200111) ApiClient.Deserialize(response.Content, typeof(InlineResponse200111), response.Headers);
        }
    
    }
}
