using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace question03
{
    class Program
    {
        static void Main(string[] args)
        { Stopwatch sw = new Stopwatch();
            sw.Start();
            string[] fruitsArray = new string[] {"Banana", "Grapefruit", "Tomato", "Oranges"};

            //List<string> fruitsArray = new List<string> {"Banana", "Grapefruit", "Tomato", "Oranges"};

            foreach(var fruit in fruitsArray) {
                Console.WriteLine(fruit);
            }
        }
    }
}
