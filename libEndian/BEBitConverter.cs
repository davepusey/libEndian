using System;

namespace libEndian
{
    public static class BEBitConverter
    {
        public static short ToInt16(byte[] value, int startIndex)
        {
            return BitConverter.ToInt16(Endianness.Conform(false, value, startIndex, 2), 0);
        }

        public static int ToInt32(byte[] value, int startIndex)
        {
            return BitConverter.ToInt32(Endianness.Conform(false, value, startIndex, 4), 0);
        }

        public static long ToInt64(byte[] value, int startIndex)
        {
            return BitConverter.ToInt64(Endianness.Conform(false, value, startIndex, 8), 0);
        }

        public static ushort ToUInt16(byte[] value, int startIndex)
        {
            return BitConverter.ToUInt16(Endianness.Conform(false, value, startIndex, 2), 0);
        }

        public static uint ToUInt32(byte[] value, int startIndex)
        {
            return BitConverter.ToUInt32(Endianness.Conform(false, value, startIndex, 4), 0);
        }

        public static ulong ToUInt64(byte[] value, int startIndex)
        {
            return BitConverter.ToUInt64(Endianness.Conform(false, value, startIndex, 8), 0);
        }
    }
}