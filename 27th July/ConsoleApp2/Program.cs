using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailsFilesSegregated
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManagementIO studentManagementIO = new StudentManagementIO();
            Boolean toExit = true;
            do
            {
                switch (studentManagementIO.Menu())
                {
                    case 1:
                        {
                            studentManagementIO.AddStudent();

                            break;
                        }
                    case 2:
                        {
                            studentManagementIO.DisplayAll();
                            break;
                        }
                    case 3:
                        {
                            studentManagementIO.UpdateStudent();
                            break;
                        }
                    case 4:
                        {
                            studentManagementIO.DeleteStudent();
                            break;
                        }
                    case 0:
                        {
                            toExit = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter the valid option");
                            break;
                        }
                }
            } while (toExit);
        }
    }
}