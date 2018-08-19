using System;

namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title
            Console.WriteLine("Days Between Dates");
            Console.WriteLine("Enter first date: "); //Prompts user to enter date.
            DateTime first = DateTime.Parse(Console.ReadLine()); //Makes what the user entered a date.
            Console.WriteLine(first.ToShortDateString()); //Displays what the user entered as m/dd/yyyy.

            Console.WriteLine("Enter second date: "); //Prompts user to enter date.
            DateTime second = DateTime.Parse(Console.ReadLine()); //Makes what the user entered a date.
            Console.WriteLine(second.ToShortDateString()); //Displays what the user entered as m/dd/yyyy.

            TimeSpan result = first - second; //New timespan created to calculate time between the first and second date.

            
            //Prints how many days the timespan is.
            Console.WriteLine("Days: " + result.Days);
            Console.ReadLine();
 
        }
    }
}
