using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class ExHandling1
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[5];

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("a[{0}]", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Khong nhap dc ki tu cho mang so");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Khong duoc nhap gia tri nam ngoai mien");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Loi vuot qua pham vi cua mang");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write(" {0}", a[i]);
            }
        }
    }
}
