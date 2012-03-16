using System.Collections.Generic;
using System.Linq;
using System.Numerics;

/* Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000. */
namespace ProjectEuler
{
    class Euler48 : EulerProblem
    {
        public override object Solution()
        {
            string output = getPowers().Sum().ToString();

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
}
