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
        T[] value;
        public FindMaxGenericClass(T first,T second,T third,T[] value)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.value = value;
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
        public static T MaxValue(params T[] values)
        {
            Array.Sort(values);
            return values[^1];
        }
        public static T GetMaxValue(params T[] value)
        {
            T max = MaxValue(value);
            return max;
        }
        public T testMaximum()
        {
            return FindMaxGenericClass<T>.GetMaxValue(this.value);
        }
    }
}
