using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class03.Logic.Entities.Interfaces
{
    public interface ITeacher
    {
        public List<string> Subject { get; set; }
        void PrintUser();
    }
}
