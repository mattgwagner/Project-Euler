using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    class Euler16 : EulerProblem
    {
        public override object Solution()
        {
            return BigInteger.Pow(2, 1000).ToString().Sum(c => int.Parse(c.ToString()));
        }
    }
}