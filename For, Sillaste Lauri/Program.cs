namespace For6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Sisesta, kui palju korrutuste arvu kümnatega te soovite näha: ");
            Console.ForegroundColor = ConsoleColor.White;
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                double result = Math.Pow(10, i);
                Console.WriteLine(result);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Arvutamise lõpp");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

