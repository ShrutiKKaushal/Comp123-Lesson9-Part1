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

            try
            {

                
                string pathName = "C:\\Users\\300804023.CENCOL\\Documents\\Visual Studio 2013\\Projects\\";
                string fileName = "testFile.txt";
                string delimeter = ",";

                FileStream outFile = new FileStream(pathName + fileName, FileMode.Create, FileAccess.Write);// FileName, ModeOfFile, Access

                StreamWriter writer = new StreamWriter(outFile); // Object Writer


                for (int i = 0; i < 4; i++)
                {

                    writer.Write("Hello World ..!");
                    if(i < 3)
                    {
                        writer.Write(delimeter); // writes to the file
                    }
                }

                writer.Close(); // closes actual file

                outFile.Close(); // closes file stream

            }

            catch(Exception e)
            {
                Console.WriteLine("Your code caused an error");
                Console.WriteLine("Error: {0}", e.Message);
            }

           
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
