using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface_Segregation_Principle
{
    public class LecturerISP : IGiveLecture
    {
        public long ID { get; set; }
        public string Name { get; set; }

        public void giveLecture()
        {
            Console.WriteLine("Lecture is being given.");
        }
    }
}
