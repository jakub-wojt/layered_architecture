using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Server.Services;

namespace Layers.Server
{
    public static class Server
    {
        public static void Main(string[] prms)
        {
            new ServerServiceFactory().GetTransportLayer().StartListener();
            Console.ReadKey();
        }
    }
}
