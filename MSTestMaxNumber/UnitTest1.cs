using GenericsProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestMaxNumber
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Pass  Integer Number and Return Maximum Number
        /// </summary>

        [TestMethod]
        public void MaximumNumberGenericInteger_PassThreeNumbers_ReturnMaximumNumber()
        {
            int[] intArray = { 112, 344, 432, 555, 678 };
            Generic<int> generic = new Generic<int>(intArray); //crating object with int data type
            int result = generic.MaxMethod();//actual
            int max = 678;//expected
            Assert.AreEqual(result, max);
        }

        /// <summary>
        /// Pass  Float Number and Return Maximum Number
        /// </summary>
        [TestMethod]
        public void MaximumNumberGenericFloat_PassThreeNumbers_ReturnMaximumNumber()
        {
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            Generic<double> genericDouble = new Generic<double>(doubleArray);
            double result = genericDouble.MaxMethod();
            double max = 55.5;
            Assert.AreEqual(result, max);
        }
        /// <summary>
        /// Pass three strin  Number and Return Maximum string
        /// </summary>
        [TestMethod]
        public void MaximumNumberGenericString_PassThreeNumbers_ReturnMaximumNumber()
        {
            string[] stringArray = { "Banana", "Peach", "Apple" };
            Generic<string> genericString = new Generic<string>(stringArray);
            string result = genericString.MaxMethod();
            string max = "Peach";
            Assert.AreEqual(result, max);
        }
    }
}