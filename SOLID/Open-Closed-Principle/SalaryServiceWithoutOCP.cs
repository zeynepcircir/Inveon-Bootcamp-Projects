using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_Closed_Principle
{
    public class SalaryServiceWithoutOCP
    {
        public double calculateSalary(Employee employee)
        {
            int salary = 100;
            if (employee.GetType() == typeof(Engineer))
            {
                return 1.25 * salary;
            }
            else if (employee.GetType() == typeof(Manager))
            {
                return 1.75 * salary;
            }
            else
            {
                throw new Exception("Wrong Employee Type");
            }
        }
    }
}
