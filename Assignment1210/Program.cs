using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("om", 25000);
            e1.calculatesal();
            Console.WriteLine(e1);

            Manager m1 = new Manager("ram", 25000, 1000);
            m1.calculatesal();
            Console.WriteLine(m1);

            President p1 = new President("jay", 25000, 2000);
            p1.calculatesal();
            Console.WriteLine(p1);

            Salesmanager s1 = new Salesmanager("sachin", 25000, 3000);
            s1.calculatesal();
            Console.WriteLine(s1);
        }
    }
}
