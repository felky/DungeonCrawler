using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Wall : Tile
    {
        public override char tile { get => '#'; }

        public override void Interact(Player player)
        {

        }
    }
}
