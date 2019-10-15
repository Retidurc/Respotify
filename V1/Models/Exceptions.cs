using Newtonsoft.Json;
using System;

namespace Remotify.V1.Models
{
    [JsonObject()]
    public class ApiException : Exception
    {
        [JsonProperty("status")]
        public string Status { get; set; }

    }

    [JsonObject()]
    public class AuthenticationException : Exception
    {
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}
