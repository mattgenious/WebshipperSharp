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
    public interface IPrinterClientApi
    {
        /// <summary>
        /// List all Printer Clients 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20082</returns>
        InlineResponse20082 PrinterClientsGet (string filterId);
        /// <summary>
        /// Show a single Printer Client 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20081</returns>
        InlineResponse20081 PrinterClientsIdGet (int? id);
        /// <summary>
        /// Update a Printer Client 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20081</returns>
        InlineResponse20081 PrinterClientsIdPatch (PrinterClientsIdBody body, int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PrinterClientApi : IPrinterClientApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterClientApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PrinterClientApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterClientApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PrinterClientApi(String basePath)
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
        /// List all Printer Clients 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <returns>InlineResponse20082</returns>
        public InlineResponse20082 PrinterClientsGet (string filterId)
        {
    
            var path = "/printer_clients";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterClientsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterClientsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20082) ApiClient.Deserialize(response.Content, typeof(InlineResponse20082), response.Headers);
        }
    
        /// <summary>
        /// Show a single Printer Client 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20081</returns>
        public InlineResponse20081 PrinterClientsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PrinterClientsIdGet");
    
            var path = "/printer_clients/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterClientsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterClientsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20081) ApiClient.Deserialize(response.Content, typeof(InlineResponse20081), response.Headers);
        }
    
        /// <summary>
        /// Update a Printer Client 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20081</returns>
        public InlineResponse20081 PrinterClientsIdPatch (PrinterClientsIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PrinterClientsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PrinterClientsIdPatch");
    
            var path = "/printer_clients/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterClientsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PrinterClientsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20081) ApiClient.Deserialize(response.Content, typeof(InlineResponse20081), response.Headers);
        }
    
    }
}
