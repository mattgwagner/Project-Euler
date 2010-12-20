using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;
using System.Numerics;

class Euler53 : EulerProblem
{
    int count = 0;

    public override object Solution()
    {
        for (int n = 1; n <= 100; n++)
        {
            for (int r = 1; r <= n; r++)
            {
                if (Evaluate(n, r) > 1000000) count++;
            }
        }

        return count;
    }

    protected BigInteger Evaluate(BigInteger n, BigInteger r)
    {
        return n.Factorial() / (r.Factorial() * (n - r).Factorial());
    }
}
