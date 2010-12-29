using System.Numerics;
using ProjectEuler;

class Euler10 : EulerProblem
{
    public override object Solution()
    {
        BigInteger bi = new BigInteger();

        foreach (var i in FindPrimesUpToMax(2000000))
        {
            bi += i;
        }

        return bi;
    }
}
