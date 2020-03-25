using System;

namespace _1._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string person = "";

            if (input >= 66)
            {
                person = "elder";
            }
            else
            {
                switch (input)
                {
                    case int age when (age >= 0 && age <= 2):
                        person = "baby";
                        break;
                    case int age when (age >= 3 && age <= 13):
                        person = "child";
                        break;
                    case int age when (age >= 14 && age <= 19):
                        person = "teenager";
                        break;
                    case int age when (age >= 20 && age <= 66):
                        person = "adult";
                        break;
                    default:
                        Console.WriteLine("no data");
                        break;
                }
            }

            //VARIANT 2
            //if (input <= 2)
            //{
            //    person = "baby";
            //}
            //
            //else if (input <= 13)
            //{
            //    person = "child";
            //}
            //
            //else if (input <= 19)
            //{
            //    person = "teenager";
            //}
            //
            //else if (input <= 65)
            //{
            //    person = "adult";
            //}
            //else
            //{
            //    person = "elder";
            //}

            Console.WriteLine(person);

        }
    }
}
