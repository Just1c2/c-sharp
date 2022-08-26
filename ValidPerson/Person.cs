using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPerson
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

       public static void Main()
        {
            Person pesho = new Person("Pesho", "Peshev", 24);
            Person fioewr = new Person(string.Empty, "Peshev", 24);
            Person peshoc = new Person("Pesho", null, 24);
            Person peshox = new Person("Pesho", "Peshev", -1);
            Person peshoz= new Person("Pesho", "Peshev", 121);

        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "First name can't be null or empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Last name can't be null or empty");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0 || 120 < value)
                {
                    throw new ArgumentOutOfRangeException("value", "Age should be in the range of 0 to 120");
                }

                this.age = value;
            }
        }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
