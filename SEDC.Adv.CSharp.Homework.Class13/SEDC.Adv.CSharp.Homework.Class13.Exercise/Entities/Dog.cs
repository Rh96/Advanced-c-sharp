using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class13.Exercise.Entities
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Dog()
        {

        }

        public string DogInfo()
        {
            return $"{Name}, {Color}, {Age}";
        }

        // Method called on serializing
        [OnSerializing]
        public void OnSerializeMethod(StreamingContext context)
        {
            Console.WriteLine("WE ARE SERIALIZING A STUDENT");
        }

        // Method called on deserializing
        [OnDeserializing]
        public void OnDeserializeMethod(StreamingContext context)
        {
            Console.WriteLine("WE ARE DESERIALIZING A STUDENT");
        }
    }
}
