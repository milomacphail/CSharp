using System;

namespace larger_number
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number.");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("{0} is the larger number.", firstNumber);
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("{0} is the larger number.", secondNumber);
            }
            else
            {
                Console.WriteLine("{0} and {0} are equal.", firstNumber, secondNumber);
            }
        }
    }
}
