using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListClass
{
    class Product
    {
        string name;
        double cost;
        int onhand;
        public Product(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }
        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C} On hand: {2}", name, cost, onhand);
        }
    }
    class Program
    {
        public static void Main()
        {
            ArrayList inv = new ArrayList();

            //Add elements to the list

            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("B", 5.29, 2));
            inv.Add(new Product("C", 8.9, 4));
            inv.Add(new Product("D", 5.9, 3));
            inv.Add(new Product("E", 1.8, 8));
            Console.WriteLine("Product list:");
            foreach(Product i in inv)
            {
                Console.WriteLine(" " + i);
            }
        }
    }
}
