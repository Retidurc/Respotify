using System.Threading.Tasks;

namespace Remotify.V1
{
    public class Player : EndPoint
    {
        public Player(RestClient restClient) : base(restClient) { }

        protected override string Endpoint => "me/player";


        public async Task Previous(string deviceId = "")
        {
            string uri = $"{Endpoint}/previous";
            if (!string.IsNullOrWhiteSpace(deviceId))
                uri += $"?device_id={deviceId}";

            await base.RestClient.Post<object>(uri, null);
        }
    }
}
