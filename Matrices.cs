using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathcalc
{
    internal class Matrices
    {
        // Dictionary to store matrices by name e.g. "a" -> [1, 2, 3, 4]
        private static Dictionary<string, double[]> matrices = new Dictionary<string, double[]>();

        public static void CreateMatrix(string[] parts)
        {
            // Get the name of the matrix from the command e.g. "mat a (1 2 3 4)" -> "a"
            string name = parts[1];

            // Parse the 4 numbers, stripping the brackets from the first and last values
            double a = double.Parse(parts[2].Replace("(", ""));
            double b = double.Parse(parts[3]);
            double c = double.Parse(parts[4]);
            double d = double.Parse(parts[5].Replace(")", ""));

            // Store as a flat array [a, b, c, d] representing:
            // | a  b |
            // | c  d |
            matrices[name] = new double[] { a, b, c, d };

            // Print the matrix in a readable format
            Console.WriteLine($"Matrix {name} created: | {a} {b} |");
            Console.WriteLine($"                  | {c} {d} |");
        }
        public static void AddMatrix(string[] parts)
        {
            // get the names of the two matricies you want to add
            string nameA = parts[1];
            string nameB = parts[2];
            //look up in dictionary
            double[] a = matrices[nameA];
            double[] b = matrices[nameB];

            //add matrices together
            double[] result = new double[]
            {
                a[0] + b[0], //top left
                a[1] + b[1], //top right
                a[2] + b[2], //bottom left
                a[3] + b[3], // bottom right
            };

            Console.WriteLine($"| {result[0]} {result[1]} |");
            Console.WriteLine($"| {result[2]} {result[3]} |");
        }
    }
}
