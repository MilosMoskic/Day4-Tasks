class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert number of rows: ");
        int lenght = Convert.ToInt32(Console.ReadLine());
        int i, j, k;

        for (i = 1; i <= lenght; i++)
        {
            for (j = 1; j <= lenght - i; j++)
            {
                Console.Write(" ");
            }


            for (k = 1; k <= i; k++)
            {
                Console.Write("*");
            }

            Console.Write("  ");

            for (k = 1; k <= i; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
        }
        Console.ReadLine();
    }
}