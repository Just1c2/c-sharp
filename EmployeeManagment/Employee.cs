using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment
{
    public sealed class Employee: Person, IRole
    {
        public string ID { get; set; }
        public override string FirstName { get => firstName; set => firstName = value; }
        public override string LastName { get => lastName; set => lastName = value; }
        public override string Email { get => email; set => email = value; }
        public override string Phone { get => phone; set => phone = value }
        public override DateTime Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        public DateTime JoiningDateTime { get; set; }
        public string Designation { get; set; }
        public Employee(string id, string firstName, string lastName, string email, string phone, DateTime DOB, DateTime joiningDateTime, int designation)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.Dateofbirth = DOB;
            this.JoiningDateTime = joiningDateTime;
            this.Designation = Enum.GetName(typeof(Designation), designation);
        }

        public override string GetFullName()
        {
            return firstName + "   " + lastName;
        }

        public override string GetAge()
        {
            TimeSpan age = DateTime.Now - dateofbirth;
            int years = age.Days / 365;
            int month = (age.Days - )
        }
    }
}
