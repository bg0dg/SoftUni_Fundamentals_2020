using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            string pattern = @"\%([A-Z]{1}[a-z]+)%.*<(?<product>\w+)>.*\|(?<count>\d+)\|.*?(?<price>\d+\.?\d+)\$"; //with numbers of groups
            //string pattern = @"\%(?<customer>[A-Z]{1}[a-z]+)%.*<(\w+)>.*\|(\d+)\|.*?(\d+\.?\d+)\$"; //with names of groups

            Regex regex = new Regex(pattern);

            decimal income = 0;

            while ((input = Console.ReadLine()) != "end of shift") 
            {
                bool isThereAMatch = regex.IsMatch(input); //проверява дали има съвпадение по образеца

                if (isThereAMatch) //Ако има 
                {
                    Match match = regex.Match(input); //Match се използва вместо MatchCollection, понеже няма да правим foreach и т.н. Т.е. не ни трябва като колекция;

                    string customerName = match.Groups[1].ToString();
                    //string customerName = match.Groups["customer"].ToString();

                    string product = match.Groups[2].ToString();
                    //string product = match.Groups["product"].ToString();

                    int quantity = int.Parse(match.Groups[3].ToString());
                    //int quantity = int.Parse(match.Groups["count"].ToString());

                    decimal cost = decimal.Parse(match.Groups[4].ToString());
                    //decimal cost = decimal.Parse(match.Groups["price"].ToString());

                    decimal totalPrice = quantity * cost;

                    Console.WriteLine($"{customerName}: {product} - {totalPrice:F}");

                    income += totalPrice;
                }              
            }

            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}
