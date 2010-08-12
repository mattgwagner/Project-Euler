using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler
{
    class Program
    {
        static EulerProblem problem;

        public static void Main()
        {
            Console.Write("Which problem to run? ");

            int problem_no = int.Parse(Console.ReadLine());

            problem = (EulerProblem) Activator.CreateInstance(Type.GetType("Euler" + problem_no));

            Console.WriteLine("Answer for Question {0}: {1}", problem.GetType(), problem.solution());

            Console.ReadLine();
        }
    }

    public abstract class EulerProblem
    {
        public abstract BigInteger solution();

        protected BigInteger factorial(BigInteger f)
        {
            return f != 1 ? (f * factorial(f - 1)) : 1;
        }

        protected Boolean isPrime(BigInteger p)
        {
            return false;
        }
    }
}
