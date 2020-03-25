using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            //George, Peter, Bill, Tom

            string participantsInput = Console.ReadLine(); //четем реда с участниците

            string participantsRegexPattern = @"\w+"; //това е regex pattern-ът, който отделя само имената от целия стринг с учасниците

            Regex regexParticipants = new Regex(participantsRegexPattern); //Това е намереният регулярен израз

            MatchCollection participantsCollection = regexParticipants.Matches(participantsInput); //Това е колекция от съвпаденията (участниците)

            List<string> participants = participantsCollection.Cast<Match>().Select(m => m.Value).ToList(); //Колекцията от съвпадения я прехвърлям в списък (MatchCollection to List)

            Dictionary<string, int> NameDistanceRecords = new Dictionary<string, int>(); //Инициирам речник в който да пазя намерените имена с изминатото разстояние

            string input; //тук се подават стринговете в които има имена и разстояния

            //G4e@55or % 6g6!68e!!@
            //R1@!3a$y4456@
            //B5 @i@#123ll
            //G @e54o$r6ge#
            //7P % et ^#e5346r
            //T$o553m & 6

            //end of race

            while ((input = Console.ReadLine()) != "end of race")
            {
                string name = GetName(input); //Метод, с който намирам чрез regex името, криещо се в реда

                bool isparticipantExist = participants.Contains(name); //Проверявам дали името се съдържа в първоначалния списък

                if (isparticipantExist) //Ако се съдържа
                {
                    int distance = GetDistance(input); //Този метод намира всички отделни разстояния от регулярния израз и ги сумира

                    if (!NameDistanceRecords.ContainsKey(name))
                    {
                        NameDistanceRecords[name] = distance;
                    }
                    else
                    {
                        NameDistanceRecords[name] += distance;
                    }                  
                }
            }

            int place = 1;

            foreach (var kvp in NameDistanceRecords.OrderByDescending(kvp => kvp.Value)) //Сортира по изминато разстояние
            {
                if (place <= 3)
                {
                    string numEnd = DefineNumEnd(place); //определя се на числителното редно окончанието 1st, 2nd, 3rd в зависимост от числото - place

                    Console.WriteLine($"{place}{numEnd} place: {kvp.Key}");

                    place++;
                }
                else
                {
                    break;
                }      
            }
        }

        private static string DefineNumEnd(int place)
        {
            string numEnd = "";

            if (place == 1)
            {
                numEnd = "st";
            }
            else if (place == 2)
            {
                numEnd = "nd";
            }
            else if (place == 3)
            {
                numEnd = "rd";
            }

            return numEnd;
        }

        private static int GetDistance(string input)
        {
            string regPaternDistance = @"\d";

            Regex regexDistance = new Regex(regPaternDistance);

            MatchCollection distancesChars = regexDistance.Matches(input); //Прави колекция от всички намерени числа

            int totalDistance = 0;

            foreach (var item in distancesChars) //всяко число от колекцията се сумира в totalDistance
            {
                int singleDistance = int.Parse(item.ToString()); //преобразува се char-а от колекцията в string и се parse-ва

                totalDistance += singleDistance;
            }

            return totalDistance;
        }

        private static string GetName(string input)
        {
            string regPaternName = @"[A-Za-z]";

            Regex regexName = new Regex(regPaternName);

            MatchCollection nameChars = regexName.Matches(input);

            string name = String.Join("", nameChars);

            return name;
        }
    }
}
