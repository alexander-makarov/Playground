namespace Playground.StudyCases
{
    using System;

    class DisposeOrderInUsing
    {
        public static void RunAndExplore()
        {
            try
            {
                //using (A a = new A(), B b = new B())
                using (A a = new A())
                {
                    using (B b = new B())
                    {
                        throw new Exception();
                    }
                }
            }
            catch
            {}

            Console.ReadKey();
        }

        class A : IDisposable
        {
            public void Dispose()
            {
                Console.Write("A ");
            }
        }
        
        class B : IDisposable
        {
            public void Dispose()
            {
                Console.Write("B ");
            }
        }
    }
}