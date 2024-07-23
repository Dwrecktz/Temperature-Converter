using System;

namespace Farenheit_To_Celcius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; //Changes console text to green.
            Console.WriteLine("1 = Farenheit to Celcius, 2 = Celcius to Farenheit");
            int input = Convert.ToInt32(Console.ReadLine()); //Takes input from user, and converts it into an integer for the switch to work.

            switch (input)
            {
                case 1:
                    Console.Write("Input Farenhiet: ");
                    double firstNum = Convert.ToDouble(Console.ReadLine()); //Converts user input into double.
                    Console.WriteLine("\n--------------------");
                    Console.Write("\nOutput: " + (firstNum - 32) * 5 / 9); //Writes out output, does necessary equation for Farenheit to Celcius.
                break;

                case 2:
                    Console.Write("Input Celsius: ");
                    double firstNum1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\n--------------------");
                    Console.WriteLine("\nOutput: " + (firstNum1 * 9 / 5 + 32)); //Writes out output, does necessary equation for Celcius to Farenheit.
                break;
            }
            Console.ReadKey();
            
        }
    }
}
