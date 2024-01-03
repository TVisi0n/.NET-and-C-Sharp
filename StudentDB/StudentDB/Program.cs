﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Tanner" };

                ctx.Students.Add(student);
                ctx.SaveChanges();

                Console.WriteLine("Student saved successfully!");
            }
        }
    }
}
