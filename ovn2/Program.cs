namespace ovn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 5;
            int height = 4;
            for (int i = 1; i <= height; ++i)
            {
                for (int j = 1; j <= width; ++j)
                {
                    var number = i * j;
                    Console.Write($"#".PadRight(2));

                }
                Console.Write("\r\n");
            }
        }
    }
}
