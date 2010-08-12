using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;
using System.Numerics;

class Euler48 : EulerProblem
{
    public override BigInteger solution()
    {
        string output = getPowers().sum().ToString();

        return BigInteger.Parse(output.Substring(output.Length - 10));
    }

    /// <summary>
    /// Have to do this because Enumerable.Range().Sum(i => Math.pow(i, i)) will overflow
    /// </summary>
    public IEnumerable<BigInteger> getPowers()
    {
        foreach (int i in Enumerable.Range(1, 1000))
        {
            yield return BigInteger.Pow(i, i);
        }
    }
}
