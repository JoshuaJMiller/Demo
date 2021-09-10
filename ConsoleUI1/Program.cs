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
        private static TextFile File = new TextFile();
        private static FileManager fm = new FileManager();
        private static string Location = "..\\..\\..\\TextFiles\\";
        private static string SaveKey = "*SAVE";
        
        static void Main(string[] args)
        {
            try
            {
                File.Location = Location;

                //Console.WriteLine("Enter file name (including ext)>");

                //File.FileName = Console.ReadLine();

                GetFileName();

                //Console.WriteLine($"Enter text to write to file ({SaveKey} to save)");

                //File.Text = fm.createTextToWrite(SaveKey);

                //fm.WriteFile(File);

                CreateAndSaveFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
        private static void GetFileName()
        {
            Console.WriteLine("Enter file name (including ext)>");

            File.FileName = Console.ReadLine();
        }
        private static void CreateAndSaveFile()
        {
            Console.WriteLine($"Enter text to write to file ({SaveKey} to save)");

            File.Text = fm.createTextToWrite(SaveKey);

            fm.WriteFile(File);
        }
    }
}
