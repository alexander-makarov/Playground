namespace Playground.StudyCases
{
    using System;

    class ExplicitInterfaceCall
    {
        public static void RunAndExplore()
        {
            (new B() as IA).SomeWork();
            ((IA)new B()).SomeWork();
            //(new IA(new B())).SomeWork(); // if uncommented - do not compile, cuz not allowed to call constuctor on interface

            Console.ReadKey();
        }

        interface IA
        {
            void SomeWork();
        }

        //abstract class A
        //{
        //    public abstract void SomeWork2();
        //}

        class B : IA
        {
            void IA.SomeWork()
            {
                Console.WriteLine("SomeWork");
            }

            //void A.SomeWork2()
            //{
            //    throw new NotImplementedException();
            //}
        }
    }
}