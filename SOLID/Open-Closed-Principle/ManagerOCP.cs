using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_Closed_Principle
{
    public class ManagerOCP : ICalculateSalary
    {
        public double calculateSalary()
        {
            return 1.75 * 100;
        }
    }
}
