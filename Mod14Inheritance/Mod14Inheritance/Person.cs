using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14Inheritance
{
    internal class Person
    {
        public string name { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
        public string birthDate { get; set; }

        public Person(string Name, string Address, string Gender, int Phone, string Email ,string BirthDate)
        {
            this.name = Name;
            this.address = Address;
            this.gender = Gender;
            this.phone = Phone;
            this.email = Email;
            this.birthDate = BirthDate;
        }

        public void introduceSelf()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("BirthDate: " + birthDate);

        }
    }

}
