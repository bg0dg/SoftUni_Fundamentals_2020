using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            string[] Phrases = {"Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."};

            string[] Events = {"Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.",
                "I feel great!"};

            string[] Authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            string[] Cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            for (int i = 0; i < numberOfMessages; i++)
            {
                string randomPhrase = RandomPhrases(Phrases);
                string randomEvents = RandomEvents(Events);
                string randomAuthors = RandomAuthors(Authors);
                string randomCities = RandomCities(Cities);

                Message message = new Message(randomPhrase, randomEvents, randomAuthors, randomCities);

                Console.WriteLine($"{message.Phrase} {message.MyEvent} {message.Author} – {message.City}.");
            }
        }

        public static string RandomCities(string[] cities)
        {
            Random rnd = new Random();
            int rndElement = rnd.Next(0, cities.Length);

            return cities[rndElement];
        }

        public static string RandomAuthors(string[] authors)
        {
            Random rnd = new Random();
            int rndElement = rnd.Next(0, authors.Length);

            return authors[rndElement];
        }

        public static string RandomEvents(string[] events)
        {
            Random rnd = new Random();
            int rndElement = rnd.Next(0, events.Length);

            return events[rndElement];
        }

        public static string RandomPhrases(string[] phrases)
        {
            Random rnd = new Random();
            int rndElement = rnd.Next(0, phrases.Length);

            return phrases[rndElement];
        }
    }
}
