using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProjectEuler;

public class Euler11 : EulerProblem
{
    private int[,] nums = new int[20, 20];

    public override object Solution()
    {
        ReadNumbers();

        return new int[] { LargestHorizontally(), LargestVertically(), LargestDiagonallyRight(), LargestDiagonallyLeft() }.Max();
    }

    protected int LargestHorizontally()
    {
        int largest = 0;

        Queue<int> q = new Queue<int>(5);

        for (int y = 0; y < 20; y++)
        {
            for (int x = 0; x < 20; x++)
            {
                while (q.Count > 3) q.Dequeue();

                q.Enqueue(nums[y, x]);

                if (q.Product() > largest) largest = q.Product();
            }
        }

        return largest;
    }

    protected int LargestVertically()
    {
        int largest = 0;

        Queue<int> q = new Queue<int>(5);

        for (int x = 0; x < 20; x++)
        {
            for (int y = 0; y < 20; y++)
            {
                while (q.Count > 3) q.Dequeue();

                q.Enqueue(nums[y, x]);

                if (q.Product() > largest) largest = q.Product();
            }
        }

        return largest;
    }

    protected int LargestDiagonallyRight()
    {
        int largest = 0;

        for (int xStart = 0; xStart <= 15; xStart++)
        {
            for (int yStart = 0; yStart <= 15; yStart++)
            {

            }
        }
        
        return largest;
    }

    protected int LargestDiagonallyLeft()
    {
        int largest = 0;

        // TODO

        return largest;
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
