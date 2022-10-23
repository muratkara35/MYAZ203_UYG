using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_UYG
{
    public class Program
    {
        public static void Main()
        {
            Student student = new Student(0, "ÇINAR", "BEYAZGÜL");

            List<Student> students = new List<Student>()
            {
                new Student(1, "AYŞEGÜL", "TULUK"),
                new Student(2, "SADIK", "TULUK"),
                new Student(3, "EDANUR", "TULUK"),
            };
            StudentManager studentManager = new StudentManager(students);
            studentManager.ReadList();
            studentManager.CreateStudent(student);
            studentManager.DeleteStudent(2);
            studentManager.UpdateStudent(1, "MEHTAP", "TULUK");

            Console.ReadLine();
        }
    }
}