using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Remotify.V1
{
    public  class RestClient
    {
        public RestClient(string BaseAddress)
        {
            Http = new HttpClient { BaseAddress = new Uri(BaseAddress) };
            Http.DefaultRequestHeaders.Add("Accept", "application/json");
            //Http.DefaultRequestHeaders.Add("Content-Type", "application/json");
            //temporary 
            Http.DefaultRequestHeaders.Add("Authorization", "Bearer BQB645JoHBIrxAta1cuHy1zAu6b9cZX1gZ37yNlrOC-h_h2MJ0cmnqUibeZloexb9TXPtA50b0nAw1UGLNFddlCWzxHHGueZtI8RUDoGXsBqTmSnS8rCo4RIb7lcUMAMMmXk1zq40YxdwnWi89pi0y-YX3kj1Mbr6aiTiZ3rzpdG3DFH_O0vDA7O4UYgHH8SEPCPKEK_auubyTjmRKkjV3qEhDzeMbB9JDoqjO-uM3Br7tNo26NiAkqvSJMzRHDqyCGu_UGJHjCtk-uonEZzy-hxpSEv4u3ugBXt");

        }

        public HttpRequestHeaders DefaultRequestHeaders => this.Http.DefaultRequestHeaders;
        private HttpClient Http { get;  set; }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">The requestUri was null</exception>
        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
        protected async Task<T> Get<T>(string uri)
        {
            HttpResponseMessage response = await Http.GetAsync(uri);
            switch (response.StatusCode)
            {
                case HttpStatusCode.TooManyRequests:
                    // HTTP client may already handle this one. Find if it's the case
                    break;

                case HttpStatusCode.OK:
                    return await Deserialize<T>(response);
                case HttpStatusCode.Unauthorized:
                    throw await Deserialize<Exception>(response);
                default:
                    throw await Deserialize<Exception>(response);
            }
            return default;
        }

        public async Task Post<TContent>(string uri,TContent content)
        {
            HttpResponseMessage response = await Http.PostAsync(uri,null);
            switch (response.StatusCode)
            {
                case HttpStatusCode.TooManyRequests:
                    // HTTP client may already handle this one. Find if it's the case
                    break;

                case HttpStatusCode.OK:
                    return ;
                case HttpStatusCode.Unauthorized:
                    throw await Deserialize<Exception>(response);
                default:
                    throw await Deserialize<Exception>(response);
            }
            return ;
        }

        private async Task<T> Deserialize<T>(HttpResponseMessage response)
        {
            var receiveStream = await response.Content.ReadAsStreamAsync();
            using StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            return JsonConvert.DeserializeObject<T>(readStream.ReadToEnd());
        }
    }
}
