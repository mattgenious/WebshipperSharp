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
    public interface ITrackingEventApi
    {
        /// <summary>
        /// List all Tracking Events 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterCreatedAt">Filter by created_at</param>
        /// <returns>InlineResponse200117</returns>
        InlineResponse200117 TrackingEventsGet (string filterId, string filterCreatedAt);
        /// <summary>
        /// Show a single Tracking Event 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200116</returns>
        InlineResponse200116 TrackingEventsIdGet (int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TrackingEventApi : ITrackingEventApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEventApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TrackingEventApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEventApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TrackingEventApi(String basePath)
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
        /// List all Tracking Events 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterCreatedAt">Filter by created_at</param>
        /// <returns>InlineResponse200117</returns>
        public InlineResponse200117 TrackingEventsGet (string filterId, string filterCreatedAt)
        {
    
            var path = "/tracking_events";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterCreatedAt != null) queryParams.Add("filter[created_at]", ApiClient.ParameterToString(filterCreatedAt)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingEventsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingEventsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200117) ApiClient.Deserialize(response.Content, typeof(InlineResponse200117), response.Headers);
        }
    
        /// <summary>
        /// Show a single Tracking Event 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse200116</returns>
        public InlineResponse200116 TrackingEventsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TrackingEventsIdGet");
    
            var path = "/tracking_events/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingEventsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingEventsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200116) ApiClient.Deserialize(response.Content, typeof(InlineResponse200116), response.Headers);
        }
    
    }
}
