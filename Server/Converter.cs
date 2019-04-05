using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Repository;

namespace Server {
    public static class Converter {
        public static DTO_User ToDTO(this User user) {
            return new DTO_User() { Id = user.Id, Name = user.Name };
        }

        public static DTO_Score ToDTO(this Score score) {
            return new DTO_Score() { Id = score.Id, Points = score.Points, GameId = score.GameId, UserId = score.UserId };
        }

        public static DTO_Game ToDTO(this Game game) {
            return new DTO_Game() { Id = game.Id, Name = game.Name };
        }

        public static DTO_GameInfo ToDTO(this GameInfo gameInfo) {
            return new DTO_GameInfo() { Game = gameInfo.Game.ToDTO(), Points = gameInfo.Points };
        }

        public static DTO_UserInfo ToDTO(this UserInfo userInfo) {
            return new DTO_UserInfo() { User = userInfo.User.ToDTO(), Points = userInfo.Points };
        }
    }
}
