using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace InheritanceExample
{
    internal class Student :Person, IPerson
    {
        public int CreditPoints { get; set; }

        public void SayHello(string message)
        {
            Console.WriteLine("Olen opiskelija "+message);
        }

        private void SetAddress(string value)
        {
            address = value;
        }
    }
}
