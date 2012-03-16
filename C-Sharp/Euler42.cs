using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler
{
    class Euler42 : EulerProblem
    {
        public const String LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public override object Solution()
        {
            List<String> list = new List<String>();

            using (StreamReader rdr = new StreamReader("Euler42.txt"))
            {
                list = new List<String>(rdr.ReadToEnd().Replace("\"", "").Split(','));
            }

            var nums = GetTriangleNumbers(50);

            int count = 0;

            foreach (String s in list)
            {
                if (nums.Contains(Value(s))) count++;
            }

            return count;
        }

        protected IEnumerable<double> GetTriangleNumbers(int n)
        {
            for (int i = 1; i < n; i++)
            {
                yield return (.5 * i) * (i + 1);
            }
        }

        protected int Value(String val)
        {
            return val.ToList().Sum(c => LETTERS.IndexOf(c) + 1);
        }
    }
}
