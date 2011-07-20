using System;
using System.Collections.Generic;
using System.Numerics;
using ProjectEuler;

class Euler25 : EulerProblem
{
    public override object Solution()
    {
        int count = 0;

        foreach (var i in Fibonacci())
        {
            count++;

            if (i.ToString().Length == 1000)
            {
                return count;
            }
        }

        throw new NotFiniteNumberException("Uh oh");
    }

    IEnumerable<BigInteger> Fibonacci()
    {
        BigInteger curr = 1, prev = 1;

        yield return prev;
        yield return curr;

        while (true)
        {
            BigInteger tmp = curr;

            curr = (prev + curr);
            prev = tmp;

            yield return curr;
        }
    }
}
