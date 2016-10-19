namespace Playground.StudyCases
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// To prevent failure because of reorder of instructions uncomment use of ThreadBarrier
    /// </summary>
    internal class VolatileIsNotEnoughUseThreadBarrierExperiment
    {
        public static void RunAndExplore()
        {
            new VolatileIsNotEnoughUseThreadBarrierExperiment().Go();
        }

        private volatile int _firstBool;
        private volatile int _secondBool;
        private volatile string _firstString;
        private volatile string _secondString;

        private int _okCount;
        private int _failCount;

        public void Go()
        {

            while (true)
            {
                Parallel.Invoke(DoThreadA, DoThreadB);
                if (_firstString == null && _secondString == null)
                {
                    _failCount++;
                }
                else
                {
                    _okCount++;
                }
                Console.WriteLine("ok - {0}, fail - {1}, fail percent - {2}",
                    _okCount, _failCount, GetFailPercent());

                Clear();
            }
        }

        private float GetFailPercent()
        {
            return (float) _failCount/(_okCount + _failCount)*100;
        }

        private void Clear()
        {
            _firstBool = 0;
            _secondBool = 0;
            _firstString = null;
            _secondString = null;
        }

        private void DoThreadA()
        {
            _firstBool = 1;
            //Thread.MemoryBarrier();
            if (_secondBool == 1)
            {
                _firstString = "a";
            }
        }

        private void DoThreadB()
        {
            _secondBool = 1;
            //Thread.MemoryBarrier();
            if (_firstBool == 1)
            {
                _secondString = "a";
            }
        }

    }
}
