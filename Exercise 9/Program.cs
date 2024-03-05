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

            for (int a = 0; a < width; a++)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}