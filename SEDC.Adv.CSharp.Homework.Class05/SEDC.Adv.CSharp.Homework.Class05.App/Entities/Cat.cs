using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class05.App.Entities
{
    public class Cat : Pet
    {
        // Properties
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        // Mehods
        public override string PrintInfo()
        {
            return $"Name: {Name}, Age: {Age}, Lives left: {LivesLeft}";
        }
    }
}
