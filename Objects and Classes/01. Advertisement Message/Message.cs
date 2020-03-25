using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Advertisement_Message
{
    public class Message
    { 
        public Message(string phrase, string myEvent, string author, string city)
        {
            Phrase = phrase;
            MyEvent = myEvent;
            Author = author;
            City = city;
        }

        public string Phrase { get; set; }
        public string MyEvent { get; set; }
        public string Author { get; set; }
        public string City { get; set; }
    }
}
