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
            Console.WriteLine("");
            Console.WriteLine("###############################");
            Console.WriteLine("Search for vehicle");
            Console.WriteLine("a) Search for vehicle");
            Console.WriteLine("b) Enter new vehicle");
            Console.WriteLine("c) Show available vehicles");
            Console.WriteLine("###############################");
            Console.WriteLine("");
        }
        public static string GetUserInput()
        {
            return Console.ReadLine();
        }

        public static void PrintLine(string text)
        {
            Console.WriteLine(text);
        }

        public static void PrintLine(List<string> text)
        {
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }            
        }
    }
}
