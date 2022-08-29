using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EmployeeManagment
{
    class Employee
    {
        ArrayList emp = new ArrayList();

        private int id;
        private string name;
        private int age;
        private string salary;

        public Employee( int id, string name, int age, string salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Salary { get; set; }


    } 
}
