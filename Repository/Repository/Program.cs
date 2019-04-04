using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    class Program {
        static void Main(string[] args) {

            var highScoreController = new HighscoreController();

            foreach (var item in highScoreController.GetGamesPerUser(1)) {
                Console.WriteLine("{0}: {1}", item.Game.Name, item.Points);
            }

            Console.ReadKey();

        }
    }
}
