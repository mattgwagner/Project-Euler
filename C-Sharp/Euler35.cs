﻿using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class Euler35 : EulerProblem
    {
        const int MAX = 2000000;

        public override object Solution()
        {



            throw new NotImplementedException();
        }

        protected IEnumerable<int> GetRotations(int number)
        {
            throw new NotImplementedException();

            for (int i = 0; i < number.ToString().Length; i++)
            {
                yield return i;
            }
        }
    }
}
