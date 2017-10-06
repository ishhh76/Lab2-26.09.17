using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Book
    {
        private string name;
        private string author;
        private int count;

        public Book(string name, string author, int count)
        {
            this.name = name;
            this.author = author;
            this.count = count;
        }

        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public int Count { get => count; set => count = value; }

        
    }
}
