namespace PyramidPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int line = 1; line <= 5; line++)
            {
                // Print spaces
                for (int space = 1; space <= 5 - line; space++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int star = 1; star <= (2 * line - 1); star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}

