using System.Linq;

class Euler5 : ProjectEuler.EulerProblem
{
    public override object Solution()
    {
        int current = 20;

        while (!Enumerable.Range(1, 20).All(i => current % i == 0))
        {
            current += 20;
        }

        return current;
    }
}
