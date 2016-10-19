namespace Playground
{
    using StudyCases;

    class Program
    {
        static void Main(string[] args)
        {
            // Basic concepts:
            AllAboutEquality.RunAndExplore();
            ExceptionHandling.RunAndExplore();
            DelegatesCombining.RunAndExplore();
            BitwiseBinaryeOrVsConditionalOr.RunAndExplore();
            EnumerableInterfaceYieldKeyword.RunAndExplore();
            DisposeOrderInUsing.RunAndExplore();
            ExplicitInterfaceCall.RunAndExplore();

            // String Interning:
            StringInterningnRefComparision.RunAndExplore();
            StringInterningUnderstandInternPool.RunAndExplore();

            // Boxing-Unboxing:
            RichterBoxingUnboxing.RunAndExplore();
            NullableTypes.RunAndExplore();

            // Multithreading:
            ExceptionOnThreadExperiment.RunAndExplore();
            VolatileIsNotEnoughUseThreadBarrierExperiment.RunAndExplore();
            ForeachVsParallelForeach.RunAndExplore(false);
            ForeachVsParallelForeach.RunAndExplore(true);

            // Cross-process Communication (when threads are not enough)
            AppDomainCreateAndUnwrap.RunAndExplore();
            CrossAppDomainCommunication.RunAndExplore();

            // Closures in Lambdas:
            CapturedVariablesOnClosureInLambdas.RunAndExplore();
            ClosureOnLambdasExpandLifetime.RunAndExplore();
            ClosureVariablesNotOnValuesInLambdas.RunAndExplore();
            ClosureOnLambdasExpandLifetime2.RunAndExplore();

            // Misc:
            LinqListMonad.RunAndExplore();
        }
    }
}
