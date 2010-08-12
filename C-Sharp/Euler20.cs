using System.Linq;
using System.Numerics;
using ProjectEuler;

class Euler20 : EulerProblem
{
    public override BigInteger solution()
    {
        return new BigInteger(100).factorial().ToString().Sum(c => int.Parse(c.ToString()));
    }
}
