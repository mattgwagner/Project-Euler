using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    // Find the maximum total from top to bottom of the triangle below:
    public class Euler18 : EulerProblem
    {
        private const String FILENAME = "Euler18.txt";

        internal static int[,] Values = new int[15, 15];

        public override object Solution()
        {
            ReadFile();

            throw new NotImplementedException("Work in progress!");
        }

        void ReadFile()
        {
            using (var rdr = new StreamReader(FILENAME))
            {
                for (int row = 0; row < 15; row++)
                {
                    var line = rdr.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();

                    for (int col = 0; col < line.Length; col++)
                    {
                        Values[row, col] = line[col];
                    }
                }
            }
        }
    }
}
