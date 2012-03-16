using System;
using System.Linq;

namespace ProjectEuler
{
    public class Euler30 : EulerProblem
    {
        private const int MAX = 1000000;

        public override object Solution()
        {
            return Enumerable.Range(2, MAX).Where(n => n == n.ToString().Select(c => int.Parse(c.ToString())).Sum(i => Math.Pow(i, 5))).Sum();
        }
    }
}