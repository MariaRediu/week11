using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    public class StringsReverse
    {
        public string ReverseString(string str)
        {
            if (str.Length.Equals(0))
            {
                throw new ArgumentException("Exception: Empty string: ");
            }
            char[] charArray = str.ToCharArray();

            Console.WriteLine("Input string: " + str);
            reverse(charArray);
            String revStr = new String(charArray);
            return revStr;
        }

        public static void reverse(char[] str)
        {
            int r = str.Length - 1;
            int l = 0;

            while (l < r)
            {
                if (!char.IsLetter(str[l]))
                    l++;
                else if (!char.IsLetter(str[r]))
                    r--;
                else
                {
                    Swap(ref str[r], ref str[l]);
                    l++;
                    r--;
                }
            }
        }

        static void Swap<T>(ref T left, ref T right)
        {
            T tmp;
            tmp = left;
            left = right;
            right = tmp;
        }

    }
