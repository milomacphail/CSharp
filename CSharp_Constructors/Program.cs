using System;

namespace CSharp_Constructors
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order); 

        }
    }
}
