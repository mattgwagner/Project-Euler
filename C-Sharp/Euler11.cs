using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler
{
    public class Euler11 : EulerProblem
    {
        private int[,] nums = new int[20, 20];

        public override object Solution()
        {
            ReadNumbers();

            return new[] { LargestHorizontally(), LargestVertically(), LargestDiagonallyRight(), LargestDiagonallyLeft() }.SelectMany(x => x).Max();
        }

        protected IEnumerable<int> LargestHorizontally()
        {
            for (int y = 0; y <= 19; y++)
            {
                for (int x = 0; x <= 16; x++)
                {
                    int product = new int[]
                                      {
                                          nums[x, y],
                                          nums[x+1, y],
                                          nums[x+2, y],
                                          nums[x+3, y]
                                      }.Product();

                    yield return product;
                }
            }
        }

        protected IEnumerable<int> LargestVertically()
        {
            for (int x = 0; x <= 19; x++)
            {
                for (int y = 0; y <= 16; y++)
                {
                    int product = new int[]
                                      {
                                          nums[x, y],
                                          nums[x, y+1],
                                          nums[x, y+2],
                                          nums[x, y+3]

                                      }.Product();

                    yield return product;
                }
            }
        }

        protected IEnumerable<int> LargestDiagonallyRight()
        {
            for (int xStart = 0; xStart <= 16; xStart++)
            {
                for (int yStart = 0; yStart <= 16; yStart++)
                {
                    int product = new int[] 
                                      { 
                                          nums[xStart, yStart],
                                          nums[xStart+1, yStart+1],
                                          nums[xStart+2, yStart+2],
                                          nums[xStart+3, yStart+3],
                                      }.Product();

                    yield return product;
                }
            }
        }

        protected IEnumerable<int> LargestDiagonallyLeft()
        {
            for (int xStart = 0; xStart <= 16; xStart++)
            {
                for (int yStart = 0; yStart <= 16; yStart++)
                {
                    int product = new int[] 
                                      { 
                                          nums[xStart+3, yStart],
                                          nums[xStart+2, yStart+1],
                                          nums[xStart+1, yStart+2],
                                          nums[xStart, yStart+3],
                                      }.Product();

                    yield return product;
                }
            }
        }

        protected void ReadNumbers()
        {
            int currentRow = 0;

            using (StreamReader rdr = new StreamReader("Euler11.txt"))
            {
                string line = string.Empty;

                while (!string.IsNullOrWhiteSpace(line = rdr.ReadLine()))
                {
                    var digits = line.Split(' ').ToList();

                    int currentColumn = 0;

                    foreach (var digit in digits)
                    {
                        nums[currentRow, currentColumn] = int.Parse(digit);

                        currentColumn++;
                    }

                    currentRow++;
                }
            }
        }
    }
}
