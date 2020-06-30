using System;
using System.IO;

namespace SEDC.Adv.CSharp.Homework.Class10.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // App path
            string appPath = @"..\..\..\";

            // Create folder
            string folderPath = appPath + @"\Exercise";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder was Created!");
            }
            else
            {
                Console.WriteLine("Folder already exists!");
            }

            // Create file
            string filePath = folderPath + @"\calculations.txt";
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                Console.WriteLine("File was created!");
            }
            else
            {
                Console.WriteLine("File aready exists!");
            }

            // Read files
            using (StreamReader sr = new StreamReader(filePath))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            Console.WriteLine("Enter to continue...");
            Console.ReadLine();


            int num;
            Console.WriteLine("Enter first number:");
            bool isParsed = int.TryParse(Console.ReadLine(), out num);

            int num2;
            Console.WriteLine("Enter first number:");
            bool isParsed2 = int.TryParse(Console.ReadLine(), out num2);

            string result = CalculateTwoNumbers(num, num2);

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"Result: {result} || Timestamp: {DateTime.Now}");
                Console.WriteLine("Writing is completed!");
            }
            Console.ReadLine();
        }

        static string CalculateTwoNumbers(int a, int b)
        {
            int result = a + b;
            string expressionFormat = string.Format("{0} + {1} = {2}", a, b, result);
            return expressionFormat;
        }
    }
}
