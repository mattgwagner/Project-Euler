using System;

namespace ProjectEuler
{
    public class Euler9 : EulerProblem
    {
        public override object Solution()
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = (a + 1); b < 1000; b++)
                {
                    Double c = Math.Sqrt((a * a) + (b * b));

                    if (a < b && b < c && (a + b + c) == 1000)
                    {
                        return (a * b * c);
                    }
                }
            }

            throw new NotFiniteNumberException("Uh oh");
        }
    }
}