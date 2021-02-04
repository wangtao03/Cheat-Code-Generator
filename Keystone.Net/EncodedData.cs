using System;
using System.Collections.Generic;
using System.Text;

namespace Keystone
{
    /// <summary>
    /// Defines an encoded instruction or group of instructions.
    /// </summary>
    public sealed class EncodedData
    {
        /// <summary>
        /// Constructs the encoded data.
        /// </summary>
        internal EncodedData(byte[] buffer, int statementCount, ulong address)
        {
            Buffer = buffer;
            Address = address;
            StatementCount = statementCount;
        }

        /// <summary>
        /// Gets the address of the first instruction for this operation.
        /// </summary>
        public ulong Address { get; }

        /// <summary>
        /// Gets the result of an assembly operation.
        /// </summary>
        public byte[] Buffer { get; }

        /// <summary>
        /// Gets the number of statements found.
        /// </summary>
        public int StatementCount { get; }

        /// <summary>
        /// Gets the Hex of an assembly operation
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public string ToString(string format)
        {
            var stringBuilder = new StringBuilder();

            foreach (var _byte in Buffer)
            {
                stringBuilder.Append(_byte.ToString(format));
            }

            return stringBuilder.ToString();
        }

        public int[] ToInt32()
        {
            var list = new List<int>();

            if (Buffer.Length % 4 == 0)
            {
                for (int i = 0; i < Buffer.Length; i += 4)
                {
                    list.Add(BitConverter.ToInt32(Buffer, i));
                }
            }
            return list.ToArray();
        }

        public uint[] ToUInt32()
        {
            var list = new List<uint>();

            if (Buffer.Length % 4 == 0)
            {
                for (int i = 0; i < Buffer.Length; i += 4)
                {
                    list.Add(BitConverter.ToUInt32(Buffer, i));
                }
            }
            return list.ToArray();
        }

        public string[] ToHex()
        {
            var list = new List<string>();
            if (Buffer.Length % 4 == 0)
            {
                for (int i = 0; i < Buffer.Length; i += 4)
                {
                    var tmp = BitConverter.ToUInt32(Buffer, i);
                    list.Add(tmp.ToString("X8"));
                }
            }
            return list.ToArray();
        }
    }
}