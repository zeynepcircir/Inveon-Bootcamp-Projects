using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface_Segregation_Principle
{
    public class LecturerWithoutISP
    {
        public long ID { get; set; }
        public string Name { get; set; }

        public void attendClass()
        {
            throw new NotImplementedException();
        }

        public void giveLecture()
        {
            Console.WriteLine("Lecture is given.");
        }
    }
}
