using System;
using System.Collections.Generic;
using System.Text;

namespace lab_04.Songs
{
    class Song
    {
        //Type List, Name and Time

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; } //Time Span - method, when we need to work with h, min

        public void PrintName()
        {
            Console.WriteLine(this.Name); //if it is in Programm must be: song.Name; "This" is the current object (instance of the class)
        }

    }
}
