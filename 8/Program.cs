namespace Test
{
    internal class Program : Test1
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo start;

            while (true)
            {
                Sohrani();
                start = Console.ReadKey();
                if (start.Key == ConsoleKey.Tab)
                    perehod();
            }
        }
    }
}