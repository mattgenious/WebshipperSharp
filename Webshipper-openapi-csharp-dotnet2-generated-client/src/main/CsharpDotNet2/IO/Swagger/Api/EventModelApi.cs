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
    public interface IEventModelApi
    {
        /// <summary>
        /// List all EventModels 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20041</returns>
        InlineResponse20041 EventModelsGet (string filterId);
        /// <summary>
        /// Delete a EventModel 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20040</returns>
        InlineResponse20040 EventModelsIdDelete (int? id);
        /// <summary>
        /// Show a single EventModel 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20040</returns>
        InlineResponse20040 EventModelsIdGet (int? id);
        /// <summary>
        /// Update a EventModel 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20040</returns>
        InlineResponse20040 EventModelsIdPatch (EventModelsIdBody body, int? id);
        /// <summary>
        /// Create a EventModel 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20040</returns>
        InlineResponse20040 EventModelsPost (EventModelsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EventModelApi : IEventModelApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventModelApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EventModelApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventModelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventModelApi(String basePath)
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
        /// List all EventModels 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20041</returns>
        public InlineResponse20041 EventModelsGet (string filterId)
        {
    
            var path = "/event_models";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventModelsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventModelsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20041) ApiClient.Deserialize(response.Content, typeof(InlineResponse20041), response.Headers);
        }
    
        /// <summary>
        /// Delete a EventModel 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20040</returns>
        public InlineResponse20040 EventModelsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EventModelsIdDelete");
    
            var path = "/event_models/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventModelsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventModelsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20040) ApiClient.Deserialize(response.Content, typeof(InlineResponse20040), response.Headers);
        }
    
        /// <summary>
        /// Show a single EventModel 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20040</returns>
        public InlineResponse20040 EventModelsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EventModelsIdGet");
    
            var path = "/event_models/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventModelsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventModelsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20040) ApiClient.Deserialize(response.Content, typeof(InlineResponse20040), response.Headers);
        }
    
        /// <summary>
        /// Update a EventModel 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20040</returns>
        public InlineResponse20040 EventModelsIdPatch (EventModelsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EventModelsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EventModelsIdPatch");
    
            var path = "/event_models/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventModelsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventModelsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20040) ApiClient.Deserialize(response.Content, typeof(InlineResponse20040), response.Headers);
        }
    
        /// <summary>
        /// Create a EventModel 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20040</returns>
        public InlineResponse20040 EventModelsPost (EventModelsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EventModelsPost");
    
            var path = "/event_models";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventModelsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventModelsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20040) ApiClient.Deserialize(response.Content, typeof(InlineResponse20040), response.Headers);
        }
    
    }
}
