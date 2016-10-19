namespace Playground.StudyCases
{
    using System;
    using System.Collections.Generic;

    class ClosureVariablesNotOnValuesInLambdas
    {
        public static void RunAndExplore()
        {
            var funcs = new List<Func<int>>();
            int[] arr = {4, 3, 2, 1};

            foreach (var item in arr)
            {
                funcs.Add(()=> item);
            }

            foreach (var f in funcs)
            {
                Console.WriteLine(f());
            }

            Console.WriteLine();

            //  closure works on variables not on the variables' values
            funcs.Clear();

            for (int i = 0; i < 4; i++)
            {
                funcs.Add(() => i);
            }

            foreach (var f in funcs)
            {
                Console.WriteLine(f());
            }

            Console.ReadKey();
        }
    }
}