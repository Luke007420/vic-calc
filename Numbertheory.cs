using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathcalc
{
    internal class Numbertheory
    {
        public static void NumbPrime(int n)
        {
            bool isPrime = true;

            if (n < 2)
            {
                isPrime = false;

            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{n} Is a prime Number");

            }
            else
            {
                Console.WriteLine($"{n} Is not a prime number");
            }
        }
        public static void NumRand(int a, int X, int c, int m)
        {
            for (int i = 1; i <m; i++)
            {
                int result = (a * X + c) % m;
                Console.WriteLine($"Xi+{i} = ({a} * {X} + {c}) Mod {m} = {result}");
                X = result;
            }
            
        }
        public static void NumCheckDigit(string number)
        {
            // remove any dashes or spaces
            number = number.Replace("-", "").Replace(" ", "");

            if (number.Length == 12)
            {
                Console.WriteLine("This is a UPC Number");
                int sum = 0;
                for (int i = 0; i < 11; i++)  // only first 11 digits
                {
                    int digit = int.Parse(number[i].ToString());
                    if (i % 2 == 0)
                        sum += digit * 3;  // odd positions (0-indexed even) × 3
                    else
                        sum += digit * 1;  // even positions × 1
                }
                int checkDigit = (10 - (sum % 10)) % 10;
                Console.WriteLine($"Check digit: {checkDigit}");
                Console.WriteLine($"Full number: {number.Substring(0, 11)}{checkDigit}");
            }
            else if (number.Length == 13)
            {
                Console.WriteLine("This is a EAN - 13 Number");
                int sum = 0;
                for (int i = 0; i < 12; i++)  // only first 12 digits
                {
                    int digit = int.Parse(number[i].ToString());
                    if (i % 2 == 0)
                        sum += digit * 1;  
                    else
                        sum += digit * 3;  
                }
                int checkDigit = (10 - (sum % 10)) % 10;
                Console.WriteLine($"Check digit: {checkDigit}");
                Console.WriteLine($"Full number: {number.Substring(0, 12)}{checkDigit}");
            }
            else if (number.Length == 10)
            {
                Console.WriteLine("This is a ISBN - 10 Number");
                int sum = 0;
                for ( int i = 0;i < 9; i++) // first 9 digits only
                {
                    int digit = int.Parse(number[i].ToString());
                    sum += digit * (i + 1);
                }
                int checkDigit = sum % 11;
                string checkChar = checkDigit == 10 ? "X" : checkDigit.ToString();
                Console.WriteLine($"Check digit: {checkChar}");
                Console.WriteLine($"Full number: {number.Substring(0, 9)}{checkChar}");
            }
            else
            {
                Console.WriteLine("Unknown barcode format");
            }
        }
    }
}
