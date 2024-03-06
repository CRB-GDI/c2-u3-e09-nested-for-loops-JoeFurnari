namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width: ");
            int width = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of rows: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int a = 1; a <= length; a++)
            {
                for (int i = 1; i <= width; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter the MAX amount of asterisks: ");
            int maxAsterisks = Int32.Parse(Console.ReadLine());

            for (int a = 1; a <= maxAsterisks; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}