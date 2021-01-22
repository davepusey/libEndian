using System.IO;
using System.Text;

namespace libEndian
{
    public class LEBinaryReader : BinaryReader
    {
        public LEBinaryReader(Stream input) : base(input)
        {
        }

        public LEBinaryReader(Stream input, Encoding encoding) : base(input, encoding)
        {
        }

        public LEBinaryReader(Stream input, Encoding encoding, bool leaveOpen) : base(input, encoding, leaveOpen)
        {
        }

        public override short ReadInt16()
        {
            return LEBitConverter.ToInt16(base.ReadBytes(2), 0);
        }

        public override int ReadInt32()
        {
            return LEBitConverter.ToInt32(base.ReadBytes(4), 0);
        }

        public override long ReadInt64()
        {
            return LEBitConverter.ToInt64(base.ReadBytes(8), 0);
        }

        public override ushort ReadUInt16()
        {
            return LEBitConverter.ToUInt16(base.ReadBytes(2), 0);
        }

        public override uint ReadUInt32()
        {
            return LEBitConverter.ToUInt32(base.ReadBytes(4), 0);
        }

        public override ulong ReadUInt64()
        {
            return LEBitConverter.ToUInt64(base.ReadBytes(8), 0);
        }
    }
}