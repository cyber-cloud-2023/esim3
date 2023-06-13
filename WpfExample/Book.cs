using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExample
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }

        public Book(string n, string a, string i) { 
            Name = n;
            Author = a;
            Isbn = i;
        }
    }
}
