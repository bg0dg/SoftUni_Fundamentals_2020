using System;
using System.Linq;

namespace _2019_Nov_Gr1_Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] particles = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string inputCommands;

            while ((inputCommands = Console.ReadLine()) != "Done")
            {
                string[] inputCommandWords = inputCommands.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = inputCommandWords[0];
                string secondCommand = inputCommandWords[1];

                int index = 0;

                if (inputCommandWords.Length > 2)
                {
                    index = int.Parse(inputCommandWords[2]);
                }

                if (secondCommand == "Right")
                {
                    MoveRight(particles, index);
                }

                else if (secondCommand == "Left")
                {
                    MoveLeft(particles, index);
                }

                else if (secondCommand == "Even")
                {
                    PrintEvenPositions(particles);
                }

                else if (secondCommand == "Odd")
                {
                    PrintOddPositions(particles);
                }
            }

            string outputString = String.Join("", particles);

            Console.WriteLine($"You crafted {outputString}!");
        }


        private static void PrintOddPositions(string[] particles)
        {
            string oddParticles = "";

            for (int i = 0; i < particles.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddParticles += particles[i] + " ";
                }
            }

            Console.WriteLine(String.Join(" ", oddParticles));
        }

        private static void PrintEvenPositions(string[] particles)
        {
            string evenParticles = "";

            for (int i = 0; i < particles.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenParticles += particles[i] + " ";
                }
            }

            Console.WriteLine(String.Join(" ", evenParticles));
        }

        private static void MoveLeft(string[] particles, int index)
        {
            if (index <= particles.Length - 1 && index > 0)
            {
                string currentParticle = particles[index];

                string leftParticle = particles[index - 1];

                particles[index - 1] = currentParticle;

                particles[index] = leftParticle;
            }
        }

        private static void MoveRight(string[] particles, int index)
        {
            if (index < particles.Length - 1 && index > -1)
            {
                string currentParticle = particles[index];

                string rightParticle = particles[index + 1];

                particles[index + 1] = currentParticle;

                particles[index] = rightParticle;
            }
        }
    }
}
