using System;
using Remotify.V1;
namespace DebugGrounds
{
    class Program
    {
        static void Main(string[] args)
        {
            var RestClient = new RestClient("https://api.spotify.com/v1");
            var Player = new Player(RestClient);
            Player.Previous().Wait();
        }
    }
}
