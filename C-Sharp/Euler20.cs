using System.Linq;
using System.Numerics;

class Euler20 : ProjectEuler.EulerProblem
{
    public override BigInteger solution()
    {
        return factorial(100).ToString().Sum(c => int.Parse(c.ToString()));
    }
}
