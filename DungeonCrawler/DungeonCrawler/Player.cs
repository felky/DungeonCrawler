using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    // en spelare class som har position, nycklar, riktning och move funktion.
    public class Player
    {
        public int Keys = 0;
        public int x = 0;
        public int y = 0;
        public int direction = 0;
        public int moves = 0;
        public const int up = 0;
        public const int right = 1;
        public const int down = 2;
        public const int left = 3;

        public void Move()
        {
            if (direction == up)
            {
                y--;
            }
            if (direction == down)
            {
                y++;
            }
            if (direction == right)
            {
                x++;
            }
            if (direction == left)
            {
                x--;
            }
            moves++;
        }
    }
}
