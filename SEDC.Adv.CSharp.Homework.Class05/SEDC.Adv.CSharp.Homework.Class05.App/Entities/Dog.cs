using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class05.App.Entities
{
    public class Dog : Pet
    {
        // Properties
        public bool GoodBoi { get; set; }
        public string FavoriteFood { get; set; }

        // Methods
        public override string PrintInfo()
        {
            return $"Name: {Name}, Age: {Age}, Favorite Food: {FavoriteFood}";
        }
    }
}
