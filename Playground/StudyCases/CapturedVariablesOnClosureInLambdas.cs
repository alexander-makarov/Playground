namespace Playground.StudyCases
{
    using System;

    /// <summary>
    /// http://blogs.msdn.com/b/matt/archive/2008/03/01/understanding-variable-capturing-in-c.aspx
    /// </summary>
    class CapturedVariablesOnClosureInLambdas
    {
        public static void RunAndExplore()
        {
            string name = "Matthew";
            Func<String> capture = () => name;
            name = "Mallory";
            Console.WriteLine(capture());
            
            Console.WriteLine();
            // one more time on captured variables:

            string str = "Initial value"; //1
            Action action = () => //2
            {
                Console.WriteLine(str); //3
                str = "Modified by closure";
            };
            str = "After delegate creation"; //4
            action(); //5
            Console.WriteLine(str); //6

            Console.ReadKey();
        }
    }
}