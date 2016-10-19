namespace Playground.StudyCases
{
    using System;
    using System.Threading.Tasks;

    public static class ExceptionOnThreadExperiment
    {
        public static void RunAndExplore()
        {
            try
            {
                //var thread = new Thread(()=> Divide(10,0));
                //thread.Start();

                var task = new Task(() => Divide(10, 0));
                task.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occured");
            }
        }
        private static void Divide(int x, int y)
        {
            int z = x / y;
        }
    }
}