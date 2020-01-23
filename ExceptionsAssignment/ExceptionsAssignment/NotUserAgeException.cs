using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment
{
    class NotUserAgeException : Exception
    {
        public NotUserAgeException()
            : base() { }
        public NotUserAgeException(string message)
            : base() { }
    }
}
