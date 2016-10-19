namespace Playground.StudyCases
{
    using System;

    /// <summary>
    /// http://blogs.msdn.com/b/ruericlippert/archive/2009/09/28/string-empty.aspx
    /// 
    /// </summary>
    class StringInterningnRefComparision
    {
        public static void RunAndExplore()
        {
            string s1, s2, s3;

            s1 = "foobar";
            Console.WriteLine(Object.ReferenceEquals(s1, "foobar"));

            s1 = "foobar";
            s2 = "foo" + "bar";
            Console.WriteLine(Object.ReferenceEquals(s1, s2));

            s1 = "foobar";
            s2 = "foo";
            s3 = s2 + "bar";
            Console.WriteLine(Object.ReferenceEquals(s1, s3));

            s1 = "foobar";
            s2 = "foo";
            s3 = s2 + "bar";
            s3 = String.Intern(s3);
            Console.WriteLine(Object.ReferenceEquals(s1, s3));

            s1 = "foobar";
            s2 = "foobar";
            Console.WriteLine(Object.ReferenceEquals(s1, s2));

            
            
            Console.ReadKey();
        }

        // need compile with /unsafe
        //private void ChangeStringWithinInterPool()
        //{
        //    var s = "Strings are immutable";
        //    int length = s.Length;
        //    unsafe
        //    {
        //        fixed (char* c = s)
        //        {
        //            for (int i = 0; i < length / 2; i++)
        //            {
        //                var temp = c[i];
        //                c[i] = c[length - i - 1];
        //                c[length - i - 1] = temp;
        //            }
        //        }
        //    }
        //    Console.WriteLine("Strings are immutable");
        //}
    }
}