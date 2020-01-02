using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str1 = "I speak Goat Latin";
                string goatstr1 = ToGoatLatin(str1);
                Console.WriteLine("Output 1:" + goatstr1);

                string str2 = "The quick brown fox jumped over the lazy dog";
                string goatstr2 = ToGoatLatin(str2);
                Console.WriteLine("Output 2:" + goatstr2);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
        public static string ToGoatLatin(string S)
        {

            string goat = "ma";
            string output = "";

            List<string> vowels = new List<string>();
            vowels.Add("a");
            vowels.Add("e");
            vowels.Add("i");
            vowels.Add("o");
            vowels.Add("u");

            string[] split = S.Split(' ');

            for (int i = 0; i < split.Length; i++)
            {
                goat += "a";
                string firstLetter = split[i][0].ToString();
                if (!vowels.Contains(firstLetter.ToLower()))
                {
                    split[i] = split[i].Remove(0, 1);
                    split[i] += firstLetter + goat;
                }
                else
                {
                    split[i] += goat;
                }

                output += split[i];
                if (i < split.Length - 1)
                {
                    output += " ";
                }

            }
            return output;
        }
    }
}

