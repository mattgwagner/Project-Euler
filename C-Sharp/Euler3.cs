using System;
using ProjectEuler;

public class Euler3 : EulerProblem
{
    public override object Solution()
    {
        long n = 600851475143;
        long i = 2;

        while (Math.Pow(i, 2) < n)
        {
            while (n % i == 0)
            {
                n = n / i;
            }

            i++;
        }

        return n;
    }
}
