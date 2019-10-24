using DalSoft.RestClient;
using Remotify.V1.Models;
using Remotify.V1.Models.Player;
using Remotify.V1.Models.Player.Reponses;
using System.Threading.Tasks;

namespace Remotify.V1
{
    public class Player : EndPoint
    {
        protected override string Ressource => "me/player";

        public async Task<object> Current()
        {
            return await this.Endpoint.Get();
        }
        public async Task<object> Current(Market market)
        {
            return await this.Endpoint.query(new { market = market.Code }).Get();
        }

        public async Task<Device[]> Devices()
        {
            Devices response =  await this.Endpoint.devices.Get();
            return response.devices;
        }
        public async Task Previous()
        {
            var response = await this.Endpoint.Previous.Post();         
        }

        public async Task Next()
        {
            await this.Endpoint.Next.Post();
        }

        public async Task Play()
        {
            await this.Endpoint.Play.Put();
        }

        public async Task Pause()
        {
            await this.Endpoint.Pause.Put();
        }
    }
}
