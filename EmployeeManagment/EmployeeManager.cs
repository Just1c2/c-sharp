using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace EmployeeManagement
{
    class Program
    {
        static ArrayList emp = new ArrayList();

        public static void Main(string[] args)
        {
            Menu();
            string choice = Console.ReadLine();
            while (true)
            {
                switch (choice)
                {
                    case "1":
                        Add();
                        Menu();
                        break;
                    case "2":
                        Delete();
                        Menu();
                        break;
                    case "3":
                        Modify();
                        Menu();
                        break;
                    case "4":
                        Display();
                        Menu();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                }
            }

        }
        public static void Menu() {
            
            Console.WriteLine("-----Menu-----");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Modify");
            Console.WriteLine("4.Display");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice: ");
           
        }
        public static void Add()
        {
            int id; string name; int age; string salary;
            Console.WriteLine("Enter id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary: ");
            salary = Console.ReadLine();
            emp.Add(new Employee(id, name, age, salary));
        }

        public static void Delete()
        {
            int id;
            Console.WriteLine("Enter employee's id: ");
            id = Convert.ToInt32(Console.ReadLine());
            emp.Remove(id);
        }

        public static void Modify()
        {
            int i;
            Console.WriteLine("Enter employee's id: ");
            i = Convert.ToInt32(Console.ReadLine());
            foreach(Employee e in emp)
            {
                if(e.Id == i)
                {
                    Console.WriteLine("Enter changed name: ");
                    string name = Console.ReadLine();
                    e.Name = name;
                    Console.WriteLine("Enter changed age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    e.Age = age;
                    Console.WriteLine("Enter changed salary: ");
                    string salary = Console.ReadLine();
                    e.Salary = salary;
                }
            }
        }

        public static void Display()
        {
            Console.WriteLine("Employee List: ");
            foreach(Employee i in emp) {
                Console.WriteLine(" " + i);
            }
        }
        
    }
    class Employee
    {


        private int id;
        private string name;
        private int age;
        private string salary;

        public Employee(int id, string name, int age, string salary)
        {
            id = Id;
            name = Name;
            age = Age;
            salary = Salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Salary { get; set; }

        public override string ToString()
        {
            return String.Format("Id: {0}  Name: {1},  Age: {2},  Salary: {3}", id, name, age, salary);
        }

    }
}
