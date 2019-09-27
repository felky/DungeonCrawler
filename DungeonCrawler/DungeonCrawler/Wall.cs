using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Wall : Tile
    {
        private char t = '█';
        public override char tile { get => t; set => t = value; }

        public override void Interact(Player player)
        {

        }
    }
}
