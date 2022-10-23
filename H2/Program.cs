using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OKUL
{
    internal class Program
    {
        public static object Public { get; private set; }

        static void Main(string[] args)
        {
            //Employee sınıfından tanımlanan nesneye değer atamalarının yapılması ve yazdırılması.

            //Employee employee = new Employee();
            //employee.ID = 1;
            //employee.FirstName = "Sadık";
            //employee.LastName = "TULUK";
            //employee.Age = 20;
            //Console.Write(employee.ID + " " + employee.FirstName + " " + employee.LastName + " " + employee.Age);

            //Constructer UYG.
            //Employee employee2 = new Employee("Sadıkcan", "TULUK", 20);
            //Console.Write(employee2.FirstName + " " + employee2.LastName + " " + employee2.Age);

            //Override UYG
            //Employee employee3 = new Employee("Ayşegül", "TULUK", 23);
            //Console.WriteLine(employee3);

            //UYG Oluşan Employee leri düzgün biçimde ve listeleyerek yazdırma.

            //1.YOL

            //Employee employee = new Employee();
            //employee.ID = 1;
            //employee.FirstName = "Edanur";
            //employee.LastName = "TULUK";
            //employee.Age = 17;

            //Employee employee2 = new Employee("Sadıkcan", "TULUK", 20);

            //Employee employee3 = new Employee("Ayşegül", "TULUK", 23);

            //var list1 = new List<Employee>();
            //list1.Add(employee);
            //list1.Add(employee2);
            //list1.Add(employee3);

            //foreach (var item in list1)
            //{
            //    Console.WriteLine(item);
            //}

            //2. YOL

            //Employee employee = new Employee();
            //employee.ID = 1;
            //employee.FirstName = "Edanur";
            //employee.LastName = "TULUK";
            //employee.Age = 17;

            //Employee employee2 = new Employee("Sadıkcan", "TULUK", 20);

            //Employee employee3 = new Employee("Ayşegül", "TULUK", 23);

            //var list2 = new List<Employee>()
            //{
            //    new Employee() { FirstName = "Edanur", LastName = "TULUK", Age = 17 },
            //    new Employee("Sadıkcan", "TULUK", 20),
            //    new Employee("Ayşegül", "TULUK", 23)
            //};

            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //Add() methodu kullanımı

            //var employee4 = new Employee();
            //employee4.Add(new Employee() { FirstName="Mehtap",LastName="TULUK",Age=26});

            //AddRange() methodu kullanımı

            //var employee5 = new Employee();
            //employee5.AddRange(
            //    new Employee() { ID = 1, FirstName = "Gülsüm", LastName = "TULUK", Age = 43 },
            //    new Employee() { ID = 2, FirstName = "Ali", LastName = "ACAR", Age = 65 },
            //    new Employee() { ID = 3, FirstName = "Hatice", LastName = "ACAR", Age = 65 },
            //    new Employee() { ID = 4, FirstName = "Çınar", LastName = "BEYAZGÜL", Age = 5 }
            //    );

            //Oluşturulan GetEmployees methodunun kullanımı.

            //var list=employee5.GetEmployees();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //employee5.Remove(2);

            //Console.WriteLine("----------------------------------------------------------");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

           

            Console.ReadLine();
        }

        
       


    }
}
