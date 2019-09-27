using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Program
    {
        static Player player = new Player { x = 4, y = 2 };
        static Tile[,] map = new Tile[5, 14];
        static void Main(string[] args)
        {
            PopulateMap();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                  @"
                    ██▄     ▄      ▄     ▄▀  ▄███▄   ████▄    ▄       ▄█▄    █▄▄▄▄ ██     ▄ ▄   █    
                    █  █     █      █  ▄▀    █▀   ▀  █   █     █      █▀ ▀▄  █  ▄▀ █ █   █   █  █    
                    █   █ █   █ ██   █ █ ▀▄  ██▄▄    █   █ ██   █     █   ▀  █▀▀▌  █▄▄█ █ ▄   █ █    
                    █  █  █   █ █ █  █ █   █ █▄   ▄▀ ▀████ █ █  █     █▄  ▄▀ █  █  █  █ █  █  █ ███▄ 
                    ███▀  █▄ ▄█ █  █ █  ███  ▀███▀         █  █ █     ▀███▀    █      █  █ █ █      ▀
                           ▀▀▀  █   ██                     █   ██             ▀      █    ▀ ▀        
                                                                                    ▀                ");
                DrawMap();
                Console.WriteLine(player.moves);
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.W)
                {
                    player.direction = Player.up;
                    map[player.y - 1, player.x].Interact(player);
                }
                if (key.Key == ConsoleKey.D)
                {
                    player.direction = Player.right;
                    map[player.y, player.x + 1].Interact(player);
                }
                if (key.Key == ConsoleKey.S)
                {
                    player.direction = Player.down;
                    map[player.y + 1, player.x].Interact(player);
                }
                if (key.Key == ConsoleKey.A)
                {
                    player.direction = Player.left;
                    map[player.y, player.x - 1].Interact(player);
                }
            }
        }

        static void DrawMap()
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (player.x == x && player.y == y)
                    {
                        Console.Write('@');
                    }
                    else
                    {
                        Console.Write(map[y, x].tile);
                    }
                }
                Console.WriteLine();
            }
        }

        static void PopulateMap()
        {
            map[0, 0] = new Wall();
            map[0, 1] = new Wall();
            map[0, 2] = new Wall();
            map[0, 3] = new Wall();
            map[0, 4] = new Wall();
            map[0, 5] = new Wall();
            map[0, 6] = new Wall();
            map[0, 7] = new Wall();
            map[0, 8] = new Wall();
            map[0, 9] = new Wall();
            map[0, 10] = new Wall();
            map[0, 11] = new Wall();
            map[0, 12] = new Wall();
            map[0, 13] = new Wall();

            map[1, 0] = new Wall();
            map[1, 1] = new Room();
            map[1, 2] = new Key();
            map[1, 3] = new Room();
            map[1, 4] = new Room();
            map[1, 5] = new Room();
            map[1, 6] = new Wall();
            map[1, 7] = new Exit();
            map[1, 8] = new Room();
            map[1, 9] = new Room();
            map[1, 10] = new Room();
            map[1, 11] = new Room();
            map[1, 12] = new Room();
            map[1, 13] = new Wall();

            map[2, 0] = new Wall();
            map[2, 1] = new Room();
            map[2, 2] = new Room();
            map[2, 3] = new Room();
            map[2, 4] = new Room();
            map[2, 5] = new Room();
            map[2, 6] = new Wall();
            map[2, 7] = new Wall();
            map[2, 8] = new Wall();
            map[2, 9] = new Wall();
            map[2, 10] = new Door();
            map[2, 11] = new Wall();
            map[2, 12] = new Wall();
            map[2, 13] = new Wall();

            map[3, 0] = new Wall();
            map[3, 1] = new Key();
            map[3, 2] = new Monster();
            map[3, 3] = new Room();
            map[3, 4] = new Room();
            map[3, 5] = new Room();
            map[3, 6] = new Door();
            map[3, 7] = new Room();
            map[3, 8] = new Door();
            map[3, 9] = new Room();
            map[3, 10] = new Room();
            map[3, 11] = new Room();
            map[3, 12] = new Key();
            map[3, 13] = new Wall();

            map[4, 0] = new Wall();
            map[4, 1] = new Wall();
            map[4, 2] = new Wall();
            map[4, 3] = new Wall();
            map[4, 4] = new Wall();
            map[4, 5] = new Wall();
            map[4, 6] = new Wall();
            map[4, 7] = new Wall();
            map[4, 8] = new Wall();
            map[4, 9] = new Wall();
            map[4, 10] = new Wall();
            map[4, 11] = new Wall();
            map[4, 12] = new Wall();
            map[4, 13] = new Wall();
        }
    }
}
