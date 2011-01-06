using System.Collections.Generic;
using System.Linq;
using ProjectEuler;
using System.Numerics;
using System;

class Euler12 : EulerProblem
{
    public override object Solution()
    {
        foreach (BigInteger i in GetTriangleNumbers())
        {
            if (GetDivisors(i).Count() > 500) return i;
        }

        return -1;
    }

    IEnumerable<BigInteger> GetDivisors(BigInteger x)
    {
        for (int i = 1; i < (x / 2) + 1; i++)
        {
            if (x % i == 0) yield return i;
        }

        yield return x;
    }

    IEnumerable<BigInteger> GetTriangleNumbers()
    {
        int current = 10000000;
        BigInteger sum = 0;

        while (true)
        {
            yield return sum += current++;
        }
    }
}
