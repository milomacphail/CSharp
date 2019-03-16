using System;

namespace reverse_order
{
    class MainClass
    {

        public static class Kata
        {
            private static int ReverseOrder(int Number)
            {
                Console.WriteLine("Enter a number to reverse: ");
                int Number = int.Parse(Console.ReadLine());
                int reverseNumber = 0;
                while (Number > 0)
                {
                    int remainder = Number % 10;
                    reverseNumber = (reverseNumber * 10) + remainder;
                    Number = Number / 10;
                }
                Console.WriteLine("In reverse, this number is {0}", reverseNumber);
                Console.ReadLine();
            }
        }

        public static void Main(string[] args) => reverse_order(76);

    }
}
