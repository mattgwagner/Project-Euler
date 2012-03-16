using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using ProjectEuler;

public class Euler30 : EulerProblem
{
    private const int MAX = 100000;

    public override object Solution()
    {
        BigInteger sum = 0;

        foreach (var current in Enumerable.Range(2, MAX))
        {
            if (current == GetDigits(current).Sum(n => Math.Pow(n, 5)))
            {
                sum += current;
            }
        }

        return sum;
    }

    IEnumerable<int> GetDigits(int number)
    {
        foreach (var c in number.ToString())
        {
            yield return int.Parse(c.ToString());
        }
    }
}