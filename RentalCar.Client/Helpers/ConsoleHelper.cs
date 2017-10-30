using RentalCar.Core.Enums;
using System;
using System.Collections.Generic;

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

        public static List<string> NewVehicleMenu()
        {
            PrintLine("Enter the new Vehicle's details");
            
            string vehicleName = LoopNonNullInput("Vehicle Name:");            
            string numberPlate = LoopNonNullInput("Vehicle Number Plate:");
            string currentMileage = LoopNonNullInput("Vehicle Current Mileage:");
            string rentalCharge = LoopNonNullInput("Vehicle Rental Charge:");


            Dictionary<string, string> choices = new Dictionary<string, string>();
            choices.Add("1", "Campervan");
            choices.Add("2", "Bike");
            choices.Add("3", "Car");
            string vehicleType = LoopNonNullInput("Vehicle Vehicle Type:", choices);
             
            //string numberPlate = LoopInput("Vehicle Number Plate:");
            //string numberPlate = LoopInput("Vehicle Number Plate:");
            //string numberPlate = LoopInput("Vehicle Number Plate:");
            //string numberPlate = LoopInput("Vehicle Number Plate:");


            //PrintLine("Vehicle Vehicle Type:");
            //PrintLine("Select one of the following below");
            //PrintLine("(1) - Campervan");
            //PrintLine("(2) - Bike");
            //PrintLine("(3) - Car");
            //string vehicleType = GetUserInput();
            //PrintLine("Vehicle Current Mileage:");
            //string currentMileage = GetUserInput();
            //PrintLine("Vehicle Current Mileage:");
            //string currentMileage = GetUserInput();
        }

        public static string LoopNonNullInput(string displayMessage, Dictionary<string, string> allowableValues = null)
        {
            string userInput = string.Empty;
            bool flag = true;
            while (flag)
            {
                PrintLine(displayMessage);
                PrintChoices(allowableValues);
                userInput = GetUserInput();
                if (string.IsNullOrEmpty(userInput))
                {
                    PrintLine("You have entered an empty command. Please try again");
                }
                else if(allowableValues != null)
                {
                    foreach (var item in allowableValues)
                    {
                        if (item.Key.ToLower().Equals(userInput.ToLower()))
                        {
                            flag = false;
                            break;
                        }
                    }
                    PrintLine("You have not made valid choice. Please try again");
                }
                else if(!string.IsNullOrEmpty(userInput))
                {
                    flag = false;
                    break;
                }
            }
            return userInput;            
        }

        public static void PrintChoices(Dictionary<string, string> choices)
        {
            if (choices == null)
                return;
            foreach (var item in choices)
            {         
                PrintLine(string.Format("({0}) - {1}", item.Key, item.Value));
            }
        }
    }
}
