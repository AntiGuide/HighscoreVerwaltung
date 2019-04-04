using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public class User {
        public int Id { get; set; }
        [Required] public string Name { get; set; }

        public ICollection<Score> Scores { get; set; }

        public override bool Equals(object obj) {
            User other = obj as User;
            if (other == null) {
                return false;
            } else {
                return Id == other.Id && Name == other.Name;
            }
        }
    }
}
