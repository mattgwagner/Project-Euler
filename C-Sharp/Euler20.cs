using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    class Euler20 : EulerProblem
    {
        public override object Solution()
        {
            return new BigInteger(100).Factorial().ToString().Sum(c => int.Parse(c.ToString()));
        }
    }
}
