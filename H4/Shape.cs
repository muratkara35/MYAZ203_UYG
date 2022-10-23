using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALITIM_UYG
{
    internal class Shape
    {
        public Shape()
        {

        }
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        //Virtual anahtar kelimesi temel sınıftaki method ve özelliklerin türetilmiş
        //sınıfta ovverride edilmelerine izin veriri.
        public virtual void Draw()
        {
            Console.WriteLine("Shape class drawing...");
        }

        //is and as operators
        public void WorkWithDifferentObjects(Object o)
        {
            Shape shapeFromParameter = o as Shape;
            if (o != null)
            {
                shapeFromParameter.Draw();
            }
        }

        public void WorkWithDifferentObjects2(Object o)
        {
            if (o is Shape)
            {
                Console.WriteLine("Task class drawing....");
            }
        }

        }
}
