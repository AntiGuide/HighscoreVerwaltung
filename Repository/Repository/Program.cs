using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    class Program {
        static void Main(string[] args) {
            using (var ctx = new HighscoreContext()) {
                var user = new User() { Name = "Lukas"};

                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
        }
    }
}
