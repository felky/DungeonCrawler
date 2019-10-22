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
        private char t = 'k';
        private Type type = Type.Key;
        public override Type Type { get => type; set => type = value; }
        private bool looted = false;

        // Spelaren plockar upp nyckeln när man går på rutan
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
