using System.Collections.Generic;

namespace Ass1ADVC_
{
    #region 1. Create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.
    //internal class Range<T> where T : IComparable<T>
    //{
    //    public T Max { get; set; }
    //    public T Min { get; set; }
    //    public Range(T min, T max)
    //    {
    //        Min = min;
    //        Max = max;
    //    }

    //    public bool IsInRange(T value)
    //    {
    //        return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
    //    }

    //    public T Length()
    //    {
    //        dynamic min = Min;
    //        dynamic max = Max;

    //        return max - min;
    //    }
    //}

    #endregion


    #region 2. You are given an ArrayList containing a sequence of elements
    internal class ArrayList<T>
    {
        public static void ReverseArray<T>(List<T> list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                T temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }

        public static void PrintList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            //Range<int> intRange = new Range<int>(4, 6);

            //Console.WriteLine("Number is in range: " + intRange.IsInRange(6));
            //Console.WriteLine("Length of range: " + intRange.Length());

            //------------------------------------------------------------------//

            List<int> intList = new List<int>() { 1 , 2 , 3};
            Console.WriteLine("original integer list: ");
    
            PrintList(intList);


        }
    }
}
