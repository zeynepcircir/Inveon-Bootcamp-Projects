using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion_Principle
{
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }
}
