using System.Globalization;

namespace ovn3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers();
            Console.WriteLine();
            Characters();
        }

        private static void Numbers()
        {
            for (int i = 1; i <= 5; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    var number = j;
                    Console.Write($"{number,-3}");

                }
                Console.Write("\r\n");
            }
        }

        private static void Characters()
        {
            int asciiOffset = 64;
            for (int i = 1; i <= 5; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    var number = j + asciiOffset;
                    Console.Write($"{((char)number).ToString().PadRight(3)}");

                }
                Console.Write("\r\n");
            }
        }
    }
}
