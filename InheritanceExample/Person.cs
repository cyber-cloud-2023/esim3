using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal abstract class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }

        protected string address;
        private string test;
       
        private void SetTest(string value)
        {
            test = value;
        }
        private void SetAddress(string value)
        {
            address = value;
        }
    }
}
