using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Single_Responsibility_Principle
{
    public class ApplicantServiceSRP
    {
        public List<Applicant> ApplicantList { get; set; }

        public void addApplicant(string name)
        {
            Random rand = new Random();
            int id = rand.Next(1, 100);
            Applicant applicant = new Applicant(id, name);

            ApplicantList.Add(applicant);
        }

        public void removeApplicant(Applicant applicant)
        {
            ApplicantList.Remove(applicant);
        }
    }
}
