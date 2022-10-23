using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_UYG
{
    public class StudentManager
    {
        List<Student> students;

        public StudentManager()
        {
            students = new List<Student>();
        }

        public StudentManager(List<Student> std)
        {
            students = std;
        }

        public StudentManager(Student std)
        {
            students = new List<Student>();
            CreateStudent(std);
        }

        // Create
        public void CreateStudent(Student student)
        {
            students.Add(student);
        }

        // Read
        public Student ReadStudent(int id)
        {
            return students[id];
        }

        // Update
        public void UpdateStudent(int id, string firstName, string lastName)
        {
            if (firstName != null)
                students[id].FirstName = firstName;
            if (lastName != null)
                students[id].LastName = lastName;
        }

        // Delete
        public Student DeleteStudent(int id)
        {
            var std = ReadStudent(id);
            // stdList.Remove(std);
            students.RemoveAt(id);
            return std;
        }

        public void ReadList()
        {
            foreach (var item in students)
                Console.WriteLine(item);
        }
    }
}