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
    public interface IFavouritePageApi
    {
        /// <summary>
        /// List all Favourite Pages 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterUserId">Filter by user_id</param>
        /// <returns>InlineResponse20043</returns>
        InlineResponse20043 FavouritePagesGet (string filterId, string filterUserId);
        /// <summary>
        /// Delete a Favourite Page 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20042</returns>
        InlineResponse20042 FavouritePagesIdDelete (int? id);
        /// <summary>
        /// Show a single Favourite Page 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20042</returns>
        InlineResponse20042 FavouritePagesIdGet (int? id);
        /// <summary>
        /// Update a Favourite Page 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20042</returns>
        InlineResponse20042 FavouritePagesIdPatch (FavouritePagesIdBody body, int? id);
        /// <summary>
        /// Create a Favourite Page 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20042</returns>
        InlineResponse20042 FavouritePagesPost (FavouritePagesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FavouritePageApi : IFavouritePageApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FavouritePageApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FavouritePageApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FavouritePageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FavouritePageApi(String basePath)
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
        /// List all Favourite Pages 
        /// </summary>
        /// <param name="filterId">Filter by id</param>
        /// <param name="filterUserId">Filter by user_id</param>
        /// <returns>InlineResponse20043</returns>
        public InlineResponse20043 FavouritePagesGet (string filterId, string filterUserId)
        {
    
            var path = "/favourite_pages";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter[id]", ApiClient.ParameterToString(filterId)); // query parameter
 if (filterUserId != null) queryParams.Add("filter[user_id]", ApiClient.ParameterToString(filterUserId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FavouritePagesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FavouritePagesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20043) ApiClient.Deserialize(response.Content, typeof(InlineResponse20043), response.Headers);
        }
    
        /// <summary>
        /// Delete a Favourite Page 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20042</returns>
        public InlineResponse20042 FavouritePagesIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling FavouritePagesIdDelete");
    
            var path = "/favourite_pages/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FavouritePagesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FavouritePagesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20042) ApiClient.Deserialize(response.Content, typeof(InlineResponse20042), response.Headers);
        }
    
        /// <summary>
        /// Show a single Favourite Page 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>InlineResponse20042</returns>
        public InlineResponse20042 FavouritePagesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling FavouritePagesIdGet");
    
            var path = "/favourite_pages/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FavouritePagesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FavouritePagesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20042) ApiClient.Deserialize(response.Content, typeof(InlineResponse20042), response.Headers);
        }
    
        /// <summary>
        /// Update a Favourite Page 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20042</returns>
        public InlineResponse20042 FavouritePagesIdPatch (FavouritePagesIdBody body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling FavouritePagesIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling FavouritePagesIdPatch");
    
            var path = "/favourite_pages/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FavouritePagesIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FavouritePagesIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20042) ApiClient.Deserialize(response.Content, typeof(InlineResponse20042), response.Headers);
        }
    
        /// <summary>
        /// Create a Favourite Page 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse20042</returns>
        public InlineResponse20042 FavouritePagesPost (FavouritePagesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling FavouritePagesPost");
    
            var path = "/favourite_pages";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FavouritePagesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FavouritePagesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20042) ApiClient.Deserialize(response.Content, typeof(InlineResponse20042), response.Headers);
        }
    
    }
}
