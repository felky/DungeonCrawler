using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Exit : Tile
    {
        public override char tile { get => 'U'; }

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
