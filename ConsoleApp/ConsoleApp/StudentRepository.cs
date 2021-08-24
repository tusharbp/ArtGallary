using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class StudentRepository
    {
        FileStream fs = null;
        List<Student> StudentList = new List<Student>();
        public void AddStudent(Student student)
        {
            StudentList.Add(student);
        }
        public List<string> DisplayStudentAsPerStaff(string staffName)
        {
            List<string> students = new List<string>();
            foreach(var c in StudentList)
            {

                if (c.StaffName == staffName)
                    students.Add(c.StudentName);
            }
            return students;
        }
        public List<string> DisplayStudentAsPerClass(int stclass)
        {
            List<string> students = new List<string>();
            foreach(var c in StudentList)
            {
                if (c.StudentClass == stclass)
                    students.Add(c.StudentName);
            }
            return students;
        }
        public void DisplayStudentAndWriteInTextFile(StudentRepository studentRepository)
        {
            foreach (var c in StudentList)
                Console.WriteLine("ID:{0}, Name;{1}, Date of Birth:{2}, Gender:{3}, Class:{4}, Section:{5}"
                        , c.StudentID, c.StudentName, c.DOB, c.Gender, c.StudentClass, c.Section);
            try
            {
                TextWriter tw = new StreamWriter("D:/Students.txt", true);
                foreach (var c in StudentList)
                    tw.WriteLine("ID:{0}, Name;{1}, Date of Birth:{2}, Gender:{3}, Class:{4}, Section:{5}"
                        , c.StudentID, c.StudentName, c.DOB, c.Gender, c.StudentClass, c.Section);
                tw.Close();
                Console.WriteLine("File Stored Successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
