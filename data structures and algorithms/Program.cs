using System;
using System.Globalization;
using System.Linq;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ///one dimensional array
            ///create an array and assign months 


            string[] months = new string[12];
            for (int i = 1; i <= months.Length; i++)
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);
                string nameOfMonth = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
                months[i - 1] = nameOfMonth;
            }

            foreach (string month in months)
            {
                Console.WriteLine(month);
            }
            //---------------------------------------------------------------------------------------------------------


            /// Multi dimensioanl array
            /// declaration and initialization


            int[,] myArray = new int[,]
            {
                 { 9, 3, -9},
                 { -11, 25, 8},
                 { 15, 1, 3},
                 { 19, 56, -91},
                 { 39, 65, -96},
            };

            int myNumber = myArray[2, 1]; //third row second column which is 1
            myArray[1, 0] = 11; //-11 becames +11
            Console.WriteLine(myNumber);
            Console.WriteLine(myArray[1, 0]);


            // create a multiplicaion board until 10 * 10

            int[,] multiplicationBoard = new int[10, 10];

            for (int i = 0; i < multiplicationBoard.GetLength(0); i++)
            {
                for (int j = 0; j < multiplicationBoard.GetLength(1); j++)
                {
                    multiplicationBoard[i, j] = (i + 1) * (j + 1);
                }
            }


            for (int i = 0; i < multiplicationBoard.GetLength(0); i++)
            {
                for (int j = 0; j < multiplicationBoard.GetLength(1); j++)
                {
                    Console.Write("{0,4}", multiplicationBoard[i, j]); //{0,4} will create space between numbers if the number is one character it will add 3 more spaces in front
                }
                Console.WriteLine();
            }

            //// create a game map

            TerrainEnum[,] map =
           {
                {
                    TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
                    TerrainEnum.GRASS,TerrainEnum.GRASS,TerrainEnum.GRASS,TerrainEnum.GRASS,
                    TerrainEnum.GRASS,TerrainEnum.GRASS
                },
                {
                    TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
                    TerrainEnum.GRASS,TerrainEnum.GRASS,TerrainEnum.GRASS,TerrainEnum.GRASS,
                    TerrainEnum.GRASS,TerrainEnum.GRASS
                },
                {
                    TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
                    TerrainEnum.GRASS,TerrainEnum.GRASS,TerrainEnum.GRASS,TerrainEnum.GRASS,
                    TerrainEnum.GRASS,TerrainEnum.GRASS
                },
                {
                    TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
                    TerrainEnum.GRASS,TerrainEnum.GRASS,TerrainEnum.GRASS,TerrainEnum.GRASS,
                    TerrainEnum.GRASS,TerrainEnum.GRASS
                },
                {
                    TerrainEnum.SAND,TerrainEnum.SAND,TerrainEnum.SAND,TerrainEnum.SAND,TerrainEnum.SAND,
                    TerrainEnum.SAND,TerrainEnum.WALL,TerrainEnum.WALL,TerrainEnum.WALL,TerrainEnum.WALL
                },
                {
                    TerrainEnum.SAND,TerrainEnum.SAND,TerrainEnum.SAND,TerrainEnum.SAND,TerrainEnum.SAND,
                    TerrainEnum.SAND,TerrainEnum.WALL,TerrainEnum.WALL,TerrainEnum.SAND,TerrainEnum.SAND
                },
                {
                    TerrainEnum.SAND,TerrainEnum.SAND,TerrainEnum.SAND,TerrainEnum.SAND,TerrainEnum.SAND,
                    TerrainEnum.SAND,TerrainEnum.WALL,TerrainEnum.WALL,TerrainEnum.SAND,TerrainEnum.SAND
                },
                {
                    TerrainEnum.SAND,TerrainEnum.SAND,TerrainEnum.SAND,TerrainEnum.SAND,TerrainEnum.SAND,
                    TerrainEnum.SAND,TerrainEnum.WALL,TerrainEnum.WALL,TerrainEnum.SAND,TerrainEnum.SAND
                },
                {
                    TerrainEnum.WATER,TerrainEnum.WATER,TerrainEnum.WATER,TerrainEnum.WATER,TerrainEnum.WATER,TerrainEnum.WATER,
                TerrainEnum.WALL, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND
                },
                {
                    TerrainEnum.WATER,TerrainEnum.WATER,TerrainEnum.WATER,TerrainEnum.WATER,TerrainEnum.WATER,TerrainEnum.WATER,
                TerrainEnum.WALL, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND
                },
                {
                    TerrainEnum.WATER,TerrainEnum.WATER,TerrainEnum.WATER,TerrainEnum.WATER,TerrainEnum.WATER,TerrainEnum.WATER,
                TerrainEnum.WALL, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND
                }
            };

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int column = 0; column < map.GetLength(1); column++)
                {
                    Console.ForegroundColor = map[row, column].GetColor();
                    Console.Write(map[row, column].GetChar() + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            //-----------------------------------------------------------------------------------------------------------

            /// jagged arrays[arrays inside an array]


            //int[][] numbers = { new int[] { 9, 5, 3 }, null }; ideclaring and initializing jagged array
            //        numbers[1]; is null,
            // numbers[0][1]; is 5

            //yearly transport plan

            Random random = new Random();
            int transportTypesCount = Enum.GetNames(typeof(TransportEnum)).Length;
            TransportEnum[][] transport = new TransportEnum[12][];

            for (int month = 1; month <= 12; month++)
            {
                int daysCount = DateTime.DaysInMonth(DateTime.Now.Year, month);
                transport[month - 1] = new TransportEnum[daysCount]; //the arrays from 12 months get filled with the day count
                for (int day = 1; day <= daysCount; day++)
                {
                    int randomType = random.Next(transportTypesCount);
                    transport[month - 1][day - 1] = (TransportEnum)randomType; //assigning a random type of tranport from enumnerable
                }
            }

            string[] monthNames = GetMonthNames();
            int monthNamesPart = monthNames.Max(n => n.Length) + 2; //gets the longest month name and adds two more for colon and space

            for (int month = 1; month <= 12; month++)
            {
                Console.Write($"{monthNames[month - 1]}:".PadRight(monthNamesPart));
                for (int day = 1; day <= transport[month - 1].Length; day++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = transport[month - 1][day - 1].GetColor();
                    Console.Write(transport[month - 1][day - 1].GetChar());
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            ///Selection sort

            int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            SelectionSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            SelectionSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));


            Console.ReadKey();

        }

        private static string[] GetMonthNames()
        {
            string[] names = new string[12];
            for (int month = 1; month <= 12; month++)
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
                string name = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
                names[month - 1] = name;
            }
            return names;
        }
    }
}
