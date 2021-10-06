using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking
{
    public class CarPark
    {
        public List<Customer> listOfCustomers = new List<Customer>();

        public CarParkCharge carparkcharge = new CarParkCharge();

        public CarPark()
        {
            Console.WriteLine("I am the CarPark()");
        }

        public override string ToString()
        {
            return "I am the CarPark()";
        }

        public void CalculateCharges()
        {
            foreach (Customer customer in listOfCustomers)
            {
                string registration = customer.registration;
                int calculatedCharge = carparkcharge.CalculateCharge(customer.hoursParked);
                Console.WriteLine($"Calculating charge for customer : cost is {calculatedCharge} euro for registration {registration}");
            }
        }
    }
}
