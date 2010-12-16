﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;

public class Euler7 : EulerProblem
{
    const int MAX = 1000000;

    public override object Solution()
    {
        return FindPrimesUpToMax(MAX).Skip(10000).First();
    }
}
