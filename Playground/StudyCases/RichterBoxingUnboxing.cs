namespace Playground.StudyCases
{
    using System;

    internal class RichterBoxingUnboxing
    {
        // Interface defining a Change method
        internal interface IChangeBoxedPoint
        {
            void Change(Int32 x, Int32 y);
        }

        // Point is a value type.
        internal struct Point : IChangeBoxedPoint
        {
            private Int32 m_x, m_y;

            public Point(Int32 x, Int32 y)
            {
                m_x = x;
                m_y = y;
            }

            public void Change(Int32 x, Int32 y)
            {
                m_x = x;
                m_y = y;
            }

            public override String ToString()
            {
                return String.Format("({0}, {1})", m_x.ToString(), m_y.ToString());
            }
        }

        public static void RunAndExplore()
        {
            Point p = new Point(1, 1);
            Console.WriteLine(p);
            p.Change(2, 2);
            Console.WriteLine(p);
            Object o = p;
            Console.WriteLine(o);
            ((Point)o).Change(3, 3);
            Console.WriteLine(o);
            // Boxes p, changes the boxed object and discards it
            ((IChangeBoxedPoint)p).Change(4, 4);
            Console.WriteLine(p);
            // Changes the boxed object and shows it
            ((IChangeBoxedPoint)o).Change(5, 5);
            Console.WriteLine(o);

            Console.ReadKey();
        }
    }
}
