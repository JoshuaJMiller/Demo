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
        public void WriteFile(String p_filename, String p_text)
        {
            StreamWriter sw = new StreamWriter(p_filename);
            try
            {
                sw.Write(p_text);
            }
            catch (Exception)
            {
                throw;
            }
            //close stream writer regardless of exception
            finally
            {
                sw.Close();
            }
        }

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

            //while (buff != p_saveKey)
            //{
            //    text += buff + "\n";
            //    buff = Console.ReadLine();
            //}
            return text;
        }
    }
}
