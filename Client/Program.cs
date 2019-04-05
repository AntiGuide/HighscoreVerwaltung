using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Common;
using System.Threading;

namespace Client {
    class Program {
        static void Main(string[] args) {
            Uri baseAddress = new Uri("net.tcp://localhost:8009/Highscore");
            EndpointAddress address = new EndpointAddress(baseAddress);
            NetTcpBinding binding = new NetTcpBinding();
            using (var factory = new ChannelFactory<IHighscoreService>(binding, address)) {
                IHighscoreService svc = factory.CreateChannel();

                svc.CreateGame("LoL");

                var games = svc.GetGames();

                foreach (var item in games) {
                    Console.WriteLine(item.Name);
                }

                (svc as IChannel).Close();

                Console.ReadKey();
            }
        }
    }
}
