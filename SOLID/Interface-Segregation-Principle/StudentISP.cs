using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface_Segregation_Principle
{
    public class StudentISP : IAttendClass
    {
        public long ID { get; set; }
        public string Name { get; set; }

        public void attendClass()
        {
            Console.WriteLine("Attended class.");
        }
    }
}
