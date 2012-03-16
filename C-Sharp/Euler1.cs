using System.Linq;

namespace ProjectEuler
{
    class Euler1 : EulerProblem
    {
        public override object Solution()
        {
            return Enumerable.Range(1, 999).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        }
    }
}
