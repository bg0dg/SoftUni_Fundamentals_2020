using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] inputData = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string title = inputData[0].Trim();
                string content = inputData[1].Trim();
                string author = inputData[2].Trim();

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            string command = Console.ReadLine();


            if (command == "title")
            {
                foreach (Article article in articles.OrderBy(x => x.Title))
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }

            else if (command == "content")
            {
                foreach (Article article in articles.OrderBy(x => x.Content))
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }

            else if (command == "author")
            {
                foreach (Article article in articles.OrderBy(x => x.Author))
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }
    
        }
    }
}
