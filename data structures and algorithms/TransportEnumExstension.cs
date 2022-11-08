using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms
{
    public static class TransportEnumExstension
    {
        public static char GetChar(this TransportEnum transport)
        {
            switch(transport)
            {
                case TransportEnum.BIKE: return 'B';
                case TransportEnum.BUS: return 'U';
                case TransportEnum.CAR: return 'C';
                case TransportEnum.SUBWAY: return 'S';
                case TransportEnum.WALK: return 'W';
                default: throw new Exception("Unknown Transport");
            }
        }

        public static ConsoleColor GetColor(this TransportEnum transport)
        {
            switch (transport)
            {
                case TransportEnum.BIKE: return ConsoleColor.Blue;
                case TransportEnum.BUS: return ConsoleColor.DarkGreen;
                case TransportEnum.CAR: return ConsoleColor.Red;
                case TransportEnum.SUBWAY: return ConsoleColor.DarkMagenta;
                case TransportEnum.WALK: return ConsoleColor.DarkYellow;
                default: throw new Exception("Unknown Transport");
            }
        }
    }
}
