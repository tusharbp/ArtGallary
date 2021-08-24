using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Student
    {
        public int StudentID = 0;
        public Student()
        {
            StudentID++;
        }
        public Student(string name, DateTime dob, string gender, int sclass, char section, string staffName)
        {
            StudentName = name;
            DOB = dob;
            Gender = gender;
            StudentClass = sclass;
            Section = section;
            StaffName = staffName;
        }

        public string StudentName { get; set; }
        public DateTime DOB;
        public string Gender { set; get; }
        public int StudentClass { set; get; }
        public char Section { set; get; }
        public string StaffName;
    }
}
