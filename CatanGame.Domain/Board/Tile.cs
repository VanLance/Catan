using CatanGame.Domain.Enums;
using CatanGame.Domain.Resources;
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
        public int number;

        private Dictionary<Edges, Tile?> tiles;
        private Dictionary<Edges, Edge> edges;
       

        public Tile(Resource resource)
        {
            _resource = resource;

            edges = new Dictionary<Edges, Edge>() {
                { Edges.TopRight,  new Edge() },
                { Edges.Right,  new Edge() },
                { Edges.BottomRight,  new Edge() },
                { Edges.BottomLeft,  new Edge() },
                { Edges.Left,  new Edge() },
                { Edges.TopLeft,  new Edge() }
            };

            tiles = new Dictionary<Edges, Tile?>()
            {
                { Edges.TopRight, null },
                { Edges.Right, null },
                { Edges.BottomRight, null },
                { Edges.BottomLeft, null },
                { Edges.Left, null },
                { Edges.TopLeft, null }
            }
        }
    }
}
