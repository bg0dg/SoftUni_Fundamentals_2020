using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_and_Classes
{
    class Car
    {
        public Car( string name, int age) //constructor
        {
            Age = age;
            Name = name;
        }

        public string Name { get; set; } //property
        //public string Model { get; set; } //property
        //public string Color { get; set; } //property
        //public string RegNum { get; set; } //property
        public int Age { get; set; }
        //
        //public void AddYears() //method
        //{
        //    int addYears = int.Parse(Console.ReadLine());
        //    Age += addYears;
        //}

            //----------------------------------------------

        //public Car() //constructor
        //{
        //    CarProperies = new List<string>(); //declaration of property
        //
        //}
        //
        //public List <string> CarProperies { get; set; } //List of properties


        
    }
}
