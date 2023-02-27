using System;

namespace _27._02._2022
{
    class Program
    {
        static T Max<T>(T a, T b, T c) where T : IComparable<T>
        {

            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                return a;
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                return b;
            }
            return c;
        }

        static T Min<T>(T a, T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) < 0 && a.CompareTo(c) < 0)
            {
                return a;
            }
            else if (b.CompareTo(a) < 0 && b.CompareTo(c) < 0)
            {
                return b;
            }
            return c;
        }
 
        static void Main(string[] arr)
        {
            int Element = Max(4,5,6);
            Console.WriteLine(Element);
            double Element1 = Min(5.6, 0.2, 3);
            Console.WriteLine(Element1);
        }
    }
    
}
