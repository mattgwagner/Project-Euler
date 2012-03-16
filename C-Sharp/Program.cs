using System;
using System.Diagnostics;
using System.Threading;

namespace ProjectEuler
{
    class Program
    {
        static EulerProblem problem;

        public static void Main()
        {
            Console.Write("Which problem to run? ");

            int problem_no = int.Parse(Console.ReadLine());

            problem = (EulerProblem)Activator.CreateInstance(Type.GetType("Euler" + problem_no));

            Stopwatch sw = Stopwatch.StartNew();

            using (Timer t = new Timer(o => Console.WriteLine("Elapsed: {0}s", sw.Elapsed.Seconds), null, 0, 5000))
            {
                Console.WriteLine("\nAnswer for Question {0}: {1}", problem_no, problem.Solution());

                Console.WriteLine("\nTotal time: {0}ms", sw.ElapsedMilliseconds);
            }

            Console.ReadLine();
        }
    }
}
