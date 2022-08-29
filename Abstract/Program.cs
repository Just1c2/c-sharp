using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            IPerson perosn = new Citizen(name, age);
            Console.WriteLine(person.Name);
            Console.WriteLine(perosn.Age);
        }
    }
}
