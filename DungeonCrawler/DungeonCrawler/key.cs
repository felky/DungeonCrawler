using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Key : Tile
    {
        public override char tile => 'k';
        private bool looted = false;

        public override void Interact(Player player)
        {
            if (!looted)
            {
                player.Keys++;
                looted = true;
            }
            player.Move();
        }
    }
}
