using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class Player
    {
        public int Keys = 0;
        public int x = 0;
        public int y = 0;
        public int direction = 0;
        public int moves = 0;
        const int up = 0;
        const int right = 1;
        const int down = 2;
        const int left = 3;

        public void Move()
        {
            if (direction == up)
            {
                y++;
            }
            if (direction == down)
            {
                y--;
            }
            if (direction == right)
            {
                x++;
            }
            if (direction == left)
            {
                x--;
            }
        }
    }
}
