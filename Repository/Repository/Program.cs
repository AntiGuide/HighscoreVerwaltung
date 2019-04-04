using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    class Program {
        static void Main(string[] args) {
            using (var ctx = new HighscoreContext()) {
                ctx.Users.Add(new User { Name = "Lukas" });
                ctx.Users.Add(new User { Name = "Janik" });
                ctx.Users.Add(new User { Name = "Almin" });
                ctx.SaveChanges();

                foreach (var item in ctx.Users) {
                    Console.WriteLine(item.Id + " | " + item.Name);
                }

                Console.ReadKey();
            }
        }
    }
}
