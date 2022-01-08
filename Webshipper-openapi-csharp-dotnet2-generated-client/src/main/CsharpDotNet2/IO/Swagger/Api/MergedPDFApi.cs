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
    public interface IMergedPDFApi
    {
        /// <summary>
        /// Show a single Merged PDF 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20058</returns>
        InlineResponse20058 PdfMergesIdGet (int? id);
        /// <summary>
        /// Create a Merged PDF 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20058</returns>
        InlineResponse20058 PdfMergesPost (PdfMergesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MergedPDFApi : IMergedPDFApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MergedPDFApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MergedPDFApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MergedPDFApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MergedPDFApi(String basePath)
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
        /// Show a single Merged PDF 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20058</returns>
        public InlineResponse20058 PdfMergesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PdfMergesIdGet");
    
            var path = "/pdf_merges/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PdfMergesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfMergesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20058) ApiClient.Deserialize(response.Content, typeof(InlineResponse20058), response.Headers);
        }
    
        /// <summary>
        /// Create a Merged PDF 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20058</returns>
        public InlineResponse20058 PdfMergesPost (PdfMergesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PdfMergesPost");
    
            var path = "/pdf_merges";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PdfMergesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfMergesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20058) ApiClient.Deserialize(response.Content, typeof(InlineResponse20058), response.Headers);
        }
    
    }
}
