using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise02
{
    
    
         // StudentManagementSystem.cs
            // Ready-to-run single-file Console App code.
            // Copy this entire file into Program.cs of a new Console App project and run (Ctrl+F5).

            using System;
            using System.Collections.Generic;

namespace StudentManagementSystem
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string ClassName { get; set; }
            public string Grade { get; set; }

            public void Display()
            {
                Console.WriteLine($"ID: {Id}\tName: {Name}\tAge: {Age}\tClass: {ClassName}\tGrade: {Grade}");
            }
        }

        class Program
        {
            static List<Student> students = new List<Student>();
            static int nextId = 1;

            static void Main(string[] args)
            {
                // Optional: seed with a couple of entries to test quickly
                // students.Add(new Student { Id = nextId++, Name = "Test", Age = 16, ClassName = "10A", Grade = "A" });

                while (true)
                {
                    ShowMenu();
                    int choice = ReadInt("Enter choice: ", allowEmpty: false);

                    switch (choice)
                    {
                        case 1: AddStudent(); break;
                        case 2: ViewStudents(); break;
                        case 3: SearchStudent(); break;
                        case 4: UpdateStudent(); break;
                        case 5: DeleteStudent(); break;
                        case 6:
                            Console.WriteLine("Exiting... Bye!");
                            return;
                        default:
                            Console.WriteLine("❌ Invalid choice, try again!");
                            break;
                    }

                    Console.WriteLine();
                }
            }

            static void ShowMenu()
            {
                Console.WriteLine("\n===== Student Management System =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student by ID");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit");
            }

            static void AddStudent()
            {
                Console.WriteLine("\n--- Add New Student ---");
                var student = new Student();
                student.Id = nextId++;
                student.Name = ReadString("Enter Name: ");
                student.Age = ReadInt("Enter Age: ", min: 1, max: 120);
                student.ClassName = ReadString("Enter Class (eg. 10A): ");
                student.Grade = ReadString("Enter Grade (eg. A/B/C): ");

                students.Add(student);
                Console.WriteLine("✅ Student added successfully!");
            }

            static void ViewStudents()
            {
                Console.WriteLine("\n--- Student List ---");
                if (students.Count == 0)
                {
                    Console.WriteLine("No students found!");
                    return;
                }

                foreach (var s in students)
                {
                    s.Display();
                }
            }

            static void SearchStudent()
            {
                Console.WriteLine("\n--- Search Student ---");
                int id = ReadInt("Enter Student ID to search: ", allowEmpty: false);
                var student = students.Find(s => s.Id == id);
                if (student != null)
                    student.Display();
                else
                    Console.WriteLine("❌ Student not found!");
            }

            static void UpdateStudent()
            {
                Console.WriteLine("\n--- Update Student ---");
                int id = ReadInt("Enter Student ID to update: ", allowEmpty: false);
                var student = students.Find(s => s.Id == id);
                if (student == null)
                {
                    Console.WriteLine("❌ Student not found!");
                    return;
                }

                Console.WriteLine($"Updating student: {student.Name} (ID: {student.Id})");
                string newName = ReadString($"Enter New Name (leave empty to keep '{student.Name}'): ", allowEmpty: true);
                if (!string.IsNullOrWhiteSpace(newName)) student.Name = newName;

                string ageInput = ReadString($"Enter New Age (leave empty to keep '{student.Age}'): ", allowEmpty: true);
                if (!string.IsNullOrWhiteSpace(ageInput) && int.TryParse(ageInput, out int newAge))
                    student.Age = newAge;

                string newClass = ReadString($"Enter New Class (leave empty to keep '{student.ClassName}'): ", allowEmpty: true);
                if (!string.IsNullOrWhiteSpace(newClass)) student.ClassName = newClass;

                string newGrade = ReadString($"Enter New Grade (leave empty to keep '{student.Grade}'): ", allowEmpty: true);
                if (!string.IsNullOrWhiteSpace(newGrade)) student.Grade = newGrade;

                Console.WriteLine("✅ Student updated successfully!");
            }

            static void DeleteStudent()
            {
                Console.WriteLine("\n--- Delete Student ---");
                int id = ReadInt("Enter Student ID to delete: ", allowEmpty: false);
                var student = students.Find(s => s.Id == id);
                if (student == null)
                {
                    Console.WriteLine("❌ Student not found!");
                    return;
                }

                Console.Write($"Are you sure you want to delete '{student.Name}' (ID: {student.Id})? (y/n): ");
                string confirm = Console.ReadLine().Trim().ToLower();
                if (confirm == "y" || confirm == "yes")
                {
                    students.Remove(student);
                    Console.WriteLine("✅ Student deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Deletion cancelled.");
                }
            }

            // Helper methods for safe input
            static int ReadInt(string prompt, bool allowEmpty = true, int min = int.MinValue, int max = int.MaxValue)
            {
                while (true)
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        if (allowEmpty) return 0;
                        Console.WriteLine("Input cannot be empty. Try again.");
                        continue;
                    }

                    if (int.TryParse(input, out int value))
                    {
                        if (value < min || value > max)
                        {
                            Console.WriteLine($"Please enter a number between {min} and {max}.");
                            continue;
                        }

                        return value;
                    }

                    Console.WriteLine("Invalid number. Try again.");
                }
            }

            static string ReadString(string prompt, bool allowEmpty = false)
            {
                while (true)
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        if (allowEmpty) return string.Empty;
                        Console.WriteLine("Input cannot be empty. Try again.");
                        continue;
                    }

                    return input.Trim();
                }
            }
        }
    }

}
    

