using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // need this for any system Input / output

namespace Comp123_Lesson9_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitForKey();
        }


        // UTILITY METHODS
        private static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
