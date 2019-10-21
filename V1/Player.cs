using DalSoft.RestClient;
using System.Threading.Tasks;

namespace Remotify.V1
{
    public class Player : EndPoint
    {
        protected override string Ressource => "me/player";

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
