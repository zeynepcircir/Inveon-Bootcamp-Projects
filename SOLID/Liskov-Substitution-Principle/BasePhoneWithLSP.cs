using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution_Principle
{
    public interface BasePhoneWithLSP
    {
        public abstract void TakePhoto();
    }

    public class MobilePhoneWithLSP : BasePhoneWithoutLSP
    {
        public void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekildi");
        }
    }

    public class HomePhoneWithLSP : BasePhoneWithoutLSP
    {
        public void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekilemedi");
        }
    }
}
