using System;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string title = inputData[0].Trim();
            string content = inputData[1].Trim();
            string author = inputData[2].Trim();

            int numberOFcommands = int.Parse(Console.ReadLine());

            Article article = new Article(title, content, author);

            for (int i = 0; i < numberOFcommands; i++)
            {
                string[] commands = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = commands[0].Trim();
                string commandText = commands[1].Trim();

                if (command == "Edit")
                {
                    article.Edit(commandText);
                }

                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(commandText);
                }

                else if (command == "Rename")
                {
                    article.Rename(commandText);
                }
                
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
