using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Single_Responsibility_Principle
{
    public class ApplicationServiceSRP
    {
        public List<Application> ApplicationList { get; set; }

        public void saveApplication(Applicant applicant, string job)
        {
            Random rand = new Random();
            int id = rand.Next(1, 100);
            Application application = new Application(id, applicant, job);

            ApplicationList.Add(application);
        }

        public void removeApplication(Application application)
        {
            ApplicationList.Remove(application);
        }
    }
}
