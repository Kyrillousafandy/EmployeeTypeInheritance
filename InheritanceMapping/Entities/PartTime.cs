using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping.Entities
{
    // concreate class
    internal class PartTime:Employee
    {
        public decimal HourRate { get; set; }
        public int CountOfHour { get; set; }
    }
}
