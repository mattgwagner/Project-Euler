using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using ProjectEuler;

public class Euler30 : EulerProblem
{
    private const int MAX = 1000000;

    public override object Solution()
    {
        return Enumerable.Range(2, MAX).Where(n => n == GetDigits(n).Sum(i => Math.Pow(i, 5))).Sum();
    }

    IEnumerable<int> GetDigits(int number)
    {
        return number.ToString().Select(c => int.Parse(c.ToString()));
    }
}