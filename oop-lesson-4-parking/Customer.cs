using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking
{
    public class Customer
    {
        public string registration { get; set; }
        public int hoursParked { get; set; }

        
        public Customer(string _registration, int _hoursParked)
        {
            Console.WriteLine("I am the Customer()");
            registration = _registration;
            hoursParked = _hoursParked;
        }
        public override string ToString()
        {
            return "I am the Customer()";
        }
    }
}
