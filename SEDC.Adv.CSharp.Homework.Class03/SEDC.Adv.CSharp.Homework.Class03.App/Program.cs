using SEDC.Adv.CSharp.Homework.Class03.Logic.Entities.Models;
using System;
using System.Collections.Generic;

namespace SEDC.Adv.CSharp.Homework.Class03.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Student rade = new Student(1, "Rade Hrgovikj", "rh96", 123, new List<string>() 
            {
                "A", "B", "B","C"
            });

            Student bob = new Student(2, "Bob Bobsky", "bob445", 445, new List<string>()
            {
                "B", "A", "C","B"
            });

            Teacher trajan = new Teacher(3, "Trajan Stevkovski", "trajan123", 332, new List<string>() 
            {
                "HTML", "CSS", "C# Basic", "C# Advanced"
            });

            Teacher toshe = new Teacher(4, "Toshe Todorovski", "toshe22", 228, new List<string>()
            {
                "HTML", "CSS", "Javascript", "Advanced Javascript"
            });

            #region Students 
            Console.WriteLine("Student");
            rade.PrintUser();
            Console.WriteLine("---------------");

            Console.WriteLine("Student");
            bob.PrintUser();
            Console.WriteLine("---------------");
            #endregion

            #region Teachers 
            Console.WriteLine("Teacher");
            trajan.PrintUser();
            Console.WriteLine("---------------");

            Console.WriteLine("Teacher");
            toshe.PrintUser();
            #endregion

            Console.ReadLine();
        }
    }
}
