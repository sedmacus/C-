using System;
using System.Collections.Generic;
using System.Linq;


namespace HomeworkClass09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> trainers = new List<string> { "Martin", "Pece", "Vesna", "Simona", "Ivana" };

                List<string> admins = new List<string> { "Goce", "Bojan", "Risto", "Elena", "Angela" };

                List<Student> students = new List<Student>
            {
                new Student("Bob", "C#", 7),
                new Student("Mike", "JS", 6),
                new Student("Jane", "HTML", 10),
                new Student("Anne", "JS", 10),
                new Student("Dave", "C#", 7),
            };

                Console.WriteLine("Please Log in as...\n1.Admin \n2.Trainer \n3.Student");
                string logInInput = Console.ReadLine();
                string adminName = string.Empty;

                if (logInInput == "1")
                {
                    Console.WriteLine("What is your admin name?");
                    adminName = Console.ReadLine();
                    string adminInput = string.Empty;

                    foreach (string a in admins)
                    {
                        if (adminName.ToLower() == a.ToLower())
                        {
                            Console.WriteLine($"Hi {adminName} what is your next task?");
                            Console.WriteLine($"1.Add Trainer \n2.Remove Trainer \n3.Add Student \n4.Remove Student \n5.Add Admin \n6.Remove Admin");
                            adminInput = Console.ReadLine();

                            if (string.IsNullOrEmpty(adminInput))
                            {
                                throw new Exception("Invalid input!");
                            }
                        }
                    }
                    switch (adminInput)
                    {
                        case "1":
                            Console.WriteLine("Please enter new Trainer");
                            string newTrainer = Console.ReadLine();

                            if (string.IsNullOrEmpty(newTrainer))
                            {
                                throw new Exception("Please enter valid name!");
                            }
                            else
                            {
                                trainers.Add(newTrainer);
                            }
                            trainers.ForEach(t => Console.WriteLine("Trainers: " + t));
                            break;

                        case "2":
                            Console.WriteLine("Which Trainer you like to Remove");

                            foreach (string t in trainers)
                            {
                                Console.WriteLine(t);
                            }
                            string trainerRemoved = Console.ReadLine();
                            if (string.IsNullOrEmpty(trainerRemoved))
                            {
                                throw new Exception("Please enter name of the Trainer to be Removed");
                            }
                            else
                            {
                                foreach (string t1 in trainers)
                                    if (trainerRemoved.ToLower() == t1.ToLower())
                                    {
                                        trainers.Remove(trainerRemoved);
                                        Console.WriteLine($"{trainerRemoved} is removed.");
                                        break;
                                    }
                                trainers.ForEach(t => Console.WriteLine("Trainers: " + t));
                            }
                            break;

                        case "3":
                            Console.WriteLine("Enter name:");
                            string studentName = Console.ReadLine();
                            if (string.IsNullOrEmpty(studentName))
                            {
                                throw new Exception("Please enter valid input!");
                            }

                            Console.WriteLine("Enter subject:");
                            string studentSubject = Console.ReadLine();
                            if (string.IsNullOrEmpty(studentSubject))
                            {
                                throw new Exception("Please enter valid input!");
                            }

                            Console.WriteLine("Enter grades");
                            string studentGrades = Console.ReadLine();
                            if (!int.TryParse(studentGrades, out int studentGradesInt))
                            {
                                throw new Exception("Please enter valid number!");
                            }

                            Student newStudent = new Student(studentName, studentSubject, studentGradesInt);

                            students.Add(newStudent);

                            break;

                        case "4":
                            Console.WriteLine("Which Student you like to remove:");
                            foreach (Student s in students)
                            {
                                Console.WriteLine(s.Name);
                            }

                            string removedStudent = Console.ReadLine();
                            if (string.IsNullOrEmpty(removedStudent))
                            {
                                throw new Exception("Invalid name");
                            }
                            foreach (Student s1 in students)
                            {
                                if (removedStudent.ToLower() == s1.Name.ToLower())
                                {
                                    students.Remove(s1);
                                    Console.WriteLine($"{removedStudent} is removed.");
                                    break;
                                }
                            }
                            break;

                        case "5":
                            Console.WriteLine("Enter name of the new admin:");
                            string newAdminName = Console.ReadLine();
                            if (string.IsNullOrEmpty(newAdminName))
                            {
                                throw new Exception("Please enter name!");
                            }
                            admins.Add(newAdminName);

                            foreach (string admn in admins)
                            {
                                Console.WriteLine(admn);
                            }
                            break;

                        case "6":
                            Console.WriteLine("Which admin you like to remove:");
                            foreach (string a in admins)
                            {
                                if (adminName.ToLower() == a.ToLower())
                                {
                                    continue;
                                }
                                Console.WriteLine(a);
                            }
                            string removedAdmin = Console.ReadLine();
                            if (string.IsNullOrEmpty(removedAdmin))
                            {
                                throw new Exception("Invalid name!");
                            }
                            admins.Remove(removedAdmin);
                            Console.WriteLine($"{removedAdmin} is removed.");
                            break;
                        default:
                            {
                                throw new Exception("Invalid input!");
                            }

                    }
                }
                else if (logInInput == "2")
                {
                    Console.WriteLine("You want to see \n1.All Students \n2.All Subjects");
                    string trainerInput = Console.ReadLine();
                    if (string.IsNullOrEmpty(trainerInput))
                    {
                        throw new Exception("Invalid input");
                    }
                    if (trainerInput == "1")
                    {
                        foreach (Student s in students)
                        {
                            Console.WriteLine(s.Name);
                        }
                        Console.WriteLine("Please choose a student");
                        string choosenStudent = Console.ReadLine();
                        if (string.IsNullOrEmpty(choosenStudent))
                        {
                            throw new Exception("Invalid student");
                        }
                        foreach (Student s in students)
                        {
                            if (choosenStudent.ToLower() == s.Name.ToLower())
                            {
                                Console.WriteLine(s.CurrentSubject);
                            }
                        }

                    }
                    else if (trainerInput == "2")
                    {
                        foreach (Student s in students)
                        {
                            Console.WriteLine(s.CurrentSubject);
                        }
                    }
                }
                else if (logInInput == "3")
                {
                    Console.WriteLine("What is you name");
                    string studentName = Console.ReadLine();
                    if (string.IsNullOrEmpty(studentName))
                    {
                        throw new Exception("Invalid student");
                    }
                    foreach (Student s in students)
                    {
                        if (studentName.ToLower() == s.Name.ToLower())
                        {
                            Console.WriteLine($"Subject: {s.CurrentSubject} Grades: {s.Grades}");
                        }
                    }
                }
                else
                {
                    throw new Exception("Invalid input!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for using our app");
            }
            
            
        }
    }
}
