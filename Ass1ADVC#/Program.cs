using System.Collections.Generic;
using System.Runtime.CompilerServices;

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


    #region 4. implement a custom list called FixedSizeList<T>
    //internal class FixedSizeList<T>
    //{
    //    private List<T> items;
    //    private int capacity;

    //    public  FixedSizeList(int _capacity)
    //    {
    //        if (_capacity <= 0)
    //            Console.WriteLine("Capacity must be greater than zero");;

    //        _capacity = capacity;
    //        items = new List<T>(capacity);
    //    }

    //    public void Add(T item)
    //    {
    //        if (items.Count >=  capacity)
    //            Console.WriteLine("List is full");
 
    //        items.Add(item);
    //    }

    //    public T Get (int index)
    //    {
    //        if (index < 0 || index >= items.Count)
    //            Console.WriteLine("Invalid index");

    //        return items[index];
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


        #region  3. You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
        //public static List<int> Even(List<int> Numbers)
        //{
        //    List<int> EvenNumbers = new List<int>();

        //    foreach (int num in Numbers)
        //    {
        //        if (num % 2  == 0) 
        //            EvenNumbers.Add(num);
        //    }
        //    return EvenNumbers;
        //}
        #endregion


        #region 5. Given a string, find the first non-repeated character in it and return its index
        //public static int FirstNonRepeatedChar(string str)
        //{
        //    Dictionary<char, int> charCount = new Dictionary<char, int>();

        //    foreach (char c in str)
        //    {
        //        if (charCount.ContainsKey(c))
        //            charCount[c]++;
        //        else
        //            charCount[c] = 1;
        //    }

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (charCount[str[i]] == 1)
        //            return i;
        //    }

        //    return -1;
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

            //List<int> numbers = new List<int> {1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10};

            //List<int> evenNumbers = Even(numbers);

            //Console.WriteLine("Original numbers: " + string.Join(", " , numbers));

            //Console.WriteLine("\nEven numbers: " + string.Join(", " , evenNumbers));

            //-------------------------------------------------------------------//

            //FixedSizeList<int> list = new FixedSizeList<int>(3);

            //list.Add(1);    
            //list.Add(2);
            //list.Add(3);

            //Console.WriteLine(list.Get(0));

            //------------------------------------------------------------------//

            //string str1 = "selena";
            //string str2 = "mohamed";
            //string str3 = "momo";
          
            //Console.WriteLine($"First non repeated char index in '{str1}': {FirstNonRepeatedChar(str1)}"); 
            //Console.WriteLine($"First non repeated char index in '{str2}': {FirstNonRepeatedChar(str2)}");
            //Console.WriteLine($"First non repeated char index in '{str3}': {FirstNonRepeatedChar(str3)}");
        }
    }
}
