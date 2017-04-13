using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task1
{
    /// <summary>
    /// 
    /// </summary>
    public static class GCDCalculator
    {
        #region UseEuclideanAlgorithm overloads

        public static int UseEuclideanAlgorithm(int firstNumber, int secondNumber)
            => GetGCD(GetEuclideanGCD, firstNumber, secondNumber);        

        public static int UseEuclideanAlgorithm(out long timeInMilliseconds, int firstNumber, int secondNumber)
            => GetGCD(out timeInMilliseconds, GetEuclideanGCD, firstNumber, secondNumber);

        public static int UseEuclideanAlgorithm(int firstNumber, int secondNumber, int thirdNumber)
            => GetGCD(GetEuclideanGCD, firstNumber, secondNumber, thirdNumber);

        public static int UseEuclideanAlgorithm(out long timeInMilliseconds, int firstNumber, int secondNumber, int thirdNumber)
            => GetGCD(out timeInMilliseconds, GetEuclideanGCD, firstNumber, secondNumber, thirdNumber);

        public static int UseEuclideanAlgorithm(params int[] setOfNumbers)
            => GetGCD(GetEuclideanGCD, setOfNumbers);

        public static int UseEuclideanAlgorithm(out long timeInMilliseconds, params int[] setOfNumbers)
            => GetGCD(out timeInMilliseconds, GetEuclideanGCD, setOfNumbers);

        #endregion

        #region UseSteinAlgorithm overloads
        
        public static int UseSteinAlgorithm(int firstNumber, int secondNumber)
            => GetGCD(GetSteinGCD, firstNumber, secondNumber);

        public static int UseSteinAlgorithm(out long timeInMilliseconds, int firstNumber, int secondNumber)
            => GetGCD(out timeInMilliseconds, GetSteinGCD, firstNumber, secondNumber);

        public static int UseSteinAlgorithm(int firstNumber, int secondNumber, int thirdNumber)
            => GetGCD(GetSteinGCD, firstNumber, secondNumber, thirdNumber);

        public static int UseSteinAlgorithm(out long timeInMilliseconds, int firstNumber, int secondNumber, int thirdNumber)
            => GetGCD(out timeInMilliseconds, GetSteinGCD, firstNumber, secondNumber, thirdNumber);

        public static int UseSteinAlgorithm(params int[] setOfNumbers)
            => GetGCD(GetSteinGCD, setOfNumbers);

        public static int UseSteinAlgorithm(out long timeInMilliseconds, params int[] setOfNumbers)
            => GetGCD(out timeInMilliseconds, GetSteinGCD, setOfNumbers);

        #endregion

        #region Private Methods

        private static int GetGCD(Func<int, int, int> funcOfGCD, int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 && secondNumber == 0)
                throw new ArgumentException();

            int result = funcOfGCD(firstNumber, secondNumber);
            return result;
        }

        public static int GetGCD(out long timeInMilliseconds, Func<int, int, int> funcOfGCD, int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 && secondNumber == 0)
                throw new ArgumentException();

            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = funcOfGCD(firstNumber, secondNumber);
            timer.Stop();
            timeInMilliseconds = timer.ElapsedMilliseconds;
            return result;
        }

        public static int GetGCD(Func<int, int, int> funcOfGCD, int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber == 0 && secondNumber == 0 && thirdNumber == 0)
                throw new ArgumentException();

            int result = funcOfGCD(funcOfGCD(firstNumber, secondNumber), thirdNumber);
            return result;
        }

        public static int GetGCD(out long timeInMilliseconds, Func<int, int, int> funcOfGCD, int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber == 0 && secondNumber == 0 && thirdNumber == 0)
                throw new ArgumentException();

            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = funcOfGCD(funcOfGCD(firstNumber, secondNumber), thirdNumber);
            timer.Stop();
            timeInMilliseconds = timer.ElapsedMilliseconds;
            return result;
        }

        public static int GetGCD(Func<int, int, int> funcOfGCD, params int[] setOfNumbers)
        {
            if (setOfNumbers == null)
                throw new ArgumentNullException();

            if (setOfNumbers.Length < 2)
                throw new ArgumentOutOfRangeException();

            if (setOfNumbers.All(x => x == 0))
                throw new ArgumentException();

            int result = setOfNumbers[0];
            for (int i = 1; i < setOfNumbers.Length; i++)
            {
                result = funcOfGCD(setOfNumbers[i], result);
            }
            return result;
        }

        public static int GetGCD(out long timeInMilliseconds, Func<int, int, int> funcOfGCD, params int[] setOfNumbers)
        {
            if (setOfNumbers == null)
                throw new ArgumentNullException();

            if (setOfNumbers.Length < 2)
                throw new ArgumentOutOfRangeException();

            if (setOfNumbers.All(x => x == 0))
                throw new ArgumentException();

            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = setOfNumbers[0];
            for (int i = 1; i < setOfNumbers.Length; i++)
            {
                result = funcOfGCD(setOfNumbers[i], result);
            }
            timer.Stop();
            timeInMilliseconds = timer.ElapsedMilliseconds;
            return result;
        }

        private static int GetEuclideanGCD(int a, int b)
        {
            int temp;
            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        private static int GetSteinGCD(int a, int b)
        {
            if (a == 0)
                return Math.Abs(b);

            if (b == 0)
                return Math.Abs(a);

            if (a == b)
                return Math.Abs(a);

            if (Math.Abs(a) == 1 || Math.Abs(b) == 1)
                return 1;

            if (a % 2 == 0)
            {
                if (b % 2 == 0)
                    return 2 * GetSteinGCD(a / 2, b / 2);
                else
                    return GetSteinGCD(a / 2, b);
            }
            else
            {
                if (b % 2 == 0)
                    return GetSteinGCD(a, b / 2);
                else
                    return GetSteinGCD(b, Math.Abs(a - b) / 2);
            }             
        }

        #endregion
    }
}
