using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBookClient
{
    internal static class Environment
    {
        public static string GetUrl()
        {
            return "http://localhost:5267";
            //return "https://mywebapi.onrender.com";
        }
    }
}
