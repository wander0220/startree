﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i < 8; i++)
            {
                for(int j = 0; j < 8-i; j++)
                {
                    Console.Write(" ");
                }
                for (int z = 0; z <=i*2; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
