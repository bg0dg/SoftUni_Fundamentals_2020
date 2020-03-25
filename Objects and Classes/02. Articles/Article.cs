using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        
        public string Title  { get; set; }
        public string Content  { get; set; }
        public string Author  { get; set; }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

    }
}
