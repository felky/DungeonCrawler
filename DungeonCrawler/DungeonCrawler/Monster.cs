using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Monster : Tile
    {
        public override char tile => 'M';
        private bool isDefeated = false;

        public override void Interact(Player player)
        {
            if (!isDefeated)
            {
                player.moves += 5;
                isDefeated = true;
                tile = '.';
            }

            player.Move();
        }
    }
}
