using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    DemoCode1 demo = new DemoCode1();
        //    try
        //    {
        //        Console.WriteLine(demo.GetArrVal(6));
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        Console.WriteLine(e.StackTrace);
        //    }
        //}
       
        static void Main(string[] args)
        {
            try
            {
                FileManager fm = new FileManager();

                Console.WriteLine("Enter file name >");

                string filename = "..\\..\\..\\TextFiles\\" + Console.ReadLine() + ".txt";

                string saveKey = "*SAVE";
                Console.WriteLine($"Enter text to write to file ({saveKey} to save)");

                string text = fm.createTextToWrite(saveKey);

                fm.WriteFile(filename, text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
        
    }
}
