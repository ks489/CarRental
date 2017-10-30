using RentalCar.Client.Helpers;
using RentalCar.Core.Models;
using System;
using System.Collections.Generic;

namespace RentalCar.Client
{
    public class RentalClient
    {
        #region Private Variables
        MyVehicleService.IVehicleService _vehicleService;
        #endregion
        public RentalClient()
        {
            _vehicleService = new MyVehicleService.VehicleServiceClient();
            RunApplication();
        }

        private void RunApplication()
        {
            bool flag = true;
            while (flag)
            {
                ConsoleHelper.PrintMenu();
                string command = ConsoleHelper.GetUserInput();
                if (ValidateCommand(command))
                {
                    RunCommand(command);
                }
                else
                {
                    ConsoleHelper.PrintLine("Incorrect command. Please enter a single character corresponding to the menu.");
                }
                
            }
        }

        private void RunCommand(string command)
        {
            command = command.ToLower();
            switch (command)
            {
                case "a":
                    {
                        ConsoleHelper.PrintLine("Enter the vehicle's number plate");
                        string numberplate = ConsoleHelper.GetUserInput();
                        var vehicle =_vehicleService.GetVehicle(numberplate);
                        if(vehicle == null)
                        {
                            ConsoleHelper.PrintLine("No Vehicle Found.");
                            return;
                        }
                        List<string> vehicleInformation = PrintVehicleInformation(vehicle);
                        ConsoleHelper.PrintLine(vehicleInformation);
                        break;
                    }
                case "b":
                    {
                        List<string> userInputList = ConsoleHelper.NewVehicleMenu();

                        break;
                    }
                case "c":
                    {
                        break;
                    }
                default:
                    {
                        ConsoleHelper.PrintLine(string.Format("The command : {0} is not a valid command. Please try again", command));
                        break;
                    }
                    
            }
        }

        private bool ValidateCommand(string command)
        {
            char character;
            if(Char.TryParse(command, out character))
            {
                return true;
            }
            return false;
        }

        private List<string> PrintVehicleInformation(VehicleDTO vehicle)
        {
            List<string> information = new List<string>();
            if (vehicle.VehicleType == Core.Enums.VehicleTypes.Campervan)
            {
                var campervan = new Campervan()
                {
                    VehicleID = vehicle.VehicleID,
                    CurrentMileage = vehicle.CurrentMileage,
                    NumberOfBeds = vehicle.NumberOfBeds,
                    NumberPlate = vehicle.NumberPlate,
                    RentalCharge = vehicle.RentalCharge,
                    Toilet = vehicle.Toilet
                };
                information.Add(campervan.Get_Basic_Information());
                information.Add(campervan.Get_Equipment());
            }
            else if(vehicle.VehicleType == Core.Enums.VehicleTypes.V2WBike)
            {
                var bike = new V2WBike()
                {
                    VehicleID = vehicle.VehicleID,
                    CurrentMileage = vehicle.CurrentMileage,
                    NumberPlate = vehicle.NumberPlate,
                    RentalCharge = vehicle.RentalCharge,
                    Under21 = vehicle.Under21
                };
                information.Add(bike.Get_Basic_Information());
                information.Add(bike.Under21_Ok());
            }
            else if (vehicle.VehicleType == Core.Enums.VehicleTypes.V4WDCar)
            {
                var car = new V4WDCar()
                {
                    VehicleID = vehicle.VehicleID,
                    CurrentMileage = vehicle.CurrentMileage,
                    NumberPlate = vehicle.NumberPlate,
                    RentalCharge = vehicle.RentalCharge,
                    RoadType = vehicle.RoadType
                };                
                information.Add(car.Get_Basic_Information());
                information.Add(car.Which_Road());

            }
            
            return information;
        }
    }
}
