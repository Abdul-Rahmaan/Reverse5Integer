﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FiveReverseInteger
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_integer
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[5];

            Console.Write("Input the number of integers to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input {0} number of integers in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("integer {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values store into the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.Write("\n\nThe values store into the array in reverse are :\n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");

        }
    }
}

