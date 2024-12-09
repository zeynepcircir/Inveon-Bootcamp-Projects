using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Single_Responsibility_Principle
{
    public class Application
    {
        public long ID { get; set; }
        public Applicant Applicant { get; set; }
        public string JobTitle { get; set; }

        public Application(long id, Applicant applicant, string jobTitle)
        {
            this.ID = id;
            this.Applicant = applicant;
            this.JobTitle = jobTitle;
        }
    }
}
