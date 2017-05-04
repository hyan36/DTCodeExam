using DT.CodeExam.Core.Core;
using DT.CodeExam.Core.Core.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.CodeExam.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = -122223340.031231231234m;
            var number = new Number(input);
            Console.WriteLine(number.Spell(100000));
            //var excp = new Number((decimal) Math.Pow(10, 22));
        }
    }
}
