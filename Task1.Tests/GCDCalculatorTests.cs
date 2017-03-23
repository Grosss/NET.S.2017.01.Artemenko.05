using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task1.Tests
{
    [TestFixture]
    public class GCDCalculatorTests
    {
        #region Tests for Euclidean algorithm
        [TestCase(12, 8, ExpectedResult = 4)]
        [TestCase(0, 12, ExpectedResult = 12)]
        [TestCase(6, 6, ExpectedResult = 6)]
        [TestCase(15, 18, ExpectedResult = 3)]
        public int UseEuclideanAlgorithm_PassedTwoNumbers_ExpectedPositiveTest(int firstNumber, int secondNumber)
        {
            return GCDCalculator.UseEuclideanAlgorithm(firstNumber, secondNumber);
        }          

        [TestCase(12, 8, ExpectedResult = 4)]
        [TestCase(0, 12, ExpectedResult = 12)]
        [TestCase(6, 6, ExpectedResult = 6)]
        [TestCase(15, 18, ExpectedResult = 3)]
        public int UseEuclideanAlgorithm_PassedTwoNumbersAndTime_ExpectedPositiveTest(int firstNumber, int secondNumber)
        {
            long time;

            int actual = GCDCalculator.UseEuclideanAlgorithm(out time, firstNumber, secondNumber);
            Debug.WriteLine($"Evaluating time is {time}ms");

            return actual;
        }

        [TestCase(12, 8, 18, ExpectedResult = 2)]
        [TestCase(0, 15, 4, ExpectedResult = 1)]
        [TestCase(6, -27, 36, ExpectedResult = 3)]
        [TestCase(27, 18, 72, ExpectedResult = 9)]
        public int UseEuclideanAlgorithm_PassedThreeNumbers_ExpectedPositiveTest(int firstNumber, int secondNumber, int thirdNumber)
        {
            return GCDCalculator.UseEuclideanAlgorithm(firstNumber, secondNumber, thirdNumber);
        }

        [TestCase(12, 8, 18, 32, ExpectedResult = 2)]
        [TestCase(0, 15, 4, 100, ExpectedResult = 1)]
        [TestCase(6, -27, 36, 18, ExpectedResult = 3)]
        [TestCase(27, 18, 72, 99, ExpectedResult = 9)]
        [TestCase(new int[] { 36, -96, 60, 126}, ExpectedResult = 6)]
        public int UseEuclideanAlgorithm_PassedSetOfNumbers_ExpectedPositiveTest(params int[] setOfNumbers)
        {
            return GCDCalculator.UseEuclideanAlgorithm(setOfNumbers);
        }
        #endregion

        #region Tests for Stein algorithm
        [TestCase(-12, 8, ExpectedResult = 4)]
        [TestCase(0, 12, ExpectedResult = 12)]
        [TestCase(6, -6, ExpectedResult = 6)]
        [TestCase(15, 18, ExpectedResult = 3)]
        public int UseSteinAlgorithm_PassedTwoNumbers_ExpectedPositiveTest(int firstNumber, int secondNumber)
        {
            return GCDCalculator.UseSteinAlgorithm(firstNumber, secondNumber);
        }

        [TestCase(12, 8, ExpectedResult = 4)]
        [TestCase(0, 12, ExpectedResult = 12)]
        [TestCase(6, 6, ExpectedResult = 6)]
        [TestCase(15, 18, ExpectedResult = 3)]
        public int UseSteinAlgorithm_PassedTwoNumbersAndTime_ExpectedPositiveTest(int firstNumber, int secondNumber)
        {
            long time;

            int actual = GCDCalculator.UseSteinAlgorithm(out time, firstNumber, secondNumber);
            Debug.WriteLine($"Evaluating time is {time}ms");

            return actual;
        }

        [TestCase(12, 8, 18, ExpectedResult = 2)]
        [TestCase(0, 15, 4, ExpectedResult = 1)]
        [TestCase(6, -27, 36, ExpectedResult = 3)]
        [TestCase(27, 18, 72, ExpectedResult = 9)]
        public int UseSteinAlgorithm_PassedThreeNumbers_ExpectedPositiveTest(int firstNumber, int secondNumber, int thirdNumber)
        {
            return GCDCalculator.UseSteinAlgorithm(firstNumber, secondNumber, thirdNumber);
        }

        [TestCase(12, 8, 18, 32, ExpectedResult = 2)]
        [TestCase(0, 15, 4, 100, ExpectedResult = 1)]
        [TestCase(6, -27, 36, 18, ExpectedResult = 3)]
        [TestCase(27, 18, 72, 99, ExpectedResult = 9)]
        [TestCase(new int[] { 36, -96, 60, 126 }, ExpectedResult = 6)]
        public int UseSteinAlgorithm_PassedSetOfNumbers_ExpectedPositiveTest(params int[] setOfNumbers)
        {
            return GCDCalculator.UseSteinAlgorithm(setOfNumbers);
        }
        #endregion
    }
}
