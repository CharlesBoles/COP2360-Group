using System;
using System.Collections.Generic;

namespace StudentRosterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Key: Student ID, Value: List of student names
            Dictionary<string, List<string>> studentRoster = new Dictionary<string, List<string>>();

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\nStudent Roster Application");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. View Roster");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddStudent(studentRoster);
                        break;

                    case "2":
                        RemoveStudent(studentRoster);
                        break;

                    case "3":
                        ViewRoster(studentRoster);
                        break;

                    case "4":
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        // =========================
        // TASK 1
        // =========================
        static void AddStudent(Dictionary<string, List<string>> roster)
        {
            // Ask for student ID and store
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine();

            // Ask for student name and store
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            // check if id already exists, and if not add to lsit
            if (!roster.ContainsKey(id))
                roster[id] = new List<string>();

            roster[id].Add(name);

            Console.WriteLine("Student added successfully.");
        }

        // =========================
        // TASK 2
        // =========================
        static void ViewRoster(Dictionary<string, List<string>> roster)
        {
            Console.WriteLine("\n--- Method 1 ---");
            foreach (var kvp in roster)
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");

            Console.WriteLine("\n--- Method 2 ---");
            foreach (var key in roster.Keys)
                Console.WriteLine($"{key}: {string.Join(", ", roster[key])}");

            Console.WriteLine("\n--- Method 3 ---");
            foreach (var values in roster.Values)
                Console.WriteLine(string.Join(", ", values));
        }

        // =========================
        // TASK 3
        // =========================
        static void RemoveStudent(Dictionary<string, List<string>> roster)
        {
            // read ID inputted
            Console.Write("Enter Student ID to remove: ");
            string id = Console.ReadLine();

            // if ID exists, remove
            // if doesn't exist, inform user
            if (roster.Remove(id))
                Console.WriteLine("Student removed.");
            else
                Console.WriteLine("Student not found.");
        }
    }
}


        

                
            
