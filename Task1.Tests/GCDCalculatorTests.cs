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
    }
}
