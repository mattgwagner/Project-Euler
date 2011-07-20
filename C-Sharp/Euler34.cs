using System;
using System.Linq;
using System.Numerics;
using ProjectEuler;

class Euler34 : EulerProblem
{
    public override object Solution()
    {
        return Enumerable.Range(3, 100000).Where(s => Check(s)).Sum();
    }

    Boolean Check(BigInteger bi)
    {
        BigInteger sum = 0;

        foreach (var c in bi.ToString())
        {
            sum += BigInteger.Parse(c + "").Factorial();
        }

        return bi == sum;
    }
}
