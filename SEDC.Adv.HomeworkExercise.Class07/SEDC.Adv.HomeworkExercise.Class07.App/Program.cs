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
            // Task 01 - Print first names which statrs with Letter R
            Func<Person, bool> firstNameStartsWithLetterR = x => x.FirstName.Contains("R");
            Func<Person, int> orderAgeByDesc = x => x.Age;

            var task1 = Database.people
                .Where(firstNameStartsWithLetterR)
                .OrderByDescending(orderAgeByDesc)
                .ToList();

            ListHelpers.PrintInfo(task1);

            Console.WriteLine("------------------------------------------------------------\n");

            // Task 02 - Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            Func<Dog, bool> printBrownDogs = x => x.Color == "Brown" && x.Age >= 3;
            Func<Dog, int> orderByAgeAscending = x => x.Age;

            var task2 = Database.dogs
                .Where(printBrownDogs)
                .OrderBy(orderByAgeAscending)
                .ToList();

            ListHelpers.PrintInfo(task2);
            Console.WriteLine("------------------------------------------------------------\n");

            // Task 03 - Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
            Func<Person, bool> printPersonsWithMoreThanTwoDogs = x => x.Dogs.Count >= 2;
            Func<Person, string> orderByFirstNameDescending = x => x.FirstName;

            var task3 = Database.people
                .Where(printPersonsWithMoreThanTwoDogs)
                .OrderByDescending(orderByFirstNameDescending)
                .ToList();

            ListHelpers.PrintInfo(task3);
            Console.WriteLine("------------------------------------------------------------\n");

            // Task 04 - Find and print all Freddy`s dogs names older than 1 year
            Func<Person, bool> findFreddy = x => x.FirstName == "Freddy";
            Func<Person, IEnumerable<Dog>> selectFreddyDogs = x => x.Dogs;
            Func<Dog, string> printFreddyDogsNames = x => x.Name;
            Func<Dog, bool> printFreddyDogsOlderThanOneYear = x => x.Age > 1;

            var task4 = Database.people
                .Where(findFreddy)
                .SelectMany(selectFreddyDogs)
                .Where(printFreddyDogsOlderThanOneYear)
                .ToList();
                
            ListHelpers.PrintInfo(task4);
            Console.WriteLine("------------------------------------------------------------\n");

            // Task 05 - Find and print Nathen`s first dog
            Func<Person, bool> findNathen = x => x.FirstName == "Nathen";
            Func<Person, Dog> findNathenFirstDog = x => x.Dogs.FirstOrDefault();

            var task5 = Database.people
                .Where(findNathen)
                .Select(findNathenFirstDog)
                .ToList();

            ListHelpers.PrintInfo(task5);
            Console.WriteLine("------------------------------------------------------------\n");

            // Task 06 - Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
            var listOfNames = new List<string>() { "Cristofer", "Freddy", "Erin", "Amelia" };

            Func<Person, bool> selectNames = p => listOfNames.Contains(p.FirstName);
            Func<Person, IEnumerable<Dog>> selectPersonDogs = p => p.Dogs;
            Func<Dog, string> orderByDogName = d => d.Name;
            Func<Dog, bool> checkDogColor = d => d.Color == "White";

            var task6 = Database.people
                .Where(selectNames)
                .SelectMany(selectPersonDogs)
                .OrderBy(orderByDogName)
                .Where(checkDogColor)
                .ToList();

            ListHelpers.PrintInfo(task6);

            // Trajan Way
            //var listOfName = new List<string> { "Cristofer", "Freddy", "Erin", "Amelia" };


            //var dogNames = Database.people
            //    .Where(x => listOfName.Contains(x.FirstName))
            //    .SelectMany(x => x.Dogs)
            //    .Where(x => x.Color == "White")
            //    .OrderBy(x => x.Name)
            //    .ToList();

            //ListHelpers.PrintInfo(dogNames);
            Console.ReadLine();
        }
    }
}
