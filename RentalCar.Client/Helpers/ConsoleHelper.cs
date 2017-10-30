using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Client.Helpers
{
    public static class ConsoleHelper
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Search for vehicle");
            Console.WriteLine("a) Search for vehicle");
            Console.WriteLine("b) Enter new vehicle");
            Console.WriteLine("c) Show available vehicles");
        }
        public static string GetUserInput()
        {
            return Console.ReadLine();
        }

        public static void PrintLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
