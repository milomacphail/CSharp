using System;

namespace input_number
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10.");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 10)
            {
                Console.WriteLine("Invalid.");
            }
            else
            {
                Console.WriteLine("Valid.");
            }
        }
    }
}
