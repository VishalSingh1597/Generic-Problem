using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Find MaximumProblem using Generics");
            Console.WriteLine(MaximumNumbers.MaxIntNumber(786, 60, 212));
            Console.WriteLine(MaximumNumbers.MaxIntNumber(70, 733, 212));
            Console.WriteLine(MaximumNumbers.MaxIntNumber(943, 73, 3312));
            Console.Read();
        }
    }
}