using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class Teacher : Person, IPerson
    {
        public double Salary { get; set; }

        public void SayHello(string message)
        {
            Console.WriteLine("Olen opettaja "+message);
        }
    }
}
