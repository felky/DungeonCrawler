using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    // ett tomt rum som man kan gå in i.
    public class Room : Tile
    {
        private char t = '.';
        public override char tile { get => t; set => t = value; }
        private Type type = Type.Empty;
        public override Type Type { get => type; set => type = value; }

        public override void Interact(Player player)
        {
            player.Move();
        }
    }
}