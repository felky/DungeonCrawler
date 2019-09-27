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
            End();
        }

        private void End()
        {
            Console.Clear();
            Console.WriteLine("Congratulations, you did it!");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
