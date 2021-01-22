using System.IO;
using System.Text;

namespace libEndian
{
    public class BEBinaryReader : BinaryReader
    {
        public BEBinaryReader(Stream input) : base(input)
        {
        }

        public BEBinaryReader(Stream input, Encoding encoding) : base(input, encoding)
        {
        }

        public BEBinaryReader(Stream input, Encoding encoding, bool leaveOpen) : base(input, encoding, leaveOpen)
        {
        }

        public override short ReadInt16()
        {
            return BEBitConverter.ToInt16(base.ReadBytes(2), 0);
        }

        public override int ReadInt32()
        {
            return BEBitConverter.ToInt32(base.ReadBytes(4), 0);
        }

        public override long ReadInt64()
        {
            return BEBitConverter.ToInt64(base.ReadBytes(8), 0);
        }

        public override ushort ReadUInt16()
        {
            return BEBitConverter.ToUInt16(base.ReadBytes(2), 0);
        }

        public override uint ReadUInt32()
        {
            return BEBitConverter.ToUInt32(base.ReadBytes(4), 0);
        }

        public override ulong ReadUInt64()
        {
            return BEBitConverter.ToUInt64(base.ReadBytes(8), 0);
        }
    }
}