

using System.Diagnostics;

namespace mathcalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mathmatics Calculator: Type 'help' for commands");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(input))
                {
                    parseCommand(input);
                }
            }

            
            
        }
        public static void parseCommand(string input)
        {
            string[] parts = input.Split(' ');
            string command = parts[0].ToLower();
            

            if (command == "help")
            {
                Console.WriteLine("-- Lines --");
                Console.WriteLine("Line a (x1 y1 x2 y2)       - Create a line named a");
                Console.WriteLine("lengthLine a                - Calculate the length of line a");
                Console.WriteLine("midpointLine a              - Calculate the midpoint of line a");
                Console.WriteLine("gradientLine a              - Calculate the gradient of line a");
                Console.WriteLine("rad2Deg a                   - Convert a from radians to degrees");
                Console.WriteLine("deg2Rad a                   - Convert a from degrees to radians");
                Console.WriteLine("");
                Console.WriteLine("-- Vectors --");
                Console.WriteLine("vec a (x y)                 - Create a vector named a");
                Console.WriteLine("addVec a b                  - Add vectors a and b");
                Console.WriteLine("subVec a b                  - Subtract vector a from b");
                Console.WriteLine("dotVec a b                  - Dot product of vectors a and b");
                Console.WriteLine("scalVec s a                 - Apply scalar s to vector a");
                Console.WriteLine("");
                Console.WriteLine("-- Matrices --");
                Console.WriteLine("mat a (a b c d)             - Create a 2x2 matrix named a");
                Console.WriteLine("addMat a b                  - Add matrices a and b");
                Console.WriteLine("dotMat a b                  - Dot product of matrices a and b");
                Console.WriteLine("scalMat s a                 - Apply scalar s to matrix a");
                Console.WriteLine("detMat a                    - Calculate the determinant of matrix a");
                Console.WriteLine("invMat a                    - Calculate the inverse of matrix a");
                Console.WriteLine("");
                Console.WriteLine("-- Number Theory --");
                Console.WriteLine("numPrime a                  - Check if a (less than 10000) is prime");
                Console.WriteLine("numCheckDigit [string]      - Identify code type and calculate check digit");
                Console.WriteLine("numRand a X c m             - Generate random number using Linear Congruential Method");
                Console.WriteLine("");
                Console.WriteLine("-- Cryptography --");
                Console.WriteLine("caesarEn \"text\"             - Encode text using Caesar cipher (n+3) mod 26");
                Console.WriteLine("caesarDe \"text\"             - Decode text using Caesar cipher (n-3) mod 26");
                Console.WriteLine("affineEn a b \"text\"         - Encrypt text using Affine cipher (aP+b) mod 26");
                Console.WriteLine("affineDe a b \"text\"         - Decrypt text using Affine cipher (aP-b) mod 26");
                Console.WriteLine("bruteAffine a b \"text\"      - Brute force decrypt using Affine cipher");
            }
            else if (command == "caesaren")
            {
                Crypto.CaesarEncrypt(parts);
            }
            else if (command == "caesarde")
            {
                Crypto.CaesarDecrypt(parts);
            }
            else if (command == "affineen")
            {
                Crypto.AffineEncrypt(parts);
            }
            else if (command == "affinede")
            {
                Crypto.AffineDecrypt(parts);
            }
            else if (command == "bruteAffine")
            {
                Crypto.BruteAffine(parts);
            }
            else if (command == "numprime")
            {
                Numbertheory.NumbPrime(int.Parse(parts[1]));
            }
            else if (command == "numrand")
            {
                Numbertheory.NumRand(
                    int.Parse(parts[1]),
                    int.Parse(parts[2]),
                    int.Parse(parts[3]),
                    int.Parse(parts[4])
                );
            }
            else if (command == "numcheckdigit")
            {
                Numbertheory.NumCheckDigit(parts[1]);
            }
            else
            {
                Console.WriteLine("Unknown command type 'help' for commands ");
            }
        }
        

    }
}
