using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathcalc
{
    internal class Crypto
    {
        public static void CaesarEncrypt(string[] parts)
        {
            string text = string.Join(" ", parts, 1, parts.Length - 1);
            string result = "";
            foreach (char c in text)
            {
                
                if (char.IsUpper(c))
                {
                    char shifted = (char)(((c - 'A' + 3) % 26) + 'A');
                    result += shifted;
                }
                else if (char.IsLower(c))
                {
                    char shifted = (char)(((c - 'a' + 3) % 26) + 'a');
                    result += shifted;
                }
                else
                {
                    result += c;
                }
                
            }
            Console.WriteLine(result);


        }

        public static void CaesarDecrypt(string[] parts)
        {
            string text = string.Join(" ", parts, 1, parts.Length - 1);
            string result = "";
            foreach (char c in text)
            {

                if (char.IsUpper(c))
                {
                    char shifted = (char)(((c - 'A' - 3 + 26) % 26) + 'A');
                    result += shifted;
                }
                else if (char.IsLower(c))
                {
                    char shifted = (char)(((c - 'a' - 3 + 26) % 26) + 'a');
                    result += shifted;
                }
                else
                {
                    result += c;
                }

            }
            Console.WriteLine(result);
        }
    }
}
