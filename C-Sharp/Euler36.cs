using System;
using System.Linq;

/* Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2. */
namespace ProjectEuler
{
    public class Euler36 : EulerProblem
    {
        public override object Solution()
        {
            var range = from r in Enumerable.Range(1, 1000000)
                        where r.ToString().isPalindrome() &&
                              Convert.ToString(r, 2).isPalindrome()
                        select r;

            return range.Sum();
        }
    }
}