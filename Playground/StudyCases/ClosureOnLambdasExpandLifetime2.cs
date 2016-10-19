namespace Playground.StudyCases
{
    using System;

    class ClosureOnLambdasExpandLifetime2
    {
        public static void RunAndExplore()
        {
            var counter1 = CreateCounter();
            Console.Write(counter1());
            Console.Write(counter1());

            var counter2 = CreateCounter();
            Console.Write(counter2());

            Console.Write(counter1());

            Console.ReadKey();
        }

        private static Func<int> CreateCounter()
        {
            int c = 0;
            return () => c++;
        }
    }
}