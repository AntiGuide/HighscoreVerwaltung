using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common {
    public class DTO_Score {
        public int Id { get; set; }
        public int Points { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
    }
}
