using System.Collections.Generic;
using System.Linq;
using ProjectEuler;

class Euler14 : EulerProblem
{
    Dictionary<long, long> dict = new Dictionary<long, long>();

    public override object Solution()
    {
        Enumerable.Range(1, 1000000).ToList().ForEach(i => dict[i] = GetChainLength(i, 0));

        return dict.OrderByDescending(k => k.Value).First().Key;
    }

    protected long GetChainLength(long i, long current)
    {
        if (i == 1) return ++current;

        if (dict.ContainsKey(i)) return current + dict[i];

        return GetChainLength(i % 2 == 0 ? i / 2 : 3 * i + 1, ++current);
    }
}
