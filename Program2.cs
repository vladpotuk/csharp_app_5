using System;

class Program2
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        IntArray2 array = new IntArray2(arr);

        array.ShowEven();
        array.ShowOdd();
    }
}
