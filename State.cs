using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    public class State : Country
    {
        public int StateId { get; set; }    

        public string Name { get; set; }

        public void Display()
        {

        }
    }
}
