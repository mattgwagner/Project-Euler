using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler
{
    /// <summary>
    /// Base class for implementing solutions to problems, allows easy use of reflection
    /// </summary>
    public abstract class EulerProblem
    {
        public abstract object Solution();

        // borrowed from http://digitalbush.com/2010/02/26/sieve-of-eratosthenes-in-csharp/
        protected static IEnumerable<int> FindPrimesUpToMax(int max)
        {
            var vals = new List<int>((int)(max / (Math.Log(max) - 1.08366)));
            var maxSquareRoot = Math.Sqrt(max);
            var eliminated = new BitArray(max + 1);

            vals.Add(2);

            for (int i = 3; i <= max; i += 2)
            {
                if (!eliminated[i])
                {
                    if (i < maxSquareRoot)
                    {
                        for (int j = i * i; j <= max; j += 2 * i)
                            eliminated[j] = true;
                    }

                    vals.Add(i);
                }
            }

            return vals;
        }
    }
}