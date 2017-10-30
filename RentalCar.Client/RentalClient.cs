using RentalCar.Client.Helpers;
using RentalCar.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        StringBuilder vehicleInformation = PrintVehicleInformation(vehicle);
                        ConsoleHelper.PrintLine(vehicleInformation.ToString());




                        break;
                    }
                case "b":
                    {
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

        private StringBuilder PrintVehicleInformation(VehicleDTO vehicle)
        {
            StringBuilder information = null;
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
                information.Append(campervan.Get_Basic_Information());
                information.Append(campervan.Get_Equipment());
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
                information.Append(bike.Get_Basic_Information());
                information.Append(bike.Under21_Ok());
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
                information.Append(car.Which_Road());
                information.Append(car.Get_Basic_Information());
                
            }
            
            return information;
        }
    }
}
