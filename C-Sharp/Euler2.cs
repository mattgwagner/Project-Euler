using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class Euler2 : ProjectEuler.EulerProblem
{
    public override BigInteger solution()
    {
        int current = 2;
        int previous = 1;
        int tmp = -1;

        int sum = 2; //starts @ 2 to accomidate current

        while (current < 4000000)
        {
            tmp = current;
            current = previous + current;
            previous = tmp;

            if (current % 2 == 0)
            {
                sum += current;
            }
        }

        return sum;
    }
}
