using BallColordemo;

namespace BallColorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create colors
            Color redColor = new Color(255, 0, 0);
            Color blueColor = new Color(0, 0, 255, 255);
            Color greenColor = new Color(0, 255, 0);

            // Create balls
            Ball ball1 = new Ball(10, redColor);
            Ball ball2 = new Ball(15, blueColor);
            Ball ball3 = new Ball(20, greenColor);

            // Throw ball 1 three times
            ball1.Throw();
            ball1.Throw();
            ball1.Throw();

            // Throw ball 2 two times
            ball2.Throw();
            ball2.Throw();

            // Throw ball 3 four times
            ball3.Throw();
            ball3.Throw();
            ball3.Throw();
            ball3.Throw();

            // Pop ball 2
            ball2.Pop();

            // Try throwing ball 2 after it has been popped
            ball2.Throw();
            ball2.Throw();

            // Pop ball 3
            ball3.Pop();

            // Try throwing ball 3 after it has been popped
            ball3.Throw();

            // Display results
            Console.WriteLine("Ball 1 throw count: " + ball1.GetThrowCount());
            Console.WriteLine("Ball 2 throw count: " + ball2.GetThrowCount());
            Console.WriteLine("Ball 3 throw count: " + ball3.GetThrowCount());

            // Test grayscale
            Console.WriteLine();
            Console.WriteLine("Red color grayscale value: "
                + redColor.GetGrayscale());

            Console.WriteLine("Blue color grayscale value: "
                + blueColor.GetGrayscale());

            Console.WriteLine("Green color grayscale value: "
                + greenColor.GetGrayscale());
        }
    }
}