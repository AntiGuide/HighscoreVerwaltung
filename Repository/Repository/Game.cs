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
            if (obj is Game) {
                Game other = obj as Game;
                return Id == other.Id && Name == other.Name;
            }

            return false;
        }

        public override int GetHashCode() {
            int hash = 23;
            hash = ((hash << 5) * 37) ^ Id.GetHashCode();
            hash = ((hash << 5) * 37) ^ (Name == null ? 0 : Name.GetHashCode());
            return hash;
        }
    }
}
