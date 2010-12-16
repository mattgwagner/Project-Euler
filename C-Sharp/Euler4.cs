using System.Collections.Generic;
using System.Linq;
using ProjectEuler;

class Euler4 : EulerProblem
{
    public override object Solution()
    {
        return getPalindromicNumbersUpTo1000().Max();
    }

    private IEnumerable<int> getPalindromicNumbersUpTo1000()
    {
        int tmp = 0;

        foreach (int x in Enumerable.Range(100, 900))
        {
            foreach (int y in Enumerable.Range(100, 900))
            {
                tmp = x * y;

                if (tmp.ToString().isPalindrome())
                {
                    yield return tmp;
                }
            }
        }
    }
}
