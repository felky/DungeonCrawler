using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Door : Tile
    {
        private char t = '▒';
        public override char tile { get => t; set => t = value; }
        private Type type = Type.Door;
        public override Type Type { get => type; set => type = value; }

        private bool locked = true;

        public override void Interact(Player player)
        {
            // Kollar ifall dörren är låst, ifall spelaren har en nyckel så låses dörren upp och nyckeln försvinner

            if (locked)
            {
                if (player.Keys >= 1)
                {
                    player.Keys--;
                    locked = false;
                    t = '.';
                }
            }

            // Ifall dörren är låst kommer spelaren inte kunna röra sig. 

            if (!locked)
            {
                player.Move();
            }
        }
    }
}
