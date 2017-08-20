namespace Problem_4___Winning_Ticket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static char[] winningSymbols = { '@', '#', '$', '^' };

        public static void Main()
        {
            string[] tickets = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim())
                .ToArray();

            int winResult = 0;


            foreach (var ticket in tickets)
            {
                if (ticket.Length < 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var leftPart = ticket.Take(10);
                var rightPart = ticket.Skip(10).Take(10);

                // take most occurrence char - left part
                char resultCharL = leftPart
               .GroupBy(x => x)
               .OrderByDescending(x => x.Count())
               .First()
               .Key;

                // take most occurrence char count - left part
                int resultIntL = leftPart
                    .GroupBy(x => x)
                    .OrderByDescending(x => x.Count())
                    .First()
                    .Count();

                if (resultIntL < 6)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }

                if (winningSymbols.Contains(resultCharL)
                                   && resultIntL >= 6)
                {
                    // take most occurrence char - right part
                    char resultCharR = rightPart
                          .GroupBy(x => x)
                          .OrderByDescending(x => x.Count())
                          .First()
                          .Key;

                    // take most occurrence char count - right part
                    int resultIntR = rightPart
                        .GroupBy(x => x)
                        .OrderByDescending(x => x.Count())
                        .First()
                        .Count();

                    if (winningSymbols.Contains(resultCharR)
                                       && resultCharL == resultCharR
                                       && resultIntR >= 6)
                    {
                        if (resultIntL == 10 && resultIntR == 10)
                        {
                            Console.WriteLine
                                ($"ticket \"{ticket}\" - {resultIntL}{resultCharL} Jackpot!");
                        }
                        else
                        {
                            if (resultIntR < resultIntL)
                            {
                                winResult = resultIntR;
                            }
                            else
                            {
                                winResult = resultIntL;
                            }
                            Console.WriteLine($"ticket \"{ticket}\" - {winResult}{resultCharL}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}

