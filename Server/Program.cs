using System;
using System.Collections.Generic;
using EFRepository;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server {
    class Program {
        static void Main(string[] args) {
            var controller = new HighscoreController(() => new EFSessionScope());
            using (var host = new Host<EFSessionScope>()) {
                host.Start();
                Console.WriteLine("Server gestartet");
                Console.ReadKey();
                host.Close();
            }
        }
    }
}
