using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Employee
    {
        public static string employee;
        public static int age;
        public string name;
        public string surName;

        static Employee()
        {
            employee = string.Empty;
            age = 0;
        }
        public int id { get; set; }

        public static void printNameSurname()
        {
            Console.WriteLine("Özay Yıldız");
        }

        public static void addNumer(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
    }
}
