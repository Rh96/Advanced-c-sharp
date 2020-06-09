using SEDC.Adv.CSharp.Homework.Class03.Logic.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class03.Logic.Entities.Models
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subject { get; set; } = new List<string>();
        public Teacher(int id, string name, string userName, int pass, List<string> subjects)
            : base(id, name, userName, pass)
        {
            Subject = subjects;
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Id: {Id} Teacher: {Name} Username: {UserName}");

            foreach (var subject in Subject)
            {
                Console.WriteLine($"Subjects: {subject}");
            }
        }
    }
}
