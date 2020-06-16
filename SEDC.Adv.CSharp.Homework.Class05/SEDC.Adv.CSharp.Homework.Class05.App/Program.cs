using SEDC.Adv.CSharp.Homework.Class05.App.GenericClasses;
using SEDC.Adv.CSharp.Homework.Class05.App.Entities;
using System.Linq;
using System;

namespace SEDC.Adv.CSharp.Homework.Class05.App
{
    class Program
    {
        public static PetStore<Dog> ListOfDogs = new PetStore<Dog>();
        public static PetStore<Cat> ListOfCats = new PetStore<Cat>();
        public static PetStore<Fish> ListOfFishes = new PetStore<Fish>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PetStore!");
            #region AddData
            ListOfDogs.AddPets(new Dog() { Name = "Spike", Type = "Dog", Age = 2, GoodBoi = true, FavoriteFood = "Spagheti" });
            ListOfDogs.AddPets(new Dog() { Name = "Jacky", Type = "Dog", Age = 4, GoodBoi = false, FavoriteFood = "Bone" });

            ListOfCats.AddPets(new Cat() { Name = "Lucky", Type = "Cat", Age = 3, Lazy = false, LivesLeft = 9 });
            ListOfCats.AddPets(new Cat() { Name = "Smok", Type = "Cat", Age = 5, Lazy = true, LivesLeft = 3 });

            ListOfFishes.AddPets(new Fish() { Name = "Goldy", Type = "Fish", Age = 3, Color = "Yellow", Size = 5 });
            ListOfFishes.AddPets(new Fish() { Name = "Great White", Type = "Fish", Age = 10, Color = "Blue", Size = 20 });

            Console.WriteLine("Dogs:");
            ListOfDogs.printPets();
            Console.WriteLine("========================");

            Console.WriteLine("Cats:");
            ListOfCats.printPets();
            Console.WriteLine("========================");

            Console.WriteLine("Fishes:");
            ListOfFishes.printPets();
            Console.WriteLine("\n");
            #endregion

            #region BuyPet
            Console.WriteLine("Dogs");
            ListOfDogs.BuyPet("Spike");

            Console.WriteLine("Pets left in the store");
            ListOfDogs.printPets();
            Console.WriteLine("========================");

            Console.WriteLine("Cats");
            ListOfCats.BuyPet("Rade");

            Console.WriteLine("Pets left in the store");
            ListOfCats.printPets();
            Console.WriteLine("========================");
            #endregion

            Console.ReadLine();
        }
    }
}
