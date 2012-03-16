using System;
using System.Collections.Generic;
using System.Linq;

/*
    If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.

    {20,48,52}, {24,45,51}, {30,40,50}

    For which value of p <= 1000, is the number of solutions maximised?
*/
namespace ProjectEuler
{
    public class Euler39 : EulerProblem
    {
        public override object Solution()
        {
            // a quick look-up table of which perimeters (values of P) have been found and how frequently
            Dictionary<int, int> counter = new Dictionary<int, int>();

            // we'll go ahead and check A and B to 500 even though that would never work (e.g. 500^2 + 500^2 = C^2 ??)
            foreach (int a in Enumerable.Range(1, 500))
            {
                foreach (int b in Enumerable.Range(1, 500))
                {
                    var t = new Triangle()
                                {
                                    A = a,
                                    B = b
                                };

                    // if this is a valid right triangle and the perimeter is less than 1000 as described
                    if (t.Check && t.P <= 1000)
                    {
                        if (!counter.ContainsKey(t.P))
                        {
                            counter.Add(t.P, 0);
                        }

                        counter[t.P] += 1;
                    }
                }
            }

            return counter.OrderByDescending(t => t.Value).First().Key;
        }

        class Triangle
        {
            public int A { get; set; }
            public int B { get; set; }

            // a kind of weird check to make sure that C is an integer result
            public Boolean Check
            {
                get
                {
                    return Math.Sqrt((A * A) + (B * B)) % 1 == 0;
                }
            }

            public int C
            {
                get
                {
                    return (int)Math.Sqrt((A * A) + (B * B));
                }
            }

            public int P
            {
                get
                {
                    return (A + B + C);
                }
            }
        }
    }
}
