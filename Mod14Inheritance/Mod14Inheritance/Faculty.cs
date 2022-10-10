using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mod14Inheritance
{
    internal class Faculty: Person
    {
        public string designation { get; set; }
        public int salary { get; set; }
        public string collegeDepartment { get; set; }
        public int subjectLoad { get; set; }


        public Faculty(string Name, string Address, string Gender, int Phone, string Email, string BirthDate, string Designation, int Salary, string CollegeDepartment, int SubjectLoad) : base (Name, Address, Gender, Phone, Email, BirthDate) 
        {
            this.designation = Designation;
            this.salary = Salary;
            this.collegeDepartment = CollegeDepartment;
            this.subjectLoad = SubjectLoad;
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
            Console.WriteLine("CollegeDepartment: " + collegeDepartment);
            Console.WriteLine("SubjectLoad: " + subjectLoad);
        }
    }

}
