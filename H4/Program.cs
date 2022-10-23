using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALITIM_UYG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Rectangle();
            var s2 = new Circle();
            var s3 = new Triangle();

            s1.X = 100;
            s1.Y = 200;
            //Console.WriteLine($"{s1.X}\n{s1.Y}");
            //s1.Draw();

            s2.X = 250;
            s2.Y = 300;
            //Console.WriteLine($"{s2.X}\n{s2.Y}");
            //s2.Draw();

            s3.X = 570;
            s3.Y = 190;
            //Console.WriteLine($"{s3.X}\n{s3.Y}");
            //s3.Draw();

            //********************************************************************************************************

            //C# Polymorphism, nesne yönelimli programlamanın temel yapı taşlarının
            //arasında yer alan, çok biçimlilik olarak bilinen bir kavramdır.
            //C# polymorphism nedir sorusuna ise programımızda oluşan bir nesne yapısının
            //birbirinden farklı nesneler şeklinde davranmasını sağlayan yapı olarak cevaplayabiliriz.

            var liste = new List<Shape>()
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };

            //foreach (var item in liste)
            //{
            //    item.Draw();
            //}

            //********************************************************************************************************

            //Multi Level inherintance

            //new Square().Caculate();

            //********************************************************************************************************

            //Hiding Method

            //new Square().Caculate();

            //Passing Parameter wtih Constructor

            //var s4 = new Rectangle(20, 30);
            //Console.WriteLine("{0},{1}",s4.X,s4.Y);

            //sealed class(Rectangle sealed old için hata verir.)
            //var s5 = new Square(89, 30);
            //Console.WriteLine("{0},{1}", s5.X, s5.Y);


            //is and as operators
            s1.WorkWithDifferentObjects(s2);
            s2.WorkWithDifferentObjects2(s3);

            Console.ReadLine();
        }
    }
}
