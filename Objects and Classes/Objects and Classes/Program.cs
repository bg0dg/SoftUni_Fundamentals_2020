using System;

namespace Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car(15); //instance of Car
            //
            //car1.Name = "Volvo";
            //car1.Model = "V50";
            //car1.Color = "black"; 
            //car1.RegNum = "CA4538XP";
            ////car1.Age = 15;
            //
            //Console.WriteLine($"Name: {car1.Name}");
            //Console.WriteLine($"Model: {car1.Model}");
            //Console.WriteLine($"Color: {car1.Color}");
            //Console.WriteLine($"RegNum: {car1.RegNum}");
            //Console.WriteLine($"Age: {car1.Age}");
            //
            //Car car2 = new Car(11);
            ////car2.Age = 11;
            //
            //car2.Name = "Citoren";
            //car2.Model = "C3 Picasso";
            //car2.Color = "grey";
            //car2.RegNum = "CA9010AB";
            //
            //Console.WriteLine($"Name: {car2.Name}");
            //Console.WriteLine($"Model: {car2.Model}");
            //Console.WriteLine($"Color: {car2.Color}");
            //Console.WriteLine($"RegNum: {car2.RegNum}");
            //Console.WriteLine($"Age: {car2.Age}");
            //
            //car2.AddYears();
            //
            //Console.WriteLine($"Age: {car2.Age}");

            //--------------------------

            //Car car1 = new Car(); //create object/instance car1 of clas Car

            //after instance with "." your can call properties !!!

            //car1.CarProperies.Add("Volvo");
            //car1.CarProperies.Add("Citoren");
            //
            //foreach (var name in car1.CarProperies)
            //{
            //    Console.WriteLine(name);
            //}


            Car car1 = new Car("Opel", 14);

            Console.WriteLine($"{car1.Name}, {car1.Age}");
        }
    }
}
