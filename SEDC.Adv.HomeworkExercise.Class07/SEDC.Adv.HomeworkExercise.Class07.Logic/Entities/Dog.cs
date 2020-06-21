using SEDC.Adv.HomeworkExercise.Class07.Logic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.HomeworkExercise.Class07.Logic.Entities
{
    public class Dog
    {
		public string Name { get; set; }
		public string Color { get; set; }
		public int Age { get; set; }
		public Race Race { get; set; }

		public Dog(string name, string color, int age, Race race)
		{
			Name = name;
			Color = color;
			Age = age;
			Race = race;
		}

		public void Info()
		{
			Console.WriteLine($"Name: {Name}, Age: {Age}, Color: {Color}, Race: {Race}");
		}
	}
}
