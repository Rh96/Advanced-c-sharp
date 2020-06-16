using SEDC.Adv.CSharp.Homework.Class04.App.Entities;
using System;

namespace SEDC.Adv.CSharp.Homework.Class04.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog sparke = new Dog() 
            { 
                Id = 1,
                Name = "Sp", 
                Color = "Yellow"
            };
            Dog leo = new Dog()
            {
                Id = 2,
                Name = "Leo",
                Color = "Red"
            };
            Dog jack = new Dog()
            {
                Id = 3,
                Name = "Jack",
                Color = "Green"
            };

            // Check if everything is okay
            if (Dog.Validate(sparke) && Dog.Validate(leo) && Dog.Validate(jack))
            {
                Console.WriteLine("Successful inputs. Dogs added to the Dog Shelter.");
                DogShelter.Dogs.Add(sparke);
                DogShelter.Dogs.Add(leo);
                DogShelter.Dogs.Add(jack);
                DogShelter.PrintAll();
            }

            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.ReadLine();
        }
    }
}
