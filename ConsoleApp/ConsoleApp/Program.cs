using System;
using System.Net.Http;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfo();
        }
        public static void GetInfo()
        {
            StaffRepository staffRepository = new StaffRepository();
            StudentRepository studentRepository = new StudentRepository();
            List<string> student = new List<string>();
            string ans = "y";
            do
            {
                Console.WriteLine("1.Add Staff");
                Console.WriteLine("2.Add Student");
                Console.WriteLine("3.Display all Student as per Staff");
                Console.WriteLine("4.Display all Student as per Class");
                Console.WriteLine("5.Display all Student and add get the list File");
                Console.WriteLine("Enter your Choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Staff Name: ");
                        try
                        {
                            string name = Console.ReadLine();
                            if (name == null)
                            {
                                throw new StaffNameCannotBeNullException("Name cannot be null!");

                            }
                            Console.WriteLine("Enter Staff ID: ");
                            int Id = int.Parse(Console.ReadLine());
                            //Staff staff = new Staff(name, Id);
                            if (staffRepository.SearchStaffID(Id) == false)
                            {
                                Staff staff = new Staff(name, Id);
                                staffRepository.AddStaff(staff);
                            }
                            else
                            {
                                throw new StaffIDAlreadyExistsException("Staff ID already Exists");
                            }
                        }
                        catch(StaffNameCannotBeNullException ne)
                        {
                            Console.WriteLine(ne.Message);
                        }
                        catch(StaffIDAlreadyExistsException se)
                        {
                            Console.WriteLine(se.Message);
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("Enter Student Name:");
                        string sname = Console.ReadLine();
                        Console.WriteLine("Enter Date of Birth");
                        DateTime dob = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Gender:");
                        string gender = Console.ReadLine();
                        Console.WriteLine("Enter Class:");
                        int sclass = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Section:");
                        char section = Convert.ToChar(Console.ReadLine());
                   start:
                        Console.WriteLine("Enter Staff Name:");
                        try
                        {
                            string staffname = Console.ReadLine();
                            Student student = new Student(sname, dob, gender, sclass, section, staffname);
                            if (staffRepository.SearchStaffName(staffname) == true)
                            {
                                studentRepository.AddStudent(student);
                                Console.WriteLine("Successfully Added");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Staff Name");
                            }
                        }
                        catch(InvalidStaffNameException ie)
                        {
                            Console.WriteLine(ie.Message);
                            goto start;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Staff Name:");
                        string stname = Console.ReadLine();
                        students = studentRepository.DisplayStudentAsPerStaff(stname);
                        Console.WriteLine("Students under {0}:", stname);
                        for (int i = 0; i < students.Count; i++) { Console.WriteLine(students[i]); }
                        break;
                    case 4:
                        Console.WriteLine("Enter Class:");
                        int stclass = int.Parse(Console.ReadLine());
                        students = studentRepository.DisplayStudentAsPerClass(stclass);
                        Console.WriteLine("Students in Class {0}:", stclass);
                        for (int i = 0; i < students.Count; i++) { Console.WriteLine(students[i]); }
                        break;
                    case 5:
                        studentRepository.DisplayStudentAndWriteInTextFile(studentRepository);
                        break;
                    default:
                        Console.WriteLine("Enter a Valid Input");
                        break;
                }
                Console.WriteLine("Do you want to continue?(y/n)");
                ans = Console.ReadLine();
            } while (ans == "y");
        }
    }
}
