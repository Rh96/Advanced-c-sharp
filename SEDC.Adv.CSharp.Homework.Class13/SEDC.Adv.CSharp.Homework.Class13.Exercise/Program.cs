using Newtonsoft.Json;
using SEDC.Adv.CSharp.Homework.Class13.Exercise.Entities;
using SEDC.Adv.CSharp.Homework.Class13.Exercise.ReadAndWriteFile;
using SEDC.Adv.CSharp.Homework.Class13.Exercise.SerializeAndDeserialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;

namespace SEDC.Adv.CSharp.Homework.Class13.Exercise
{
    class Program
    {
        static string directoryPath = @"..\..\..\Data\";
        static string filePath = directoryPath + @"dogJson.json";
        static SerializeAndDeserializeJson serializeAndDeserializeObject = new SerializeAndDeserializeJson();
        static ReaderAndWriteFile readerAndWriteFile = new ReaderAndWriteFile();
        static void Main(string[] args)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Enter Dog properties: Name, Color, Age");
            string name = Console.ReadLine();
            string color = Console.ReadLine();
            bool isParsed = int.TryParse(Console.ReadLine(), out int age);

            Dog dog = new Dog()
            {
                Name = name,
                Color = color,
                Age = age
            };
            
            
            // Serialize object and write in file
            string dogSerialize = serializeAndDeserializeObject.SerializeDog(dog);
            Console.WriteLine(dogSerialize);
            readerAndWriteFile.WriteInJsonFile(dogSerialize, filePath);
            Console.ReadLine();

            // Read from json file and Deserialize object
            string jsonData = readerAndWriteFile.ReadJsonFromFile(filePath);
            var dog1 = serializeAndDeserializeObject.DeserializeDog(jsonData);


            Console.ReadLine();
        }
    }
}
