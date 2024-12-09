using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion_Principle
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }
}
