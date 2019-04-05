using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common {
    public class DTO_User {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj) {
            if (obj is DTO_User) {
                DTO_User other = obj as DTO_User;
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
