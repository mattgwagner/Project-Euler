using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProjectEuler;

class Euler22 : EulerProblem
{
    const String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public override object Solution()
    {
        var names = GetNames();

        names.Sort();

        int num = 1;
        int total = 0;

        foreach (var name in names)
        {
            total += num * name.Sum(c => alphabet.IndexOf(c) + 1);

            num++;
        }

        return total;
    }

    List<String> GetNames()
    {
        using (StreamReader rdr = new StreamReader("Euler22.txt"))
        {
            return new List<String>(rdr.ReadToEnd().Replace("\"", "").Split(','));
        }
    }
}
