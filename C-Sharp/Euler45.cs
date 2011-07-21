using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using ProjectEuler;

/* Find the next triangle number that is also pentagonal and hexagonal. */
public class Euler45 : EulerProblem
{
    const int MAX = 100000;

    public override object Solution()
    {
        return GetTriangles().Intersect(GetPentagonals()).Intersect(GetHexagonals()).FirstOrDefault();
    }

    IEnumerable<BigInteger> GetTriangles()
    {
        foreach (BigInteger bi in Enumerable.Range(286, MAX))
        {
            yield return bi * (bi + 1) / 2;
        }
    }

    IEnumerable<BigInteger> GetPentagonals()
    {
        foreach (BigInteger bi in Enumerable.Range(144, MAX))
        {
            yield return bi * (3 * bi - 1) / 2;
        }
    }

    IEnumerable<BigInteger> GetHexagonals()
    {
        foreach (BigInteger bi in Enumerable.Range(166, MAX))
        {
            yield return bi * (2 * bi - 1);
        }
    }
}
