using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SOLID.Single_Responsibility_Principle
{
    public class ApplicantServiceWithoutSRP
    {
        public List<Applicant> applicantList;
        public List<Application> applicationList;


        public Applicant getApplicant(int id)
        {
            return new Applicant(id, "sample");
        }

        public void saveApplicant(Applicant applicant)
        {
            applicantList.Add(applicant);
        }

        // Job application part
        public void submitApplication(Applicant applicant, string jobTitle)
        {
            Random rand = new Random();
            int id = rand.Next(1, 100);
            applicationList.Add(new Application(id, applicant, jobTitle));
        }

        public void removeApplication(Application application)
        {
            applicationList.Remove(application);
        }

    }
}
