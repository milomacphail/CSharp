﻿using System;
namespace Constructors_Inheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car {0}", registrationNumber);
        }
    }
}
