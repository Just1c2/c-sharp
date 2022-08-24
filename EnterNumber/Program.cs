using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Console.WriteLine("Enter the start number: ");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the end number: ");
                int end = Convert.ToInt32(Console.ReadLine());

                ReadNumber(start, end);

                Console.WriteLine("Enter 10 number: ");

                for (int i = 0; i < 10; i++)
                {
                    int numEntered = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch(InvalidInput ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ReadNumber(int start, int end)
        {
            int[] arr = Enumerable.Range(start, end).ToArray();
        }

        static void ValidateInput(int numEntered, int start, int end)
        {
            if(numEntered > end && numEntered < start)
            {
                throw new InvalidInput();
            }
        }
    }
    [Serializable]
    class InvalidInput : Exception
    {
        public InvalidInput() {}

        public InvalidInput(int numEntered) : base(String.Format("Invalid Input"))
        {

        }


    }
}
