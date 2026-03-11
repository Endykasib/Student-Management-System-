using System;
using System.Collections.Generic;
namespace Student_Management_System_Task
{
    internal class Program
    {
        class Student
        {

            public int StudentId;
            public string Name = string.Empty;
            public int Age;
            public List<Course> Courses = new List<Course>();

            public bool Enroll(Course course)
            {
                Courses.Add(course);
                return true;
            }

            public string PrintDetails()
            {
                return "ID: " + StudentId + " Name: " + Name + " Age: " + Age;
            }
        }
        class Course
        {
            public int CourseId;
            public string Title = string.Empty;

            public Instructor? Instructor;

            public string PrintDetails()
            {
                return "Course ID: " + CourseId + " Title: " + Title +
                       " Instructor: " + Instructor?.Name;
            }
        }
        class Instructor
        {
            public int InstructorId;
            public string Name = string.Empty;
            public string Specialization = string.Empty;

            public string PrintDetails()
            {
                return "Instructor ID: " + InstructorId +
                       " Name: " + Name +
                       " Specialization: " + Specialization;
            }
        }
        class StudentManager
        {
            public List<Student> Students = new List<Student>();
            public List<Course> Courses = new List<Course>();
            public List<Instructor> Instructors = new List<Instructor>();

            public bool AddStudent(Student student)
            {
                Students.Add(student);
                return true;
            }

            public bool AddCourse(Course course)
            {
                Courses.Add(course);
                return true;
            }

            public bool AddInstructor(Instructor instructor)
            {
                Instructors.Add(instructor);
                return true;
            }

            public Student FindStudent(int id)
            {
                foreach (Student s in Students)
                {
                    if (s.StudentId == id)
                        return s;
                }
                return null;
            }

            public Course FindCourse(int id)
            {
                foreach (Course c in Courses)
                {
                    if (c.CourseId == id)
                        return c;
                }
                return null;
            }

            public bool EnrollStudentInCourse(int studentId, int courseId)
            {
                Student student = FindStudent(studentId);
                Course course = FindCourse(courseId);

                if (student != null && course != null)
                {
                    student.Enroll(course);
                    return true;
                }

                return false;
            }
        }
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();

            while (true)
            {
                Console.WriteLine("\n 1 Add Student");
                Console.WriteLine("2 Add Instructor");
                Console.WriteLine("3 Add Course");
                Console.WriteLine("4 Enroll Student");
                Console.WriteLine("5 Show Students");
                Console.WriteLine("6 Show Courses");
                Console.WriteLine("7 Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Student s = new Student();

                    Console.Write("Enter ID: ");
                    s.StudentId = int.Parse(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    s.Name = Console.ReadLine();

                    Console.Write("Enter Age: ");
                    s.Age = int.Parse(Console.ReadLine());

                    manager.AddStudent(s);
                }

                else if (choice == 2)
                {
                    Instructor i = new Instructor();

                    Console.Write("Instructor ID: ");
                    i.InstructorId = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    i.Name = Console.ReadLine();

                    Console.Write("Specialization: ");
                    i.Specialization = Console.ReadLine();

                    manager.AddInstructor(i);
                }

                else if (choice == 3)
                {
                    Course c = new Course();

                    Console.Write("Course ID: ");
                    c.CourseId = int.Parse(Console.ReadLine());

                    Console.Write("Title: ");
                    c.Title = Console.ReadLine();

                    Console.Write("Instructor ID: ");
                    int insId = int.Parse(Console.ReadLine());

                    foreach (Instructor i in manager.Instructors)
                    {
                        if (i.InstructorId == insId)
                            c.Instructor = i;
                    }

                    manager.AddCourse(c);
                }

                else if (choice == 4)
                {
                    Console.Write("Student ID: ");
                    int sid = int.Parse(Console.ReadLine());

                    Console.Write("Course ID: ");
                    int cid = int.Parse(Console.ReadLine());

                    manager.EnrollStudentInCourse(sid, cid);
                }

                else if (choice == 5)
                {
                    for (int i = 0; i < manager.Students.Count; i++)
                    {
                        Console.WriteLine(manager.Students[i].PrintDetails());
                    }
                }

                else if (choice == 6)
                {
                    for (int i = 0; i < manager.Courses.Count; i++)
                    {
                        Console.WriteLine(manager.Courses[i].PrintDetails());
                    }
                }

                else if (choice == 7)
                {
                    break;
                }
            }
        }
    }
}
    


