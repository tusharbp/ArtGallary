using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class StaffNameCannotBeNullException:Exception
    {
        public StaffNameCannotBeNullException() : base() { }
        public StaffNameCannotBeNullException(string message) : base(message) { }
    }
}
