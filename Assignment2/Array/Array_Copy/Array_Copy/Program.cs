namespace Array_Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the original array with 10 items
            int[] originalArray = new int[10];

            // Put values into the original array
            originalArray[0] = 10;
            originalArray[1] = 20;
            originalArray[2] = 30;
            originalArray[3] = 40;
            originalArray[4] = 50;
            originalArray[5] = 60;
            originalArray[6] = 70;
            originalArray[7] = 80;
            originalArray[8] = 90;
            originalArray[9] = 100;

            // Create a second array using the Length property
            int[] copiedArray = new int[originalArray.Length];

            // Copy values from the original array
            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            // Print the original array
            Console.WriteLine("Original array:");

            for (int i = 0; i < originalArray.Length; i++)
            {
                Console.Write(originalArray[i] + " ");
            }

            Console.WriteLine();

            // Print the copied array
            Console.WriteLine("Copied array:");

            for (int i = 0; i < copiedArray.Length; i++)
            {
                Console.Write(copiedArray[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
