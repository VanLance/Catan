using CatanGame.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatanGame.Domain
{
    internal class Player
    {
        public PlayerColor color;
        public Road[] roads;
        public Settlement[] settlements;
        public City[] cities;

        public Player(PlayerColor color) {
            this.color = color;
            roads = new Road[15];
            settlements = new Settlement[5];
            cities = new City[4];
        }
    }
}
