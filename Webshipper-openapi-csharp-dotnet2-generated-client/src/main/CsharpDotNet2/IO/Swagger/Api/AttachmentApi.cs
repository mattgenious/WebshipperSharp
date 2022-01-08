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
    public interface IAttachmentApi
    {
        /// <summary>
        /// List all Attachments 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 AttachmentsGet (string filterId);
        /// <summary>
        /// Delete a Attachment 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 AttachmentsIdDelete (int? id);
        /// <summary>
        /// Show a single Attachment 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 AttachmentsIdGet (int? id);
        /// <summary>
        /// Update a Attachment 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 AttachmentsIdPatch (AttachmentsIdBody body, int? id);
        /// <summary>
        /// Create a Attachment 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 AttachmentsPost (AttachmentsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttachmentApi : IAttachmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AttachmentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttachmentApi(String basePath)
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
        /// List all Attachments 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse2009</returns>
        public InlineResponse2009 AttachmentsGet (string filterId)
        {
    
            var path = "/attachments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AttachmentsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttachmentsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2009) ApiClient.Deserialize(response.Content, typeof(InlineResponse2009), response.Headers);
        }
    
        /// <summary>
        /// Delete a Attachment 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse2008</returns>
        public InlineResponse2008 AttachmentsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AttachmentsIdDelete");
    
            var path = "/attachments/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AttachmentsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttachmentsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2008) ApiClient.Deserialize(response.Content, typeof(InlineResponse2008), response.Headers);
        }
    
        /// <summary>
        /// Show a single Attachment 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse2008</returns>
        public InlineResponse2008 AttachmentsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AttachmentsIdGet");
    
            var path = "/attachments/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AttachmentsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttachmentsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2008) ApiClient.Deserialize(response.Content, typeof(InlineResponse2008), response.Headers);
        }
    
        /// <summary>
        /// Update a Attachment 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse2008</returns>
        public InlineResponse2008 AttachmentsIdPatch (AttachmentsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AttachmentsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AttachmentsIdPatch");
    
            var path = "/attachments/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AttachmentsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttachmentsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2008) ApiClient.Deserialize(response.Content, typeof(InlineResponse2008), response.Headers);
        }
    
        /// <summary>
        /// Create a Attachment 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse2008</returns>
        public InlineResponse2008 AttachmentsPost (AttachmentsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AttachmentsPost");
    
            var path = "/attachments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AttachmentsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttachmentsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2008) ApiClient.Deserialize(response.Content, typeof(InlineResponse2008), response.Headers);
        }
    
    }
}
