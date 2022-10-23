using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALITIM_UYG
{
    internal /*sealed*/ class Rectangle : Shape
    {
        public Rectangle()
        {

        }

        //Passing Parameter wtih Constructor
        public Rectangle(int x,int y):base(x,y)
        {
            
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle class drawing...");
        }

        public void Caculate()
        {
            Console.WriteLine("Rectangle HESAPLANDI...");
        }
    }
}
