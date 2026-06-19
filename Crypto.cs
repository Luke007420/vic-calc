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
        public static void AffineEncrypt(string[] parts)
        {
            int a = int.Parse(parts[1]);
            int b = int.Parse(parts[2]);
            string text = string.Join(" ", parts, 3, parts.Length - 3);

            string result = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    int P = char.ToUpper(c) - 'A';
                    int encrypted = ((a * P + b) % 26 + 26) % 26;  // +26 handles negatives
                    char encryptedChar = (char)(encrypted + 'A');
                    result += encryptedChar;
                }
                // Ingores spaces and puncuation
            }
            Console.WriteLine(result);
        }
        public static void AffineDecrypt(string[] parts)
        {
            int a = int.Parse(parts[1]);
            int b = int.Parse(parts[2]);
            string text = string.Join(" ", parts, 3, parts.Length - 3);
            int aInverse = ModularInverse(a);
            Console.WriteLine($"Debug: aInverse = {aInverse}");
            string result = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    int P = char.ToUpper(c) - 'A';
                    int encrypted = ((aInverse * (P - b + 26)) % 26 + 26) % 26;  // +26 handles negatives
                    char encryptedChar = (char)(encrypted + 'A');
                    result += encryptedChar;
                }
                
            }
            Console.WriteLine(result);
        }
        private static int ModularInverse(int a)
        {
            for (int i = 1; i <= 26; i++)
            {
                if ((a * i) % 26 == 1)
                    return i;
            }
            throw new Exception("No modular inverse exists - 'a' must be coprime with 26");
        }
    }
}
