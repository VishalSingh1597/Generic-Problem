﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class MaximumNumbers
    {
        /// <summary>
        /// This method returns largest string among all 3 string
        /// </summary>
        /// <param name="firstValue">firstValue is of string type</param>
        /// <param name="secondValue">secondValue is of string type</param>
        /// <param name="thirdValue">thirdValue is of string type</param>
        /// <returns></returns>
        public static string StringMaximumNumber(string S1, string S2, string S3) //static method
        {
            if (S1.CompareTo(S2) > 0 && S1.CompareTo(S3) > 0)
            {
                return S1;
            }
            if (S2.CompareTo(S1) > 0 && S2.CompareTo(S3) > 0)
            {
                return S2;
            }
            if (S3.CompareTo(S1) > 0 && S3.CompareTo(S2) > 0)
            {
                return S3;
            }
            throw new Exception("S1,S2,S3 are Same ");
        }


    }
}