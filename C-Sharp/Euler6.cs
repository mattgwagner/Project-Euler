using System.Linq;
using System.Numerics;

class Euler6 : ProjectEuler.EulerProblem
{
    public override object Solution()
    {
        BigInteger sqOfSums = BigInteger.Pow(Enumerable.Range(1, 100).Sum(), 2);
        BigInteger sumOfSqs = Enumerable.Range(1, 100).Sum(i => i * i);

        return sqOfSums - sumOfSqs;
    }
}
