using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_04.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < count; i++)
            {
                string[] inputInfo = Console.ReadLine().Split('_').ToArray();

                string typeList = inputInfo[0];
                string name = inputInfo[1];
                string time = inputInfo[2];

                Song song = new Song();

                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);

                //song.PrintName();
            }

            string targerListType = Console.ReadLine();

            if (targerListType == "all")
            {
                foreach (Song currentSong in songs)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }

            else
            {
                foreach (Song currentSong in songs)
                {
                    if (currentSong.TypeList == targerListType)
                    {
                        Console.WriteLine(currentSong.Name);
                    }
                }
            }

            //1st solution:

            //foreach (Song currentSong in songs)
            //{
            //    if (currentSong.TypeList == targerListType)
            //    {
            //        Console.WriteLine(currentSong.Name);
            //    }
            //}

            //2nd solution:

            //songs = songs.FindAll(x => x.TypeList == targerListType);
            //
            //foreach (Song currentSong in songs)
            //{
            //    if (currentSong.TypeList == targerListType)
            //    {
            //        Console.WriteLine(currentSong.Name);
            //    }
            //}

            //3rd solutoin:

            //songs.Where(x => x.TypeList == targerListType).ToList().ForEach(x => Console.WriteLine(x.Name));
        }
    }
}
