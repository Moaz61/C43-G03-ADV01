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


    internal class Program
    {

        #region 2. You are given an ArrayList containing a sequence of elements
        //public static void ReverseArray<T>(List<T> list)
        //{
        //    int left = 0;
        //    int right = list.Count - 1;

        //    while (left < right)
        //    {
        //        T temp = list[left];
        //        list[left] = list[right];
        //        list[right] = temp;

        //        left++;
        //        right--;
        //    }
        //}
        #endregion



        static void Main(string[] args)
        {
            //Range<int> intRange = new Range<int>(4, 6);
            //Console.WriteLine("Number is in range: " + intRange.IsInRange(6));
            //Console.WriteLine("Length of range: " + intRange.Length());

            //Range<double> doubleRange = new Range<double>(1.5, 4.5);
            //Console.WriteLine(doubleRange.IsInRange(3.2));
            //Console.WriteLine(doubleRange.Length());

            //------------------------------------------------------------------//

            //List<int> myList = new List<int> { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Original List: " + string.Join(", ", myList.ToArray()));

            //ReverseArray(myList);

            //Console.WriteLine("Reversed List: " + string.Join(", ", myList.ToArray()));

            //-------------------------------------------------------------------//




        }
    }
}
