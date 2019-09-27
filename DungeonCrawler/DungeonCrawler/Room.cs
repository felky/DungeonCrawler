using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Type { Monster, Key, Empty, Door, Exit }

namespace DungeonCrawler
{
    public class Room : Tile
    {
        private Type _type; 

        public Room(Type type)
        {
            _type = type;
        }

        public override void Interact(Player player)
        {
            switch (_type)
            {
                case Type.Empty:
                    tile = '.';
                    break;
                case Type.Key:
                    tile = 'k';
                    break;
                case Type.Door:
                    tile = 'D';
                    break;
                case Type.Exit:
                    tile = 'U';
                    break;
                case Type.Monster:
                    tile = 'M';
                    break;
                default:
                    break;
            }
        }
    }
}

