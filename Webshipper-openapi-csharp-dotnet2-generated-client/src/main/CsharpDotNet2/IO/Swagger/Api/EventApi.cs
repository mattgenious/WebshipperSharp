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
    public interface IEventApi
    {
        /// <summary>
        /// List all Events 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20039</returns>
        InlineResponse20039 EventsGet (string filterId);
        /// <summary>
        /// Delete a Event 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20038</returns>
        InlineResponse20038 EventsIdDelete (int? id);
        /// <summary>
        /// Show a single Event 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20038</returns>
        InlineResponse20038 EventsIdGet (int? id);
        /// <summary>
        /// Update a Event 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20038</returns>
        InlineResponse20038 EventsIdPatch (EventsIdBody body, int? id);
        /// <summary>
        /// Create a Event 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20038</returns>
        InlineResponse20038 EventsPost (EventsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EventApi : IEventApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EventApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventApi(String basePath)
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
        /// List all Events 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20039</returns>
        public InlineResponse20039 EventsGet (string filterId)
        {
    
            var path = "/events";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20039) ApiClient.Deserialize(response.Content, typeof(InlineResponse20039), response.Headers);
        }
    
        /// <summary>
        /// Delete a Event 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20038</returns>
        public InlineResponse20038 EventsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EventsIdDelete");
    
            var path = "/events/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20038) ApiClient.Deserialize(response.Content, typeof(InlineResponse20038), response.Headers);
        }
    
        /// <summary>
        /// Show a single Event 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20038</returns>
        public InlineResponse20038 EventsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EventsIdGet");
    
            var path = "/events/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20038) ApiClient.Deserialize(response.Content, typeof(InlineResponse20038), response.Headers);
        }
    
        /// <summary>
        /// Update a Event 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20038</returns>
        public InlineResponse20038 EventsIdPatch (EventsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EventsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EventsIdPatch");
    
            var path = "/events/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20038) ApiClient.Deserialize(response.Content, typeof(InlineResponse20038), response.Headers);
        }
    
        /// <summary>
        /// Create a Event 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20038</returns>
        public InlineResponse20038 EventsPost (EventsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EventsPost");
    
            var path = "/events";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20038) ApiClient.Deserialize(response.Content, typeof(InlineResponse20038), response.Headers);
        }
    
    }
}
