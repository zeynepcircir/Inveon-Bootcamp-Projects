using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion_Principle
{
    public class MessageService
    {
        private IMessageSender sender;

        public MessageService(IMessageSender sender)
        {
            this.sender = sender;
        }

        public void sendMessage(string message)
        {
            sender.SendMessage(message);
        }
    }
}
