using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class StaffIDAlreadyExistsException:Exception
    {
        public StaffIDAlreadyExistsException() : base() { }
        public StaffIDAlreadyExistsException(string message) : base(message) { }
    }
}
