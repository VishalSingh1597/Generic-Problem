using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    class Program
    {
        /// <summary>
        /// Entery point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Find MaximumProblem using Generics");
            /// Int Value

            //Console.WriteLine(MaximumNumbers.MaxIntNumber(786, 60, 212));
            //Console.WriteLine(MaximumNumbers.MaxIntNumber(70, 733, 212));
            //Console.WriteLine(MaximumNumbers.MaxIntNumber(943, 73, 3312));


            ///Float values

            //Console.WriteLine(MaximumNumbers.MaxFloatNumber(7.6f, 6.5f, 2.2f));
            //Console.WriteLine(MaximumNumbers.MaxFloatNumber(7.6f, 66.5f, 3f));
            //Console.WriteLine(MaximumNumbers.MaxFloatNumber(7.46f, 65.5f, 231.2f));


            ///string 
            Console.Write("Maximum String is : ");
            string StringOutput = MaximumNumbers.StringMaximumNumber("Apple", "Peach", "Banana");
            Console.Write(StringOutput);

            Console.Read();
        }
    }
}