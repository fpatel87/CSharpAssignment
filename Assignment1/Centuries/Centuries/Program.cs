namespace Centuries
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Input: ");

            decimal centuries = decimal.Parse(Console.ReadLine());

            decimal years = centuries * 100;
            decimal days = years * 365.24m;
            decimal hours = days * 24;
            decimal minutes = hours * 60;
            decimal seconds = minutes * 60;
            decimal milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine(
                $"{centuries:0.##} centuries = {years:0.##} years = {days:0.##} days = " +
                $"{hours:0.##} hours = {minutes:0.##} minutes = {seconds:0.##} seconds = " +
                $"{milliseconds:0.##} milliseconds = {microseconds:0.##} microseconds = " +
                $"{nanoseconds:0.##} nanoseconds");



        }
    }
}
