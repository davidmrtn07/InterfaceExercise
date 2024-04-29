using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myfirstcar = new Car { Year = "1995", Make = "Honda", Model = "Accord", HasTrunk = true, Has6seats = false, CanDrive = true, DateEstablished = "1995", Logo = "Yes"};
            SUV myfirstsuv = new SUV { Year = "2020", Make = "Ford", Model = "Explorer", HasThirdRow = true, HasFourthRow = false, CanDrive = true, DateEstablished = "2020", Logo = "Yes" };
            Truck myfirsttruck = new Truck { Year = "2003", Make = "Chevy", Model = "Silverado", HasLongBed = true, HasBedCover = false, CanDrive = true, DateEstablished = "2003", Logo = "Yes" };


            List<ICompany> vehicles = new List<ICompany>();

            vehicles.Add(myfirstcar);
            vehicles.Add(myfirstsuv);
            vehicles.Add(myfirsttruck);

            foreach (ICompany vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model} CanDrive? {vehicle.CanDrive}");
                Console.WriteLine();
                vehicle.Drive();
                Console.WriteLine();
            }

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
