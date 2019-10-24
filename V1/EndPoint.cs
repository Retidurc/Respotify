using DalSoft.RestClient;
using System;
using System.Net.Http;
namespace Remotify.V1
{
    public abstract class EndPoint
    {
        protected abstract string Ressource { get; }
        protected EndPoint() : base()
        {
            this.RestClient = new RestClient(API.BaseAdress);
            RestClient.HttpClient.DefaultRequestHeaders
                .Add("Authorization", "Bearer BQCGLUUdtev-UMFvtDVBuGkIbxIZOKRtZhkxWcBa_oyUN0ebxiFF4XXlBhTMRcW1mwOMFoU4tUaQgg-9qh9EJRvivGDfFIJ6d90nhZzwFtj6eHCh1RXcDj_HlE9wxBKpOr4FMqguCOw8inbNC_V2PdeID1jJjRQcP5r68ta1c7enZbN7YoUCkGXBvICeXy5RCBoyuqQnoEtvTXxG7aQufCyC3JeEnA7_dQm09VSuwSVDmX-ed8pnO3fM7BUgmCLRqaV6-6OluBtM4CRcTtPXvft_BkRsuKgChOh9");
        }

        protected RestClient RestClient { get; }
        protected  dynamic Endpoint => this.RestClient.Resource(this.Ressource);
    }
}
