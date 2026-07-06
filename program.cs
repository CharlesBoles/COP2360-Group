using System;
using System.Collections.Generic;

namespace StudentRosterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize dictionary shared by whole group
            //Key: Student ID (String), Value: Student Name (string)
            Dictionary<string, List<string>> studentRoster = new Dictionary<string, List<string>>();
            bool keepRunning = true;

            // Main application loop keeps the program open until the user decides to exit
            while (keepRunning)
            {
                Console.WriteLine("Student Roster Application");
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
                    
                    //---ROLE 2 FUNCTIONS---
                    static void AddStudent(Dictionary<string, List<string>> roster)
                    {
                        Console.WriteLine("[Placeholder] Role 2 will implement: Populate the Roster.");
        }

        static void DisplayRoster(Dictionary<string, string> roster)
        {
            Console.WriteLine("[Placeholder] Role 2 will implement: Display Current Roster.");
        }

        static void RemoveStudent(Dictionary<string, string> roster)
        {
            Console.WriteLine("[Placeholder] Role 2 will implement: Remove a Student.");
        }

        // --- ROLE 3 FUNCTIONS ---
        static void AddNewStudent(Dictionary<string, string> roster)
        {
            Console.WriteLine("[Placeholder] Role 3 will implement: Add a New Student.");
        }

        static void AppendStudentValue(Dictionary<string, string> roster)
        {
            Console.WriteLine("[Placeholder] Role 3 will implement: Append to Existing Student.");
        }

        static void SortRosterKeys(Dictionary<string, string> roster)


        

                
            