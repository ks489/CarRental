using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Client
{
    public class RentalClient
    {
        public void PrintMenu()
        {
            Console.WriteLine("Search for vehicle");
            Console.WriteLine("a) Search for vehicle");
            Console.WriteLine("b) Enter new vehicle");
            Console.WriteLine("c) Show available vehicles");
        }

        public string GetUserInput()
        {
            return Console.ReadLine();
        }
    }
}
