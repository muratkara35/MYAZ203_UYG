using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALITIM_UYG
{
    internal class Square:Rectangle
    {
        //HİDİNG METHOD
        //Temel sınıftan alınan aynı imzaya sahip bir methodun türetilmiş sınıfta
        //kullanılabilmesi (yani geçersiz kılınması) için ya virtual,overrid anahtar 
        //kelimeleri kullanılır ya da methodun başına new anahtar sözcüğü eklenir.
        new public void Caculate()
        {
            Console.WriteLine("Square HESAPLANDI...");
        }

        public Square()
        {
                
        }

        public Square(int x,int y):base(x,y)
        {


        }
    }
}
