using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Exit : Tile
    {
        private char t = '╬';
        public override char tile { get => t; set => t = value; }
        private Type type = Type.Exit;
        public override Type Type { get => type; set => type = value; }

        // Om spelaren går in i rutan körs End() metoden
        public override void Interact(Player player)
        {
            End(player);
        }

        // Skriver ut ett meddelande och stänger av spelet 
        private void End(Player player)
        {
            Console.Clear();
            Console.WriteLine($"Congratulations, you did it!\nIt took you {player.moves} moves to finish the map :)");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
