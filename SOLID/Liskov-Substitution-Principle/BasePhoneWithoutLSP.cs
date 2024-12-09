using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution_Principle
{
    public interface BasePhoneWithoutLSP
    {
        public abstract void TakePhoto();
    }

    public class MobilePhone : BasePhoneWithoutLSP
    {
        public void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekildi");
        }
    }

    public class HomePhone : BasePhoneWithoutLSP
    {
        public void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }

}
