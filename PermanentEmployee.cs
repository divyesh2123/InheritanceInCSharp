using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    public class PermanentEmployee : MyEmployee
    {
        private string Id;
        public double MonthlySalary { get; }
        public override string EmployeeId { get { return "TMP" + Id; } }
        //override to provide Monthly Salary
        public override double Salary()
        {
            return MonthlySalary;
        }
        public PermanentEmployee(string Id, string Name, double MonthlySalary) : base(Name)
        {
            this.MonthlySalary = MonthlySalary;
            this.Id = Id;
        }
        
    }
}
