internal class Program
{
    private static void Main(string[] arg)
    {
        ArrayTest array = new();

        int[] arr = { 0, 0, 0, 1, 1, 1, 2, 4, 5 };

        int[] res = array.ReturnDistinctValue(arr);

        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }
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
}