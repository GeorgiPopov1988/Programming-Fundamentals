﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Employee_Data
{
    class Problem3_Employee_Data
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}\n" +
                              $"Age: {age}\n" +
                              $"Employee ID: {employeeID:D8}\n" +
                              $"Salary: {salary:F2}\n");
        }
    }
}
