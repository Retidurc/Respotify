using System;
using System.Threading;
using System.Threading.Tasks;
using Remotify.V1;
namespace DebugGrounds
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var  Player = new Player();
            var returned = await Player.Devices();
        }
    }
}
