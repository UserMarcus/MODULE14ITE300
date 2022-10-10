using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14Inheritance
{
    internal class Staff: Person
    {
        public string designation { get; set; }
        public int salary { get; set; }
        public string serviceDepartment { get; set; }

        public Staff(string Name, string Address, string Gender, int Phone, string Email, string BirthDate, string Designation, int Salary, string ServiceDepartment) : base(Name, Address, Gender, Phone, Email, BirthDate)
        {
            this.designation = Designation;
            this.salary = Salary;
            this.serviceDepartment = ServiceDepartment;
        }

        public void introduceSelf()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("BirthDate: " + birthDate);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("ServiceDepartment" + serviceDepartment);
        }
    }
}
