using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DulTests._00_Assert
{
    [TestClass]
    public class AssertDemo
    {
        /*[TestMethod]
        public void AssertEqualTest()
        {
            Assert.AreEqual(1234, 1234);
        }*/

        [TestMethod]
        public void SelectionSort_ShouldReturnSortedArray()
        {
            int[] arr = { 33, 22, 44 };

            //int[] results = Operator.클래스_라이브러리.Algorithm.SelectionSort(arr);

            int[] results = DulAlgorithm.Algorithm.SelectionSort(arr);

            Assert.AreEqual(22, results[0]);
            Assert.AreEqual(44, results[results.Length - 1]);
            foreach(int nums in results)
            {
                Console.WriteLine(nums);
            }

        }
    }
}
