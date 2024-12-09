using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion_Principle
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }
}
