﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Monster : Tile
    {
        private char t = 'm';
        public override char tile { get => t; set => t = value; }
        private Type type = Type.Monster;
        public override Type Type { get => type; set => type = value; }

        private bool isDefeated = false;

        public override void Interact(Player player)
        {
            if (!isDefeated)
            {
                player.moves += 5;
                isDefeated = true;
                t = '.';
            }

            player.Move();
        }
    }
}
