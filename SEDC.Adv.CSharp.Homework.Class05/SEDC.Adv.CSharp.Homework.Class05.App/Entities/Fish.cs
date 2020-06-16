using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class05.App.Entities
{
    public class Fish : Pet
    {
        // Properties
        public string Color { get; set; }
        public int Size { get; set; }

        // Methods
        public override string PrintInfo()
        {
            return $"Name: {Name}, Age: {Age}, Size: {Size} meters long";
        }
    }
}
