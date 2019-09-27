using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Exit : Tile
    {
        private char t = 'U';
        public override char tile { get => t; set => t = value; }

        public override void Interact(Player player)
        {
            End(player);
        }

        private void End(Player player)
        {
            Console.Clear();
            Console.WriteLine($"Congratulations, you did it!\nIt took you {player.moves} to finish the map :)");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
