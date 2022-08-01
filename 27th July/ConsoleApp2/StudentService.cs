using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailsFilesSegregated
{
    class StudentService
    {
        List<Student> list1 = new List<Student>();
        public Student AddStudent(string name, string id, byte age, byte standard, string city)
        {
            Student s = new Student(name, id, age, standard, city);
            list1.Add(s);
            return s;
        }

        public Student GetStudentByID(string id)
        {
            if (list1.Count != 0)
            {
                foreach (Student s in list1)
                {
                    if (s.ID == id)
                    {
                        return s;
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        public Student UpdateStudentAge(string id, byte age)
        {
            if (list1.Count != 0)
            {
                foreach (Student s in list1)
                {
                    if (s.ID == id)
                    {
                        s.Age = age;
                        return s;
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }
        public Student UpdateStudentCity(string id, string city)
        {
            if (list1.Count != 0)
            {
                foreach (Student s in list1)
                {
                    if (s.ID == id)
                    {
                        s.City = city;
                        return s;
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        public void DisplayAll()
        {
            if (list1.Count == 0)
            {
                Console.WriteLine("There are no Students, First Add Some");
            }
            else
            {
                Console.WriteLine("All Students are show below:");
                foreach (Student std in list1)
                {
                    Console.WriteLine("".PadLeft(15, '-'));
                    Console.WriteLine("ID: " + std.ID);
                    Console.WriteLine("Name: " + std.Name);
                    Console.WriteLine("Age: " + std.Age);
                    Console.WriteLine("Class: " + std.Standard);
                    Console.WriteLine("City: " + std.City);
                }
            }
        }
        public bool DeleteStudent(string id)
        {
            if (list1.Count > 0)
            {
                Student std = GetStudentByID(id);
                if (std != null)
                {
                    list1.Remove(std);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}