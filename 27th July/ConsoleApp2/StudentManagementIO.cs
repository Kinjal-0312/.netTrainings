using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailsFilesSegregated
{
    class StudentManagementIO
    {
        StudentService studentService = new StudentService();
        public byte Menu()
        {
            Console.WriteLine("Press 1 to Add");
            Console.WriteLine("Press 2 to display");
            Console.WriteLine("Press 3 to Update");
            Console.WriteLine("Press 4 to Delete");
            Console.WriteLine("Press 0 to Exit");
            Console.WriteLine("Enter option");
            byte option = Convert.ToByte(Console.ReadLine());
            return option;
        }
        public void AddStudent()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter standard");
            byte standard = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter Id");
            string id = Console.ReadLine();

            Student student = studentService.AddStudent(name, id, age, standard, address);
            Display(student);
            Console.WriteLine("=========================================");

        }
        public void DisplayAll()
        {
            Console.WriteLine();
            studentService.DisplayAll();
            Console.WriteLine();
        }

        private void Display(Student student)
        {
            if (student == null)
            {
                Console.WriteLine("Student not found");
            }
            else
            {
                Console.WriteLine("==============================");
                Console.WriteLine("id: " + student.ID);
                Console.WriteLine("name: " + student.Name);
                Console.WriteLine("Age: " + student.Age);
                Console.WriteLine("standard" + student.Standard);
                Console.WriteLine("Address: " + student.City);
            }
        }

        public void DeleteStudent()
        {
            Console.WriteLine("Enter id");
            string id = Console.ReadLine();
            if (studentService.DeleteStudent(id))
            {
                Console.WriteLine("Student deleted successfully");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        public void UpdateStudent()
        {
            Console.WriteLine("1 update");
            Console.WriteLine("2 update address");
            Console.WriteLine("Enter option: ");
            switch (Convert.ToByte(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.Write("enter id: ");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter new age");
                        byte age = Convert.ToByte(Console.ReadLine());
                        Display(studentService.UpdateStudentAge(id, age));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter id:");
                        string id = Console.ReadLine();
                        Console.Write("Enter new address");
                        string city = Console.ReadLine();
                        Display(studentService.UpdateStudentCity(id, city));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter valid option");
                        break;
                    }
            }
        }
    }
}