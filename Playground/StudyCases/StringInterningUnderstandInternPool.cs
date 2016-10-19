namespace Playground.StudyCases
{
    using System;

    class StringInterningUnderstandInternPool
    {
        public static void RunAndExplore()
        {
            string a = new string(new char[] { 'a', 'b', 'c' });
            object o = String.Copy(a);
            Console.WriteLine(object.ReferenceEquals(o, a));

            String.Intern(o.ToString());
            Console.WriteLine(object.ReferenceEquals(o, String.Intern(a)));

            object o2 = String.Copy(a);
            String.Intern(o2.ToString());
            Console.WriteLine(object.ReferenceEquals(o2, String.Intern(a)));

            Console.ReadKey();
        }
    }
}