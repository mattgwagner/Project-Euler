﻿using System.Linq;
using System.Numerics;

class Euler16 : ProjectEuler.EulerProblem
{
    public override object Solution()
    {
        return BigInteger.Pow(2, 1000).ToString().Sum(c => int.Parse(c.ToString()));
    }
}