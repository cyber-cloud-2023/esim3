using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExample
{
    internal class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }

        public Person(string fn, string ln)
        {
            Fname = fn;
            Lname = ln;
        }
        public Person() { }
    }
}
