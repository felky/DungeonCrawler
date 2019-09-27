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
        //Inget händer när man försöker gå in i en vägg.
        public override void Interact(Player player)
        {

        }
    }
}
