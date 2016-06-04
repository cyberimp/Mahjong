using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mahjong
{
    class Hand
    {
        private List<Tile> collection;
        private List<Meld> melds;
        public void GetFromWall(Wall wall)
        {
            collection.Add(wall.GetTile());
        }
    }
}
