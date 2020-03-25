using System;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {           
            string title = Console.ReadLine();

            string article = Console.ReadLine();

            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {article}");
            Console.WriteLine("</article>");

            string commands;

            while ((commands = Console.ReadLine()) != "end of comments")
            {
                string comment = commands;

                Console.WriteLine("<div>");
                Console.WriteLine($"    {comment}");
                Console.WriteLine("</div>");
            }
        }
    }
}
