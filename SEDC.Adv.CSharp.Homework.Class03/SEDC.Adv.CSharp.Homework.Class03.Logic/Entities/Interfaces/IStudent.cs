using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class03.Logic.Entities.Interfaces
{
    public interface IStudent
    {
        public List<string> Grades { get; set; }
        void PrintUser();
    }
}
