using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.CodeExam.Core.Core.Exceptions
{
    public class NumberTooHugeException : Exception
    {
        public NumberTooHugeException (decimal number): base("Given "+number+" is too huge")
        {
        }
    }
}
