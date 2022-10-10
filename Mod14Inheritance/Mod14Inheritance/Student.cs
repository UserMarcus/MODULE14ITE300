using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14Inheritance
{
    internal class Student: Person
    {
        public string schoolLastGraduated { get; set; }
        public string course { get; set; }


        public Student(string Name, string Address, string Gender, int Phone, string Email, string BirthDate, string SchoolLastGraduated, string Course) : base (Name,Address,Gender,Phone,Email,BirthDate)
        {
            this.schoolLastGraduated = SchoolLastGraduated;
            this.course = Course;
        }

        public void introduceSelf()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("BirthDate: " + birthDate);
            Console.WriteLine("SchoolLastGraduated: " + schoolLastGraduated);
            Console.WriteLine("Course: " + course);

        }
    }
}
