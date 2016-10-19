namespace Playground.StudyCases
{
    using System;
    using System.Linq;

    /// <summary>
    /// http://blogs.msdn.com/b/wesdyer/archive/2008/01/11/the-marvels-of-monads.aspx
    /// http://twistedoakstudios.com/blog/Post867_how-would-i-even-use-a-monad-in-c
    /// </summary>
    static class LinqListMonad
    {
        //public static IEnumerable<U> SelectMany<T, U>(this IEnumerable<T> m, Func<T, IEnumerable<U>> k)
        //{
        //    foreach (var x in m)
        //        foreach (var y in k(x))
        //            yield return y;
        //}

        public static void RunAndExplore()
        {
            var r = from x in new[] { 0, 1, 2 }
                    from y in new[] { 0, 1, 2 }
                    select x + y;

            foreach (var i in r)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }


}