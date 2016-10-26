namespace Playground
{
    using StudyCases;

    class Program
    {
        static void Main(string[] args)
        {
            // pick up one of the study cases below, go to the code and explore without running it first
            // once you made your mind on how the code is expected to work, uncomment the study case here to run it
            // check whether your expectation and understanding were correct ;)

            //          Basic concepts:
            //AllAboutEquality.RunAndExplore();
            //ExceptionHandling.RunAndExplore();
            //DelegatesCombining.RunAndExplore();
            //BitwiseBinaryeOrVsConditionalOr.RunAndExplore();
            //EnumerableInterfaceYieldKeyword.RunAndExplore();
            //DisposeOrderInUsing.RunAndExplore();
            //ExplicitInterfaceCall.RunAndExplore();

            //          String Interning:
            //StringInterningnRefComparision.RunAndExplore();
            //StringInterningUnderstandInternPool.RunAndExplore();

            //          Boxing-Unboxing:
            //RichterBoxingUnboxing.RunAndExplore();
            //NullableTypes.RunAndExplore();

            //          Multithreading:
            //ExceptionOnThreadExperiment.RunAndExplore();
            //VolatileIsNotEnoughUseThreadBarrierExperiment.RunAndExplore();
            //ForeachVsParallelForeach.RunAndExplore(false);
            //ForeachVsParallelForeach.RunAndExplore(true);

            //          Cross-process Communication (when threads are not enough)
            //AppDomainCreateAndUnwrap.RunAndExplore();
            //CrossAppDomainCommunication.RunAndExplore();

            //          Closures in Lambdas:
            //CapturedVariablesOnClosureInLambdas.RunAndExplore();
            //ClosureOnLambdasExpandLifetime.RunAndExplore();
            //ClosureVariablesNotOnValuesInLambdas.RunAndExplore();
            //ClosureOnLambdasExpandLifetime2.RunAndExplore();

            //          Misc:
            //LinqListMonad.RunAndExplore();
            CSharp60Features.RunAndExplore();
        }
    }
}
