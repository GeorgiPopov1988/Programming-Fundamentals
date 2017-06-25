using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < resultCnt; cnt++)
            {
                string result = Console.ReadLine();

                if (result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();

                    Console.WriteLine(GetSuccessResult(operation, message));
                }
                else if (result == "error")
                {
                    var reason = string.Empty;

                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());

                    if (code > 0)
                    {
                        reason = "Invalid Client Data";
                    }
                    else
                    {
                        reason = "Internal System Failure";
                    }

                    Console.WriteLine(GetErrorResult(operation, code, reason));

                }

            }


        }

        static string GetErrorResult(string operation, int code,string reason)
        {
            return $"Error: Failed to execute {operation}.\n" +
                   $"==============================\n" +
                   $"Error Code: { code}.\n" +
                   $"Reason: {reason}.";
        }

        static string GetSuccessResult(string operation, string message)
        {
           return $"Successfully executed {operation}.\n" +
                  $"==============================\n" +
                  $"Message: {message}.";
        }
    }
}
