namespace Playground.StudyCases
{
    using System;

    class ExceptionHandling
    {
        public static void RunAndExplore()
        {
            int i = 1, j = 0;

            try
            {
                i++;
                i += i/j;
            }
            catch (DivideByZeroException)
            {
                i--;
            }
            catch (Exception)
            {
                i = 0;
            }
            catch
            {
                i = -1;
            }
            finally
            {
                i *= i;
            }

            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}