namespace _1_Reverse_string
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            
            Console.WriteLine(new string(input.Reverse().ToArray()));

        }   
    }
}
