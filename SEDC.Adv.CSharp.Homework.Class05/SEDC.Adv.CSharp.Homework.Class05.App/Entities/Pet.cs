using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class05.App.Entities
{
    public abstract class Pet
    {
        // Properties
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        // Methods
        public abstract string PrintInfo();
    }
}
