using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _6._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehiclesList = new List<Vehicle>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "")
                {
                    break;
                }

                string[] inputString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string typeOfVehicle = inputString[0];
                string modelOfVehicle = inputString[1];
                string colorOfVehicle = inputString[2];
                int horsepowerOfVehicle = int.Parse(inputString[3]);

                Vehicle vehicle = new Vehicle(typeOfVehicle, modelOfVehicle, colorOfVehicle, horsepowerOfVehicle);

                vehiclesList.Add(vehicle);

            }

            string secondImput = Console.ReadLine();

            while (secondImput != "Close the Catalogue")
            {

                if (secondImput == null)
                {
                    break;
                }

                Vehicle searchedVehicle = vehiclesList.Find(x => x.Model == secondImput);

                //string vehicleTypeString = searchedVehicle.Type;

                //string vehicleTypeStringFirstCharUpper =  MakeFirstCharToUpper(vehicleTypeString);

                //Console.WriteLine($"Type: {vehicleTypeStringFirstCharUpper}");
                //Console.WriteLine($"Model: {searchedVehicle.Model}");
                //Console.WriteLine($"Color: {searchedVehicle.Color}");
                //Console.WriteLine($"Horsepower: {searchedVehicle.Horsepower}");

                Console.WriteLine(searchedVehicle); //Can be with or without ".ToString()". Substitutes the upper rows.

                //----------------
                secondImput = Console.ReadLine();

                if (secondImput == "Close the Catalogue")
                {
                    double totalHPCars = 0;

                    List<Vehicle> onlyCars = vehiclesList.Where(x => x.Type == "car").ToList();
                    List<Vehicle> onlyTrucks = vehiclesList.Where(x => x.Type == "truck").ToList();

                    foreach (Vehicle vehicle in onlyCars)
                    {
                        totalHPCars += vehicle.Horsepower;
                    }

                    double totalHPTrucks = 0;

                    foreach (Vehicle vehicle in onlyTrucks)
                    {
                        totalHPTrucks += vehicle.Horsepower;
                    }


                    double averageCarsHP = 0;

                    if (onlyCars.Count > 0)
                    {
                        averageCarsHP = totalHPCars / onlyCars.Count;
                    }


                    double averageTrucksHP = 0;

                    if (onlyTrucks.Count > 0)
                    {
                        averageTrucksHP = totalHPTrucks / onlyTrucks.Count;
                    }

                    Console.WriteLine($"Cars have average horsepower of: {averageCarsHP:F2}.");
                    Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHP:F2}.");

                }
            }

        }

        //private static string MakeFirstCharToUpper(string vehicleTypeString)
        //{
        //    return vehicleTypeString.First().ToString().ToUpper() + vehicleTypeString.Substring(1);
        //}
    }

    class Vehicle
    {
        public Vehicle(string typeOfVehicle, string modelOfVehicle, string colorOfVehicle, int horsepowerOfVehicle)
        {
            this.Type = typeOfVehicle;
            this.Model = modelOfVehicle;
            this.Color = colorOfVehicle;
            this.Horsepower = horsepowerOfVehicle;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            //string capitalized = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.Type);

            //string output = $"Type: {capitalized}{Environment.NewLine}" //string output = $"Type: {this.Type}\n";

            string output = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}"
            + $"Model: {this.Model}{Environment.NewLine}" //output += $"Model: {this.Model}\n";
            + $"Color: {this.Color}{Environment.NewLine}" //output += $"Color: {this.Color}\n";
            + $"Horsepower: {this.Horsepower}"; //output += $"Horsepower: {this.Horsepower}";

            return output;
        }

    }
}
