using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxUsingGenerics
{
    public class FindMaxGenericClass<T> where T:IComparable
    {
        T first;
        T second;
        T third;
        public FindMaxGenericClass(T first,T second,T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static T testMax(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 ||
                third.CompareTo(first) >= 0 && third.CompareTo(second) > 0 ||
                third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
            {
                return third;
            }
            throw new Exception("first, second and third are same");
        }
    }
}
