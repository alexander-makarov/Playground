namespace Playground.StudyCases
{
    using System;

    /// <summary>
    /// http://www.codethinked.com/c-closures-explained
    /// http://stackoverflow.com/questions/12953907/resharper-implicitly-captured-closure-this?lq=1
    /// http://stackoverflow.com/questions/13633617/why-does-resharper-tell-me-implicitly-captured-closure/15843306#15843306
    /// </summary>
    class ClosureOnLambdasExpandLifetime
    {
        public static void RunAndExplore()
        {
            var inc = GetAFunc();
            Console.WriteLine(inc(5));
            Console.WriteLine(inc(6));

            Console.ReadKey();
        }

        public static Func<int, int> GetAFunc()
        {
            var myVar = 1; // over this variable lambda will have a closure, thus lifetime of myVar wil expand beyond the scope!
            Func<int, int> inc = delegate(int var1)
            {
                myVar = myVar + 1;
                return var1 + myVar;
            };
            return inc;
        }
    }
}