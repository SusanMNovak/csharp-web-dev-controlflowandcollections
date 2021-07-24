using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dictionaries!");
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            //Input student names and IDs
            Console.WriteLine("Enter dtudents' names, and ID numbers or Enter to finish:");
            do
            {
                Console.WriteLine("Student Name: ");
                newStudent = Console.ReadLine();

                if (newStudent != "")
                {
                    Console.WriteLine("ID number: ");
                    int newID = int.Parse(Console.ReadLine());
                    students.Add(newID, newStudent);

                }

            }

            //Print class roster
            while (newStudent != "");

            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Value + "'s ID: " + student.Key);
            }

            Console.WriteLine("Number of students in roster: " + students.Count);

        }
    }
}
