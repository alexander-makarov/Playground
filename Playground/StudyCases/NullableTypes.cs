namespace Playground.StudyCases
{
    using System;

    class NullableTypes
    {
        public static void RunAndExplore()
        {
            Console.WriteLine(typeof(Nullable<>) + " " + typeof(Nullable<int>));
            Console.WriteLine(typeof(Nullable<int>) + " " + (new Nullable<int>(5)).GetType()); // second one is workaround on possible boxing

            int? a = 10;
            Console.WriteLine(a.GetType().FullName);

            if (a is int)
            {
                Console.WriteLine("Truly unboxed ValueType Int32 on a stack variable");
            }

            Console.WriteLine();

            int? num1 = 10;
            int? num2 = null;
            if (num1 >= num2)
            {
                Console.WriteLine("num1 is greater than or equal to num1");
            }
            else
            {
                Console.WriteLine("num1 is NOT less than num2! Cuz num2 is undefined-null");
            }

            Console.WriteLine();

            int? b = 10;
            int? c = null;

            b++;         
            b = b * 10;  
            b = b + c;  // now b is null
            Console.WriteLine(b.ToString());

            Console.ReadKey();
        }
    }


}