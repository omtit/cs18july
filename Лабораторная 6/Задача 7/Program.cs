﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            if (A > B)
            {
                while (B <= A)
                {
                    Console.Write(A+" " );
                    A = A- 1;
                }
            }
            else
            {
                while (A <= B)
                {
                    Console.Write(A+" " );
                    A = A + 1;
                }
            }
        }
    }
}
