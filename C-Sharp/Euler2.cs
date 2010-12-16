using System.Collections.Generic;
using System.Linq;

class Euler2 : ProjectEuler.EulerProblem
{
    const int MAX = 4000000;

    public override object Solution()
    {
        return getEvenFibonaciTo4Million().Sum();
    }

    public IEnumerable<int> getEvenFibonaciTo4Million()
    {
        int tmp = -1;
        int current = 1;
        int previous = 0;

        while (current < MAX)
        {
            tmp = current;
            current = previous + current;
            previous = tmp;

            if (current % 2 == 0)
            {
                yield return current;
            }
        }
    }
}
