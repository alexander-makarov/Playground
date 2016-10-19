namespace Playground.StudyCases
{
    using System;

    class AllAboutEquality
    {
        public static void RunAndExplore()
        {
            ClassA ref1 = new ClassA();
            ref1.Value = 7;

            ClassA ref2 = new ClassA();
            ref2.Value = 7;

            Console.WriteLine(ref1 == ref2);
            Console.WriteLine(ref1.Equals(ref2));
            Console.WriteLine(ReferenceEquals(ref1,ref2));
            
            Console.ReadKey();
        }

        private class ClassA
        {
            public int Value { get; set; }

            public override bool Equals(object obj)
            {
                var that = obj as ClassA;
                
                return that != null && that.Value == this.Value;
            }
        }
    }
}
