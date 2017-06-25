using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            var theString = Console.ReadLine();


            if (theString.EndsWith("y"))
            {
                theString = theString.Remove(theString.Length - 1);

                Console.WriteLine(theString + "ies");
            }
            else if (theString.EndsWith("o") || theString.EndsWith("s") ||
                theString.EndsWith("x") || theString.EndsWith("z") ||
                theString.EndsWith("sh") || theString.EndsWith("ch"))
            {

                Console.WriteLine(theString + "es");
            }
            else
            {
                Console.WriteLine(theString + "s");
            }




        }
    }
}
