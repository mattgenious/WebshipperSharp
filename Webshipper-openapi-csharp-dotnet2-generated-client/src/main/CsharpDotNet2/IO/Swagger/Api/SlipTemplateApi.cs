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
    public interface ISlipTemplateApi
    {
        /// <summary>
        /// List all Slip Templates 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterReturnsOnly">Filter by returns_only</param>
        /// <returns>InlineResponse200110</returns>
        InlineResponse200110 SlipTemplatesGet (string filterId, string filterReturnsOnly);
        /// <summary>
        /// Delete a Slip Template 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200109</returns>
        InlineResponse200109 SlipTemplatesIdDelete (int? id);
        /// <summary>
        /// Show a single Slip Template 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200109</returns>
        InlineResponse200109 SlipTemplatesIdGet (int? id);
        /// <summary>
        /// Update a Slip Template 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200109</returns>
        InlineResponse200109 SlipTemplatesIdPatch (SlipTemplatesIdBody body, int? id);
        /// <summary>
        /// Create a Slip Template 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200109</returns>
        InlineResponse200109 SlipTemplatesPost (SlipTemplatesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SlipTemplateApi : ISlipTemplateApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlipTemplateApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SlipTemplateApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SlipTemplateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SlipTemplateApi(String basePath)
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
        /// List all Slip Templates 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterReturnsOnly">Filter by returns_only</param>
        /// <returns>InlineResponse200110</returns>
        public InlineResponse200110 SlipTemplatesGet (string filterId, string filterReturnsOnly)
        {
    
            var path = "/slip_templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterReturnsOnly != null) queryParams.Add("filter[returns_only]", ApiClient.ParameterToString(filterReturnsOnly)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200110) ApiClient.Deserialize(response.Content, typeof(InlineResponse200110), response.Headers);
        }
    
        /// <summary>
        /// Delete a Slip Template 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200109</returns>
        public InlineResponse200109 SlipTemplatesIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SlipTemplatesIdDelete");
    
            var path = "/slip_templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200109) ApiClient.Deserialize(response.Content, typeof(InlineResponse200109), response.Headers);
        }
    
        /// <summary>
        /// Show a single Slip Template 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200109</returns>
        public InlineResponse200109 SlipTemplatesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SlipTemplatesIdGet");
    
            var path = "/slip_templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200109) ApiClient.Deserialize(response.Content, typeof(InlineResponse200109), response.Headers);
        }
    
        /// <summary>
        /// Update a Slip Template 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200109</returns>
        public InlineResponse200109 SlipTemplatesIdPatch (SlipTemplatesIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SlipTemplatesIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SlipTemplatesIdPatch");
    
            var path = "/slip_templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatesIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatesIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200109) ApiClient.Deserialize(response.Content, typeof(InlineResponse200109), response.Headers);
        }
    
        /// <summary>
        /// Create a Slip Template 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200109</returns>
        public InlineResponse200109 SlipTemplatesPost (SlipTemplatesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SlipTemplatesPost");
    
            var path = "/slip_templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SlipTemplatesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200109) ApiClient.Deserialize(response.Content, typeof(InlineResponse200109), response.Headers);
        }
    
    }
}
