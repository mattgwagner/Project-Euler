using System.Numerics;
using ProjectEuler;

/* Considering natural numbers of the form, a^b, where a, b  100, what is the maximum digital sum? */
class Euler56 : EulerProblem
{
    public override object Solution()
    {
        BigInteger max = 0;

        for (int a = 1; a < 100; a++)
        {
            for (int b = 1; b < 100; b++)
            {
                var sum = GetDigitalSum(a, b);

                if (sum > max) max = sum;
            }
        }

        return max;
    }

    BigInteger GetDigitalSum(int a, int b)
    {
        BigInteger sum = 0;

        foreach (var c in BigInteger.Pow(a, b).ToString())
        {
            sum += int.Parse(c + "");
        }

        return sum;
    }
}
