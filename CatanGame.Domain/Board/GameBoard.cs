using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CatanGame.Domain.Board
{
    internal class GameBoard
    {
        private Tile[][] _layout;

        public GameBoard()
        {
            _layout = [new Tile[3], new Tile[4], new Tile[5], new Tile[4], new Tile[3],];
        }
    }
}
