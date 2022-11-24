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
    public interface IUserGroupApi
    {
        /// <summary>
        /// List all User Groups 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200123</returns>
        InlineResponse200123 UserGroupsGet (string filterId);
        /// <summary>
        /// Delete a User Group 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200122</returns>
        InlineResponse200122 UserGroupsIdDelete (int? id);
        /// <summary>
        /// Show a single User Group 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200122</returns>
        InlineResponse200122 UserGroupsIdGet (int? id);
        /// <summary>
        /// Update a User Group 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200122</returns>
        InlineResponse200122 UserGroupsIdPatch (UserGroupsIdBody body, int? id);
        /// <summary>
        /// Create a User Group 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200122</returns>
        InlineResponse200122 UserGroupsPost (UserGroupsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserGroupApi : IUserGroupApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGroupApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserGroupApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGroupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserGroupApi(String basePath)
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
        /// List all User Groups 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse200123</returns>
        public InlineResponse200123 UserGroupsGet (string filterId)
        {
    
            var path = "/user_groups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200123) ApiClient.Deserialize(response.Content, typeof(InlineResponse200123), response.Headers);
        }
    
        /// <summary>
        /// Delete a User Group 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200122</returns>
        public InlineResponse200122 UserGroupsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsIdDelete");
    
            var path = "/user_groups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200122) ApiClient.Deserialize(response.Content, typeof(InlineResponse200122), response.Headers);
        }
    
        /// <summary>
        /// Show a single User Group 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200122</returns>
        public InlineResponse200122 UserGroupsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsIdGet");
    
            var path = "/user_groups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200122) ApiClient.Deserialize(response.Content, typeof(InlineResponse200122), response.Headers);
        }
    
        /// <summary>
        /// Update a User Group 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse200122</returns>
        public InlineResponse200122 UserGroupsIdPatch (UserGroupsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UserGroupsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsIdPatch");
    
            var path = "/user_groups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200122) ApiClient.Deserialize(response.Content, typeof(InlineResponse200122), response.Headers);
        }
    
        /// <summary>
        /// Create a User Group 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200122</returns>
        public InlineResponse200122 UserGroupsPost (UserGroupsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UserGroupsPost");
    
            var path = "/user_groups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200122) ApiClient.Deserialize(response.Content, typeof(InlineResponse200122), response.Headers);
        }
    
    }
}
