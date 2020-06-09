using SEDC.Adv.CSharp.Homework.Class03.Logic.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SEDC.Adv.CSharp.Homework.Class03.Logic.Entities.Models
{
    public class Student:User, IStudent
    {
        public List<string> Grades { get; set; } = new List<string>();

        public Student(int id, string name, string userName, int pass, List<string> grades)
            :base(id, name, userName, pass)
        {
            Grades = grades;
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Id: {Id} Student: {Name} Username: {UserName}");

            foreach (var grades in Grades)
            {
                Console.WriteLine($"Grades: {grades}");
            }
        }
    }
}
