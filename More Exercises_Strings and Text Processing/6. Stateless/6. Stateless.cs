namespace _6.Stateless
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
            string firstInputLine = Console.ReadLine();

            while (firstInputLine != "collapse")
            {

                string secondInputLine = Console.ReadLine();

                while (secondInputLine.Length > 0)
                {

                    bool contains = firstInputLine.Contains(secondInputLine);

                    if (contains)
                    {

                        firstInputLine = firstInputLine.Replace(secondInputLine, "");
                        contains = false;

                    }

                    else
                    {
                        secondInputLine = secondInputLine.Remove(0, 1);

                        if (secondInputLine.Length > 0)
                        {

                            secondInputLine = secondInputLine.Remove((secondInputLine.Length - 1), 1);

                        }
                    }
                }
                if (firstInputLine.Length > 0)
                {
                    Console.WriteLine(firstInputLine.Trim());
                }
                else

                {
                    Console.WriteLine("(void)");
                }

                firstInputLine = Console.ReadLine();
            }
        }
    }
}
