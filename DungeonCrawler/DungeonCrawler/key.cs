using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Key : Tile
    {
        private char t = 'k';
        public override char tile { get => t; set => t = value; }
        private bool looted = false;

        public override void Interact(Player player)
        {
            if (!looted)
            {
                player.Keys++;
                looted = true;
                t = '.';
            }
            player.Move();
        }
    }
}
