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
    public interface IEndOfDayReportApi
    {
        /// <summary>
        /// List all End-of-day reports 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20035</returns>
        InlineResponse20035 EndOfDayReportsGet (string filterId);
        /// <summary>
        /// Delete a End-of-day report 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20034</returns>
        InlineResponse20034 EndOfDayReportsIdDelete (int? id);
        /// <summary>
        /// Show a single End-of-day report 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20034</returns>
        InlineResponse20034 EndOfDayReportsIdGet (int? id);
        /// <summary>
        /// Update a End-of-day report 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20034</returns>
        InlineResponse20034 EndOfDayReportsIdPatch (EndOfDayReportsIdBody body, int? id);
        /// <summary>
        /// Create a End-of-day report 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20034</returns>
        InlineResponse20034 EndOfDayReportsPost (EndOfDayReportsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EndOfDayReportApi : IEndOfDayReportApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndOfDayReportApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EndOfDayReportApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EndOfDayReportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EndOfDayReportApi(String basePath)
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
        /// List all End-of-day reports 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20035</returns>
        public InlineResponse20035 EndOfDayReportsGet (string filterId)
        {
    
            var path = "/end_of_day_reports";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EndOfDayReportsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EndOfDayReportsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20035) ApiClient.Deserialize(response.Content, typeof(InlineResponse20035), response.Headers);
        }
    
        /// <summary>
        /// Delete a End-of-day report 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20034</returns>
        public InlineResponse20034 EndOfDayReportsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EndOfDayReportsIdDelete");
    
            var path = "/end_of_day_reports/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EndOfDayReportsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EndOfDayReportsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20034) ApiClient.Deserialize(response.Content, typeof(InlineResponse20034), response.Headers);
        }
    
        /// <summary>
        /// Show a single End-of-day report 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20034</returns>
        public InlineResponse20034 EndOfDayReportsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EndOfDayReportsIdGet");
    
            var path = "/end_of_day_reports/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EndOfDayReportsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EndOfDayReportsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20034) ApiClient.Deserialize(response.Content, typeof(InlineResponse20034), response.Headers);
        }
    
        /// <summary>
        /// Update a End-of-day report 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20034</returns>
        public InlineResponse20034 EndOfDayReportsIdPatch (EndOfDayReportsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EndOfDayReportsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EndOfDayReportsIdPatch");
    
            var path = "/end_of_day_reports/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EndOfDayReportsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EndOfDayReportsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20034) ApiClient.Deserialize(response.Content, typeof(InlineResponse20034), response.Headers);
        }
    
        /// <summary>
        /// Create a End-of-day report 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20034</returns>
        public InlineResponse20034 EndOfDayReportsPost (EndOfDayReportsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EndOfDayReportsPost");
    
            var path = "/end_of_day_reports";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EndOfDayReportsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EndOfDayReportsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20034) ApiClient.Deserialize(response.Content, typeof(InlineResponse20034), response.Headers);
        }
    
    }
}
