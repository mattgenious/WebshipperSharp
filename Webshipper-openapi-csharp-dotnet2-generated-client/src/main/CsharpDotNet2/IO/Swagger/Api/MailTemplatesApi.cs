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
    public interface IMailTemplatesApi
    {
        /// <summary>
        /// List all Mail Templatess 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterPurpose">Filter by purpose</param>
        /// <returns>InlineResponse20057</returns>
        InlineResponse20057 MailTemplatesGet (string filterId, string filterPurpose);
        /// <summary>
        /// Delete a Mail Templates 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20056</returns>
        InlineResponse20056 MailTemplatesIdDelete (int? id);
        /// <summary>
        /// Show a single Mail Templates 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20056</returns>
        InlineResponse20056 MailTemplatesIdGet (int? id);
        /// <summary>
        /// Update a Mail Templates 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20056</returns>
        InlineResponse20056 MailTemplatesIdPatch (MailTemplatesIdBody body, int? id);
        /// <summary>
        /// Create a Mail Templates 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20056</returns>
        InlineResponse20056 MailTemplatesPost (MailTemplatesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MailTemplatesApi : IMailTemplatesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailTemplatesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MailTemplatesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MailTemplatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MailTemplatesApi(String basePath)
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
        /// List all Mail Templatess 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterPurpose">Filter by purpose</param>
        /// <returns>InlineResponse20057</returns>
        public InlineResponse20057 MailTemplatesGet (string filterId, string filterPurpose)
        {
    
            var path = "/mail_templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterPurpose != null) queryParams.Add("filter[purpose]", ApiClient.ParameterToString(filterPurpose)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20057) ApiClient.Deserialize(response.Content, typeof(InlineResponse20057), response.Headers);
        }
    
        /// <summary>
        /// Delete a Mail Templates 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20056</returns>
        public InlineResponse20056 MailTemplatesIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MailTemplatesIdDelete");
    
            var path = "/mail_templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20056) ApiClient.Deserialize(response.Content, typeof(InlineResponse20056), response.Headers);
        }
    
        /// <summary>
        /// Show a single Mail Templates 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20056</returns>
        public InlineResponse20056 MailTemplatesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MailTemplatesIdGet");
    
            var path = "/mail_templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20056) ApiClient.Deserialize(response.Content, typeof(InlineResponse20056), response.Headers);
        }
    
        /// <summary>
        /// Update a Mail Templates 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20056</returns>
        public InlineResponse20056 MailTemplatesIdPatch (MailTemplatesIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling MailTemplatesIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MailTemplatesIdPatch");
    
            var path = "/mail_templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatesIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatesIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20056) ApiClient.Deserialize(response.Content, typeof(InlineResponse20056), response.Headers);
        }
    
        /// <summary>
        /// Create a Mail Templates 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20056</returns>
        public InlineResponse20056 MailTemplatesPost (MailTemplatesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling MailTemplatesPost");
    
            var path = "/mail_templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MailTemplatesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20056) ApiClient.Deserialize(response.Content, typeof(InlineResponse20056), response.Headers);
        }
    
    }
}
