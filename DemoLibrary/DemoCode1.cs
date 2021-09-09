using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    
    public class DemoCode1
    {
        public int[] array = new int[] { 0, 1, 2, 3 };
        public int GetArrVal(int p_num)
        {
            //sim db open
            Console.WriteLine("opening fake databass connection");
            try
            {
                return array[p_num];
            }
            catch (Exception e)
            {
                throw;
            }
            //sim db close regardless of exception
            finally
            {
                Console.WriteLine("closing fake databass connection");
            }
        }
       
    }
}
