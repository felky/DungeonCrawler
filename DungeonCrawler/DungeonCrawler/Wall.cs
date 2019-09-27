using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    // Väggen stoppar spelaren.

    class Wall : Tile
    {
        private char t = '█';
        public override char tile { get => t; set => t = value; }
        private Type type = Type.Wall;
        public override Type Type { get => type; set => type = value; }

        public override void Interact(Player player)
        {

        }
    }
}
