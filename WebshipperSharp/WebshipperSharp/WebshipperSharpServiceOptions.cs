namespace WebshipperSharp
{
    public class WebshipperSharpServiceOptions
    {
        /// <summary>
        /// Token used for authentication
        /// </summary>
        public string? BearerToken { get; set; }

        /// <summary>
        /// String to prepend api url e.g. company-name
        /// </summary>
        public string? TenantName { get; set; }
    }
}
