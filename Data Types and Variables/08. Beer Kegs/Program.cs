using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            string biggestModel = null;

            double maxVolume = 0.0D;

            byte n = byte.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentModel = Console.ReadLine();

                double radius = double.Parse(Console.ReadLine());

                int height = int.Parse(Console.ReadLine());

                double currentVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (currentVolume > maxVolume)
                {
                    maxVolume = currentVolume;
                    biggestModel = currentModel;
                }
            }

            Console.WriteLine(biggestModel);
        }
    }
}
