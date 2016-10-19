namespace Playground.StudyCases
{
    using System;
    using System.Collections.Generic;

    class EnumerableInterfaceYieldKeyword
    {
        public static void RunAndExplore()
        {
            foreach (var item in GetItems())
            {
                Console.WriteLine(item);
                Console.WriteLine("Line");
            }

            Console.ReadKey();
        }

        private static IEnumerable<string> GetItems()
        {
            yield return "String 1";
            Console.WriteLine("String 2");
            yield return "String 3";
        }
    }
}