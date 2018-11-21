using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new student("george");
            Console.WriteLine($"Hello World!from {student}");
            Console.Read();
        }
    }
}
