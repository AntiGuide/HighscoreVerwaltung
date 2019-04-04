using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public class Game {
        public int Id { get; set; }
        [Required] public string Name { get; set; }

        public ICollection<Score> Scores { get; set; }

        public override bool Equals(object obj) {
            Game other = obj as Game;
            if (other == null) {
                return false;
            } else {
                return Id == other.Id && Name == other.Name && Scores == other.Scores;
            }
        }
    }
}
