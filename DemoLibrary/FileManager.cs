using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class FileManager
    {
        //create folderlcoation string that main can write, and FileManager can use
        public StreamWriter SW { get; set; }
        public StreamWriter SR { get; set; }

        public void WriteFile(TextFile p_file)
        {
            //StreamWriter sw = new StreamWriter(p_filename);
            SW = new StreamWriter($"{p_file.Location}{p_file.FileName}");
            try
            {
                //sw.Write(p_text);
                SW.Write(p_file.Text);
            }
            catch (Exception)
            {
                throw;
            }
            //close stream writer regardless of exception
            finally
            {
                SW.Close();
            }
        }

        //public string CreateFileLocation()
        //{
        //    string fileLocation = $"{FMFile.FolderPath}{FMFile.FileName}";
        //    return fileLocation;
        //}

        public string createTextToWrite(string p_saveKey)
        {
            string buff = "";
            string text = "";
            do
            {
                text += buff;
                buff = Console.ReadLine();
                if (text != "")
                {
                    text += "\n";
                }
            } while (buff != p_saveKey);

            return text;
        }
    }
}
