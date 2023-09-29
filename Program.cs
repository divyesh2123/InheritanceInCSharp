using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyEmployee emp1 = new PermanentEmployee("267543", "Tom", 5000);
            MyEmployee emp2 = new ContractEmployee("953456", "Ketty", 30);
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            NewEmployee newEmployee = new NewEmployee();

            newEmployee.AddEditEmployee();

            Console.ReadKey();


        }
    }
}
