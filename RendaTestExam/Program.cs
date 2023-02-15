internal class Program
{
    private static void Main(string[] arg)
    {
        ArrayTest array = new();

        int[] arr = { 0, 0, 0, 1, 1, 1, 2, 4, 5 };

        //int[] res = array.ReturnDistinctValue(arr);

        int res = array.NumberOfOccurence(arr);

        //for (int i = 0; i < res.Length; i++)
        //{
        //    Console.WriteLine(res[i]);
        //}
        Console.WriteLine(res);
    }
}

public class ArrayTest
{
    public int[] ReturnDistinctValue(int[] intArr)
    {
        //Write a program to remove duplicates from a arrays of integers(constraints do not use methods from the System.Linq, Systems.Collections and System.Collections.Generic namespace) a
        //nd return an array without duplicates.
        int indexNumber = 1;
        for (int i = 0; i < intArr.Length - 1; i++)
        {
            if (intArr[i] != intArr[i + 1])
            {
                intArr[indexNumber] = intArr[i + 1];
                indexNumber++;
            }
            else
            {
                continue;
            }
        }
        int[] newArr = new int[indexNumber];
        for (int j = 0; j < indexNumber; j++)
        {
            newArr[j] = intArr[j];
        }
        return newArr;
    }

    public int NumberOfOccurence(int[] intArr)
    {
        //Extend the program with a method that can return the element of the integer array that has the highest number of occurrence.

        int[] arr = intArr;
        int count = 1, maxCount = 1, maxValue = 0;

        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            maxCount = arr[i];

            for (int j = 0; j < arr.Length; j++)
            {
                if (maxValue == arr[j] && j != i)
                {
                    count++;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        result = arr[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
        }
        return result;
    }
}