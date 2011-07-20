using System.Collections.Generic;
using System.Linq;

/* vEvaluate the sum of all the amicable numbers under 10000. */
public class Euler21 : ProjectEuler.EulerProblem
{
    public override object Solution()
    {
        int sum = 0;

        foreach (int i in Enumerable.Range(1, 10000))
        {
            int res = GetDivisors(i).Sum();

            if (i != res && i == GetDivisors(res).Sum())
            {
                sum += i;
            }
        }

        return sum;
    }

    IEnumerable<int> GetDivisors(int num)
    {
        return Enumerable.Range(1, num).Where(i => num % i == 0 && i != num);
    }
}