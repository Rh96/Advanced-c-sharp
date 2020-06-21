using SEDC.Adv.HomeworkExercise.Class07.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.HomeworkExercise.Class07.Logic.ListHelpers
{
    public static class ListHelpers
    {
        public static void PrintInfo(List<Person> listPersons)
        {
            Console.WriteLine("People:");
            foreach (var person in listPersons)
            {
                person.Info();
            }
        }

        public static void PrintInfo(List<Dog> listDogs)
        {
            Console.WriteLine("Dogs:");
            foreach (var dog in listDogs)
            {
                dog.Info();
            }
        }
    }
}
