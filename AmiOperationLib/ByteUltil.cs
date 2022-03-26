//-----< Class Name="ByteUtil.cs" copyrigth (C) SAO VIET GROUP >-------
// Author: Nguyen Tat Thanh
// Email: thanhnt@saovietgroup.com.vn
// Mobile: 098 664 8910
// Created date: Monday, June 15, 2015 9:27 AM
// -------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Text;

namespace AmiOperationLib
{
    public static class ByteUltil
    {
        /// <summary>
        /// Get byte from byte arry
        /// </summary>
        /// <param name="byteInput">Byte arry</param>
        /// <param name="startIndex">StartIndex</param>
        /// <param name="lastIndex">LastIndex</param>
        /// <returns></returns>
        public static byte[] GetBy(byte[] byteInput, int startIndex, int lastIndex)
        {
            byte[] temp = new byte[lastIndex - startIndex + 1];
            Array.Copy(byteInput, startIndex, temp, 0, lastIndex - startIndex + 1);
            return temp;
        }

        public static byte[] Combine(byte[] first, byte[] second)
        {
            int l = -1;
            if (first == null)
                l = 0;
            else
                l = first.Length;
            byte[] ret = new byte[l + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, l);
            Buffer.BlockCopy(second, 0, ret, l, second.Length);
            return ret;
        }

        public static byte[] Combine(params byte[][] arrays)
        {
            byte[] ret = new byte[arrays.Sum(x => x.Length)];
            int offset = 0;
            foreach (byte[] data in arrays)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            return ret;
        }

        /// <summary>
        /// Convert hex string to hex byte
        /// </summary>
        /// <param name="hex">hex string</param>
        /// <returns>hex byte</returns>
        public static byte[] HexStringToHexByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        /// <summary>
        /// Convert string to bytes
        /// </summary>
        /// <param name="inputString">inputString</param>
        /// <returns></returns>
        public static Byte[] ConvertStringToBytes(string inputString)
        {
            return Encoding.ASCII.GetBytes(inputString);
        }

    }
}
