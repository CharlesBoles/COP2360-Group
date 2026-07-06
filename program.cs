using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentRosterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Key: Student ID, Value: List of student names
            Dictionary<string, List<string>> studentRoster = new Dictionary<string, List<string>>();

            // Populate the dictionary
            studentRoster.Add("1001", new List<string> { "Alice" });
            studentRoster.Add("1002", new List<string> { "Bob" });
            studentRoster.Add("1003", new List<string> { "Charlie" });

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\nStudent Roster Application");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. View Roster");
                Console.WriteLine("4. Append Student Values");
                Console.WriteLine("5. Sort Roster Keys");
                Console.WriteLine("6. Exit");
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
                        AppendStudentValue(studentRoster);
                        break;
                
                    case "5":
                        SortRosterKeys(studentRoster);
                        break;
                
                    case "6":
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
                Console.Write("Enter new Student ID: ");
                string id = Console.ReadLine();
            
                if (roster.ContainsKey(id))
                {
                    Console.WriteLine("Student ID already exists.");
                    return;
                }
            
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();
            
                roster.Add(id, new List<string> { name });
            
                Console.WriteLine("New student added successfully.");
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

        // =========================
        // TASK 5
        // =========================
        static void AppendStudentValue(Dictionary<string, List<string>> roster)
        {
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine();
        
            if (!roster.ContainsKey(id))
            {
                Console.WriteLine("Student ID not found.");
                return;
            }
        
            Console.Write("Enter another value (course, club, nickname, etc.): ");
            string value = Console.ReadLine();
        
            roster[id].Add(value);
        
            Console.WriteLine("Value added successfully.");
        }
        
        // =========================
        // TASK 6
        // =========================
        static void SortRosterKeys(Dictionary<string, List<string>> roster)
        {
            Console.WriteLine("\nStudents Sorted by Student ID:");
        
            foreach (var student in roster.OrderBy(student => student.Key))
            {
                Console.WriteLine($"{student.Key}: {string.Join(", ", student.Value)}");
            }
        }
    }
}


        

                
            
