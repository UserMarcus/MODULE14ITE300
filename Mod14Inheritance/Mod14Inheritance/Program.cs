using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STUDENT");
            Student s = new Student("Mark", "Laguna", "Male", 9952314, "Mark.com", "January", "Laguna National Highschool", "BSIT");
            s.introduceSelf();

            Console.WriteLine("EMPLOYEE");

            Console.WriteLine("FACULTY");
            Faculty f = new Faculty("Miranda", "Laguna", "Female", 9957689, "Miranda.com", "February", "Laguna College", 18000, "IT Department", 20);
            f.introduceSelf();

            Console.WriteLine("STAFF");
            Staff st = new Staff("Jose", "Laguna", "Male", 09954321, "Jose.com", "March", "Laguna College", 10000, "Cleaner Department");
            st.introduceSelf();

            Console.ReadLine();
        }
    }

   

}
