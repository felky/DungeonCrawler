using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DungeonCrawler
{
    public abstract class Tile : IDrawable
    {
        public abstract char tile { get; set; }
        public abstract Type Type { get; set; }
        public abstract void Interact(Player player);
    }
}
