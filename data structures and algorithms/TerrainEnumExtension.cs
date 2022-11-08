using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms
{
    //extension classes are always static
    public static class TerrainEnumExtension
    {
        public static ConsoleColor GetColor(this TerrainEnum terrain) //by using this keyword you specify which class or object you want to add this method
        {
            switch(terrain)
            {
                case TerrainEnum.GRASS: return ConsoleColor.Green;
                case TerrainEnum.SAND: return ConsoleColor.Yellow;
                case TerrainEnum.WATER: return ConsoleColor.Blue;
                default: return ConsoleColor.DarkGray;
            }
        }

        public static char GetChar(this TerrainEnum terrain)
        {
            switch(terrain)
            {
                case TerrainEnum.GRASS: return '\u201c';
                case TerrainEnum.SAND: return '\u25cb';
                case TerrainEnum.WATER: return '\u2248';
                default: return '\u25cf';

            }
        }
    }
}
