﻿using RentalCar.Client.Helpers;
using RentalCar.Core.Models;
using System;
using System.Collections.Generic;

namespace RentalCar.Client
{
    /// <summary>
    /// Console client application that deals with Rental Car client interaction
    /// </summary>
    public class RentalClient
    {
        #region Private Variables
        MyVehicleService.IVehicleService _vehicleService;        
        MySearchVehicleWorkFlow.IService _searchVehicle;
        MyAddVehicleWorkFlow.IService _addVehicle;
        MyAvailableVehiclesWorkFlow.IService _availableVehicles;
        #endregion

        /// <summary>
        /// Constructor - Added constructor dependency injection (Without any containers) 
        /// To add any external web services this client interacts with which are the workflow wcf services
        /// </summary>
        public RentalClient()
        {
            _vehicleService = new MyVehicleService.VehicleServiceClient();
            _searchVehicle = new MySearchVehicleWorkFlow.ServiceClient();
            _addVehicle = new MyAddVehicleWorkFlow.ServiceClient();
            _availableVehicles = new MyAvailableVehiclesWorkFlow.ServiceClient();
            RunApplication();
        }

        /// <summary>
        /// Entry point to this client's application
        /// It will initialize and run the application
        /// </summary>
        private void RunApplication()
        {
            bool flag = true;
            //This will iterate the application
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

        /// <summary>
        /// This will navigate to the correct menu selected functionality
        /// </summary>
        /// <param name="command">Menu Item Command</param>
        private void RunCommand(string command)
        {
            try
            {
                command = command.ToLower();
                switch (command)
                {
                    case "a":
                        {
                            ConsoleHelper.PrintLine("Enter the vehicle's number plate");
                            string numberplate = ConsoleHelper.GetUserInput();

                            var vehicle = _searchVehicle.Get(numberplate);
                            
                            if (vehicle == null)
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
                            VehicleDTO vehicle = ConsoleHelper.NewVehicleMenu();
                            int addResult = _addVehicle.Add(vehicle);

                            string lol = "";
                            break;
                        }
                    case "c":
                        {
                            var list = _availableVehicles.Get();
                            foreach (var item in list)
                            {
                                List<string> vehicleInformation = PrintVehicleInformation(item);
                                ConsoleHelper.PrintLine(vehicleInformation);
                            }
                            break;
                        }
                    default:
                        {
                            ConsoleHelper.PrintLine(string.Format("The command : {0} is not a valid command. Please try again", command));
                            break;
                        }

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Validates the user input has entered the correct menu item command and that it is of type char
        /// </summary>
        /// <param name="command">Menu item command</param>
        /// <returns>Validated boolean value</returns>
        private bool ValidateCommand(string command)
        {
            char character;
            if(Char.TryParse(command, out character))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// This will print the vehicle information according to the vehicle type being returned
        /// This will add all valid string information about the vehicle. Some vehicles have 
        /// More information returned.
        /// </summary>
        /// <param name="vehicle">Vehicle Data Transfer Object</param>
        /// <returns>List of string values that are used to print the vehicles details</returns>
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
