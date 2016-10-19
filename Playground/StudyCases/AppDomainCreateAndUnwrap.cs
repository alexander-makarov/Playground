namespace Playground.StudyCases
{
    using System;

    /// <summary>
    /// (!) Try uncomment different obj creating lines
    /// http://geekswithblogs.net/vadivelkumar/archive/2006/02/25/70674.aspx
    /// http://stackoverflow.com/questions/574708/what-is-appdomain
    /// 
    /// </summary>
    class AppDomainCreateAndUnwrap
    {
        public static void RunAndExplore()
        {
            AppDomain domain = AppDomain.CreateDomain("NewDomain");

            //var obj = (ClassA)domain.CreateInstanceAndUnwrap("Playground", "CrossAppClassA");
            //var obj = (ClassA)domain.CreateInstanceAndUnwrap(typeof(ClassA).Assembly.FullName, typeof(ClassA).FullName);
            var obj = (CrossAppClassA)domain.CreateInstanceAndUnwrap(typeof(CrossAppClassA).Assembly.FullName, typeof(CrossAppClassA).FullName);
            obj.Method();

            Console.ReadKey();
        }

        private class ClassA
        {
            public void Method()
            {
                Console.WriteLine("Hello");
            }
        }

        private class CrossAppClassA : MarshalByRefObject
        {
            public void Method()
            {
                Console.WriteLine("Hello");
            }
        }
    }
}