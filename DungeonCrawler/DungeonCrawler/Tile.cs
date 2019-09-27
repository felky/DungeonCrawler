using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Type { Monster, Key, Empty, Door, Exit }

namespace DungeonCrawler
{
    public abstract class Tile : IDrawable
    {
        public abstract char tile { get; }
        public abstract void Interact(Player player);
    }
}
