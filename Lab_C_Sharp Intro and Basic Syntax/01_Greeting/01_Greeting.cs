using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Name
{
    class Hello_Name
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            WriteName(name);
        }

        private static void WriteName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
