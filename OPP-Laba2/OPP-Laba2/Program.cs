using System;
using System.IO;
using System.Threading;
using System.Text.Json;
using System.Collections.Generic;

using UniversityLibrary;

namespace OPP_Laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = ' ';
            while (input != 'q')
            { 
                Console.Write(
                    "Make a choise:\n" +
                    "1. Print data from current JSON file;\n" +
                    "2. Generate new random data and save into JSON file;\n" +
                    "(input number or press Q to exit)\n" +
                    "Your choice: "
                );
                input = Console.ReadKey().KeyChar;

                switch (input) {
                    case '1' : printDataFromJSON(); break;
                    case '2' : generateRandomData(); break;
                    case 'q' : Console.WriteLine("\n\nGood bye!"); break;
                    default  : Console.WriteLine("\n\n[ERROR] - Wrong input. You must press 1 or 2. Try again.\n"); break;
                }
            }
        }

        static void printDataFromJSON() 
        {
            Console.WriteLine("\n\nJSON data:");
            var data = File.ReadAllText("data.json");
            Student[] students = Newtonsoft.Json.JsonConvert.DeserializeObject<Student[]>(data);
            Array.Sort(students);
            foreach(Student item in students)
                Console.Write(item);
            Console.WriteLine("[END]\n\n");
        }

        static void generateRandomData()
        {
            Console.WriteLine("\n\nMaking random...");
            for (int i = 1; i <= 10; i++) {
                Console.Clear();
                Console.WriteLine("Process: " + i + "0%");
                Thread.Sleep(200);
            }

            var data = File.ReadAllText("dataForRandom.json");
            Student[] dataForRandom = Newtonsoft.Json.JsonConvert.DeserializeObject<Student[]>(data);
            List<Student> dataForSaving = new List<Student>();

            Random random = new Random();   
            int numberOfItems = random.Next(dataForRandom.Length);
            for (int i = 0; i < numberOfItems; i++)
                if (random.Next(100) > 50)
                    dataForSaving.Add(dataForRandom[random.Next(dataForRandom.Length)]);

            string jsonString = JsonSerializer.Serialize(dataForSaving);
            File.WriteAllText("data.json", jsonString);

            Console.WriteLine("\nDone!!!\n");
            Thread.Sleep(500);
        }
    }
}
