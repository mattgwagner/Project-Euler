﻿using System.Linq;

namespace ProjectEuler
{
    class Euler5 : EulerProblem
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
}
