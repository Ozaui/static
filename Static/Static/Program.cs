﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee.printNameSurname();
            Employee.addNumer(3, 5);
            Employee.employee = "Özay";

            Console.ReadLine(); 
        }
    }
}
