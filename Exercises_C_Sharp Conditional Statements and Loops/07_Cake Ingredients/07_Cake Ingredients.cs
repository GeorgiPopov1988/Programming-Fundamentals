using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var addProduct = string.Empty;
            var counter = 0;

            while (addProduct != "Bake!")
            {
                addProduct = Console.ReadLine();
                if (addProduct == "Bake!")
                {

                    Console.WriteLine($"Preparing cake with {counter} ingredients.");

                }
                else
                {
                    Console.WriteLine($"Adding ingredient {addProduct}.");
                }


                counter++;
            }





        }
    }
}
