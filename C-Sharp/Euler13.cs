using System.Collections.Generic;
using System.IO;
using System.Numerics;
using ProjectEuler;

class Euler13 : EulerProblem
{
    public override object Solution()
    {
        return GetNumbers().Sum().ToString().Substring(0, 10);
    }

    protected IEnumerable<BigInteger> GetNumbers()
    {
        string str;

        using (StreamReader rdr = new StreamReader("Euler13.txt"))
        {
            while ((str = rdr.ReadLine()) != null)
            {
                yield return BigInteger.Parse(str);
            }
        }
    }
}
