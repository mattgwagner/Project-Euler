using System.Linq;
using System.Numerics;

class Euler1 : ProjectEuler.EulerProblem
{
    public override BigInteger solution()
    {
        return Enumerable.Range(1, 999).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
    }
}
