using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Key : Tile
    {
        public override char tile { get => t; set => t = value; }
        private Type type = Type.Key;
        public override Type Type { get => type; set => type = value; }

        private char t = '¶';
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
