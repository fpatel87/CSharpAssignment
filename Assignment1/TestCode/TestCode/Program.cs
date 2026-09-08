namespace TestCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 500;

            try
            {
                checked
                {
                    for (byte i = 0; i < max; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Warning: The byte variable has reached its maximum value and overflowed.");
            }

        }
    }
}
