using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class04.App.Entities
{
    public static class DogShelter
    {
        public static List<Dog> Dogs = new List<Dog>();

        public static void PrintAll()
        {
            foreach (var dog in Dogs)
            {
                dog.DogInfo();
            }
        }
    }
}
