using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping.Entities
{
    // concreate class
    internal class FullTime:Employee
    {
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }
}
