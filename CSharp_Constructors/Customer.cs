using System.Collections.Generic;

namespace CSharp_Constructors
{
    internal class Customer
    {
            public int Id;
            public string Name;
            public List<Order> Orders;

        public Customer(int id)
            :this()
        {
            this.Id = id;

        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}