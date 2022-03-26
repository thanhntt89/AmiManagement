//-----< Class Name="ConvertUtil.cs" copyrigth (C) SAO VIET GROUP >-------
// Author: Nguyen Tat Thanh
// Email: thanhnt@saovietgroup.com.vn
// Mobile: 098 664 8910
// Created date: Monday, June 15, 2015 9:27 AM
// -------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using AmiOperationLib;

namespace AmiOperationLib
{
    public static class ConvertUtil
    {      

        public static byte[] AsnEncode(string tagCodeHex, string valueHex, int countByteValue = -1)
        {
            byte[] buff = null;

            byte[] value = null;
            value = ByteUltil.Combine(HexStringToHexByteArray(valueHex));

            if (countByteValue != -1)
            {
                byte[] temp = new byte[countByteValue - value.Length];
                value = ByteUltil.Combine(temp, value);
            }

            buff = ByteUltil.Combine(HexStringToHexByteArray(tagCodeHex));
            buff = ByteUltil.Combine(buff, HexStringToHexByteArray(value.Length.ToString().PadLeft(2, '0')));
            buff = ByteUltil.Combine(buff, value);

            return buff;
        }


        /// <summary>
        /// Convert hex string to hex byte
        /// </summary>
        /// <param name="hex">hex string</param>
        /// <returns>hex byte</returns>
        public static byte[] HexStringToHexByteArray(string hex)
        {
            int lengt = hex.Length;
            if (lengt % 2 != 0)
                hex = hex.PadLeft(lengt + 1, '0');

            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public static byte[] FromHexStringToDecimalByteArray(string hex)
        {
            int lengt = hex.Length;
            if (lengt % 2 != 0)
                hex = hex.PadLeft(lengt + 1, '0');

            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 10))
                             .ToArray();
        }

        /// <summary>
        /// Convert byte to object
        /// </summary>
        /// <param name="arrBytes"></param>
        /// <returns></returns>
        public static object ConvertObjectToClass(byte[] arrBytes)
        {
            if (arrBytes == null)
                return null;
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            //binForm.Binder = new AllowAllAssemblyVersionsDeserializationBinder();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            object obj = binForm.Deserialize(memStream);
            return obj;
        }

        /// <summary>
        /// Convert number to byte 
        /// </summary>
        /// <param name="valueInput">valueInput</param>
        /// <param name="byteCount">number of byte need</param>
        /// <returns></returns>
        public static byte[] ConvertForEachCharacterInStringToByte(string valueInput, int byteCount)
        {
            if (valueInput.Contains('.'))
            {
                valueInput = valueInput.Replace(".", string.Empty);
            }

            byte[] data = ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(int.Parse(valueInput)));

            byte[] temp = null;
            if (byteCount > data.Length)
                temp = new byte[byteCount - data.Length];

            temp = ByteUltil.Combine(temp, data);
            return temp.Reverse().ToArray();
        }

        /// <summary>
        /// Chuyển đổi từ HEX 16 sang hệ 10 max length 12
        /// </summary>
        /// <param name="hex16String">hex16String</param>
        /// <returns>decimal value</returns>
        public static decimal? ConvertHex16Todecimal(string hex16String)
        {
            if (string.IsNullOrEmpty(hex16String))
                return null;
            return Convert.ToInt64(hex16String, 16);
        }

        /// <summary>
        /// Chuyển đổi từ HEX 16 sang hệ 10 max length 12
        /// </summary>
        /// <param name="hex16String">hex16String</param>
        /// <returns>decimal value</returns>
        public static decimal ConvertHexToDecimal(string hex16String)
        {
            if (string.IsNullOrEmpty(hex16String))
                return 0;
            return Convert.ToInt64(hex16String, 16);
        }

        public static string StringToHex(string hexstring)
        {
            var sb = new StringBuilder();
            foreach (char t in hexstring)
                sb.Append(Convert.ToInt32(t).ToString("x") + " ");
            return sb.ToString();
        }

        /// <summary>
        /// Convert Hex 16 to decimal string 07DE về 2014
        /// </summary>
        /// <param name="hex16String">Hex string</param>
        /// <returns>decimal string</returns>
        public static string ConvertHexToDecimalString(string hex16String)
        {
            return Convert.ToInt64(hex16String, 16).ToString();
        }

        /// <summary>
        /// Convert hex format string 3x3y3z to xyz
        /// </summary>
        /// <param name="asciiString">3x3y3z</param>
        /// <returns>xyz</returns>
        public static string HexaDecimalToHexString(string asciiString)
        {
            string StrValue = "";
            asciiString = asciiString.PadLeft(32, '0');
            while (asciiString.Length > 0)
            {
                StrValue += System.Convert.ToChar(System.Convert.ToInt32(asciiString.Substring(0, 2), 16)).ToString();
                asciiString = asciiString.Substring(2, asciiString.Length - 2);
            }
            StrValue = StrValue.Trim(new Char[] { '\0', '\b' });
            return StrValue;
        }


        /// <summary>
        /// Convert hex format string 3x3y3z to xyz
        /// </summary>
        /// <param name="asciiString">3x3y3z</param>
        /// <returns>xyz</returns>
        public static decimal HexaDecimalToDecimal(string asciiString)
        {
            string StrValue = HexaDecimalToHexString(asciiString);
            decimal valueout = -1;

            if (!decimal.TryParse(StrValue, out valueout))
            {
                valueout = 0;
            }
            return valueout;
        }

        public static decimal? HexaDecimalToIsDecimal(string asciiString)
        {
            string StrValue = HexaDecimalToHexString(asciiString);
            decimal valueout = -1;

            if (!decimal.TryParse(StrValue, out valueout))
            {
                valueout = 0;
            }
            return valueout;
        }

        public static string IntToHex(int value)
        {
            return String.Format("{0:X}", value).PadLeft(2, '0');
        }

        public static string ToHexString(string stringInput)
        {
            if (string.IsNullOrEmpty(stringInput))
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (char c in stringInput)
                    sb.AppendFormat("{0:X2}", (int)c);
                return sb.ToString().Replace(" ", "");
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string ToHexStringToString(byte[] message)
        {
            string temp = null;
            try
            {
                foreach (byte item in message)
                {
                    byte[] a = new byte[1];
                    a[0] = item;
                    if (item > 32 && item < 125 || item == 20)
                    {
                        temp += Encoding.ASCII.GetString(a);
                    }
                    else
                    {
                        temp += ConvertUtil.BytesToHexString(a);
                    }
                }
            }
            catch (Exception ex) { return null; }
            return temp;
        }

        /// <summary>
        /// Convert byte to hex string
        /// </summary>
        /// <param name="source">source</param>
        /// <returns>HEX string</returns>
        public static string BytesToHexString(byte[] source)
        {
            if (source == null || source.Length == 0)
                return null;
            try
            {
                string hex = BitConverter.ToString(source);
                return hex.Replace("-", "");
            }
            catch
            {
                return null;
            }
        }
     
        public static DateTime? convertMeterTimeElster(string hexString)
        {
            //yy-mm-dd -w - HH-MM-ss 
            try
            {
                int year = 2000 + int.Parse(hexString.Substring(0, 4));
                int mm = int.Parse(hexString.Substring(4, 2));
                int dd = int.Parse(hexString.Substring(6, 2));

                int hh = int.Parse(hexString.Substring(8, 2));
                int min = int.Parse(hexString.Substring(10, 2));
                int sc = int.Parse(hexString.Substring(12, 2));

                DateTime date = new DateTime(year, mm, dd, hh, min, sc);
                return date;
            }
            catch
            {
                return null;
            }
        }

        public static DateTime? convertDateTime(string hexString)
        {
            // yy-mm-dd -HH:MM:ss
            try
            {
                int year = 2000 + (int)ConvertUtil.ConvertHexToDecimal(hexString.Substring(0, 2));
                int mm = (int)ConvertUtil.ConvertHexToDecimal(hexString.Substring(2, 2));
                int dd = (int)ConvertUtil.ConvertHexToDecimal(hexString.Substring(4, 2));

                int hh = (int)ConvertUtil.ConvertHexToDecimal(hexString.Substring(6, 2));
                int min = (int)ConvertUtil.ConvertHexToDecimal(hexString.Substring(8, 2));
                int sc = (int)ConvertUtil.ConvertHexToDecimal(hexString.Substring(10, 2));

                DateTime date = new DateTime(year, mm, dd, hh, min, sc);
                return date;
            }
            catch
            {
                return null;
            }
        }

        public static DateTime? convertMeterTimeGelex(string hexString)
        {
            //yy-mm-dd -w - HH-MM-ss 
            try
            {
                int year = int.Parse(ConvertUtil.ConvertHexToDecimalString(hexString.Substring(0, 4)));
                int mm = int.Parse(ConvertUtil.ConvertHexToDecimalString(hexString.Substring(4, 2)));
                int dd = int.Parse(ConvertUtil.ConvertHexToDecimalString(hexString.Substring(6, 2)));

                int hh = int.Parse(ConvertUtil.ConvertHexToDecimalString(hexString.Substring(10, 2)));
                int min = int.Parse(ConvertUtil.ConvertHexToDecimalString(hexString.Substring(12, 2)));
                int sc = int.Parse(ConvertUtil.ConvertHexToDecimalString(hexString.Substring(14, 2)));

                DateTime date = new DateTime(year, mm, dd, hh, min, sc);
                return date;
            }
            catch
            {
                return null;
            }
        }

        public static DateTime? convertMeterTimeStar(string hexString)
        {
            //yy-mm-dd -w - HH-MM-ss 
            try
            {
                int year = 2000 + int.Parse(hexString.Substring(0, 2));
                int mm = int.Parse(hexString.Substring(2, 2));
                int dd = int.Parse(hexString.Substring(4, 2));

                int hh = int.Parse(hexString.Substring(8, 2));
                int min = int.Parse(hexString.Substring(10, 2));
                int sc = int.Parse(hexString.Substring(12, 2));

                DateTime date = new DateTime(year, mm, dd, hh, min, sc);
                return date;
            }
            catch
            {
                return null;
            }
        }

        public static DateTime? convertMeterTimeLandis(string hexString)
        {
            //yy-mm-dd -w - HH-MM-ss 
            try
            {
                int year = int.Parse(ConvertUtil.ConvertHexToDecimalString(hexString.Substring(0, 4)));
                int mm = int.Parse(ConvertUtil.ConvertHexToDecimalString(hexString.Substring(4, 2)));
                int dd = int.Parse(ConvertUtil.ConvertHexToDecimalString(hexString.Substring(6, 2)));

                int hh = int.Parse(ConvertUtil.ConvertHexToDecimalString(hexString.Substring(10, 2)));
                int min = int.Parse(ConvertUtil.ConvertHexToDecimalString(hexString.Substring(12, 2)));
                int sc = int.Parse(ConvertUtil.ConvertHexToDecimalString(hexString.Substring(14, 2)));

                DateTime date = new DateTime(year, mm, dd, hh, min, sc);
                return date;
            }
            catch
            {
                return null;
            }
        }
    }
}
