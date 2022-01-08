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
    public interface ICustomsLineApi
    {
        /// <summary>
        /// List all Customs Lines 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20029</returns>
        InlineResponse20029 CustomsLinesGet (string filterId);
        /// <summary>
        /// Delete a Customs Line 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20028</returns>
        InlineResponse20028 CustomsLinesIdDelete (int? id);
        /// <summary>
        /// Show a single Customs Line 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20028</returns>
        InlineResponse20028 CustomsLinesIdGet (int? id);
        /// <summary>
        /// Update a Customs Line 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20028</returns>
        InlineResponse20028 CustomsLinesIdPatch (CustomsLinesIdBody body, int? id);
        /// <summary>
        /// Create a Customs Line 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20028</returns>
        InlineResponse20028 CustomsLinesPost (CustomsLinesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomsLineApi : ICustomsLineApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsLineApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CustomsLineApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsLineApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomsLineApi(String basePath)
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
        /// List all Customs Lines 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20029</returns>
        public InlineResponse20029 CustomsLinesGet (string filterId)
        {
    
            var path = "/customs_lines";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CustomsLinesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CustomsLinesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20029) ApiClient.Deserialize(response.Content, typeof(InlineResponse20029), response.Headers);
        }
    
        /// <summary>
        /// Delete a Customs Line 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20028</returns>
        public InlineResponse20028 CustomsLinesIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CustomsLinesIdDelete");
    
            var path = "/customs_lines/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CustomsLinesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CustomsLinesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20028) ApiClient.Deserialize(response.Content, typeof(InlineResponse20028), response.Headers);
        }
    
        /// <summary>
        /// Show a single Customs Line 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20028</returns>
        public InlineResponse20028 CustomsLinesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CustomsLinesIdGet");
    
            var path = "/customs_lines/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CustomsLinesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CustomsLinesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20028) ApiClient.Deserialize(response.Content, typeof(InlineResponse20028), response.Headers);
        }
    
        /// <summary>
        /// Update a Customs Line 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20028</returns>
        public InlineResponse20028 CustomsLinesIdPatch (CustomsLinesIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CustomsLinesIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CustomsLinesIdPatch");
    
            var path = "/customs_lines/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CustomsLinesIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CustomsLinesIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20028) ApiClient.Deserialize(response.Content, typeof(InlineResponse20028), response.Headers);
        }
    
        /// <summary>
        /// Create a Customs Line 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20028</returns>
        public InlineResponse20028 CustomsLinesPost (CustomsLinesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CustomsLinesPost");
    
            var path = "/customs_lines";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CustomsLinesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CustomsLinesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20028) ApiClient.Deserialize(response.Content, typeof(InlineResponse20028), response.Headers);
        }
    
    }
}
