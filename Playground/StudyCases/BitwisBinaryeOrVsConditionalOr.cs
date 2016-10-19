namespace Playground.StudyCases
{
    using System;

    class BitwiseBinaryeOrVsConditionalOr
    {
        public static void RunAndExplore()
        {
            Console.WriteLine(FuncA() | FuncB());
            Console.WriteLine(FuncA() || FuncB());

            Console.ReadKey();
        }

        public static bool FuncA()
        {
            Console.WriteLine("FuncA");
            return true;
        }

        public static bool FuncB()
        {
            Console.WriteLine("FuncB");
            return false;
        }
    }
}