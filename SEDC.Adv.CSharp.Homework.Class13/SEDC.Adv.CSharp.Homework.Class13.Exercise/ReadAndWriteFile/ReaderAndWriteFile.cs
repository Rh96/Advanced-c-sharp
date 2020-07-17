using Newtonsoft.Json;
using SEDC.Adv.CSharp.Homework.Class13.Exercise.Entities;
using SEDC.Adv.CSharp.Homework.Class13.Exercise.SerializeAndDeserialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class13.Exercise.ReadAndWriteFile
{
    public class ReaderAndWriteFile
    {
        // Read from file
        public string ReadJsonFromFile(string path)
        {
            string result = string.Empty;
            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exitst!");
            }
            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
                Console.WriteLine(result);
            }
            Console.WriteLine("Successfully read from file!");
            return result;
        }
        // Write from file
        public void WriteInJsonFile(string content, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(content);
            }
            Console.WriteLine("Successfully write in file!");
        }
    }
}
