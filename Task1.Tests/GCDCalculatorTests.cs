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

        [TestCase(null)]
        public void UseEuclideanAlgorithm_PassedNullReference_ThrowsArgumentNullException(int[] setOfNumbers)
        {
            Assert.Throws<ArgumentNullException>(() => GCDCalculator.UseEuclideanAlgorithm(setOfNumbers));
        }

        [TestCase(null)]
        public void UseEuclideanAlgorithm_PassedNullReferenceAndTime_ThrowsArgumentNullException(int[] setOfNumbers)
        {
            long time;
            Assert.Throws<ArgumentNullException>(() => GCDCalculator.UseEuclideanAlgorithm(out time, setOfNumbers));
        }

        [TestCase(1)]
        public void UseEuclideanAlgorithm_PassedArrayWithInvalidLength_ThrowsArgumentOutOfRangeException(params int[] setOfNumbers)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => GCDCalculator.UseEuclideanAlgorithm(setOfNumbers));
        }

        [TestCase(new int[] { })]
        public void UseEuclideanAlgorithm_PassedArrayWithInvalidLengthAndTime_ThrowsArgumentOutOfRangeException(params int[] setOfNumbers)
        {
            long time;
            Assert.Throws<ArgumentOutOfRangeException>(() => GCDCalculator.UseEuclideanAlgorithm(out time, setOfNumbers));
        }

        [TestCase(0, 0, 0, 0)]
        public void UseEuclideanAlgorithm_PassedOnlyZeros_ThrowsArgumentException(params int[] setOfNumbers)
        {
            Assert.Throws<ArgumentException>(() => GCDCalculator.UseEuclideanAlgorithm(setOfNumbers));
        }

        [TestCase(0, 0, 0, 0)]
        public void UseEuclideanAlgorithm_PassedOnlyZerosAndTime_ThrowsArgumentException(params int[] setOfNumbers)
        {
            long time;
            Assert.Throws<ArgumentException>(() => GCDCalculator.UseEuclideanAlgorithm(out time, setOfNumbers));
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

        [TestCase(0, 0)]
        public void UseSteinAlgorithm_PassedTwoZeros_ThrowsArgumentException(int firstNumber, int secondNumber)
        {
            Assert.Throws<ArgumentException>(() => GCDCalculator.UseSteinAlgorithm(firstNumber, secondNumber));
        }

        [TestCase(0, 0)]
        public void UseSteinAlgorithm_PassedTwoZerosAndTime_ThrowsArgumentException(int firstNumber, int secondNumber)
        {
            long time;
            Assert.Throws<ArgumentException>(() => GCDCalculator.UseSteinAlgorithm(out time, firstNumber, secondNumber));
        }

        [TestCase(0, 0, 0)]
        public void UseSteinAlgorithm_PassedThreeZeros_ThrowsArgumentException(int firstNumber, int secondNumber, int thirdNumber)
        {
            Assert.Throws<ArgumentException>(() => GCDCalculator.UseSteinAlgorithm(firstNumber, secondNumber, thirdNumber));
        }

        [TestCase(0, 0, 0)]
        public void UseSteinAlgorithm_PassedThreeZerosAndTime_ThrowsArgumentException(int firstNumber, int secondNumber, int thirdNumber)
        {
            long time;
            Assert.Throws<ArgumentException>(() => GCDCalculator.UseSteinAlgorithm(out time, firstNumber, secondNumber, thirdNumber));
        }

        [TestCase(null)]
        public void UseSteinAlgorithm_PassedNullReference_ThrowsArgumentNullException(int[] setOfNumbers)
        {
            Assert.Throws<ArgumentNullException>(() => GCDCalculator.UseSteinAlgorithm(setOfNumbers));
        }

        [TestCase(null)]
        public void UseSteinAlgorithm_PassedNullReferenceAndTime_ThrowsArgumentNullException(int[] setOfNumbers)
        {
            long time;
            Assert.Throws<ArgumentNullException>(() => GCDCalculator.UseSteinAlgorithm(out time, setOfNumbers));
        }

        [TestCase(1)]
        public void UseSteinAlgorithm_PassedArrayWithInvalidLength_ThrowsArgumentOutOfRangeException(params int[] setOfNumbers)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => GCDCalculator.UseSteinAlgorithm(setOfNumbers));
        }

        [TestCase(new int[] { })]
        public void UseSteinAlgorithm_PassedArrayWithInvalidLengthAndTime_ThrowsArgumentOutOfRangeException(params int[] setOfNumbers)
        {
            long time;
            Assert.Throws<ArgumentOutOfRangeException>(() => GCDCalculator.UseSteinAlgorithm(out time, setOfNumbers));
        }

        [TestCase(0, 0, 0, 0)]
        public void UseSteinAlgorithm_PassedOnlyZeros_ThrowsArgumentException(params int[] setOfNumbers)
        {
            Assert.Throws<ArgumentException>(() => GCDCalculator.UseSteinAlgorithm(setOfNumbers));
        }

        [TestCase(0, 0, 0, 0)]
        public void UseSteinAlgorithm_PassedOnlyZerosAndTime_ThrowsArgumentException(params int[] setOfNumbers)
        {
            long time;
            Assert.Throws<ArgumentException>(() => GCDCalculator.UseSteinAlgorithm(out time, setOfNumbers));
        }
        #endregion
    }
}
