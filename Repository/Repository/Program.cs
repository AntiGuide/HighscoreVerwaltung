using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    class Program {
        static void Main(string[] args) {
            using (var ctx = new HighscoreContext()) {
                foreach (var score in ctx.Scores.Include("User")
                    .Where(s => s.Game.Name == "CS:GO")
                    .OrderByDescending(s => s.Points)
                    .Take(5)) {
                    Console.WriteLine("{1}: {0}", score.Points, score.User.Name);
                }

                Console.ReadKey();
            }
        }
    }
}
