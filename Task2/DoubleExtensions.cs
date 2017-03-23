using System;
using System.Text;

namespace Task2
{
    public static class DoubleExtensions
    {
        public static string RepresentInBinary(this double value)
        {
            if (value == double.Epsilon)
                return "0001";
            else
                return GetBinaryRepresentation(value);
        }

        #region Private methods
        private static string GetBinaryRepresentation(double value)
        {
            StringBuilder result = new StringBuilder();
            long valueBits = BitConverter.DoubleToInt64Bits(value);
            result.Append(Convert.ToString(((valueBits >> 63) == 0 ? 0 : 1), 2));
            long exponent = (valueBits >> 52) & 0x7FF;
            result.Append(Convert.ToString(exponent, 2));
            result.Append(Convert.ToString(exponent != 0
                ? ((valueBits & 0xFFFFFFFFFFFFF) | 0x10000000000000)
                : ((valueBits & 0x10000000000000) << 1)
                , 2)
                , 1, 52);
            return result.ToString();
        }
        #endregion
    }
}
