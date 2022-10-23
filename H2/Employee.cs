using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OKUL
{
    internal class Employee

    {
        private List<Employee> _list=new List<Employee>();

        private string _FirstName;
        
        //Field tanımlamadır.
        //Program.cs üzerinden erişim sağlanamaz.

        //Property Tanımlama

        //Kapsülleme:Sınıf içerisndeki nesne özelliklerine dışarından erişim sağlayabilmek için yapılır.
        //Aşağıda yaptığımız property tanımlama bir kapsülleme işlemidir.

        //public Employee(int ıD, string firstName, string lastName, int age)
        //{
        //    ID = ıD;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Age = age;
        //}

        //NOT:get bloğu okuma izni verirken set bloğu yazma izni verir.
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        
        //Expression bodied property accessors:Tanımlanmış field ile CTRL+"." tuş kombinasyonu
            // ile kısayoldan kapsüllenmesi işlemine denir.

        private string _LastName;
        public string LastName1 { get => _LastName; set => _LastName = value; }

        //Auto-implemented Properties:Property tanımlamak için kullanılan kısayoldur.
        //"prop"+TAB**2 tuş kombinasyonu ile yapılır.

        //Constructor:Nesne yönelimli programlamada,
        //bir yapıcı (constructor), bir nesne oluşturmak için 
        // çağrılan özel bir alt yordam türüdür.
        // Yeni nesneyi kullanıma hazırlar, genellikle yapıcının gerekli
        //üye değişkenlerini ayarlamak için kullandığı argümanları kabul eder
        //prop gibi bir yöntem ancak daha kısa ve kullanışlıdır.
        //ctor+TAB tuş kombinasyonu ile oluşturulur.
        public Employee(string FirstName,string LastName,int Age)
        {
            this.FirstName = FirstName; //This Employee yi temsil eder.
            this.LastName = LastName;
            this.Age = Age;
        }

        //Difault yani parametre almayan bir constructor tanımlanmış ise program.cs de
        //onun da çalışabilmesi için boş bir burada parametresiz bir constructor oluşturmak lazım.

         public Employee()
        {

        }



        //Override:Geçersiz kılma (override), bir alt sınıfın, üst sınıfında veya üst sınıflarından birinde 
            //önceden tanımlanmış ve/veya uygulanmış bir yöntem için farklı uygulama sağlamasını olanak
            //tanıyan nesne yönelimli bir programlama özelliğidir.Override, tek tip bir interface aracılığıyla
            //farklı veri türlerinin işlenmesini sağlar.
            //Oluşturuluşu CTRL+"." kombinasyonu ve seçeneklerden 'Generate Ovverides' seçilerek oluşturulur.

        public override string ToString()
        {
            return $"{ID,-10} {FirstName,-10} {LastName,-10} {Age,10}" ;
            // 10 ar karakterlik alan verdik."-" işareti ile de sola yasladık.İşaretsiz ise sağa yaslanık olur.
        }

        //Add metodu tanımlayarak listeye yazdırma işilemi.
        //list en yukarda tanımlandı.

        public void Add(Employee emp)
        {
            _list.Add(emp);
        }

        //Dinamik parametreli method tanımlama ve kulanma.

        public void AddRange(params Employee[] employees)
        {
            _list.AddRange(employees);
        }

        //Oluşturduğumuz ve elemanlar eklediğimiz _list adlı listenin program üzerinden
        //ulaşılabilinmesi için tanımlanmış method.

        public List<Employee> GetEmployees()
        {
            return _list;   
        }

        public void Remove(int id)
        {
            _list.RemoveAt(id);
        }

        
    }
}
