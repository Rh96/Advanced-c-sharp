using SEDC.Adv.CSharp.Homework.Class05.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class05.App.GenericClasses
{
    public class PetStore<T>
        where T : Pet
    {
        // Properties
        private List<T> ListOfPets;

        public PetStore()
        {
            ListOfPets = new List<T>();
        }

        // Add Pets to Store
        public void AddPets(T pet)
        {
            ListOfPets.Add(pet);
        }

        // Print pets depending on what is passed as T
        public void printPets()
        {
            foreach (T pet in ListOfPets)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }

        // Buy a pet and remove from the list with success message and if there is no such pet with that name inform the customer
        public void BuyPet(string nameOfPet)
        {
            T buyPet = ListOfPets
                .FirstOrDefault(name => name.Name == nameOfPet);

            if (buyPet == null)
            {
                Console.WriteLine($"Pet was not found by that name {nameOfPet}!");
                return;
            }

            ListOfPets.Remove(buyPet);
            Console.WriteLine($"You bought a {buyPet.Type} with name {nameOfPet}!");
        }
    }
}
