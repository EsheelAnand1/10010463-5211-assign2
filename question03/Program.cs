using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace question03
{
    class Program
    {
        static void Main(string[] args)
        { 
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //string[] fruitsArray = new string[] {"Banana", "Grapefruit", "Tomato", "Oranges"};//00:00:00.0000008

            List<string> fruitsArray = new List<string> {"Banana", "Grapefruit", "Tomato", "Oranges"}; //00:00:00.0000019
               
            
            sw.Stop();
             Console.WriteLine(sw.Elapsed);
            foreach(var fruit in fruitsArray) {
                Console.WriteLine(fruit);
            }
            Debug.Write(fruitsArray);
            Console.ReadLine();
        }
    }
}
