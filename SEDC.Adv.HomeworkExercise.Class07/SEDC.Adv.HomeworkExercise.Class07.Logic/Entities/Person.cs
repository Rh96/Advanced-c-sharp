using SEDC.Adv.HomeworkExercise.Class07.Logic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.HomeworkExercise.Class07.Logic.Entities
{
    public class Person
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public Job Occupation { get; set; }
		public List<Dog> Dogs { get; set; }

		public Person(string firstName, string lastName, int age, Job occupation)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Occupation = occupation;
			Dogs = new List<Dog>();
		}

		public void Info()
		{
			Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, Age: {Age} Job: {Occupation} Dogs count: {Dogs.Count}");
		}
	}
}
