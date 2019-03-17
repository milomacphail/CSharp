using System;

namespace speed_limit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter speed limit.");
            int speedLimit = int.Parse(Console.ReadLine());
            if (speedLimit <= 0)
            {
                Console.WriteLine("Please enter a speed limit.");
            }

            Console.WriteLine("Enter car speed.");
            int carSpeed = int.Parse(Console.ReadLine());
            if (carSpeed <= 0)
            {
                Console.WriteLine("Get a move on!");
            }


            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("OK.");
            } else if (carSpeed >= (speedLimit + 5) && carSpeed < (speedLimit + 10))
            {
                Console.WriteLine("You have 1 demerit.");
            } else if (carSpeed >= (speedLimit + 10) && carSpeed < (speedLimit + 15))
            {
                Console.WriteLine("You have 2 demerits.");
            } else if (carSpeed >= (speedLimit + 15) && carSpeed < (speedLimit + 20))
            {

                Console.WriteLine("You have 3 demerits.");
            }
            else if (carSpeed >= (speedLimit + 20) && carSpeed < (speedLimit + 25))
            {
                Console.WriteLine("You have 4 demerits.");
            }
            else if (carSpeed >= (speedLimit + 25) && carSpeed < (speedLimit + 30))
            {
                Console.WriteLine("You have 5 demerits.");
            }
            else if (carSpeed >= (speedLimit + 30) && carSpeed < (speedLimit + 35))
            {
                Console.WriteLine("You have 6 demerits.");
            }
            else if (carSpeed >= (speedLimit + 35) && carSpeed < (speedLimit + 40))
            {
                Console.WriteLine("You have 7 demerits.");
            }
            else if (carSpeed >= (speedLimit + 40) && carSpeed < (speedLimit + 45))
            {
                Console.WriteLine("You have 8 demerits.");
            }
            else if (carSpeed >= (speedLimit + 45) && carSpeed < (speedLimit + 50))
            {
                Console.WriteLine("You have 9 demerits.");
            }
            else if (carSpeed >= (speedLimit + 50) && carSpeed < (speedLimit + 55))
            {
                Console.WriteLine("You have 4 demerits.");
            }
            else if (carSpeed >= (speedLimit + 55) && carSpeed < (speedLimit + 60))
            {
                Console.WriteLine("You have 11 demerits.");
            }
            else if (carSpeed >= (speedLimit + 60))
            {
                Console.WriteLine("License suspended.");
            }
        }
    }
}
