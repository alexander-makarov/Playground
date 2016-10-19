namespace Playground.StudyCases
{
    using System;

    class DelegatesCombining
    {
        public static void RunAndExplore()
        {
            Action handler1 = new Action(SomeAction1);
            Action handler2 = new Action(SomeAction2);
            Action handler3 = (Action)Delegate.Combine(handler1, handler2);

            Console.WriteLine(handler3.GetInvocationList().Length);

            Console.ReadKey();
        }

        public static void SomeAction1()
        { }

        public static void SomeAction2()
        { }
    }
}