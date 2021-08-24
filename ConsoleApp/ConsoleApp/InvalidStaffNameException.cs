using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class InvalidStaffNameException:Exception
    {
        public InvalidStaffNameException() : base() { }
        public InvalidStaffNameException(string message) : base(message) { }
    }
}
