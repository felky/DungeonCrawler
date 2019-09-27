using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Door : Tile
    {
        private char t = 'D';
        public override char tile { get => t; set => t = value; }
        private bool locked = true;

        public override void Interact(Player player)
        {
            if (locked)
            {
                if (player.Keys >= 1)
                {
                    player.Keys--;
                    locked = false;
                }
            }
            if (!locked)
            {
                player.Move();
            }
        }
    }
}
