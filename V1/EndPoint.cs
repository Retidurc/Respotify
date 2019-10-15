using Remotify.V1.Models;

namespace Remotify.V1
{
    public abstract class EndPoint
    {
        protected virtual string Endpoint { get;  }
        protected EndPoint(RestClient restClient) : base()
        {
            this.RestClient = restClient;
        }

        protected RestClient RestClient { get; private set; }
    }
}
