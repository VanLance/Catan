using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatanGame.Domain.Board
{
    internal class Tile
    {
        public Resource _resource;

        private Tile? leftTile;
        private Tile? rightTile;
        private Tile? upRightTile;
        private Tile? upLeftTile;
        private Tile? downLeftTile;
        private Tile? downRightTile;

        private Edge? leftEdge;
        private Edge? rightEdge;
        private Edge? upRightEdge;
        private Edge? upLeftEdge;
        private Edge? downLeftEdge;
        private Edge? downRightEdge;


        public Tile(Resource resource)
        {
            _resource = resource;
        }
    }
}
