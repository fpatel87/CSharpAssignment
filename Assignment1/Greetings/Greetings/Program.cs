namespace Greetings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;

            if (time.Hour >= 5 && time.Hour < 12)
            {
                Console.WriteLine("Good Morning");
            }

            if (time.Hour >= 12 && time.Hour < 17)
            {
                Console.WriteLine("Good Afternoon");
            }

            if (time.Hour >= 17 && time.Hour < 21)
            {
                Console.WriteLine("Good Evening");
            }

            if (time.Hour >= 21 || time.Hour < 5)
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}

