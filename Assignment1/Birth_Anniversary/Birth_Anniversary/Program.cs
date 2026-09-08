namespace Birth_Anniversary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birth date (yyyy-mm-dd): ");

            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;

            TimeSpan age = today - birthDate;

            int daysOld = age.Days;

            Console.WriteLine($"You are {daysOld} days old.");

            int daysToNextAnniversary = 10000 - (daysOld % 10000);

            DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);

            Console.WriteLine(
                $"Your next 10,000 day anniversary is in {daysToNextAnniversary} days.");

            Console.WriteLine(
                $"The date will be {nextAnniversary:MMMM dd, yyyy}.");
        }
    }
}



