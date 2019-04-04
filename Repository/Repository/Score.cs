using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    class Score {
        public int Id { get; set; }
        public int Points { get; set; }
        public Game Game { get; set; }
        public User User { get; set; }
    }
}
