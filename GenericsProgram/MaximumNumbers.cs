using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class MaximumNumbers
    {
        /// <summary>
        /// This method returns largest numbers among all 3 float numbers 
        /// </summary>
        /// <param name="firstValue">firstValue is of float type</param>
        /// <param name="secondValue">secondValue is of float type</param>
        /// <param name="thirdValue">thirdValue is of float type</param>
        /// <returns></returns>
        public static float MaxFloatNumber(float firstnumb, float secondnumb, float thirdnumb)
        {
            if (firstnumb.CompareTo(secondnumb) > 0 && firstnumb.CompareTo(thirdnumb) > 0)
            {
                return firstnumb;
            }
            else if (secondnumb.CompareTo(firstnumb) > 0 && secondnumb.CompareTo(thirdnumb) > 0)
            {
                return secondnumb;
            }
            else if (thirdnumb.CompareTo(firstnumb) > 0 && thirdnumb.CompareTo(secondnumb) > 0)
            {
                return thirdnumb;
            }
            else
            {
                Console.WriteLine("all 3 numbers are same");
                return 0;
            }
        }
    }

}