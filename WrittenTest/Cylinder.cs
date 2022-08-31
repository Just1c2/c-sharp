using System;

namespace WrittenTest
{
    class Cylinder
    {
        static double radius, height;

        static void Main(string[] args)
        {
            Process();
            Result();
        }

        public static void Process()
        {
            Console.WriteLine("Enter the dimenstions of the cylinder");
            Console.Write("Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            height = Convert.ToDouble(Console.ReadLine());          
        }
        public static void Result()
        {
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius: {0}, Height: {1}", radius, height);
            Console.WriteLine("Base: {0} | Lateral: {1} | Total: {2} | Volume: {3}", radius * radius * Math.PI, 2 * Math.PI * radius * height, 2 * Math.PI * radius * (height + radius), Math.PI * radius * radius * height);
        }
    }
}
