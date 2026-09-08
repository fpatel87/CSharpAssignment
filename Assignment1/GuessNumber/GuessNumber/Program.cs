namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correctNumber = new Random().Next(3) + 1;

            Console.Write(correctNumber);
            Console.Write("Guess a number between 1 and 3: "); 

            int guessedNumber = int.Parse(Console.ReadLine()); 

            if (guessedNumber < 1 || guessedNumber > 3) 
            { 
                Console.WriteLine("Your guess is outside the valid range. Please enter a number between 1 and 3."); 
            } 
            else if (guessedNumber < correctNumber) 
            {
                Console.WriteLine("Your guess is too low."); 
            } 
            else if (guessedNumber > correctNumber) 
            { 
                Console.WriteLine("Your guess is too high."); 
            } 
            else 
            { 
                Console.WriteLine("Correct! You guessed the number."); 
            }
        }
    }
}
