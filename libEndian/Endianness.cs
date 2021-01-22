using System;

namespace libEndian
{
    internal class Endianness
    {
        internal static byte[] Conform(bool toLittleEndian, byte[] value, int startIndex, int length)
        {
            byte[] returnValue = new byte[length];

            Array.Copy(value, startIndex, returnValue, 0, length);

            if (BitConverter.IsLittleEndian ^ toLittleEndian)
            {
                Array.Reverse(returnValue);
            }

            return returnValue;
        }
    }
}