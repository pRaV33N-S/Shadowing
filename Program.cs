using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowing
{
    internal class Program
    {
        static int myVar = 15;
        public static void Display()
        {
            int myVar = 25;
            Console.WriteLine("Value of local myVar in Display : "+myVar);
            Console.WriteLine("Global Variable Values is : " + Program.myVar);
        }
        static void Main(string[] args)
        {
            int myVar = 10;
            Console.WriteLine("Inner myVar is : "+myVar);
            Console.WriteLine("Outer myVar is : "+Program.myVar);
            Display();
        }
    }
}
