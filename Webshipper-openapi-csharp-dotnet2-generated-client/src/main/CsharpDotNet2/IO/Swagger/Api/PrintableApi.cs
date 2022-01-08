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
    public interface IPrintableApi
    {
        /// <summary>
        /// List all Printables 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20078</returns>
        InlineResponse20078 PrintablesGet (string filterId);
        /// <summary>
        /// Delete a Printable 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20077</returns>
        InlineResponse20077 PrintablesIdDelete (int? id);
        /// <summary>
        /// Show a single Printable 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20077</returns>
        InlineResponse20077 PrintablesIdGet (int? id);
        /// <summary>
        /// Update a Printable 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20077</returns>
        InlineResponse20077 PrintablesIdPatch (PrintablesIdBody body, int? id);
        /// <summary>
        /// Create a Printable 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20077</returns>
        InlineResponse20077 PrintablesPost (PrintablesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PrintableApi : IPrintableApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintableApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PrintableApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintableApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PrintableApi(String basePath)
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
        /// List all Printables 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20078</returns>
        public InlineResponse20078 PrintablesGet (string filterId)
        {
    
            var path = "/printables";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrintablesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrintablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20078) ApiClient.Deserialize(response.Content, typeof(InlineResponse20078), response.Headers);
        }
    
        /// <summary>
        /// Delete a Printable 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20077</returns>
        public InlineResponse20077 PrintablesIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PrintablesIdDelete");
    
            var path = "/printables/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrintablesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrintablesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20077) ApiClient.Deserialize(response.Content, typeof(InlineResponse20077), response.Headers);
        }
    
        /// <summary>
        /// Show a single Printable 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20077</returns>
        public InlineResponse20077 PrintablesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PrintablesIdGet");
    
            var path = "/printables/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrintablesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrintablesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20077) ApiClient.Deserialize(response.Content, typeof(InlineResponse20077), response.Headers);
        }
    
        /// <summary>
        /// Update a Printable 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20077</returns>
        public InlineResponse20077 PrintablesIdPatch (PrintablesIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PrintablesIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PrintablesIdPatch");
    
            var path = "/printables/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrintablesIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrintablesIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20077) ApiClient.Deserialize(response.Content, typeof(InlineResponse20077), response.Headers);
        }
    
        /// <summary>
        /// Create a Printable 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20077</returns>
        public InlineResponse20077 PrintablesPost (PrintablesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PrintablesPost");
    
            var path = "/printables";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrintablesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrintablesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20077) ApiClient.Deserialize(response.Content, typeof(InlineResponse20077), response.Headers);
        }
    
    }
}
