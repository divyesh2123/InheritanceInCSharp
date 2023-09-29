using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    public abstract class MyEmployee
    {
        public string Name { get; set; }

        public abstract string EmployeeId { get; }

        public abstract double Salary();
        public double MedicalCoverage()
        {
            return 200000;
        }
        public MyEmployee(string Name)
        {
            this.Name = Name;
        }
     
    }
}
