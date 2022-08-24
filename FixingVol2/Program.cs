using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixingVol2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;

            num1 = 30;
            num2 = 60;
            result = Convert.ToByte(num1 * num2);
            
            try
            {
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
                Console.ReadLine();
            } catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
