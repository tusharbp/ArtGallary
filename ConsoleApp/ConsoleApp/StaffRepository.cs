using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class StaffRepository
    {
        List<Staff> StaffList = new List<Staff>();
        public void AddStaff(Staff staff)
        {
            StaffList.Add(staff);

        }
        public bool SearchStaffID(int id)
        {
            foreach(var c in StaffList)
            {
                if (c.StaffID == id)
                    return true;
            }
            return false;
        }
        public bool SearchStaffName(string name)
        {
            foreach(var c in StaffList)
            {
                if (c.StaffName == name)
                    return true;
            }
            return false;
        }   
    }
}
