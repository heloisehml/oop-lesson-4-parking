﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking
{
    public class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am the code driver");

        }
        public void CreateObjects()
        {
            CarPark carpark = new CarPark();

            carpark.listOfCustomers.Add(new Customer("a",2));
            carpark.listOfCustomers.Add(new Customer("b",3));
            carpark.listOfCustomers.Add(new Customer("c", 4));
            carpark.listOfCustomers.Add(new Customer("d", 5));
            carpark.listOfCustomers.Add(new Customer("e", 6));
            carpark.listOfCustomers.Add(new Customer("f", 7));

            carpark.CalculateCharges();



            Customer customer = new Customer("g", 8);
            CarParkCharge carparkcharge = new CarParkCharge();


            //call the ToString method
            Console.Write(carpark.ToString());
            Console.Write(customer.ToString());
            Console.Write(carparkcharge.ToString());
        }
    }
}
