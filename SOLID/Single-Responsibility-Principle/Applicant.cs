using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Single_Responsibility_Principle
{
    public class Applicant
    {
        public long ID { get; set; }
        public string Name { get; set; }

        public Applicant(long id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
