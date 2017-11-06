I have attempted all exercises.

The architecture of the application is as follows

Client -> WCF WorkFlow -> WCF Services

All client calls will call a wcf workflow service and that workflow service calls a wcf service.



Project setup
1. Create all sql schemas using the scripts found in the SQL folder of the project.
2. Open up the "RentalCar" solution file
3. Run the visual studio application (I have configured this to start up all the relevant services and client in the correct order by just running the application using f5 button)