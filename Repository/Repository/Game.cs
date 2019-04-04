using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    class Game {
        public int Id { get; set; }
        [Required] public string Name { get; set; }

        public ICollection<Score> Scores { get; set; }
    }
}
