using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class Room : Tile
    {
        public override char tile { get => '.'; }
        public override void Interact(Player player)
        {
            player.Move();
        }
    }
}