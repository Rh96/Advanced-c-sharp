using SEDC.Adv.HomeworkExercise.Class07.Logic.DatabaseRepository;
using SEDC.Adv.HomeworkExercise.Class07.Logic.Entities;
using SEDC.Adv.HomeworkExercise.Class07.Logic.ListHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Adv.HomeworkExercise.Class07.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print first names which statrs with Letter R");
            Console.WriteLine("--------------------------------------");

            var firstNameStartsWithLetterR = Database.people
                .Where(x => x.FirstName.Contains("R"))
                .OrderByDescending(x => x.Age)
                .ToList();

            ListHelpers.PrintInfo(firstNameStartsWithLetterR);
            Console.WriteLine("------------------------------------------------------------\n");

            Console.WriteLine("Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER");
            Console.WriteLine("--------------------------------------");

            var printBrownDogs = Database.dogs
                .Where(x => x.Color == "Brown" && x.Age >= 3)
                .OrderBy(x => x.Age)
                .ToList();

            ListHelpers.PrintInfo(printBrownDogs);
            Console.WriteLine("------------------------------------------------------------\n");

            Console.WriteLine("Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER");
            Console.WriteLine("--------------------------------------");

            var printPersonsWithMoreThanTwoDogs = Database.people
                .Where(x => x.Dogs.Count >= 2)
                .OrderByDescending(x => x.FirstName)
                .ToList();

            ListHelpers.PrintInfo(printPersonsWithMoreThanTwoDogs);
            Console.WriteLine("------------------------------------------------------------\n");

            Console.WriteLine("Find and print all Freddy`s dogs names older than 1 year");
            Console.WriteLine("--------------------------------------");

            var printDogsOlderThanOneYear = Database.people
                .Where(fName => fName.FirstName == "Freddy")
                .SelectMany(dogAge => dogAge.Dogs
                .Where(x => x.Age > 1))
                .ToList();
            ListHelpers.PrintInfo(printDogsOlderThanOneYear);
            Console.WriteLine("------------------------------------------------------------\n");

            Console.WriteLine("Find and print Nathen`s first dog");
            Console.WriteLine("--------------------------------------");

            var printNathenFirstDog = Database.people
                .Where(person => person.FirstName == "Nathen")
                .Select(person => person.Dogs.FirstOrDefault())
                .ToList();

            ListHelpers.PrintInfo(printNathenFirstDog);
            Console.WriteLine("------------------------------------------------------------\n");

            Console.WriteLine("Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER");
            Console.WriteLine("--------------------------------------");

            var printWhiteDogsName = Database.people
                .Where(p => p.FirstName == "Cristofer" || p.FirstName == "Freddy" || p.FirstName == "Erin" || p.FirstName == "Amelia")
                .SelectMany(person => person.Dogs
                .OrderBy(dog => dog.Name)
                .Where(dog => dog.Color == "White"))
                .ToList();

            ListHelpers.PrintInfo(printWhiteDogsName);    
            Console.ReadLine();
        }
    }
}
