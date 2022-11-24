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
    public interface IMailTemplatePreviewApi
    {
        /// <summary>
        /// List all Mail Template Previews 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20055</returns>
        InlineResponse20055 MailTemplatePreviewsGet (string filterId);
        /// <summary>
        /// Delete a Mail Template Preview 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20054</returns>
        InlineResponse20054 MailTemplatePreviewsIdDelete (int? id);
        /// <summary>
        /// Show a single Mail Template Preview 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20054</returns>
        InlineResponse20054 MailTemplatePreviewsIdGet (int? id);
        /// <summary>
        /// Update a Mail Template Preview 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20054</returns>
        InlineResponse20054 MailTemplatePreviewsIdPatch (MailTemplatePreviewsIdBody body, int? id);
        /// <summary>
        /// Create a Mail Template Preview 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20054</returns>
        InlineResponse20054 MailTemplatePreviewsPost (MailTemplatePreviewsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MailTemplatePreviewApi : IMailTemplatePreviewApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailTemplatePreviewApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MailTemplatePreviewApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MailTemplatePreviewApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MailTemplatePreviewApi(String basePath)
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
        /// List all Mail Template Previews 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20055</returns>
        public InlineResponse20055 MailTemplatePreviewsGet (string filterId)
        {
    
            var path = "/mail_template_previews";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatePreviewsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatePreviewsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20055) ApiClient.Deserialize(response.Content, typeof(InlineResponse20055), response.Headers);
        }
    
        /// <summary>
        /// Delete a Mail Template Preview 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20054</returns>
        public InlineResponse20054 MailTemplatePreviewsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MailTemplatePreviewsIdDelete");
    
            var path = "/mail_template_previews/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatePreviewsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatePreviewsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20054) ApiClient.Deserialize(response.Content, typeof(InlineResponse20054), response.Headers);
        }
    
        /// <summary>
        /// Show a single Mail Template Preview 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20054</returns>
        public InlineResponse20054 MailTemplatePreviewsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MailTemplatePreviewsIdGet");
    
            var path = "/mail_template_previews/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatePreviewsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatePreviewsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20054) ApiClient.Deserialize(response.Content, typeof(InlineResponse20054), response.Headers);
        }
    
        /// <summary>
        /// Update a Mail Template Preview 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20054</returns>
        public InlineResponse20054 MailTemplatePreviewsIdPatch (MailTemplatePreviewsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling MailTemplatePreviewsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MailTemplatePreviewsIdPatch");
    
            var path = "/mail_template_previews/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatePreviewsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatePreviewsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20054) ApiClient.Deserialize(response.Content, typeof(InlineResponse20054), response.Headers);
        }
    
        /// <summary>
        /// Create a Mail Template Preview 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20054</returns>
        public InlineResponse20054 MailTemplatePreviewsPost (MailTemplatePreviewsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling MailTemplatePreviewsPost");
    
            var path = "/mail_template_previews";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatePreviewsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatePreviewsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20054) ApiClient.Deserialize(response.Content, typeof(InlineResponse20054), response.Headers);
        }
    
    }
}
