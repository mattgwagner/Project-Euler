using System;
using System.Linq;

/*
    It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.

    Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits
*/
namespace ProjectEuler
{
    public class Euler52 : EulerProblem
    {
        public override object Solution()
        {
            foreach (int x in Enumerable.Range(1, 1000000))
            {
                Char[] x2 = (x * 2).ToString().ToCharArray();
                Char[] x3 = (x * 3).ToString().ToCharArray();
                Char[] x4 = (x * 4).ToString().ToCharArray();
                Char[] x5 = (x * 5).ToString().ToCharArray();
                Char[] x6 = (x * 5).ToString().ToCharArray();

                if (Check(x.ToString().ToCharArray(), x2, x3, x4, x5, x6))
                {
                    return x;
                }
            }

            throw new Exception("Not found within range");
        }

        Boolean Check(params char[][] list)
        {
            foreach (char[] c in list)
            {
                foreach (char[] c2 in list)
                {
                    if (false == c2.All(i => c.Contains(i)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
