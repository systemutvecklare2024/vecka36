namespace ovn1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; ++i)
            {
                for (int j = 1; j <= 5; ++j)
                {
                    var number = i * j;
                    Console.Write($"{number.ToString().PadRight(3)}");

                }
                Console.Write("\r\n");
            }
        }
    }
}
