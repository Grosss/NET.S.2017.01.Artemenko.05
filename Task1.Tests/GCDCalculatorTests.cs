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

        [TestCase(12, 8, 18, ExpectedResult = 2)]
        [TestCase(0, 15, 4, ExpectedResult = 1)]
        [TestCase(6, -27, 36, ExpectedResult = 3)]
        [TestCase(27, 18, 72, ExpectedResult = 9)]
        public int UseEuclideanAlgorithm_PassedThreeNumbersAndTime_ExpectedPositiveTest(int firstNumber, int secondNumber, int thirdNumber)
        {
            long time;

            int actual = GCDCalculator.UseEuclideanAlgorithm(out time, firstNumber, secondNumber, thirdNumber);
            Debug.WriteLine($"Evaluating time is {time}ms");

            return actual;
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

        [TestCase(12, 8, 18, 32, ExpectedResult = 2)]
        [TestCase(0, 15, 4, 100, ExpectedResult = 1)]
        [TestCase(6, -27, 36, 18, ExpectedResult = 3)]
        [TestCase(27, 18, 72, 99, ExpectedResult = 9)]
        [TestCase(new int[] { 36, -96, 60, 126 }, ExpectedResult = 6)]
        public int UseEuclideanAlgorithm_PassedSetOfNumbersAndTime_ExpectedPositiveTest(params int[] setOfNumbers)
        {
            long time;

            int actual = GCDCalculator.UseEuclideanAlgorithm(out time, setOfNumbers);
            Debug.WriteLine($"Evaluating time is {time}ms");

            return actual;
        }

        [TestCase(0, 0)]
        public void UseEuclideanAlgorithm_PassedTwoZeros_ThrowsArgumentException(int firstNumber, int secondNumber)
        {
            Assert.Throws<ArgumentException>(() => GCDCalculator.UseEuclideanAlgorithm(firstNumber, secondNumber));
        }

        [TestCase(0, 0)]
        public void UseEuclideanAlgorithm_PassedTwoZerosAndTime_ThrowsArgumentException(int firstNumber, int secondNumber)
        {
            long time;
            Assert.Throws<ArgumentException>(() => GCDCalculator.UseEuclideanAlgorithm(out time, firstNumber, secondNumber));
        }

        [TestCase(0, 0, 0)]
        public void UseEuclideanAlgorithm_PassedThreeZeros_ThrowsArgumentException(int firstNumber, int secondNumber, int thirdNumber)
        {
            Assert.Throws<ArgumentException>(() => GCDCalculator.UseEuclideanAlgorithm(firstNumber, secondNumber, thirdNumber));
        }

        [TestCase(0, 0, 0)]
        public void UseEuclideanAlgorithm_PassedThreeZerosAndTime_ThrowsArgumentException(int firstNumber, int secondNumber, int thirdNumber)
        {
            long time;
            Assert.Throws<ArgumentException>(() => GCDCalculator.UseEuclideanAlgorithm(out time, firstNumber, secondNumber, thirdNumber));
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

        [TestCase(12, 8, 18, ExpectedResult = 2)]
        [TestCase(0, 15, 4, ExpectedResult = 1)]
        [TestCase(6, -27, 36, ExpectedResult = 3)]
        [TestCase(27, 18, 72, ExpectedResult = 9)]
        public int UseSteinAlgorithm_PassedThreeNumbersAndTime_ExpectedPositiveTest(int firstNumber, int secondNumber, int thirdNumber)
        {
            long time;

            int actual = GCDCalculator.UseSteinAlgorithm(out time, firstNumber, secondNumber, thirdNumber);
            Debug.WriteLine($"Evaluating time is {time}ms");

            return actual;
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

        [TestCase(12, 8, 18, 32, ExpectedResult = 2)]
        [TestCase(0, 15, 4, 100, ExpectedResult = 1)]
        [TestCase(6, -27, 36, 18, ExpectedResult = 3)]
        [TestCase(27, 18, 72, 99, ExpectedResult = 9)]
        [TestCase(new int[] { 36, -96, 60, 126 }, ExpectedResult = 6)]
        public int UseSteinAlgorithm_PassedSetOfNumbersAndTime_ExpectedPositiveTest(params int[] setOfNumbers)
        {
            long time;

            int actual = GCDCalculator.UseSteinAlgorithm(out time, setOfNumbers);
            Debug.WriteLine($"Evaluating time is {time}ms");

            return actual;
        }
        #endregion
    }
}
