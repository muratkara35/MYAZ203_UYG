﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_UYG
{
    public class Student
    {
        public Student(int ıd, string firstName, string lastName)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email => FirstName.ToLower() + "." + LastName.ToLower()
            + "@samsun.edu.tr";

        public string FullName => $"{FirstName} {LastName}";

        public override string ToString()
        {
            return $"{Id} {FullName} {Email}";
        }
    }
}