using System;

public class IntArray2 : IOutput2
{
    private int[] elements;

    public IntArray2(int[] arr)
    {
        elements = arr;
    }

    public void ShowEven()
    {
        Console.WriteLine("Парні елементи масиву:");
        foreach (var element in elements)
        {
            if (element % 2 == 0)
                Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        Console.WriteLine("Непарні елементи масиву:");
        foreach (var element in elements)
        {
            if (element % 2 != 0)
                Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
