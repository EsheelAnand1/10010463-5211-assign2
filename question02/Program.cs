﻿using System;
using System.Diagnostics;

namespace question02
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string[] fruits = new string[4] {"Apple", "Banana", "Coconut", "Mandarin"};

            foreach(var fruit in fruits) {
                 Console.Write(fruit + " ");
            }  
           
            Debug.WriteLine(fruits);
            Console.ReadLine();
        }
    }
}
