using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portforwarding.WinForm
{
    public static class StringHelper
    {
        public static string InsertSplitSymbol(string source, string splitSymbol, int splitLength)
        {
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(splitSymbol) || splitLength <= 0 || source.Length <= splitLength)
                return source;

            string result = string.Empty;

            for (int i = 0; i < source.Length; i += splitLength)
            {
                int subLength = i + splitLength <= source.Length ? splitLength : source.Length - i;

                if (i != 0)
                    result += splitSymbol;

                result += source.Substring(i, subLength);
            }

            return result;
        }

        public static string RemoveSplitSymbol(string source, string splitSymbol, int splitLength)
        {
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(splitSymbol) || splitLength <= 0 || source.Length <= splitLength)
                return source;

            string result = string.Empty;

            for (int i = 0; i < source.Length; i += (splitLength + splitSymbol.Length))
            {
                int subLength = i + splitLength <= source.Length ? splitLength : source.Length - i;

                result += source.Substring(i, subLength);
            }

            return result;
        }

        public static byte[] XStringToByteArray(string source, XType x)
        {
            string tempString = string.Empty; string splitSymbol = " ";

            string[] tempStrings; byte[] tempBytes;

            switch (x)
            {
                case XType.Bin:
                    tempString = InsertSplitSymbol(source, splitSymbol, 8);
                    break;
                case XType.Oct:
                    tempString = InsertSplitSymbol(source, splitSymbol, 3);
                    break;
                case XType.Dec:
                    tempString = InsertSplitSymbol(source, splitSymbol, 3);
                    break;
                case XType.Hex:
                    tempString = InsertSplitSymbol(source, splitSymbol, 2);
                    break;
                default:
                    break;
            }

            if (string.IsNullOrEmpty(tempString))
                return null;

            tempStrings = tempString.Split(new string[] { splitSymbol }, StringSplitOptions.None);

            tempBytes = new byte[tempStrings.Length];

            for (int i = 0; i < tempStrings.Length; i++)
            {
                tempBytes[i] = Convert.ToByte(tempStrings[i], (int)x);
            }

            return tempBytes;
        }

        public static string ByteArrayToXString(byte[] source, XType x)
        {
            StringBuilder sb = new StringBuilder();

            int n = (int)x, l = 0; string s = string.Empty;

            foreach (byte b in source)
            {
                s = Convert.ToString(b, n);

                switch (x)
                {
                    case XType.Bin:
                        l = 8 - s.Length;
                        break;
                    case XType.Oct:
                        l = 3 - s.Length;
                        break;
                    case XType.Dec:
                        l = 3 - s.Length;
                        break;
                    case XType.Hex:
                        l = 2 - s.Length;
                        break;
                    default:
                        break;
                }

                for (int i = 0; i < l; i++)
                {
                    s = "0" + s;
                }

                sb.Append(s);
            }

            return sb.ToString();
        }

    }
}
