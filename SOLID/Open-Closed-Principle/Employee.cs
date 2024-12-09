using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_Closed_Principle
{
    public abstract class Employee
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
